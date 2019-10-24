namespace TestRuneterraDataDragon
{
    partial class DialogInputText
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
            this.OkDecisionButton = new System.Windows.Forms.Button();
            this.CancelDecisionButton = new System.Windows.Forms.Button();
            this.SoleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkDecisionButton
            // 
            this.OkDecisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkDecisionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkDecisionButton.Location = new System.Drawing.Point(208, 42);
            this.OkDecisionButton.Name = "OkDecisionButton";
            this.OkDecisionButton.Size = new System.Drawing.Size(75, 23);
            this.OkDecisionButton.TabIndex = 0;
            this.OkDecisionButton.Text = "OK";
            this.OkDecisionButton.UseVisualStyleBackColor = true;
            this.OkDecisionButton.Click += new System.EventHandler(this.OkDecisionButton_Click);
            // 
            // CancelDecisionButton
            // 
            this.CancelDecisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDecisionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDecisionButton.Location = new System.Drawing.Point(289, 42);
            this.CancelDecisionButton.Name = "CancelDecisionButton";
            this.CancelDecisionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDecisionButton.TabIndex = 1;
            this.CancelDecisionButton.Text = "キャンセル";
            this.CancelDecisionButton.UseVisualStyleBackColor = true;
            this.CancelDecisionButton.Click += new System.EventHandler(this.CancelDecisionButton_Click);
            // 
            // SoleTextBox
            // 
            this.SoleTextBox.Location = new System.Drawing.Point(12, 12);
            this.SoleTextBox.Name = "SoleTextBox";
            this.SoleTextBox.Size = new System.Drawing.Size(348, 19);
            this.SoleTextBox.TabIndex = 2;
            // 
            // DialogInputText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 77);
            this.Controls.Add(this.SoleTextBox);
            this.Controls.Add(this.CancelDecisionButton);
            this.Controls.Add(this.OkDecisionButton);
            this.Name = "DialogInputText";
            this.Text = "DialogInputText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkDecisionButton;
        private System.Windows.Forms.Button CancelDecisionButton;
        private System.Windows.Forms.TextBox SoleTextBox;
    }
}