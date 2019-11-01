namespace TestRuneterraDataDragon
{
    partial class ViewUserInputData
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
            this.CardCodeLabel = new System.Windows.Forms.Label();
            this.CardCodeTextBox = new System.Windows.Forms.TextBox();
            this.DraftPointLabel = new System.Windows.Forms.Label();
            this.DraftPointNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.ImageUrlLabel = new System.Windows.Forms.Label();
            this.ImageUrlTextBox = new System.Windows.Forms.TextBox();
            this.OpenMobalyticsPageButton = new System.Windows.Forms.Button();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.MakeTextLinkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DraftPointNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CardCodeLabel
            // 
            this.CardCodeLabel.AutoSize = true;
            this.CardCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.CardCodeLabel.Name = "CardCodeLabel";
            this.CardCodeLabel.Size = new System.Drawing.Size(60, 12);
            this.CardCodeLabel.TabIndex = 0;
            this.CardCodeLabel.Text = "カードコード";
            // 
            // CardCodeTextBox
            // 
            this.CardCodeTextBox.Location = new System.Drawing.Point(116, 6);
            this.CardCodeTextBox.Name = "CardCodeTextBox";
            this.CardCodeTextBox.ReadOnly = true;
            this.CardCodeTextBox.Size = new System.Drawing.Size(100, 19);
            this.CardCodeTextBox.TabIndex = 1;
            // 
            // DraftPointLabel
            // 
            this.DraftPointLabel.AutoSize = true;
            this.DraftPointLabel.Location = new System.Drawing.Point(12, 85);
            this.DraftPointLabel.Name = "DraftPointLabel";
            this.DraftPointLabel.Size = new System.Drawing.Size(62, 12);
            this.DraftPointLabel.TabIndex = 2;
            this.DraftPointLabel.Text = "ドラフト点数";
            // 
            // DraftPointNumericUpDown
            // 
            this.DraftPointNumericUpDown.Location = new System.Drawing.Point(116, 83);
            this.DraftPointNumericUpDown.Name = "DraftPointNumericUpDown";
            this.DraftPointNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.DraftPointNumericUpDown.TabIndex = 3;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(12, 151);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(38, 12);
            this.CommentLabel.TabIndex = 4;
            this.CommentLabel.Text = "コメント";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(116, 151);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(255, 64);
            this.CommentTextBox.TabIndex = 5;
            // 
            // ImageUrlLabel
            // 
            this.ImageUrlLabel.AutoSize = true;
            this.ImageUrlLabel.Location = new System.Drawing.Point(12, 115);
            this.ImageUrlLabel.Name = "ImageUrlLabel";
            this.ImageUrlLabel.Size = new System.Drawing.Size(51, 12);
            this.ImageUrlLabel.TabIndex = 6;
            this.ImageUrlLabel.Text = "画像URL";
            // 
            // ImageUrlTextBox
            // 
            this.ImageUrlTextBox.Location = new System.Drawing.Point(116, 112);
            this.ImageUrlTextBox.Name = "ImageUrlTextBox";
            this.ImageUrlTextBox.Size = new System.Drawing.Size(716, 19);
            this.ImageUrlTextBox.TabIndex = 7;
            // 
            // OpenMobalyticsPageButton
            // 
            this.OpenMobalyticsPageButton.Location = new System.Drawing.Point(404, 12);
            this.OpenMobalyticsPageButton.Name = "OpenMobalyticsPageButton";
            this.OpenMobalyticsPageButton.Size = new System.Drawing.Size(180, 23);
            this.OpenMobalyticsPageButton.TabIndex = 8;
            this.OpenMobalyticsPageButton.Text = "MOBALYTICSのページに飛ぶ";
            this.OpenMobalyticsPageButton.UseVisualStyleBackColor = true;
            this.OpenMobalyticsPageButton.Click += new System.EventHandler(this.OpenMobalyticsPageButton_Click);
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.Location = new System.Drawing.Point(12, 36);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(45, 12);
            this.CardNameLabel.TabIndex = 9;
            this.CardNameLabel.Text = "カード名";
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Location = new System.Drawing.Point(116, 33);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.ReadOnly = true;
            this.CardNameTextBox.Size = new System.Drawing.Size(255, 19);
            this.CardNameTextBox.TabIndex = 10;
            // 
            // MakeTextLinkButton
            // 
            this.MakeTextLinkButton.Location = new System.Drawing.Point(480, 179);
            this.MakeTextLinkButton.Name = "MakeTextLinkButton";
            this.MakeTextLinkButton.Size = new System.Drawing.Size(319, 26);
            this.MakeTextLinkButton.TabIndex = 11;
            this.MakeTextLinkButton.Text = "画像にリンクするハイパーリンクテキストをクリップボードにコピー";
            this.MakeTextLinkButton.UseVisualStyleBackColor = true;
            this.MakeTextLinkButton.Click += new System.EventHandler(this.MakeTextLinkButton_Click);
            // 
            // ViewUserInputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 249);
            this.Controls.Add(this.MakeTextLinkButton);
            this.Controls.Add(this.CardNameTextBox);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.OpenMobalyticsPageButton);
            this.Controls.Add(this.ImageUrlTextBox);
            this.Controls.Add(this.ImageUrlLabel);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.DraftPointNumericUpDown);
            this.Controls.Add(this.DraftPointLabel);
            this.Controls.Add(this.CardCodeTextBox);
            this.Controls.Add(this.CardCodeLabel);
            this.Name = "ViewUserInputData";
            this.Text = "ViewUserInputData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewUserInputData_FormClosed);
            this.Load += new System.EventHandler(this.ViewUserInputData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DraftPointNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardCodeLabel;
        private System.Windows.Forms.TextBox CardCodeTextBox;
        private System.Windows.Forms.Label DraftPointLabel;
        private System.Windows.Forms.NumericUpDown DraftPointNumericUpDown;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label ImageUrlLabel;
        private System.Windows.Forms.TextBox ImageUrlTextBox;
        private System.Windows.Forms.Button OpenMobalyticsPageButton;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.TextBox CardNameTextBox;
        private System.Windows.Forms.Button MakeTextLinkButton;
    }
}