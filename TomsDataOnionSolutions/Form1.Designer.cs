namespace TomsDataOnionSolutions
{
    partial class EncryptionWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionWindow));
            this.EncryptButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveText = new System.Windows.Forms.SaveFileDialog();
            this.ACII85Lable = new System.Windows.Forms.Label();
            this.encTextBox = new System.Windows.Forms.TextBox();
            this.encryptPhase2 = new System.Windows.Forms.Button();
            this.encodePhae2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(14, 557);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(87, 27);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(462, 559);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 27);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save to";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1281, 557);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 27);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveText
            // 
            this.saveText.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ACII85Lable
            // 
            this.ACII85Lable.AutoSize = true;
            this.ACII85Lable.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACII85Lable.Location = new System.Drawing.Point(14, 10);
            this.ACII85Lable.Name = "ACII85Lable";
            this.ACII85Lable.Size = new System.Drawing.Size(226, 24);
            this.ACII85Lable.TabIndex = 4;
            this.ACII85Lable.Text = "ASCII85 Encryption";
            this.ACII85Lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // encTextBox
            // 
            this.encTextBox.AcceptsReturn = true;
            this.encTextBox.AcceptsTab = true;
            this.encTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.encTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.encTextBox.Location = new System.Drawing.Point(14, 49);
            this.encTextBox.MaxLength = 1000000;
            this.encTextBox.Multiline = true;
            this.encTextBox.Name = "encTextBox";
            this.encTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encTextBox.Size = new System.Drawing.Size(1354, 489);
            this.encTextBox.TabIndex = 5;
            this.encTextBox.TextChanged += new System.EventHandler(this.encTextBox_TextChanged);
            // 
            // encryptPhase2
            // 
            this.encryptPhase2.Location = new System.Drawing.Point(107, 557);
            this.encryptPhase2.Name = "encryptPhase2";
            this.encryptPhase2.Size = new System.Drawing.Size(132, 27);
            this.encryptPhase2.TabIndex = 6;
            this.encryptPhase2.Text = "Encrypt Phase 1";
            this.encryptPhase2.UseVisualStyleBackColor = true;
            this.encryptPhase2.Click += new System.EventHandler(this.encryptPhase2_Click);
            // 
            // encodePhae2
            // 
            this.encodePhae2.Location = new System.Drawing.Point(245, 557);
            this.encodePhae2.Name = "encodePhae2";
            this.encodePhae2.Size = new System.Drawing.Size(132, 27);
            this.encodePhae2.TabIndex = 7;
            this.encodePhae2.Text = "Encrypt Phase 2";
            this.encodePhae2.UseVisualStyleBackColor = true;
            this.encodePhae2.Click += new System.EventHandler(this.encodePhae2_Click);
            // 
            // EncryptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.encodePhae2);
            this.Controls.Add(this.encryptPhase2);
            this.Controls.Add(this.encTextBox);
            this.Controls.Add(this.ACII85Lable);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.EncryptButton);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptionWindow";
            this.Text = "Ascii85 Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.SaveFileDialog saveText;
        private System.Windows.Forms.Label ACII85Lable;
        private System.Windows.Forms.TextBox encTextBox;
        private System.Windows.Forms.Button encryptPhase2;
        private System.Windows.Forms.Button encodePhae2;
    }
}

