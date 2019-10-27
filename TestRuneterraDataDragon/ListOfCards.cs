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
        public ListOfCards()
        {
            InitializeComponent();
        }

        private SearchUtility _su = new SearchUtility();

        private void ListOfCards_Load(object sender, EventArgs e)
        {
            // TODO: 関連カード一覧の初期化分を関数化する
            AssociatedCardsObjectListView.UseHyperlinks = true;
            AssociatedCardsObjectListView.ShowGroups = false;
            var associatedColumnName = new List<string>
            {
                "name"
            };
            var associatedColumnWidth = new List<int>
            {
                140
            };
            FormUtil.InitColumns(associatedColumnName, associatedColumnWidth, AssociatedCardsObjectListView);
            FormUtil.SetHyperlinkOfColumn(AssociatedCardsObjectListView, "name", true);
            // 関連カード一覧の初期化ここまで

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

            // フィルタ機能用のチェックボックス群を作成する
            InitializeFilterCheckboxes();

            MakeSoleList();
        }

        private void InitializeFilterCheckboxes()
        {
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
            for (int i = 0; i < _su._manaCostNames.Count; i++)
            {
                CheckBox c = FormUtil.MakeCheckBoxForFilter(_su._manaCostNames[i], _su.manaCostTexts[i], FilterControlChanged);
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
        }

        private void MakeSoleList()
        {
            // TODO: 言語切り替えられるようにする
            Util.GetCardInfos(out var cardInfos, Util.JapaneseCode);

            // 地域でフィルタする
            _su.FilterByRegion(ref cardInfos, RegionFlowLayoutPanel);

            // 希少度でフィルタする
            _su.FilterByRarity(ref cardInfos, RarityFlowLayoutPanel);

            // マナコストでフィルタする
            _su.FilterByManaCost(ref cardInfos, ManaCostFlowLayoutPanel);

            // スペル速度でフィルタする
            _su.FilterBySpellSpeed(ref cardInfos, SpellSpeedFlowLayoutPanel);

            // タイプでフィルタする
            _su.FilterByType(ref cardInfos, TypeFlowLayoutPanel);

            // 親タイプでフィルタする
            _su.FilterBySuperType(ref cardInfos, SuperTypeFlowLayoutPanel);

            // サブタイプでフィルタする
            _su.FilterBySubType(ref cardInfos, SubTypeFlowLayoutPanel);

            // 収集可能性でフィルタする
            if (OnlyCollectibleCheckBox.Checked)
            {
                cardInfos = cardInfos.Where(s => s.collectible == true).ToList();
            }

            SoleObjectListView.SetObjects(cardInfos);
        }

        private void SoleObjectListView_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
        {
            var cardInfo = (CardInfo) e.Item.RowObject;
            var cardInfos = new List<CardInfo> {cardInfo};

            // 選択されたカードを元に、関連カード一覧を更新する
            Util.GetCardInfos(out var allCardInfos, Util.JapaneseCode);
            List<CardInfo> associatedCardInfoList = new List<CardInfo>();
            foreach (string cardCode in cardInfo.associatedCardRefs)
            {
                var associatedCard = allCardInfos.FirstOrDefault(s => s.cardCode == cardCode);
                if(associatedCard == null)
                {
                    // TODO: エラーログなど
                    continue;
                }

                associatedCardInfoList.Add(associatedCard);
            }

            AssociatedCardsObjectListView.SetObjects(associatedCardInfoList);

            // カード選択イベントを発生させる
            ((Form1)MdiParent)._selectCardInfos?.Invoke(cardInfos);

            e.Handled = true;
        }

        private void FilterControlChanged(object sender, EventArgs e)
        {
            MakeSoleList();
        }

        private void AssociatedCardsObjectListView_HyperlinkClicked(object sender, HyperlinkClickedEventArgs e)
        {
            var cardInfo = (CardInfo)e.Item.RowObject;
            var cardInfos = new List<CardInfo> { cardInfo };

            // カード選択イベントを発生させる
            ((Form1)MdiParent)._selectCardInfos?.Invoke(cardInfos);

            e.Handled = true;
        }

        /// <summary>
        /// 検索関連の処理をまとめる内部クラス
        /// </summary>
        class SearchUtility
        {
            public List<string> _manaCostNames = new List<string>
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

            public List<Point> _manaCostMinMax = new List<Point>
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

            public List<string> manaCostTexts = new List<string>
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

            public void FilterByRegion(ref List<CardInfo> cardInfos, FlowLayoutPanel checkboxPanel)
            {
                List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(checkboxPanel);

                // 1つもチェックされていなければフィルタしない
                if (!checkBoxes.Any(s => s.Checked))
                {
                    return;
                }

                // チェックされていない地域を除外する
                FormUtil.FilterByComparePropertyWithCheckBoxName(
                    ref cardInfos, typeof(CardInfo).GetProperty("regionRef"), checkBoxes);
            }

            public void FilterByRarity(ref List<CardInfo> cardInfos, FlowLayoutPanel checkboxPanel)
            {
                List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(checkboxPanel);

                // 1つもチェックされていなければフィルタしない
                if (!checkBoxes.Any(s => s.Checked))
                {
                    return;
                }

                // チェックされていない希少度を除外する
                FormUtil.FilterByComparePropertyWithCheckBoxName(
                    ref cardInfos, typeof(CardInfo).GetProperty("rarityRef"), checkBoxes);
            }

            public void FilterByManaCost(ref List<CardInfo> cardInfos, FlowLayoutPanel manacostPanel)
            {
                List<CheckBox> checkBoxes = new List<CheckBox>();
                foreach (string manaCostName in _manaCostNames)
                {
                    CheckBox c = (CheckBox)manacostPanel.Controls[manaCostName];
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

            public void FilterBySpellSpeed(ref List<CardInfo> cardInfos, FlowLayoutPanel checkboxPanel)
            {
                List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(checkboxPanel);

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

            public void FilterByType(ref List<CardInfo> cardInfos, FlowLayoutPanel checkboxPanel)
            {
                List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(checkboxPanel);

                // 1つもチェックされていなければフィルタしない
                if (!checkBoxes.Any(s => s.Checked))
                {
                    return;
                }

                // チェックされていないタイプを除外する
                FormUtil.FilterByComparePropertyWithCheckBoxName(
                    ref cardInfos, typeof(CardInfo).GetProperty("type"), checkBoxes);
            }

            public void FilterBySuperType(ref List<CardInfo> cardInfos, FlowLayoutPanel checkboxPanel)
            {
                List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(checkboxPanel);

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

            public void FilterBySubType(ref List<CardInfo> cardInfos, FlowLayoutPanel checkboxPanel)
            {
                List<CheckBox> checkBoxes = FormUtil.GetCheckBoxes(checkboxPanel);

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
        }
    }
}
