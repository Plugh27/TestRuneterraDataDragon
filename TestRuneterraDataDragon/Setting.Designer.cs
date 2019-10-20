namespace TestRuneterraDataDragon
{
    partial class Setting
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
            this.CoreDataFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CoreDataLabel = new System.Windows.Forms.Label();
            this.SetDataLabel = new System.Windows.Forms.Label();
            this.SetDataFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SelectCoreDataFileButton = new System.Windows.Forms.Button();
            this.SelectSetDataFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OkDecisionButton
            // 
            this.OkDecisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkDecisionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkDecisionButton.Location = new System.Drawing.Point(471, 184);
            this.OkDecisionButton.Name = "OkDecisionButton";
            this.OkDecisionButton.Size = new System.Drawing.Size(75, 23);
            this.OkDecisionButton.TabIndex = 0;
            this.OkDecisionButton.Text = "OK";
            this.OkDecisionButton.UseVisualStyleBackColor = true;
            this.OkDecisionButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelDecisionButton
            // 
            this.CancelDecisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDecisionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDecisionButton.Location = new System.Drawing.Point(552, 184);
            this.CancelDecisionButton.Name = "CancelDecisionButton";
            this.CancelDecisionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDecisionButton.TabIndex = 1;
            this.CancelDecisionButton.Text = "キャンセル";
            this.CancelDecisionButton.UseVisualStyleBackColor = true;
            this.CancelDecisionButton.Click += new System.EventHandler(this.CancelDecisionButton_Click);
            // 
            // CoreDataFilePathTextBox
            // 
            this.CoreDataFilePathTextBox.Location = new System.Drawing.Point(99, 50);
            this.CoreDataFilePathTextBox.Name = "CoreDataFilePathTextBox";
            this.CoreDataFilePathTextBox.Size = new System.Drawing.Size(453, 19);
            this.CoreDataFilePathTextBox.TabIndex = 2;
            this.CoreDataFilePathTextBox.Text = "C:\\Users\\Admin\\Documents\\DataDragon\\datadragon-core-ja_jp\\metadata.json";
            // 
            // CoreDataLabel
            // 
            this.CoreDataLabel.AutoSize = true;
            this.CoreDataLabel.Location = new System.Drawing.Point(43, 53);
            this.CoreDataLabel.Name = "CoreDataLabel";
            this.CoreDataLabel.Size = new System.Drawing.Size(50, 12);
            this.CoreDataLabel.TabIndex = 3;
            this.CoreDataLabel.Text = "コアデータ";
            // 
            // SetDataLabel
            // 
            this.SetDataLabel.AutoSize = true;
            this.SetDataLabel.Location = new System.Drawing.Point(35, 85);
            this.SetDataLabel.Name = "SetDataLabel";
            this.SetDataLabel.Size = new System.Drawing.Size(58, 12);
            this.SetDataLabel.TabIndex = 4;
            this.SetDataLabel.Text = "セットデータ";
            // 
            // SetDataFilePathTextBox
            // 
            this.SetDataFilePathTextBox.Location = new System.Drawing.Point(99, 82);
            this.SetDataFilePathTextBox.Name = "SetDataFilePathTextBox";
            this.SetDataFilePathTextBox.Size = new System.Drawing.Size(453, 19);
            this.SetDataFilePathTextBox.TabIndex = 5;
            this.SetDataFilePathTextBox.Text = "C:\\Users\\Admin\\Documents\\DataDragon\\datadragon-set1-ja_jp\\metadata.json";
            // 
            // SelectCoreDataFileButton
            // 
            this.SelectCoreDataFileButton.Location = new System.Drawing.Point(558, 48);
            this.SelectCoreDataFileButton.Name = "SelectCoreDataFileButton";
            this.SelectCoreDataFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectCoreDataFileButton.TabIndex = 6;
            this.SelectCoreDataFileButton.Text = "選択";
            this.SelectCoreDataFileButton.UseVisualStyleBackColor = true;
            this.SelectCoreDataFileButton.Click += new System.EventHandler(this.SelectCoreDataFileButton_Click);
            // 
            // SelectSetDataFileButton
            // 
            this.SelectSetDataFileButton.Location = new System.Drawing.Point(558, 80);
            this.SelectSetDataFileButton.Name = "SelectSetDataFileButton";
            this.SelectSetDataFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectSetDataFileButton.TabIndex = 7;
            this.SelectSetDataFileButton.Text = "選択";
            this.SelectSetDataFileButton.UseVisualStyleBackColor = true;
            this.SelectSetDataFileButton.Click += new System.EventHandler(this.SelectSetDataFileButton_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 216);
            this.Controls.Add(this.SelectSetDataFileButton);
            this.Controls.Add(this.SelectCoreDataFileButton);
            this.Controls.Add(this.SetDataFilePathTextBox);
            this.Controls.Add(this.SetDataLabel);
            this.Controls.Add(this.CoreDataLabel);
            this.Controls.Add(this.CoreDataFilePathTextBox);
            this.Controls.Add(this.CancelDecisionButton);
            this.Controls.Add(this.OkDecisionButton);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkDecisionButton;
        private System.Windows.Forms.Button CancelDecisionButton;
        private System.Windows.Forms.TextBox CoreDataFilePathTextBox;
        private System.Windows.Forms.Label CoreDataLabel;
        private System.Windows.Forms.Label SetDataLabel;
        private System.Windows.Forms.TextBox SetDataFilePathTextBox;
        private System.Windows.Forms.Button SelectCoreDataFileButton;
        private System.Windows.Forms.Button SelectSetDataFileButton;
    }
}