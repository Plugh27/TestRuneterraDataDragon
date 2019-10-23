using BrightIdeasSoftware;
using LoRDeckCodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    internal class FormUtil
    {
        /// <summary>
        /// ObjectListViewのColumnの初期設定を行う。
        /// </summary>
        /// <param name="nameList">名称のリスト</param>
        /// <param name="widthList">幅のリスト</param>
        /// <param name="objectListView">処理対象のObjectListView</param>
        public static void InitColumns(List<string> nameList, List<int> widthList, ObjectListView objectListView)
        {
            for (var i = 0; i < nameList.Count; i++)
            {
                // ReSharper disable once UseObjectOrCollectionInitializer
                var columnHeader = new OLVColumn();
                columnHeader.Text = nameList[i];
                columnHeader.AspectName = nameList[i];
                columnHeader.Width = widthList[i];
                objectListView.AllColumns.Add(columnHeader);
                objectListView.Columns.Add(columnHeader);
            }
        }

        /// <summary>
        /// AspectNameを元にHyperLinkの設定を行う
        /// </summary>
        /// <param name="objectListView">処理対象のObjectListView</param>
        /// <param name="aspectName">設定対象のカラムのAspectName</param>
        /// <param name="isHyperLink">設定するHyperLinkのブール値</param>
        public static void SetHyperlinkOfColumn(ObjectListView objectListView, string aspectName, bool isHyperLink)
        {
            var column = objectListView.AllColumns.FirstOrDefault(s => s.AspectName.Equals(aspectName));
            if (column == null)
            {
                //Log.Error($"SetHyperlinkOfColumn カラムが見つからない。aspectName: {aspectName}");
            }
            else
            {
                column.Hyperlink = isHyperLink;
            }
        }

        public static Image GetStretchedImage(Image targetImage, int resizeWidth, int resizeHeight)
        {
            // 伸縮後の画像を作成
            var resizeBitmap = new Bitmap(resizeWidth, resizeHeight);
            var g = Graphics.FromImage(resizeBitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(targetImage, 0, 0, resizeWidth, resizeHeight);

            return resizeBitmap;
        }

        /// <summary>
        /// 指定されたSizeの幅を基準に画像を伸縮し、PictureBoxに設定する。
        /// </summary>
        /// <param name="targetImage">処理対象の画像</param>
        /// <param name="clientSize">画像のサイズを指定</param>
        /// <param name="targetPictureBox">処理対象のコントロール</param>
        public static void SetImageStretched(Image targetImage, Size clientSize, PictureBox targetPictureBox)
        {
            // 伸縮後の幅と高さを計算（サイズの幅に合わせて伸縮する）
            var imageSize = targetImage.Size;
            var resizeWidth = clientSize.Width;
            var resizeHeight = (int)(imageSize.Height * (double)resizeWidth / imageSize.Width);

            // 伸縮後の画像を作成
            var resizeBmp = GetStretchedImage(targetImage, resizeWidth, resizeHeight);

            // 画像コントロールのサイズを調整
            targetPictureBox.Width = resizeBmp.Width;
            targetPictureBox.Height = resizeBmp.Height;
            targetPictureBox.Image = resizeBmp;
        }

        /// <summary>
        /// フィルタするためのチェックボックスを作成する
        /// </summary>
        /// <param name="name">Nameプロパティに設定する文字列</param>
        /// <param name="text">Textプロパティに設定する文字列</param>
        /// <param name="checkedChangedHandler">CheckedChengedハンドラに登録する関数</param>
        /// <returns>作成したチェックボックス</returns>
        public static CheckBox MakeCheckBoxForFilter(string name, string text, EventHandler checkedChangedHandler)
        {
            CheckBox c = new CheckBox();
            c.UseMnemonic = false;
            c.AutoSize = true;
            c.Name = name;
            c.Text = text;
            c.CheckedChanged += checkedChangedHandler;

            return c;
        }

        /// <summary>
        /// チェックボックスしか登録されていないフローレイアウトパネルの、チェックボックスのリストを返す
        /// </summary>
        /// <param name="flowLayoutPanel">処理対象のコントロール</param>
        /// <returns>チェックボックスのリスト</returns>
        public static List<CheckBox> GetCheckBoxes(FlowLayoutPanel flowLayoutPanel)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            foreach (Control control in flowLayoutPanel.Controls)
            {
                checkBoxes.Add((CheckBox)control);
            }

            return checkBoxes;
        }

        /// <summary>
        /// 指定されたカード情報のプロパティと、CheckBoxコントロールのNameプロパティを比較して
        /// カード情報をフィルタする
        /// </summary>
        /// <param name="cardInfos">フィルタ対象のカード情報リスト</param>
        /// <param name="propertyInfo">比較対象のプロパティ</param>
        /// <param name="checkBoxes">比較対象になるNameプロパティを持つCheckBox</param>
        public static void FilterByComparePropertyWithCheckBoxName(ref List<CardInfo> cardInfos, PropertyInfo propertyInfo, List<CheckBox> checkBoxes)
        {
            List<CheckBox> uncheckedList = checkBoxes.Where(s => s.Checked == false).ToList();
            foreach (CheckBox checkBox in uncheckedList)
            {
                cardInfos = cardInfos.Where(s => (string)propertyInfo.GetValue(s) != checkBox.Name).ToList();
            }
        }

        /// <summary>
        /// CardInfoのプロパティを参照して表示するカラムのAspectGetterを設定する
        /// </summary>
        /// <param name="objectListView">処理対象のコントロール</param>
        /// <param name="aspectName">処理対象のカラムのAspectName</param>
        /// <param name="cardInfos">全てのカード情報</param>
        /// <param name="propertyInfo">表示するプロパティ</param>
        public static void SetAspectGetterByStringProperty(ObjectListView objectListView, string aspectName, List<CardInfo> cardInfos, PropertyInfo propertyInfo)
        {
            var NameColumn = objectListView.AllColumns.First(s => s.AspectName.Equals(aspectName));
            NameColumn.AspectGetter = delegate (object x)
            {
                CardCodeAndCount ccac = (CardCodeAndCount)x;
                CardInfo cardInfo = cardInfos.First(s => s.cardCode == ccac.CardCode);
                return (string) propertyInfo.GetValue(cardInfo);
            };
        }

        /// <summary>
        /// CardInfoのプロパティを参照して表示するカラムのAspectGetterを設定する
        /// </summary>
        /// <param name="objectListView">処理対象のコントロール</param>
        /// <param name="aspectName">処理対象のカラムのAspectName</param>
        /// <param name="cardInfos">全てのカード情報</param>
        /// <param name="propertyInfo">表示するプロパティ</param>
        public static void SetAspectGetterByIntProperty(ObjectListView objectListView, string aspectName, List<CardInfo> cardInfos, PropertyInfo propertyInfo)
        {
            var NameColumn = objectListView.AllColumns.First(s => s.AspectName.Equals(aspectName));
            NameColumn.AspectGetter = delegate (object x)
            {
                CardCodeAndCount ccac = (CardCodeAndCount)x;
                CardInfo cardInfo = cardInfos.First(s => s.cardCode == ccac.CardCode);
                return (int)propertyInfo.GetValue(cardInfo);
            };
        }
    }
}
