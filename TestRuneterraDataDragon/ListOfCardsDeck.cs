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
    public partial class ListOfCardsDeck : Form
    {
        public ListOfCardsDeck()
        {
            InitializeComponent();
        }

        public void SelectCardInfos(List<CardInfo> cardInfos)
        {
            // カード追加しないなら何もせず抜ける
            if (AddCardDisableRadioButton.Checked)
            {
                return;
            }

            // カード追加する
            foreach (CardInfo cardInfo in cardInfos)
            {
                // コレクタブルでないカードはデッキに追加しない
                if (!cardInfo.collectible)
                {
                    continue;
                }

                CardCodeAndCount cardCodeAndCount = _cardCodeAndCounts.FirstOrDefault(s => s.CardCode == cardInfo.cardCode);

                // 現在のデッキ構成に存在しないカードなら1枚追加する
                if (cardCodeAndCount == null)
                {
                    _cardCodeAndCounts.Add(new CardCodeAndCount(){CardCode = cardInfo.cardCode, Count = 1});
                }
                else
                {
                    // 現在のデッキ構成に存在するカードなら、1枚追加するが3枚以上にはしない
                    if (cardCodeAndCount.Count < 3)
                    {
                        cardCodeAndCount.Count += 1;
                    }
                }
            }

            MakeSoleList();
        }

        private List<CardCodeAndCount> _cardCodeAndCounts = new List<CardCodeAndCount>();

        private void ListOfCardsDeck_Load(object sender, EventArgs e)
        {
            // リストビューの諸設定を行う
            SoleObjectListView.UseHyperlinks = true;
            SoleObjectListView.ShowGroups = false;

            // カラムの諸設定を行う
            var nameList = new List<string>
            {
                "CardCode",
                "Region",
                "Name",
                "Cost",
                "CardType",
                "Count"
            };
            var widthList = new List<int>
            {
                100,
                50,
                80,
                20,
                80,
                80
            };
            FormUtil.InitColumns(nameList, widthList, SoleObjectListView);

            // ハイパーリンクの設定
            FormUtil.SetHyperlinkOfColumn(SoleObjectListView, "CardCode", true);

            Util.GetCardInfos(out var cardInfos, Util.JapaneseCode);

            // カード情報の表示方法を指定

            // カードコードを元に、カードの各種情報を表示する設定をする
            FormUtil.SetAspectGetterByStringProperty(SoleObjectListView, "Region", cardInfos,
                typeof(CardInfo).GetProperty("region"));

            FormUtil.SetAspectGetterByStringProperty(SoleObjectListView, "Name", cardInfos,
                typeof(CardInfo).GetProperty("name"));

            FormUtil.SetAspectGetterByIntProperty(SoleObjectListView, "Cost", cardInfos,
                typeof(CardInfo).GetProperty("cost"));

            var CardTypeColumn = SoleObjectListView.AllColumns.First(s => s.AspectName.Equals("CardType"));
            CardTypeColumn.AspectGetter = delegate(object x)
            {
                // TODO: typeRefなどが無いため多言語対応出来る見込みが全然ない
                CardCodeAndCount ccac = (CardCodeAndCount)x;
                CardInfo cardInfo = cardInfos.First(s => s.cardCode == ccac.CardCode);
                if (cardInfo.type == "スペル")
                {
                    return "スペル";
                }
                else if (cardInfo.supertype == "チャンピオン" && cardInfo.type == "ユニット")
                {
                    return "チャンピオン";
                }
                else if(cardInfo.supertype != "チャンピオン" && cardInfo.type == "ユニット")
                {
                    return "フォロワー";
                }
                else
                {
                    return "不明: type: " + cardInfo.type + " supertype: " + cardInfo.supertype + " subtype: " +
                           cardInfo.subtype;
                }
            };

            ((Form1)MdiParent)._selectCardInfos += SelectCardInfos;
        }

        private void MakeSoleList()
        {
            SoleObjectListView.SetObjects(_cardCodeAndCounts);
        }

        private void ImportFromClipboardButton_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText())
            {
                return;
            }

            string deckCode = Clipboard.GetText();
            if (!WrapperUtil.GetDeckFromCode(out var deck, deckCode))
            {
                MessageBox.Show("デッキコードの読み込みに失敗しました。内容: " + deckCode);
                return;
            }

            _cardCodeAndCounts = deck;
            MakeSoleList();
        }

        private void ListOfCardsDeck_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)MdiParent)._selectCardInfos -= SelectCardInfos;
        }

        private void ExportToClipboardButton_Click(object sender, EventArgs e)
        {
            string deckCode = WrapperUtil.GetCodeFromDeck(_cardCodeAndCounts);
            if (deckCode == "")
            {
                MessageBox.Show("不正なデッキです");
            }

            Clipboard.SetText(deckCode);
        }

        private void SoleObjectListView_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
        {
            // カード削除しないなら何もせず抜ける
            if (RemoveCardDisableRadioButton.Checked)
            {
                e.Handled = true;
                return;
            }

            // カード削除する
            CardCodeAndCount cardCodeAndCount = (CardCodeAndCount) e.Item.RowObject;

            CardCodeAndCount targetCardCodeAndCount =
                _cardCodeAndCounts.FirstOrDefault(s => s.CardCode == cardCodeAndCount.CardCode);
            if (targetCardCodeAndCount == null)
            {
                return; // TODO: エラー処理方法検討
            }

            // 枚数を1減らす
            targetCardCodeAndCount.Count -= 1;

            // 枚数が0ならリストから削除する
            if (targetCardCodeAndCount.Count == 0)
            {
                _cardCodeAndCounts = _cardCodeAndCounts.Where(
                    s => s.CardCode != targetCardCodeAndCount.CardCode).ToList();
            }

            MakeSoleList();
            e.Handled = true;
        }
    }
}
