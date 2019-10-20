using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRuneterraDataDragon
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();

            // 設定をフォームに反映する
            CoreDataFilePathTextBox.Text = Properties.Settings.Default.CoreDataFilePath;
            SetDataFilePathTextBox.Text = Properties.Settings.Default.SetDataFilePath;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // フォームの内容で設定を保存する
            Properties.Settings.Default.CoreDataFilePath = CoreDataFilePathTextBox.Text;
            Properties.Settings.Default.SetDataFilePath = SetDataFilePathTextBox.Text;
            Properties.Settings.Default.Save();

            Close();
        }

        private void CancelDecisionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectCoreDataFileButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                CoreDataFilePathTextBox.Text = f.FileName;
            }
        }

        private void SelectSetDataFileButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                SetDataFilePathTextBox.Text = f.FileName;
            }
        }
    }
}
