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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SpellCountLabel = new System.Windows.Forms.Label();
            this.UnitCountLabel = new System.Windows.Forms.Label();
            this.CardsDeckCountLabel = new System.Windows.Forms.Label();
            this.ChampionCountLabel = new System.Windows.Forms.Label();
            this.RegionListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).BeginInit();
            this.AddCardGroupBox.SuspendLayout();
            this.RemoveCardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoleObjectListView
            // 
            this.SoleObjectListView.CellEditUseWholeCell = false;
            this.SoleObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SoleObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoleObjectListView.Location = new System.Drawing.Point(0, 0);
            this.SoleObjectListView.Name = "SoleObjectListView";
            this.SoleObjectListView.Size = new System.Drawing.Size(601, 305);
            this.SoleObjectListView.TabIndex = 0;
            this.SoleObjectListView.UseCompatibleStateImageBehavior = false;
            this.SoleObjectListView.View = System.Windows.Forms.View.Details;
            this.SoleObjectListView.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.SoleObjectListView_HyperlinkClicked);
            // 
            // ImportFromClipboardButton
            // 
            this.ImportFromClipboardButton.Location = new System.Drawing.Point(650, 12);
            this.ImportFromClipboardButton.Name = "ImportFromClipboardButton";
            this.ImportFromClipboardButton.Size = new System.Drawing.Size(245, 23);
            this.ImportFromClipboardButton.TabIndex = 1;
            this.ImportFromClipboardButton.Text = "クリップボードからインポート";
            this.ImportFromClipboardButton.UseVisualStyleBackColor = true;
            this.ImportFromClipboardButton.Click += new System.EventHandler(this.ImportFromClipboardButton_Click);
            // 
            // AddCardGroupBox
            // 
            this.AddCardGroupBox.Controls.Add(this.AddCardDisableRadioButton);
            this.AddCardGroupBox.Controls.Add(this.AddCardEnableRadioButton);
            this.AddCardGroupBox.Location = new System.Drawing.Point(226, 12);
            this.AddCardGroupBox.Name = "AddCardGroupBox";
            this.AddCardGroupBox.Size = new System.Drawing.Size(362, 44);
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
            this.ExportToClipboardButton.Location = new System.Drawing.Point(650, 41);
            this.ExportToClipboardButton.Name = "ExportToClipboardButton";
            this.ExportToClipboardButton.Size = new System.Drawing.Size(245, 23);
            this.ExportToClipboardButton.TabIndex = 3;
            this.ExportToClipboardButton.Text = "クリップボードにエクスポート";
            this.ExportToClipboardButton.UseVisualStyleBackColor = true;
            this.ExportToClipboardButton.Click += new System.EventHandler(this.ExportToClipboardButton_Click);
            // 
            // RemoveCardGroupBox
            // 
            this.RemoveCardGroupBox.Controls.Add(this.RemoveCardDisableRadioButton);
            this.RemoveCardGroupBox.Controls.Add(this.RemoveCardEnableRadioButton);
            this.RemoveCardGroupBox.Location = new System.Drawing.Point(226, 62);
            this.RemoveCardGroupBox.Name = "RemoveCardGroupBox";
            this.RemoveCardGroupBox.Size = new System.Drawing.Size(362, 44);
            this.RemoveCardGroupBox.TabIndex = 4;
            this.RemoveCardGroupBox.TabStop = false;
            this.RemoveCardGroupBox.Text = "デッキカード一覧でクリックされたカードを除外";
            // 
            // RemoveCardDisableRadioButton
            // 
            this.RemoveCardDisableRadioButton.AutoSize = true;
            this.RemoveCardDisableRadioButton.Checked = true;
            this.RemoveCardDisableRadioButton.Location = new System.Drawing.Point(89, 18);
            this.RemoveCardDisableRadioButton.Name = "RemoveCardDisableRadioButton";
            this.RemoveCardDisableRadioButton.Size = new System.Drawing.Size(52, 16);
            this.RemoveCardDisableRadioButton.TabIndex = 3;
            this.RemoveCardDisableRadioButton.TabStop = true;
            this.RemoveCardDisableRadioButton.Text = "しない";
            this.RemoveCardDisableRadioButton.UseVisualStyleBackColor = true;
            // 
            // RemoveCardEnableRadioButton
            // 
            this.RemoveCardEnableRadioButton.AutoSize = true;
            this.RemoveCardEnableRadioButton.Location = new System.Drawing.Point(6, 18);
            this.RemoveCardEnableRadioButton.Name = "RemoveCardEnableRadioButton";
            this.RemoveCardEnableRadioButton.Size = new System.Drawing.Size(42, 16);
            this.RemoveCardEnableRadioButton.TabIndex = 0;
            this.RemoveCardEnableRadioButton.Text = "する";
            this.RemoveCardEnableRadioButton.UseVisualStyleBackColor = true;
            // 
            // DecksListBox
            // 
            this.DecksListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DecksListBox.FormattingEnabled = true;
            this.DecksListBox.ItemHeight = 12;
            this.DecksListBox.Location = new System.Drawing.Point(0, 0);
            this.DecksListBox.Name = "DecksListBox";
            this.DecksListBox.Size = new System.Drawing.Size(220, 232);
            this.DecksListBox.TabIndex = 5;
            this.DecksListBox.SelectedIndexChanged += new System.EventHandler(this.DecksListBox_SelectedIndexChanged);
            // 
            // ChangeDeckNameButton
            // 
            this.ChangeDeckNameButton.Location = new System.Drawing.Point(226, 206);
            this.ChangeDeckNameButton.Name = "ChangeDeckNameButton";
            this.ChangeDeckNameButton.Size = new System.Drawing.Size(204, 23);
            this.ChangeDeckNameButton.TabIndex = 6;
            this.ChangeDeckNameButton.Text = "デッキの名前を変更";
            this.ChangeDeckNameButton.UseVisualStyleBackColor = true;
            this.ChangeDeckNameButton.Click += new System.EventHandler(this.ChangeDeckNameButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(226, 177);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(204, 23);
            this.SaveAsButton.TabIndex = 8;
            this.SaveAsButton.Text = "別名で保存";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // NewDeckButton
            // 
            this.NewDeckButton.Location = new System.Drawing.Point(650, 70);
            this.NewDeckButton.Name = "NewDeckButton";
            this.NewDeckButton.Size = new System.Drawing.Size(245, 23);
            this.NewDeckButton.TabIndex = 9;
            this.NewDeckButton.Text = "新規";
            this.NewDeckButton.UseVisualStyleBackColor = true;
            this.NewDeckButton.Click += new System.EventHandler(this.NewDeckButton_Click);
            // 
            // DeleteDeckButton
            // 
            this.DeleteDeckButton.Location = new System.Drawing.Point(704, 206);
            this.DeleteDeckButton.Name = "DeleteDeckButton";
            this.DeleteDeckButton.Size = new System.Drawing.Size(191, 23);
            this.DeleteDeckButton.TabIndex = 10;
            this.DeleteDeckButton.Text = "削除";
            this.DeleteDeckButton.UseVisualStyleBackColor = true;
            this.DeleteDeckButton.Click += new System.EventHandler(this.DeleteDeckButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DecksListBox);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveCardGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.SaveAsButton);
            this.splitContainer1.Panel1.Controls.Add(this.ExportToClipboardButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteDeckButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddCardGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.ChangeDeckNameButton);
            this.splitContainer1.Panel1.Controls.Add(this.ImportFromClipboardButton);
            this.splitContainer1.Panel1.Controls.Add(this.NewDeckButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(907, 541);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RegionListLabel);
            this.splitContainer2.Panel1.Controls.Add(this.SpellCountLabel);
            this.splitContainer2.Panel1.Controls.Add(this.UnitCountLabel);
            this.splitContainer2.Panel1.Controls.Add(this.CardsDeckCountLabel);
            this.splitContainer2.Panel1.Controls.Add(this.ChampionCountLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SoleObjectListView);
            this.splitContainer2.Size = new System.Drawing.Size(907, 305);
            this.splitContainer2.SplitterDistance = 302;
            this.splitContainer2.TabIndex = 0;
            // 
            // SpellCountLabel
            // 
            this.SpellCountLabel.AutoSize = true;
            this.SpellCountLabel.Location = new System.Drawing.Point(12, 61);
            this.SpellCountLabel.Name = "SpellCountLabel";
            this.SpellCountLabel.Size = new System.Drawing.Size(34, 12);
            this.SpellCountLabel.TabIndex = 3;
            this.SpellCountLabel.Text = "スペル";
            // 
            // UnitCountLabel
            // 
            this.UnitCountLabel.AutoSize = true;
            this.UnitCountLabel.Location = new System.Drawing.Point(12, 36);
            this.UnitCountLabel.Name = "UnitCountLabel";
            this.UnitCountLabel.Size = new System.Drawing.Size(39, 12);
            this.UnitCountLabel.TabIndex = 2;
            this.UnitCountLabel.Text = "ユニット";
            // 
            // CardsDeckCountLabel
            // 
            this.CardsDeckCountLabel.AutoSize = true;
            this.CardsDeckCountLabel.Location = new System.Drawing.Point(13, 131);
            this.CardsDeckCountLabel.Name = "CardsDeckCountLabel";
            this.CardsDeckCountLabel.Size = new System.Drawing.Size(57, 12);
            this.CardsDeckCountLabel.TabIndex = 1;
            this.CardsDeckCountLabel.Text = "カード枚数";
            // 
            // ChampionCountLabel
            // 
            this.ChampionCountLabel.AutoSize = true;
            this.ChampionCountLabel.Location = new System.Drawing.Point(12, 12);
            this.ChampionCountLabel.Name = "ChampionCountLabel";
            this.ChampionCountLabel.Size = new System.Drawing.Size(58, 12);
            this.ChampionCountLabel.TabIndex = 0;
            this.ChampionCountLabel.Text = "チャンピオン";
            // 
            // RegionListLabel
            // 
            this.RegionListLabel.AutoSize = true;
            this.RegionListLabel.Location = new System.Drawing.Point(13, 86);
            this.RegionListLabel.Name = "RegionListLabel";
            this.RegionListLabel.Size = new System.Drawing.Size(29, 12);
            this.RegionListLabel.TabIndex = 4;
            this.RegionListLabel.Text = "地域";
            // 
            // ListOfCardsDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 541);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListOfCardsDeck";
            this.Text = "ListOfCardsDeck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListOfCardsDeck_FormClosed);
            this.Load += new System.EventHandler(this.ListOfCardsDeck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).EndInit();
            this.AddCardGroupBox.ResumeLayout(false);
            this.AddCardGroupBox.PerformLayout();
            this.RemoveCardGroupBox.ResumeLayout(false);
            this.RemoveCardGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label ChampionCountLabel;
        private System.Windows.Forms.Label CardsDeckCountLabel;
        private System.Windows.Forms.Label UnitCountLabel;
        private System.Windows.Forms.Label SpellCountLabel;
        private System.Windows.Forms.Label RegionListLabel;
    }
}