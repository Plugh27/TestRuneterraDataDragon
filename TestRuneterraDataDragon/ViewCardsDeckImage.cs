using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            // 受け取ったCardCodeAndCountのリストに相当するCardInfoのリストを作成する
            List<CardInfo> cardInfos = new List<CardInfo>();
            foreach (CardCodeAndCount cardCodeAndCount in displayDeck)
            {
                cardInfos.Add(Util.GetCardInfoFromCardCodeAndCount(allCardInfos, cardCodeAndCount));
            }

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

            // 定義されたマナコスト毎のList<CardCodeAndCount>のリストを作成する
            List<List<CardCodeAndCount> > byManaDecks = new List<List<CardCodeAndCount>>();
            foreach (Point minMax in manacostMinMax)
            {
                List<CardInfo> columnCardInfos =
                    cardInfos.Where(s => s.cost >= minMax.X && s.cost <= minMax.Y).ToList();

                List<CardCodeAndCount> byManaDeck = new List<CardCodeAndCount>();
                foreach (CardInfo cardInfo in columnCardInfos)
                {
                    byManaDeck.Add(Util.GetCardCodeAndCountFromCardInfo(displayDeck, cardInfo));
                }

                byManaDecks.Add(byManaDeck);
            }

            int cardImageWidth = 136;
            int cardImageHeight = 205;
            int yGap = 10;
            int xGap = 10;

            int maxYPos = 0;
            int maxXPos = 0;
            foreach (List<CardCodeAndCount> deck in byManaDecks)
            {
                int yPos = 1;
                foreach (CardCodeAndCount cardCodeAndCount in deck)
                {
                    yPos += cardImageHeight + (yGap * cardCodeAndCount.Count);
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
                foreach (List<CardCodeAndCount> oneColumnDeck in byManaDecks)
                {
                    int yPos = 1;
                    foreach (CardCodeAndCount oneCardCodeAndCount in oneColumnDeck)
                    {
                        // カードのイメージを作成
                        CardInfo target = Util.GetCardInfoFromCardCodeAndCount(allCardInfos, oneCardCodeAndCount);
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

                    xPos += cardImageWidth + xGap;
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
    }
}
