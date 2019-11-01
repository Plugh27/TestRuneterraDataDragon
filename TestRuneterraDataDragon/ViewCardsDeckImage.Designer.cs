namespace TestRuneterraDataDragon
{
    partial class ViewCardsDeckImage
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
            this.components = new System.ComponentModel.Container();
            this.SolePictureBox = new System.Windows.Forms.PictureBox();
            this.SoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SolePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SolePictureBox)).BeginInit();
            this.SoleContextMenuStrip.SuspendLayout();
            this.SolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolePictureBox
            // 
            this.SolePictureBox.Location = new System.Drawing.Point(0, 0);
            this.SolePictureBox.Name = "SolePictureBox";
            this.SolePictureBox.Size = new System.Drawing.Size(841, 321);
            this.SolePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SolePictureBox.TabIndex = 0;
            this.SolePictureBox.TabStop = false;
            // 
            // SoleContextMenuStrip
            // 
            this.SoleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToClipboardToolStripMenuItem});
            this.SoleContextMenuStrip.Name = "SoleContextMenuStrip";
            this.SoleContextMenuStrip.Size = new System.Drawing.Size(169, 26);
            // 
            // CopyToClipboardToolStripMenuItem
            // 
            this.CopyToClipboardToolStripMenuItem.Name = "CopyToClipboardToolStripMenuItem";
            this.CopyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CopyToClipboardToolStripMenuItem.Text = "クリップボードにコピー";
            this.CopyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyToClipboardToolStripMenuItem_Click);
            // 
            // SolePanel
            // 
            this.SolePanel.AutoScroll = true;
            this.SolePanel.Controls.Add(this.SolePictureBox);
            this.SolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolePanel.Location = new System.Drawing.Point(0, 0);
            this.SolePanel.Name = "SolePanel";
            this.SolePanel.Size = new System.Drawing.Size(841, 324);
            this.SolePanel.TabIndex = 1;
            // 
            // ViewCardsDeckImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 324);
            this.ContextMenuStrip = this.SoleContextMenuStrip;
            this.Controls.Add(this.SolePanel);
            this.Name = "ViewCardsDeckImage";
            this.Text = "ViewCardsDeckImage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCardsDeckImage_FormClosed);
            this.Load += new System.EventHandler(this.ViewCardsDeckImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SolePictureBox)).EndInit();
            this.SoleContextMenuStrip.ResumeLayout(false);
            this.SolePanel.ResumeLayout(false);
            this.SolePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SolePictureBox;
        private System.Windows.Forms.ContextMenuStrip SoleContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToClipboardToolStripMenuItem;
        private System.Windows.Forms.Panel SolePanel;
    }
}