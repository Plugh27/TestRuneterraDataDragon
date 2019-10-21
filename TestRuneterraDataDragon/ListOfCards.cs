using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using TestRuneterraDataDragon.JsonPattern;
using Region = System.Drawing.Region;

namespace TestRuneterraDataDragon
{
    public partial class ListOfCards : Form
    {
        private List<string> _manaCostNames = new List<string>
        {
            "cost0",
            "cost1",
            "cost2",
            "cost3",
            "cost4",
            "cost5",
            "cost6",
            "cost7over"
        };

        private List<Point> _manaCostMinMax = new List<Point>
        {
            new Point(0, 0), // コスト0
            new Point(1, 1),
            new Point(2, 2),
            new Point(3, 3),
            new Point(4, 4),
            new Point(5, 5),
            new Point(6, 6),
            new Point(7, 100) // コスト7以上
        };
 
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


            Util.GetGlobalData(out var jaGlobal, Util.JapaneseCode);// TODO: 言語切り替えられるようにする

            // 地域のチェックボックスを作成する
            foreach (JsonPattern.Region region in jaGlobal.regions)
            {
                CheckBox c = FormUtil.MakeCheckBoxForFilter(region.nameRef, region.name, FilterControlChanged);
                RegionFlowLayoutPanel.Controls.Add(c);
            }

            // 希少度のチェックボックスを作成する
            foreach (JsonPattern.Rarity rarity in jaGlobal.rarities)
            {
                CheckBox c = FormUtil.MakeCheckBoxForFilter(rarity.nameRef, rarity.name, FilterControlChanged);
                RarityFlowLayoutPanel.Controls.Add(c);
            }

            // マナコストのチェックボックスを作成する
            List<string> manaCostTexts = new List<string>
            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7+",
            };
            for (int i = 0; i < _manaCostNames.Count; i++)
            {
                CheckBox c = FormUtil.MakeCheckBoxForFilter(_manaCostNames[i], manaCostTexts[i], FilterControlChanged);
                ManaCostFlowLayoutPanel.Controls.Add(c);
            }

            // スペルスピードのチェックボックスを作成する
            foreach (JsonPattern.SpellSpeed spellSpeed in jaGlobal.spellSpeeds)
            {
                CheckBox c = FormUtil.MakeCheckBoxForFilter(spellSpeed.nameRef, spellSpeed.name, FilterControlChanged);
                SpellSpeedFlowLayoutPanel.Controls.Add(c);
            }

            Util.GetCardInfos(out var cardInfos, Util.JapaneseCode); // TODO: 言語を切り替えられるようにする
            // タイプ名のリストを作成する
            List<CardInfo> uniqueTypeCardInfos =
                cardInfos.GroupBy(s => s.type).Select(s => s.First()).ToList();
            // タイプのチェックボックスを作成する
            foreach (CardInfo cardInfo in uniqueTypeCardInfos)
            {
                CheckBox c = FormUtil.MakeCheckBoxForFilter(cardInfo.type, cardInfo.type, FilterControlChanged);
                TypeFlowLayoutPanel.Controls.Add(c);
            }

            // 親タイプのリストを作成する
            List<CardInfo> uniqueSuperTypeCardInfos =
                cardInfos.GroupBy(s => s.supertype).Select(s => s.First()).ToList();
            uniqueSuperTypeCardInfos = uniqueSuperTypeCardInfos.Where(s => s.supertype != string.Empty).ToList();
            // 親タイプのチェックボックスを作成する
            foreach (CardInfo cardInfo in uniqueSuperTypeCardInfos)
            {
                CheckBox c =
                    FormUtil.MakeCheckBoxForFilter(cardInfo.supertype, cardInfo.supertype, FilterControlChanged);
                SuperTypeFlowLayoutPanel.Controls.Add(c);
            }

            // サブタイプのリストを作成する
            List<CardInfo> uniqueSubTypeCardInfos =
                cardInfos.GroupBy(s => s.subtype).Select(s => s.First()).ToList();
            uniqueSubTypeCardInfos = uniqueSubTypeCardInfos.Where(s => s.subtype != string.Empty).ToList();
            // サブタイプのチェックボックスを作成する
            foreach (CardInfo cardInfo in uniqueSubTypeCardInfos)
            {
                CheckBox c =
                    FormUtil.MakeCheckBoxForFilter(cardInfo.subtype, cardInfo.subtype, FilterControlChanged);
                SubTypeFlowLayoutPanel.Controls.Add(c);
            }

            MakeSoleList();
        }

        private void MakeSoleList()
        {
            // TODO: 言語切り替えられるようにする
            Util.GetCardInfos(out var cardInfos, Util.JapaneseCode);

            // 地域でフィルタする
            FilterByRegion(ref cardInfos);

            // 希少度でフィルタする
            FilterByRarity(ref cardInfos);

            // マナコストでフィルタする
            FilterByManaCost(ref cardInfos);

            // スペル速度でフィルタする
            FilterBySpellSpeed(ref cardInfos);

            // タイプでフィルタする
            FilterByType(ref cardInfos);

            // 親タイプでフィルタする
            FilterBySuperType(ref cardInfos);

            // サブタイプでフィルタする
            FilterBySubType(ref cardInfos);

            SoleObjectListView.SetObjects(cardInfos);
        }

        private void FilterByRegion(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(RegionFlowLayoutPanel);

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされていない地域を除外する
            FormUtil.FilterByComparePropertyWithCheckBoxName(
                ref cardInfos, typeof(CardInfo).GetProperty("regionRef"), checkBoxes);
        }

        private void FilterByRarity(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(RarityFlowLayoutPanel);

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされていない希少度を除外する
            FormUtil.FilterByComparePropertyWithCheckBoxName(
                ref cardInfos, typeof(CardInfo).GetProperty("rarityRef"), checkBoxes);
        }

        private void FilterByManaCost(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            foreach (string manaCostName in _manaCostNames)
            {
                CheckBox c = (CheckBox) ManaCostFlowLayoutPanel.Controls[manaCostName];
                checkBoxes.Add(c);
            }

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされていないマナコストを除外する
            for (int i = 0; i < _manaCostNames.Count; i++)
            {
                if (checkBoxes[i].Checked == false)
                {
                    cardInfos =
                        cardInfos.Where(s => !(s.cost >= _manaCostMinMax[i].X && s.cost <= _manaCostMinMax[i].Y)).ToList();
                }
            }
        }

        private void FilterBySpellSpeed(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(SpellSpeedFlowLayoutPanel);

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされていないスペル速度を除外する
            FormUtil.FilterByComparePropertyWithCheckBoxName(
                ref cardInfos, typeof(CardInfo).GetProperty("spellSpeedRef"), checkBoxes);

            // スペル速度が空欄の情報を除外する
            cardInfos = cardInfos.Where(s => s.spellSpeed != string.Empty).ToList();
        }

        private void FilterByType(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(TypeFlowLayoutPanel);

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされていないタイプを除外する
            FormUtil.FilterByComparePropertyWithCheckBoxName(
                ref cardInfos, typeof(CardInfo).GetProperty("type"), checkBoxes);
        }

        private void FilterBySuperType(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(SuperTypeFlowLayoutPanel);

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされている親タイプのデータのみ残す
            List<CardInfo> tempCardInfos = new List<CardInfo>();
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    tempCardInfos.AddRange(cardInfos.Where(s => s.supertype == checkBox.Name));
                }
            }

            cardInfos = tempCardInfos;
        }

        private void FilterBySubType(ref List<CardInfo> cardInfos)
        {
            List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(SubTypeFlowLayoutPanel);

            // 1つもチェックされていなければフィルタしない
            if (!checkBoxes.Any(s => s.Checked))
            {
                return;
            }

            // チェックされているサブタイプのデータのみ残す
            List<CardInfo> tempCardInfos = new List<CardInfo>();
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    tempCardInfos.AddRange(cardInfos.Where(s => s.subtype == checkBox.Name));
                }
            }

            cardInfos = tempCardInfos;
        }

        private void SoleObjectListView_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
        {
            var cardInfo = (CardInfo) e.Item.RowObject;
            var cardInfos = new List<CardInfo> {cardInfo};

            ((Form1)MdiParent)._selectCardInfos?.Invoke(cardInfos);

            e.Handled = true;
        }

        private void FilterControlChanged(object sender, EventArgs e)
        {
            MakeSoleList();
        }
    }
}
