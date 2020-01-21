using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoRDeckCodes;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    public partial class ViewCardsDeckImage : Form
    {
        public ViewCardsDeckImage()
        {
            InitializeComponent();
        }

        public void UpdateCardsDeck(List<CardCodeAndCount> displayDeck)
        {
            Util.GetCardInfos(out var allCardInfos, Util.JapaneseCode);

            // CardCodeAndCountのリストを元にCardDeckDetailのリストを作成する
            List<CardDeckDetail> deckDetails = new List<CardDeckDetail>();
            displayDeck.ForEach(s => deckDetails.Add(new CardDeckDetail(allCardInfos, s)));

            // チャンピオン、チャンピオン以外のユニット、スペルの順でソートする
            List<CardDeckDetail> temp = new List<CardDeckDetail>();
            temp.AddRange(deckDetails.Where(s => s.cardInfo.type == "ユニット" && s.cardInfo.supertype == "チャンピオン"));
            temp.AddRange(deckDetails.Where(s => s.cardInfo.type == "ユニット" && s.cardInfo.supertype != "チャンピオン"));
            temp.AddRange(deckDetails.Where(s => s.cardInfo.type != "ユニット"));
            deckDetails = temp;

            // マナコストの幅を定義
            List<Point> manacostMinMax = new List<Point>
            {
                new Point(0, 1),
                new Point(2, 2),
                new Point(3, 3),
                new Point(4, 4),
                new Point(5, 5),
                new Point(6, 6),
                new Point(7, 100)
            };

            // 定義されたマナコスト毎のリストを作成する
            List<List<CardDeckDetail> > byManaDecks = new List<List<CardDeckDetail>>();
            manacostMinMax.ForEach(minMax =>
                byManaDecks.Add(deckDetails.Where(s => s.cardInfo.cost >= minMax.X && s.cardInfo.cost <= minMax.Y)
                    .ToList()));
               

            int cardImageWidth = 136;
            int cardImageHeight = 205;
            int yGap = 0;
            int xGap = 0;

            int maxYPos = 0;
            int maxXPos = 0;
            foreach (List<CardDeckDetail> deck in byManaDecks)
            {
                int yPos = 1;
                foreach (CardDeckDetail cardDeckDetail in deck)
                {
                    yPos += cardImageHeight + (yGap * cardDeckDetail.cardCodeAndCount.Count);
                }

                if (maxYPos < yPos)
                {
                    maxYPos = yPos;
                }

                maxXPos += cardImageWidth + xGap;
            }


            // 表示する画像を作成する
            var bitmap = new Bitmap(maxXPos, maxYPos); // TODO: const

            using (var canvas = Graphics.FromImage(bitmap))
            {
                canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;

                int xPos = 1;
                foreach (List<CardDeckDetail> oneColumnDeck in byManaDecks)
                {
                    int yPos = 1;
                    foreach (CardDeckDetail oneCardCodeAndCount in oneColumnDeck)
                    {
                        // カードのイメージを作成
                        // CardInfo target = Util.GetCardInfoFromCardCodeAndCount(allCardInfos, oneCardCodeAndCount);
                        CardInfo target = oneCardCodeAndCount.cardInfo;
                        string cardImageFilePath = Util.GetImageFilePath(target, Util.JapaneseCode); // TODO: 多言語対応
                        var fileImage = Image.FromFile(cardImageFilePath);
                        var cardImage = FormUtil.GetStretchedImage(fileImage, cardImageWidth, cardImageHeight);

                        // カード枚数のループ
                        CardCodeAndCount cardCodeAndCount =
                            Util.GetCardCodeAndCountFromCardInfo(displayDeck, target);
                        for (int k = 0; k < cardCodeAndCount.Count; k++)
                        {
                            canvas.DrawImage(cardImage, new Point(xPos, yPos)); //TODO: 調整、const
                            yPos += yGap; //TODO: 調整、const
                        }

                        yPos += cardImageHeight - yGap; //TODO: 調整、const
                    }

                    // カードが一枚も無い列だったなら横位置を動かさない
                    if (oneColumnDeck.Count != 0)
                    {
                        xPos += cardImageWidth + xGap;
                    }
                }
            }

            SolePictureBox.Height = bitmap.Height;
            SolePictureBox.Width = bitmap.Width;
            SolePictureBox.Image = bitmap;

            ClientSize = new Size(bitmap.Width, bitmap.Height);
        }

        private void ViewCardsDeckImage_Load(object sender, EventArgs e)
        {
            ((Form1) MdiParent)._updateCardsDeck += UpdateCardsDeck;
        }

        private void ViewCardsDeckImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)MdiParent)._updateCardsDeck -= UpdateCardsDeck;
        }

        private void CopyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(SolePictureBox.Image);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|png";
            sfd.FileName = "deckimage.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SolePictureBox.Image.Save(sfd.FileName, ImageFormat.Png);
            }
        }
    }
}
