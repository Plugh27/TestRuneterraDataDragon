using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
