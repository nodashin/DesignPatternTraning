namespace State.Sample
{
    partial class SafeForm
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
            this.textBoxCurrentTime = new System.Windows.Forms.TextBox();
            this.textBoxRecords = new System.Windows.Forms.TextBox();
            this.buttonUse = new System.Windows.Forms.Button();
            this.buttonAlram = new System.Windows.Forms.Button();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCurrentTime
            // 
            this.textBoxCurrentTime.Enabled = false;
            this.textBoxCurrentTime.Location = new System.Drawing.Point(12, 12);
            this.textBoxCurrentTime.Name = "textBoxCurrentTime";
            this.textBoxCurrentTime.Size = new System.Drawing.Size(909, 25);
            this.textBoxCurrentTime.TabIndex = 0;
            // 
            // textBoxRecords
            // 
            this.textBoxRecords.Enabled = false;
            this.textBoxRecords.Location = new System.Drawing.Point(12, 43);
            this.textBoxRecords.Multiline = true;
            this.textBoxRecords.Name = "textBoxRecords";
            this.textBoxRecords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRecords.Size = new System.Drawing.Size(909, 267);
            this.textBoxRecords.TabIndex = 1;
            // 
            // buttonUse
            // 
            this.buttonUse.Location = new System.Drawing.Point(12, 316);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(75, 23);
            this.buttonUse.TabIndex = 2;
            this.buttonUse.Text = "金庫使用";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // buttonAlram
            // 
            this.buttonAlram.Location = new System.Drawing.Point(93, 316);
            this.buttonAlram.Name = "buttonAlram";
            this.buttonAlram.Size = new System.Drawing.Size(75, 23);
            this.buttonAlram.TabIndex = 3;
            this.buttonAlram.Text = "非常ベル";
            this.buttonAlram.UseVisualStyleBackColor = true;
            this.buttonAlram.Click += new System.EventHandler(this.buttonAlram_Click);
            // 
            // buttonPhone
            // 
            this.buttonPhone.Location = new System.Drawing.Point(174, 316);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(75, 23);
            this.buttonPhone.TabIndex = 4;
            this.buttonPhone.Text = "通常通話";
            this.buttonPhone.UseVisualStyleBackColor = true;
            this.buttonPhone.Click += new System.EventHandler(this.buttonPhone_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(846, 316);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "終了";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // SafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 351);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPhone);
            this.Controls.Add(this.buttonAlram);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.textBoxRecords);
            this.Controls.Add(this.textBoxCurrentTime);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SafeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCurrentTime;
        private System.Windows.Forms.TextBox textBoxRecords;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Button buttonAlram;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonClose;
    }
}