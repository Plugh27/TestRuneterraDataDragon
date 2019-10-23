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
            ((System.ComponentModel.ISupportInitialize)(this.SolePictureBox)).BeginInit();
            this.SoleContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolePictureBox
            // 
            this.SolePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolePictureBox.Location = new System.Drawing.Point(0, 0);
            this.SolePictureBox.Name = "SolePictureBox";
            this.SolePictureBox.Size = new System.Drawing.Size(984, 461);
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
            this.CopyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyToClipboardToolStripMenuItem.Text = "クリップボードにコピー";
            this.CopyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyToClipboardToolStripMenuItem_Click);
            // 
            // ViewCardsDeckImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.ContextMenuStrip = this.SoleContextMenuStrip;
            this.Controls.Add(this.SolePictureBox);
            this.Name = "ViewCardsDeckImage";
            this.Text = "ViewCardsDeckImage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCardsDeckImage_FormClosed);
            this.Load += new System.EventHandler(this.ViewCardsDeckImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SolePictureBox)).EndInit();
            this.SoleContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SolePictureBox;
        private System.Windows.Forms.ContextMenuStrip SoleContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToClipboardToolStripMenuItem;
    }
}