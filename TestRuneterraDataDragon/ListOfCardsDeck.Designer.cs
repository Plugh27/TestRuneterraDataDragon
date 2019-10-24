namespace TestRuneterraDataDragon
{
    partial class ListOfCardsDeck
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
            this.SoleObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.ImportFromClipboardButton = new System.Windows.Forms.Button();
            this.AddCardGroupBox = new System.Windows.Forms.GroupBox();
            this.AddCardDisableRadioButton = new System.Windows.Forms.RadioButton();
            this.AddCardEnableRadioButton = new System.Windows.Forms.RadioButton();
            this.ExportToClipboardButton = new System.Windows.Forms.Button();
            this.RemoveCardGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveCardDisableRadioButton = new System.Windows.Forms.RadioButton();
            this.RemoveCardEnableRadioButton = new System.Windows.Forms.RadioButton();
            this.DecksListBox = new System.Windows.Forms.ListBox();
            this.ChangeDeckNameButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.NewDeckButton = new System.Windows.Forms.Button();
            this.DeleteDeckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).BeginInit();
            this.AddCardGroupBox.SuspendLayout();
            this.RemoveCardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoleObjectListView
            // 
            this.SoleObjectListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoleObjectListView.CellEditUseWholeCell = false;
            this.SoleObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SoleObjectListView.Location = new System.Drawing.Point(12, 247);
            this.SoleObjectListView.Name = "SoleObjectListView";
            this.SoleObjectListView.Size = new System.Drawing.Size(776, 284);
            this.SoleObjectListView.TabIndex = 0;
            this.SoleObjectListView.UseCompatibleStateImageBehavior = false;
            this.SoleObjectListView.View = System.Windows.Forms.View.Details;
            this.SoleObjectListView.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.SoleObjectListView_HyperlinkClicked);
            // 
            // ImportFromClipboardButton
            // 
            this.ImportFromClipboardButton.Location = new System.Drawing.Point(12, 12);
            this.ImportFromClipboardButton.Name = "ImportFromClipboardButton";
            this.ImportFromClipboardButton.Size = new System.Drawing.Size(152, 23);
            this.ImportFromClipboardButton.TabIndex = 1;
            this.ImportFromClipboardButton.Text = "クリップボードからインポート";
            this.ImportFromClipboardButton.UseVisualStyleBackColor = true;
            this.ImportFromClipboardButton.Click += new System.EventHandler(this.ImportFromClipboardButton_Click);
            // 
            // AddCardGroupBox
            // 
            this.AddCardGroupBox.Controls.Add(this.AddCardDisableRadioButton);
            this.AddCardGroupBox.Controls.Add(this.AddCardEnableRadioButton);
            this.AddCardGroupBox.Location = new System.Drawing.Point(12, 41);
            this.AddCardGroupBox.Name = "AddCardGroupBox";
            this.AddCardGroupBox.Size = new System.Drawing.Size(269, 44);
            this.AddCardGroupBox.TabIndex = 2;
            this.AddCardGroupBox.TabStop = false;
            this.AddCardGroupBox.Text = "カード一覧でクリックされたカードを追加";
            // 
            // AddCardDisableRadioButton
            // 
            this.AddCardDisableRadioButton.AutoSize = true;
            this.AddCardDisableRadioButton.Location = new System.Drawing.Point(89, 18);
            this.AddCardDisableRadioButton.Name = "AddCardDisableRadioButton";
            this.AddCardDisableRadioButton.Size = new System.Drawing.Size(52, 16);
            this.AddCardDisableRadioButton.TabIndex = 3;
            this.AddCardDisableRadioButton.Text = "しない";
            this.AddCardDisableRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddCardEnableRadioButton
            // 
            this.AddCardEnableRadioButton.AutoSize = true;
            this.AddCardEnableRadioButton.Checked = true;
            this.AddCardEnableRadioButton.Location = new System.Drawing.Point(6, 18);
            this.AddCardEnableRadioButton.Name = "AddCardEnableRadioButton";
            this.AddCardEnableRadioButton.Size = new System.Drawing.Size(42, 16);
            this.AddCardEnableRadioButton.TabIndex = 0;
            this.AddCardEnableRadioButton.TabStop = true;
            this.AddCardEnableRadioButton.Text = "する";
            this.AddCardEnableRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExportToClipboardButton
            // 
            this.ExportToClipboardButton.Location = new System.Drawing.Point(170, 12);
            this.ExportToClipboardButton.Name = "ExportToClipboardButton";
            this.ExportToClipboardButton.Size = new System.Drawing.Size(152, 23);
            this.ExportToClipboardButton.TabIndex = 3;
            this.ExportToClipboardButton.Text = "クリップボードにエクスポート";
            this.ExportToClipboardButton.UseVisualStyleBackColor = true;
            this.ExportToClipboardButton.Click += new System.EventHandler(this.ExportToClipboardButton_Click);
            // 
            // RemoveCardGroupBox
            // 
            this.RemoveCardGroupBox.Controls.Add(this.RemoveCardDisableRadioButton);
            this.RemoveCardGroupBox.Controls.Add(this.RemoveCardEnableRadioButton);
            this.RemoveCardGroupBox.Location = new System.Drawing.Point(12, 91);
            this.RemoveCardGroupBox.Name = "RemoveCardGroupBox";
            this.RemoveCardGroupBox.Size = new System.Drawing.Size(269, 44);
            this.RemoveCardGroupBox.TabIndex = 4;
            this.RemoveCardGroupBox.TabStop = false;
            this.RemoveCardGroupBox.Text = "デッキカード一覧でクリックされたカードを除外";
            // 
            // RemoveCardDisableRadioButton
            // 
            this.RemoveCardDisableRadioButton.AutoSize = true;
            this.RemoveCardDisableRadioButton.Location = new System.Drawing.Point(89, 18);
            this.RemoveCardDisableRadioButton.Name = "RemoveCardDisableRadioButton";
            this.RemoveCardDisableRadioButton.Size = new System.Drawing.Size(52, 16);
            this.RemoveCardDisableRadioButton.TabIndex = 3;
            this.RemoveCardDisableRadioButton.Text = "しない";
            this.RemoveCardDisableRadioButton.UseVisualStyleBackColor = true;
            // 
            // RemoveCardEnableRadioButton
            // 
            this.RemoveCardEnableRadioButton.AutoSize = true;
            this.RemoveCardEnableRadioButton.Checked = true;
            this.RemoveCardEnableRadioButton.Location = new System.Drawing.Point(6, 18);
            this.RemoveCardEnableRadioButton.Name = "RemoveCardEnableRadioButton";
            this.RemoveCardEnableRadioButton.Size = new System.Drawing.Size(42, 16);
            this.RemoveCardEnableRadioButton.TabIndex = 0;
            this.RemoveCardEnableRadioButton.TabStop = true;
            this.RemoveCardEnableRadioButton.Text = "する";
            this.RemoveCardEnableRadioButton.UseVisualStyleBackColor = true;
            // 
            // DecksListBox
            // 
            this.DecksListBox.FormattingEnabled = true;
            this.DecksListBox.ItemHeight = 12;
            this.DecksListBox.Location = new System.Drawing.Point(519, 12);
            this.DecksListBox.Name = "DecksListBox";
            this.DecksListBox.Size = new System.Drawing.Size(269, 88);
            this.DecksListBox.TabIndex = 5;
            this.DecksListBox.SelectedIndexChanged += new System.EventHandler(this.DecksListBox_SelectedIndexChanged);
            // 
            // ChangeDeckNameButton
            // 
            this.ChangeDeckNameButton.Location = new System.Drawing.Point(519, 109);
            this.ChangeDeckNameButton.Name = "ChangeDeckNameButton";
            this.ChangeDeckNameButton.Size = new System.Drawing.Size(269, 23);
            this.ChangeDeckNameButton.TabIndex = 6;
            this.ChangeDeckNameButton.Text = "デッキの名前を変更";
            this.ChangeDeckNameButton.UseVisualStyleBackColor = true;
            this.ChangeDeckNameButton.Click += new System.EventHandler(this.ChangeDeckNameButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(655, 138);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(133, 23);
            this.SaveAsButton.TabIndex = 8;
            this.SaveAsButton.Text = "別名で保存";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // NewDeckButton
            // 
            this.NewDeckButton.Location = new System.Drawing.Point(519, 167);
            this.NewDeckButton.Name = "NewDeckButton";
            this.NewDeckButton.Size = new System.Drawing.Size(269, 23);
            this.NewDeckButton.TabIndex = 9;
            this.NewDeckButton.Text = "新規";
            this.NewDeckButton.UseVisualStyleBackColor = true;
            this.NewDeckButton.Click += new System.EventHandler(this.NewDeckButton_Click);
            // 
            // DeleteDeckButton
            // 
            this.DeleteDeckButton.Location = new System.Drawing.Point(519, 196);
            this.DeleteDeckButton.Name = "DeleteDeckButton";
            this.DeleteDeckButton.Size = new System.Drawing.Size(269, 23);
            this.DeleteDeckButton.TabIndex = 10;
            this.DeleteDeckButton.Text = "削除";
            this.DeleteDeckButton.UseVisualStyleBackColor = true;
            this.DeleteDeckButton.Click += new System.EventHandler(this.DeleteDeckButton_Click);
            // 
            // ListOfCardsDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.DeleteDeckButton);
            this.Controls.Add(this.NewDeckButton);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.ChangeDeckNameButton);
            this.Controls.Add(this.DecksListBox);
            this.Controls.Add(this.RemoveCardGroupBox);
            this.Controls.Add(this.ExportToClipboardButton);
            this.Controls.Add(this.AddCardGroupBox);
            this.Controls.Add(this.ImportFromClipboardButton);
            this.Controls.Add(this.SoleObjectListView);
            this.Name = "ListOfCardsDeck";
            this.Text = "ListOfCardsDeck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListOfCardsDeck_FormClosed);
            this.Load += new System.EventHandler(this.ListOfCardsDeck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).EndInit();
            this.AddCardGroupBox.ResumeLayout(false);
            this.AddCardGroupBox.PerformLayout();
            this.RemoveCardGroupBox.ResumeLayout(false);
            this.RemoveCardGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView SoleObjectListView;
        private System.Windows.Forms.Button ImportFromClipboardButton;
        private System.Windows.Forms.GroupBox AddCardGroupBox;
        private System.Windows.Forms.RadioButton AddCardDisableRadioButton;
        private System.Windows.Forms.RadioButton AddCardEnableRadioButton;
        private System.Windows.Forms.Button ExportToClipboardButton;
        private System.Windows.Forms.GroupBox RemoveCardGroupBox;
        private System.Windows.Forms.RadioButton RemoveCardDisableRadioButton;
        private System.Windows.Forms.RadioButton RemoveCardEnableRadioButton;
        private System.Windows.Forms.ListBox DecksListBox;
        private System.Windows.Forms.Button ChangeDeckNameButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button NewDeckButton;
        private System.Windows.Forms.Button DeleteDeckButton;
    }
}