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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.colleagueButtonCancel = new Mediator.Sample.ColleagueButton();
            this.colleagueButtonOK = new Mediator.Sample.ColleagueButton();
            this.colleagueTextBoxPassword = new Mediator.Sample.ColleagueTextBox();
            this.colleagueTextBoxUsername = new Mediator.Sample.ColleagueTextBox();
            this.colleagueRadioButtonLogin = new Mediator.Sample.ColleagueRadioButton();
            this.colleagueRadioButtonGuest = new Mediator.Sample.ColleagueRadioButton();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(29, 43);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 18);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(29, 74);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 18);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // colleagueButtonCancel
            // 
            this.colleagueButtonCancel.Location = new System.Drawing.Point(128, 102);
            this.colleagueButtonCancel.Name = "colleagueButtonCancel";
            this.colleagueButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.colleagueButtonCancel.TabIndex = 7;
            this.colleagueButtonCancel.Text = "Cancel";
            this.colleagueButtonCancel.UseVisualStyleBackColor = true;
            // 
            // colleagueButtonOK
            // 
            this.colleagueButtonOK.Location = new System.Drawing.Point(29, 102);
            this.colleagueButtonOK.Name = "colleagueButtonOK";
            this.colleagueButtonOK.Size = new System.Drawing.Size(75, 23);
            this.colleagueButtonOK.TabIndex = 6;
            this.colleagueButtonOK.Text = "OK";
            this.colleagueButtonOK.UseVisualStyleBackColor = true;
            // 
            // colleagueTextBoxPassword
            // 
            this.colleagueTextBoxPassword.Location = new System.Drawing.Point(103, 71);
            this.colleagueTextBoxPassword.Name = "colleagueTextBoxPassword";
            this.colleagueTextBoxPassword.PasswordChar = '*';
            this.colleagueTextBoxPassword.Size = new System.Drawing.Size(100, 25);
            this.colleagueTextBoxPassword.TabIndex = 4;
            // 
            // colleagueTextBoxUsername
            // 
            this.colleagueTextBoxUsername.Location = new System.Drawing.Point(103, 40);
            this.colleagueTextBoxUsername.Name = "colleagueTextBoxUsername";
            this.colleagueTextBoxUsername.Size = new System.Drawing.Size(100, 25);
            this.colleagueTextBoxUsername.TabIndex = 3;
            // 
            // colleagueRadioButtonLogin
            // 
            this.colleagueRadioButtonLogin.AutoSize = true;
            this.colleagueRadioButtonLogin.Location = new System.Drawing.Point(103, 12);
            this.colleagueRadioButtonLogin.Name = "colleagueRadioButtonLogin";
            this.colleagueRadioButtonLogin.Size = new System.Drawing.Size(57, 22);
            this.colleagueRadioButtonLogin.TabIndex = 1;
            this.colleagueRadioButtonLogin.Text = "Login";
            this.colleagueRadioButtonLogin.UseVisualStyleBackColor = true;
            // 
            // colleagueRadioButtonGuest
            // 
            this.colleagueRadioButtonGuest.AutoSize = true;
            this.colleagueRadioButtonGuest.Checked = true;
            this.colleagueRadioButtonGuest.Location = new System.Drawing.Point(29, 12);
            this.colleagueRadioButtonGuest.Name = "colleagueRadioButtonGuest";
            this.colleagueRadioButtonGuest.Size = new System.Drawing.Size(60, 22);
            this.colleagueRadioButtonGuest.TabIndex = 0;
            this.colleagueRadioButtonGuest.TabStop = true;
            this.colleagueRadioButtonGuest.Text = "Gesut";
            this.colleagueRadioButtonGuest.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 142);
            this.Controls.Add(this.colleagueButtonCancel);
            this.Controls.Add(this.colleagueButtonOK);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.colleagueTextBoxPassword);
            this.Controls.Add(this.colleagueTextBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.colleagueRadioButtonLogin);
            this.Controls.Add(this.colleagueRadioButtonGuest);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediator Sample";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueRadioButton colleagueRadioButtonGuest;
        private ColleagueRadioButton colleagueRadioButtonLogin;
        private System.Windows.Forms.Label labelUsername;
        private ColleagueTextBox colleagueTextBoxUsername;
        private ColleagueTextBox colleagueTextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private ColleagueButton colleagueButtonOK;
        private ColleagueButton colleagueButtonCancel;
    }
}