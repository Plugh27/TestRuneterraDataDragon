namespace TestRuneterraDataDragon
{
    partial class ListOfCards
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
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // SoleObjectListView
            // 
            this.SoleObjectListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoleObjectListView.CellEditUseWholeCell = false;
            this.SoleObjectListView.Location = new System.Drawing.Point(12, 207);
            this.SoleObjectListView.Name = "SoleObjectListView";
            this.SoleObjectListView.Size = new System.Drawing.Size(776, 231);
            this.SoleObjectListView.TabIndex = 0;
            this.SoleObjectListView.UseCompatibleStateImageBehavior = false;
            this.SoleObjectListView.View = System.Windows.Forms.View.Details;
            this.SoleObjectListView.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.SoleObjectListView_HyperlinkClicked);
            // 
            // ListOfCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SoleObjectListView);
            this.Name = "ListOfCards";
            this.Text = "ListOfCards";
            this.Load += new System.EventHandler(this.ListOfCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView SoleObjectListView;
    }
}