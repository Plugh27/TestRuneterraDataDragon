using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoRDeckCodes;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    internal delegate void SelectCardInfos(List<CardInfo> cardInfos);
    internal delegate void SelectCardInfosInCardsDeck(List<CardInfo> cardInfos);

    internal delegate void UpdateCardsDeck(List<CardCodeAndCount> deck);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // カード一覧でカードが選択された時のデリゲート
        internal SelectCardInfos _selectCardInfos;

        // デッキカード一覧でカードが選択された時のデリゲート
        internal SelectCardInfosInCardsDeck _selectCardInfosInCardsDeck;

        // デッキのカードが更新された時のデリゲート
        internal UpdateCardsDeck _updateCardsDeck;

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Setting();
            f.MdiParent = this;
            f.Show();
        }

        private void ListOfKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ListOfKeywords();
            f.MdiParent = this;
            f.Show();
        }

        private void Set1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ListOfCards();
            f.MdiParent = this;
            f.Show();
        }

        private void GameImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ViewGameImage();
            f.MdiParent = this;
            f.Show();
        }

        private void ListOfCardsDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ListOfCardsDeck();
            f.MdiParent = this;
            f.Show();
        }

        private void CardsDeckImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ViewCardsDeckImage();
            f.MdiParent = this;
            f.Show();
        }
    }
}
