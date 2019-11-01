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
using LoRDeckCodes;
using Newtonsoft.Json;
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

                CardCodeAndCount cardCodeAndCount = _editedDeck.FirstOrDefault(s => s.CardCode == cardInfo.cardCode);

                // 現在のデッキ構成に存在しないカードなら1枚追加する
                if (cardCodeAndCount == null)
                {
                    _editedDeck.Add(new CardCodeAndCount(){CardCode = cardInfo.cardCode, Count = 1});
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

        /// <summary>
        /// 編集中（リスト表示中）のデッキ情報
        /// </summary>
        private List<CardCodeAndCount> _editedDeck = new List<CardCodeAndCount>();

        /// <summary>
        /// 全てのデッキ情報
        /// </summary>
        private List<DeckAndName> _deckAndNameList = new List<DeckAndName>();

        private void ListOfCardsDeck_Load(object sender, EventArgs e)
        {
            // リストビューの諸設定を行う
            SoleObjectListView.UseHyperlinks = true;
            SoleObjectListView.ShowGroups = false;

            // カラムの諸設定を行う
            var nameList = new List<string>
            {
                "cardInfo.name",
                "cardInfo.cost",
                "cardInfo.cardType",
                "cardInfo.region",
                "cardCodeAndCount.Count"
            };
            var widthList = new List<int>
            {
                120,
                20,
                80,
                50,
                80
            };
            FormUtil.InitColumns(nameList, widthList, SoleObjectListView);

            // ハイパーリンクの設定
            FormUtil.SetHyperlinkOfColumn(SoleObjectListView, "cardInfo.name", true);

            Util.GetCardInfos(out var cardInfos, Util.JapaneseCode);

            // カード情報の表示方法を指定

            var CardTypeColumn = SoleObjectListView.AllColumns.First(s => s.AspectName.Equals("cardInfo.cardType"));
            CardTypeColumn.AspectGetter = delegate(object x)
            {
                // TODO: typeRefなどが無いため多言語対応出来る見込みが全然ない
                CardCodeAndCount ccac = ((CardDeckDetail)x).cardCodeAndCount;
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

            // デッキ情報を読み込む
            _deckAndNameList = Util.GetDeckAndNameList();

            // リストボックスにデッキ情報を表示
            FormUtil.RefreshListBox(DecksListBox, _deckAndNameList, "name");

            ((Form1)MdiParent)._selectCardInfos += SelectCardInfos;
        }

        private void ListOfCardsDeck_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)MdiParent)._selectCardInfos -= SelectCardInfos;

            SaveUserDecks();
        }

        private void MakeSoleList()
        {
            //
            Util.GetCardInfos(out var allCardInfos, Util.JapaneseCode);
            List<CardDeckDetail> cardDeckDetails = new List<CardDeckDetail>();
            foreach (CardCodeAndCount cardCodeAndCount in _editedDeck)
            {
                cardDeckDetails.Add(new CardDeckDetail(allCardInfos, cardCodeAndCount));
            }

            // チャンピオンの枚数を数えて表示
            int championCount = 0;
            cardDeckDetails.Where(s => s.cardInfo.supertype == "チャンピオン").ToList()
                .ForEach(s => championCount += s.cardCodeAndCount.Count);

            ChampionCountLabel.Text = "チャンピオン: " + championCount.ToString() + " / 6";

            // ユニットの枚数を数えて表示
            int unitCount = 0;
            cardDeckDetails.Where(s => s.cardInfo.type == "ユニット").ToList()
                .ForEach(s => unitCount += s.cardCodeAndCount.Count);

            UnitCountLabel.Text = "ユニット（チャンピオン含む）: " + unitCount;

            // スペルの枚数を数えて表示
            int spellCount = 0;
            cardDeckDetails.Where(s => s.cardInfo.type == "スペル").ToList()
                .ForEach(s => spellCount += s.cardCodeAndCount.Count);

            SpellCountLabel.Text = "スペル: " + spellCount;

            // 地域を表示
            StringBuilder regionStringBuilder = new StringBuilder();
            regionStringBuilder.Append("地域: ");
            cardDeckDetails.GroupBy(s => s.cardInfo.regionRef).Select(s => s.First()).ToList()
                .ForEach(s => regionStringBuilder.Append(s.cardInfo.region + " "));

            RegionListLabel.Text = regionStringBuilder.ToString();

            // デッキの枚数を数えて表示
            int cardsDeckCount = 0;
            cardDeckDetails.ForEach(s => cardsDeckCount += s.cardCodeAndCount.Count);

            CardsDeckCountLabel.Text = "カード枚数: " + cardsDeckCount + " / 40";

            // リストに表示するオブジェクトを設定
            SoleObjectListView.SetObjects(cardDeckDetails);

            ((Form1)MdiParent)._updateCardsDeck?.Invoke(_editedDeck); // TODO: 処理が重そう
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

            // インポートしたデッキをデッキリストに加える
            // 新しいデッキをデッキリストに加える
            DeckAndName newDeckAndName = new DeckAndName() {deck = deck, name = "インポートしたデッキ"};
            _deckAndNameList.Add(newDeckAndName);
            FormUtil.RefreshListBox(DecksListBox, _deckAndNameList, "name");
            DecksListBox.SelectedItem = newDeckAndName;

            _editedDeck = deck;
            MakeSoleList();
        }

        private void SaveUserDecks()
        {
            // TODO: 今リストに表示しているデッキの変更を反映する

            Util.SetDeckAndNameList(_deckAndNameList);
        }

        private void ExportToClipboardButton_Click(object sender, EventArgs e)
        {
            string deckCode = WrapperUtil.GetCodeFromDeck(_editedDeck);
            if (deckCode == "")
            {
                MessageBox.Show("不正なデッキです");
            }

            Clipboard.SetText(deckCode);
        }

        private void SoleObjectListView_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
        {
            // クリックされた項目（CardCodeAndCount）と、それに相当するCardInfoを取得する
            CardDeckDetail cardDeckDetail = (CardDeckDetail) e.Item.RowObject;

            // デッキ一覧でカードが選択された時の処理を実行する
            ((Form1) MdiParent)._selectCardInfosInCardsDeck?.Invoke(new List<CardInfo> {cardDeckDetail.cardInfo});

            // カード削除しないなら何もせず抜ける
            if (RemoveCardDisableRadioButton.Checked)
            {
                e.Handled = true;
                return;
            }

            // カード削除する
            CardCodeAndCount targetCardCodeAndCount =
                _editedDeck.FirstOrDefault(s => s.CardCode == cardDeckDetail.cardCodeAndCount.CardCode);
            if (targetCardCodeAndCount == null)
            {
                return; // TODO: エラー処理方法検討
            }

            // 枚数を1減らす
            targetCardCodeAndCount.Count -= 1;

            // 枚数が0ならリストから削除する
            if (targetCardCodeAndCount.Count == 0)
            {
                _editedDeck = _editedDeck.Where(
                    s => s.CardCode != targetCardCodeAndCount.CardCode).ToList();
            }

            MakeSoleList();
            e.Handled = true;
        }

        private void ChangeDeckNameButton_Click(object sender, EventArgs e)
        {
            var deck = (DeckAndName) DecksListBox.SelectedItem;

            // デッキが選択されていなければ何もしない
            if (deck == null)
            {
                return;
            }

            var f = new DialogInputText();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                // 選択中のデッキのnameを上書きする
                deck.name = f._InputtedText;
            }

            // 変更を画面に反映する
            FormUtil.RefreshListBox(DecksListBox, _deckAndNameList, "name");
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            // TODO: テキストの入力を求める

            // 編集中のデッキを元に、新しいデッキを作る
            DeckAndName newDeckAndName = new DeckAndName();
            newDeckAndName.name = WrapperUtil.GetCodeFromDeck(_editedDeck);
            newDeckAndName.deck = _editedDeck;

            // 新しいデッキをデッキリストに加える
            _deckAndNameList.Add(newDeckAndName);
            FormUtil.RefreshListBox(DecksListBox, _deckAndNameList, "name");
            DecksListBox.SelectedItem = newDeckAndName;
        }

        private void NewDeckButton_Click(object sender, EventArgs e)
        {
            // TODO: テキストの入力を求める

            // 空のデッキを作る
            DeckAndName newDeckAndName = new DeckAndName();
            newDeckAndName.name = "新しいデッキ";
            newDeckAndName.deck = new List<CardCodeAndCount>();

            // 空のデッキをデッキリストに加える
            _deckAndNameList.Add(newDeckAndName);
            FormUtil.RefreshListBox(DecksListBox, _deckAndNameList, "name");
            DecksListBox.SelectedItem = newDeckAndName;
        }

        private void DecksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deckAndName = (DeckAndName)DecksListBox.SelectedItem;

            // デッキが選択されていなければ何もしない
            if (deckAndName == null)
            {
                return;
            }

            // TODO: 切り替え前のデッキ情報の変更は保存するのか確認とかなんとか

            // 一覧の表示を切り替える
            _editedDeck = deckAndName.deck;
            MakeSoleList();
        }

        private void DeleteDeckButton_Click(object sender, EventArgs e)
        {
            var deckAndName = (DeckAndName)DecksListBox.SelectedItem;

            // デッキが選択されていなければ何もしない
            if (deckAndName == null)
            {
                return;
            }

            // TODO: 確認ダイアログなどを出したい

            _deckAndNameList.Remove(deckAndName);
            FormUtil.RefreshListBox(DecksListBox, _deckAndNameList, "name");

        }
    }
}
