using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    public partial class ViewGameImage : Form
    {
        public ViewGameImage()
        {
            InitializeComponent();
        }

        private List<CardInfo> _selectedCardInfos;

        public void SelectCardInfos(List<CardInfo> cardInfos)
        {
            _selectedCardInfos = cardInfos;
            MakeSoleImage();
        }

        private void MakeSoleImage()
        {
            if (_selectedCardInfos.Count == 0)
            {
                return;
            }

            // 先頭のカードのみ表示する
            var targetCardInfos = new List<CardInfo> { _selectedCardInfos.First() };
            var targetCard = targetCardInfos.First();

            // カードのファイルパスを求める
            string metaFileDir = Path.GetDirectoryName(Properties.Settings.Default.SetDataFilePath);
            string locale = "ja_jp"; // TODO: 切り替えられるようにする
            string separator = Path.DirectorySeparatorChar.ToString();
            string cardImageDir = metaFileDir + separator + locale + separator + "img" + separator + "cards" + separator;

            string cardImageFileName = Path.GetFileName(targetCard.assets[0].gameAbsolutePath);
            string cardImageFilePath = cardImageDir + cardImageFileName;

            SolePictureBox.Image = Image.FromFile(cardImageFilePath);
        }

        private void ViewGameImage_Load(object sender, EventArgs e)
        {
            _selectedCardInfos = new List<CardInfo>();

            ((Form1) MdiParent)._selectCardInfos += SelectCardInfos;
        }

        private void ViewGameImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)MdiParent)._selectCardInfos -= SelectCardInfos;
        }
    }
}
