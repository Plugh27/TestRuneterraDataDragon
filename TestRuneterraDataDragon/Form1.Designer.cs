namespace TestRuneterraDataDragon
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SoleMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfKeywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Set1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoleMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoleMenuStrip
            // 
            this.SoleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.ViewVToolStripMenuItem});
            this.SoleMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SoleMenuStrip.Name = "SoleMenuStrip";
            this.SoleMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.SoleMenuStrip.TabIndex = 0;
            this.SoleMenuStrip.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingToolStripMenuItem.Text = "設定(&S)";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // ViewVToolStripMenuItem
            // 
            this.ViewVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GlobalToolStripMenuItem,
            this.Set1ToolStripMenuItem,
            this.GameImageToolStripMenuItem});
            this.ViewVToolStripMenuItem.Name = "ViewVToolStripMenuItem";
            this.ViewVToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ViewVToolStripMenuItem.Text = "表示(&V)";
            // 
            // GlobalToolStripMenuItem
            // 
            this.GlobalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfKeywordsToolStripMenuItem});
            this.GlobalToolStripMenuItem.Name = "GlobalToolStripMenuItem";
            this.GlobalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GlobalToolStripMenuItem.Text = "グローバル";
            // 
            // ListOfKeywordsToolStripMenuItem
            // 
            this.ListOfKeywordsToolStripMenuItem.Name = "ListOfKeywordsToolStripMenuItem";
            this.ListOfKeywordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ListOfKeywordsToolStripMenuItem.Text = "キーワード";
            this.ListOfKeywordsToolStripMenuItem.Click += new System.EventHandler(this.ListOfKeywordsToolStripMenuItem_Click);
            // 
            // Set1ToolStripMenuItem
            // 
            this.Set1ToolStripMenuItem.Name = "Set1ToolStripMenuItem";
            this.Set1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Set1ToolStripMenuItem.Text = "セット1";
            this.Set1ToolStripMenuItem.Click += new System.EventHandler(this.Set1ToolStripMenuItem_Click);
            // 
            // GameImageToolStripMenuItem
            // 
            this.GameImageToolStripMenuItem.Name = "GameImageToolStripMenuItem";
            this.GameImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GameImageToolStripMenuItem.Text = "ゲーム画像";
            this.GameImageToolStripMenuItem.Click += new System.EventHandler(this.GameImageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 589);
            this.Controls.Add(this.SoleMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.SoleMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SoleMenuStrip.ResumeLayout(false);
            this.SoleMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SoleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GlobalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfKeywordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Set1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GameImageToolStripMenuItem;
    }
}

