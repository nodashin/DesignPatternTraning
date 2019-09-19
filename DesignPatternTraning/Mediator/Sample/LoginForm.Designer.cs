namespace Mediator.Sample
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.colleagueRadioButton2 = new Mediator.Sample.ColleagueRadioButton();
            this.colleagueRadioButton1 = new Mediator.Sample.ColleagueRadioButton();
            this.colleagueTextBox1 = new Mediator.Sample.ColleagueTextBox();
            this.colleagueTextBox2 = new Mediator.Sample.ColleagueTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colleagueButton1 = new Mediator.Sample.ColleagueButton();
            this.colleagueButton2 = new Mediator.Sample.ColleagueButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // colleagueRadioButton2
            // 
            this.colleagueRadioButton2.AutoSize = true;
            this.colleagueRadioButton2.Location = new System.Drawing.Point(103, 12);
            this.colleagueRadioButton2.Name = "colleagueRadioButton2";
            this.colleagueRadioButton2.Size = new System.Drawing.Size(57, 22);
            this.colleagueRadioButton2.TabIndex = 1;
            this.colleagueRadioButton2.TabStop = true;
            this.colleagueRadioButton2.Text = "Login";
            this.colleagueRadioButton2.UseVisualStyleBackColor = true;
            // 
            // colleagueRadioButton1
            // 
            this.colleagueRadioButton1.AutoSize = true;
            this.colleagueRadioButton1.Location = new System.Drawing.Point(29, 12);
            this.colleagueRadioButton1.Name = "colleagueRadioButton1";
            this.colleagueRadioButton1.Size = new System.Drawing.Size(60, 22);
            this.colleagueRadioButton1.TabIndex = 0;
            this.colleagueRadioButton1.TabStop = true;
            this.colleagueRadioButton1.Text = "Gesut";
            this.colleagueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // colleagueTextBox1
            // 
            this.colleagueTextBox1.Location = new System.Drawing.Point(103, 40);
            this.colleagueTextBox1.Name = "colleagueTextBox1";
            this.colleagueTextBox1.Size = new System.Drawing.Size(100, 25);
            this.colleagueTextBox1.TabIndex = 3;
            // 
            // colleagueTextBox2
            // 
            this.colleagueTextBox2.Location = new System.Drawing.Point(103, 71);
            this.colleagueTextBox2.Name = "colleagueTextBox2";
            this.colleagueTextBox2.PasswordChar = '*';
            this.colleagueTextBox2.Size = new System.Drawing.Size(100, 25);
            this.colleagueTextBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // colleagueButton1
            // 
            this.colleagueButton1.Location = new System.Drawing.Point(29, 102);
            this.colleagueButton1.Name = "colleagueButton1";
            this.colleagueButton1.Size = new System.Drawing.Size(75, 23);
            this.colleagueButton1.TabIndex = 6;
            this.colleagueButton1.Text = "OK";
            this.colleagueButton1.UseVisualStyleBackColor = true;
            // 
            // colleagueButton2
            // 
            this.colleagueButton2.Location = new System.Drawing.Point(128, 102);
            this.colleagueButton2.Name = "colleagueButton2";
            this.colleagueButton2.Size = new System.Drawing.Size(75, 23);
            this.colleagueButton2.TabIndex = 7;
            this.colleagueButton2.Text = "Cancel";
            this.colleagueButton2.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 142);
            this.Controls.Add(this.colleagueButton2);
            this.Controls.Add(this.colleagueButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colleagueTextBox2);
            this.Controls.Add(this.colleagueTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colleagueRadioButton2);
            this.Controls.Add(this.colleagueRadioButton1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediator Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueRadioButton colleagueRadioButton1;
        private ColleagueRadioButton colleagueRadioButton2;
        private System.Windows.Forms.Label label1;
        private ColleagueTextBox colleagueTextBox1;
        private ColleagueTextBox colleagueTextBox2;
        private System.Windows.Forms.Label label2;
        private ColleagueButton colleagueButton1;
        private ColleagueButton colleagueButton2;
    }
}