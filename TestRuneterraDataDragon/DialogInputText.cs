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
    public partial class DialogInputText : Form
    {
        public string _InputtedText = "";

        public DialogInputText()
        {
            InitializeComponent();
        }

        private void OkDecisionButton_Click(object sender, EventArgs e)
        {
            _InputtedText = SoleTextBox.Text;
            Close();
        }

        private void CancelDecisionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
