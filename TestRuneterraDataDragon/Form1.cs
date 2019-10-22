using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    internal delegate void SelectCardInfos(List<CardInfo> cardInfos);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal SelectCardInfos _selectCardInfos;

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
    }
}
