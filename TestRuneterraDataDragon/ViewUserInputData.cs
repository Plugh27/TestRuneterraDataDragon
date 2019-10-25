using LoRDeckCodes;
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
    public partial class ViewUserInputData : Form
    {
        public ViewUserInputData()
        {
            InitializeComponent();
        }

        private CardInfo _selectedCardInfo;

        private List<UserInputData> _userInputDatas;

        private void ViewUserInputData_Load(object sender, EventArgs e)
        {
            // ユーザー入力情報をファイルから読み込む
            _userInputDatas = Util.GetUserInputDatasFromJsonFile();

            ((Form1)MdiParent)._selectCardInfos += SelectCardInfos;
            ((Form1)MdiParent)._selectCardInfosInCardsDeck += SelectCardInfos;
        }

        private void ViewUserInputData_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ユーザー入力情報をファイルに書き込む
            RefreshMemberValueByForm();
            Util.SetupUserInputDatasToJsonFile(_userInputDatas); // TODO: この仕様から、本フォームは複数起動不可にすべき

            ((Form1)MdiParent)._selectCardInfos -= SelectCardInfos;
            ((Form1)MdiParent)._selectCardInfosInCardsDeck -= SelectCardInfos;
        }

        public void SelectCardInfos(List<CardInfo> cardInfos)
        {
            // 空が渡されていたら無視する
            if (cardInfos.Count < 1)
            {
                return;
            }

            // ユーザー入力情報をファイルに書き込む
            RefreshMemberValueByForm();
            Util.SetupUserInputDatasToJsonFile(_userInputDatas); // TODO: この仕様から、本フォームは複数起動不可にすべき

            // 最初の要素を処理対象とする
            _selectedCardInfo = cardInfos.First();

            // 画面表示を更新する
            RefreshFormByMemberValue();
        }

        private void RefreshFormByMemberValue()
        {
            // 選択中のカードが無ければ処理しない
            if (_selectedCardInfo == null)
            {
                return;
            }

            // 選択中のカードの情報を得る
            Util.GetCardInfos(out var cardInfos, Util.JapaneseCode);
            CardInfo targetCardInfo = cardInfos.FirstOrDefault(s => s.cardCode == _selectedCardInfo.cardCode);
            if (targetCardInfo == null)
            {
                // TODO: エラーログ出すなど
                return;
            }

            // 選択中のカードのユーザー入力情報を得る
            UserInputData targetUserInputData =
                _userInputDatas.FirstOrDefault(s => s.cardCode == _selectedCardInfo.cardCode);
            // 存在しなければ追加する
            if (targetUserInputData == null)
            {
                targetUserInputData = new UserInputData()
                {
                    cardCode = _selectedCardInfo.cardCode,
                    comment = "",
                    draftPoint = 50,
                    imageUrl = "",
                    webpageUrl = ""
                };
                _userInputDatas.Add(targetUserInputData);
            }

            // メンバ変数の値をフォームに反映する
            CardCodeTextBox.Text = targetCardInfo.cardCode;
            CardNameTextBox.Text = targetCardInfo.name;
            DraftPointNumericUpDown.Value = targetUserInputData.draftPoint;
            ImageUrlTextBox.Text = targetUserInputData.imageUrl;
            CommentTextBox.Text = targetUserInputData.comment;
        }

        private void RefreshMemberValueByForm()
        {
            // 選択中のカードが無ければ処理しない
            if (_selectedCardInfo == null)
            {
                return;
            }

            // 選択中のカードのユーザー入力情報を参照する
            UserInputData targetUserInputData =
                _userInputDatas.FirstOrDefault(s => s.cardCode == _selectedCardInfo.cardCode);
            if (targetUserInputData == null)
            {
                // TODO: エラーログなど
                return;
            }

            // フォームの値をメンバ変数に反映する
            targetUserInputData.draftPoint = (int) DraftPointNumericUpDown.Value;
            targetUserInputData.imageUrl = ImageUrlTextBox.Text;
            targetUserInputData.comment = CommentTextBox.Text;
        }

        private void OpenMobalyticsPageButton_Click(object sender, EventArgs e)
        {
            // 選択中のカードが無ければ処理しない
            if (_selectedCardInfo == null)
            {
                return;
            }

            System.Diagnostics.Process.Start("https://lor.mobalytics.gg/ja_jp/cards/" + _selectedCardInfo.cardCode);
        }
    }
}