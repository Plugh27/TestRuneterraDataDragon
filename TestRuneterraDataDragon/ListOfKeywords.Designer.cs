namespace TestRuneterraDataDragon
{
    partial class ListOfKeywords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SoleListBox
            // 
            this.SoleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoleListBox.FormattingEnabled = true;
            this.SoleListBox.ItemHeight = 12;
            this.SoleListBox.Location = new System.Drawing.Point(0, 0);
            this.SoleListBox.Name = "SoleListBox";
            this.SoleListBox.Size = new System.Drawing.Size(547, 511);
            this.SoleListBox.TabIndex = 0;
            // 
            // ListOfKeywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 511);
            this.Controls.Add(this.SoleListBox);
            this.Name = "ListOfKeywords";
            this.Text = "ListOfKeywords";
            this.Load += new System.EventHandler(this.ListOfKeywords_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SoleListBox;
    }
}