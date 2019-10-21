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
            this.RegionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RarityFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ManaCostFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SpellSpeedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TypeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuperTypeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SubTypeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // SoleObjectListView
            // 
            this.SoleObjectListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoleObjectListView.CellEditUseWholeCell = false;
            this.SoleObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SoleObjectListView.Location = new System.Drawing.Point(12, 320);
            this.SoleObjectListView.Name = "SoleObjectListView";
            this.SoleObjectListView.Size = new System.Drawing.Size(993, 207);
            this.SoleObjectListView.TabIndex = 0;
            this.SoleObjectListView.UseCompatibleStateImageBehavior = false;
            this.SoleObjectListView.View = System.Windows.Forms.View.Details;
            this.SoleObjectListView.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.SoleObjectListView_HyperlinkClicked);
            // 
            // RegionFlowLayoutPanel
            // 
            this.RegionFlowLayoutPanel.AutoSize = true;
            this.RegionFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegionFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.RegionFlowLayoutPanel.Name = "RegionFlowLayoutPanel";
            this.RegionFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.RegionFlowLayoutPanel.TabIndex = 1;
            // 
            // RarityFlowLayoutPanel
            // 
            this.RarityFlowLayoutPanel.AutoSize = true;
            this.RarityFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RarityFlowLayoutPanel.Location = new System.Drawing.Point(12, 52);
            this.RarityFlowLayoutPanel.Name = "RarityFlowLayoutPanel";
            this.RarityFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.RarityFlowLayoutPanel.TabIndex = 2;
            // 
            // ManaCostFlowLayoutPanel
            // 
            this.ManaCostFlowLayoutPanel.AutoSize = true;
            this.ManaCostFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ManaCostFlowLayoutPanel.Location = new System.Drawing.Point(12, 92);
            this.ManaCostFlowLayoutPanel.Name = "ManaCostFlowLayoutPanel";
            this.ManaCostFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.ManaCostFlowLayoutPanel.TabIndex = 3;
            // 
            // SpellSpeedFlowLayoutPanel
            // 
            this.SpellSpeedFlowLayoutPanel.AutoSize = true;
            this.SpellSpeedFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpellSpeedFlowLayoutPanel.Location = new System.Drawing.Point(12, 132);
            this.SpellSpeedFlowLayoutPanel.Name = "SpellSpeedFlowLayoutPanel";
            this.SpellSpeedFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.SpellSpeedFlowLayoutPanel.TabIndex = 4;
            // 
            // TypeFlowLayoutPanel
            // 
            this.TypeFlowLayoutPanel.AutoSize = true;
            this.TypeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TypeFlowLayoutPanel.Location = new System.Drawing.Point(12, 172);
            this.TypeFlowLayoutPanel.Name = "TypeFlowLayoutPanel";
            this.TypeFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.TypeFlowLayoutPanel.TabIndex = 5;
            // 
            // SuperTypeFlowLayoutPanel
            // 
            this.SuperTypeFlowLayoutPanel.AutoSize = true;
            this.SuperTypeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SuperTypeFlowLayoutPanel.Location = new System.Drawing.Point(12, 212);
            this.SuperTypeFlowLayoutPanel.Name = "SuperTypeFlowLayoutPanel";
            this.SuperTypeFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.SuperTypeFlowLayoutPanel.TabIndex = 6;
            // 
            // SubTypeFlowLayoutPanel
            // 
            this.SubTypeFlowLayoutPanel.AutoSize = true;
            this.SubTypeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubTypeFlowLayoutPanel.Location = new System.Drawing.Point(12, 252);
            this.SubTypeFlowLayoutPanel.Name = "SubTypeFlowLayoutPanel";
            this.SubTypeFlowLayoutPanel.Size = new System.Drawing.Size(304, 34);
            this.SubTypeFlowLayoutPanel.TabIndex = 7;
            // 
            // ListOfCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 539);
            this.Controls.Add(this.SubTypeFlowLayoutPanel);
            this.Controls.Add(this.SuperTypeFlowLayoutPanel);
            this.Controls.Add(this.TypeFlowLayoutPanel);
            this.Controls.Add(this.SpellSpeedFlowLayoutPanel);
            this.Controls.Add(this.ManaCostFlowLayoutPanel);
            this.Controls.Add(this.RarityFlowLayoutPanel);
            this.Controls.Add(this.RegionFlowLayoutPanel);
            this.Controls.Add(this.SoleObjectListView);
            this.Name = "ListOfCards";
            this.Text = "ListOfCards";
            this.Load += new System.EventHandler(this.ListOfCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoleObjectListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView SoleObjectListView;
        private System.Windows.Forms.FlowLayoutPanel RegionFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel RarityFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ManaCostFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SpellSpeedFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel TypeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SuperTypeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SubTypeFlowLayoutPanel;
    }
}