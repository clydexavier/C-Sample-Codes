namespace RideSharingApplicationProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(149, 80);
            usernameTB.Name = "usernameTB";
            usernameTB.PlaceholderText = "Enter username";
            usernameTB.Size = new Size(244, 31);
            usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(149, 126);
            passwordTB.Name = "passwordTB";
            passwordTB.PlaceholderText = "Enter password";
            passwordTB.Size = new Size(244, 31);
            passwordTB.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(215, 180);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(112, 34);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 222);
            Controls.Add(loginBtn);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginBtn;
    }
}