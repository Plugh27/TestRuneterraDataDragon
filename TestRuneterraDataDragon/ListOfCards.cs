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
    public partial class ListOfCards : Form
    {
        public ListOfCards()
        {
            InitializeComponent();
        }

        private void ListOfCards_Load(object sender, EventArgs e)
        {
            // リストビューの諸設定を行う
            SoleObjectListView.UseHyperlinks = true;
            SoleObjectListView.ShowGroups = false;

            // カラムの諸設定を行う
            var nameList = new List<string>
            {
                "name",
                "type",
                "region",
                "spellSpeed",
                "descriptionRaw"
            };
            var widthList = new List<int>
            {
                140,
                80,
                80,
                80,
                640
            };
            FormUtil.InitColumns(nameList, widthList, SoleObjectListView);

            // 名前がハイパーリンクになるようにする
            FormUtil.SetHyperlinkOfColumn(SoleObjectListView, "name", true);

            Util.GetSet1Data(out var set1s);

            // ja_jpのデータだけ表示する
            var jaSet = set1s["ja_jp"]; // TODO: 言語切り替えられるようにする

            SoleObjectListView.SetObjects(jaSet.cardInfos);
        }

        private void SoleObjectListView_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
        {
            var cardInfo = (CardInfo) e.Item.RowObject;
            var cardInfos = new List<CardInfo> {cardInfo};

            ((Form1)MdiParent)._selectCardInfos?.Invoke(cardInfos);

            e.Handled = true;
        }
    }
}
