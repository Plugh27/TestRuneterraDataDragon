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
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    public partial class ViewAssociatedCards : Form
    {
        public ViewAssociatedCards()
        {
            InitializeComponent();
        }

        private List<CardInfo> _selectedCardInfos = new List<CardInfo>();

        public void SelectCardInfos(List<CardInfo> cardInfos)
        {
            _selectedCardInfos = cardInfos;
            MakeSoleImage();
        }

        private void ViewAssociatedCards_Load(object sender, EventArgs e)
        {
            ((Form1)MdiParent)._selectCardInfos += SelectCardInfos;
            ((Form1)MdiParent)._selectCardInfosInCardsDeck += SelectCardInfos;

        }

        private void ViewAssociatedCards_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)MdiParent)._selectCardInfos -= SelectCardInfos;
            ((Form1)MdiParent)._selectCardInfosInCardsDeck -= SelectCardInfos;
        }

        private void MakeSoleImage()
        {
            if (_selectedCardInfos.Count == 0)
            {
                return;
            }

            // 先頭のカードだけが処理対象
            var targetCardInfos = new List<CardInfo> { _selectedCardInfos.First() };
            var targetCard = targetCardInfos.First();

            Util.GetCardInfos(out var allCardInfos, Util.JapaneseCode);
            List<CardInfo> associatedCardInfos  = new List<CardInfo>();
            foreach (string cardCode in targetCard.associatedCardRefs)
            {
                CardInfo associatedCard = allCardInfos.FirstOrDefault(s => s.cardCode == cardCode);
                if (associatedCard == null)
                {
                    // TODO: エラーログなど
                    continue;
                }

                associatedCardInfos.Add(associatedCard);
            }

            // TODO: 画像なしを伝える画像を表示する
            if (associatedCardInfos.Count == 0)
            {
                return;
            }

            // 表示する画像を作成する
            var bitmap = new Bitmap(Util.RawCardWidth * associatedCardInfos.Count, Util.RawCardHeight);

            using (var canvas = Graphics.FromImage(bitmap))
            {
                canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;

                int xPos = 0;
                foreach (CardInfo cardInfo in associatedCardInfos)
                {
                    string filePath = Util.GetImageFilePath(cardInfo, Util.JapaneseCode); // TODO: 多言語対応
                    var fileImage = Image.FromFile(filePath);

                    canvas.DrawImage(fileImage, new Point(xPos, 0));
                    xPos += Util.RawCardWidth;
                }
            }

            FormUtil.SetImageStretchedByHeight(bitmap, ClientSize, SolePictureBox);
        }

        private void CopyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(SolePictureBox.Image);
        }

        private void ViewAssociatedCards_SizeChanged(object sender, EventArgs e)
        {
            MakeSoleImage();
        }
    }
}
