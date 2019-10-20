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
using Newtonsoft.Json;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    public partial class ListOfKeywords : Form
    {
        public ListOfKeywords()
        {
            InitializeComponent();
        }

        private void ListOfKeywords_Load(object sender, EventArgs e)
        {
            Util.GetGlobalData(out var globalDictionary); 

            // ja-jpのデータだけ表示する
            var jaGlobal = globalDictionary["ja_jp"]; // TODO: 言語切り替えられるようにする

            // リストボックスに表示する
            SoleListBox.DisplayMember = "name";
            SoleListBox.ValueMember = "nameRef";
            SoleListBox.DataSource = jaGlobal.keywords;
        }
    }
}
