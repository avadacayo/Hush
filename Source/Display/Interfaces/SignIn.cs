using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using System.Collections.Generic;

namespace Hush.Display.Interfaces
{

    class SignIn : Interface
    {
        private Label LoginLabel;
        private Button LoginButton;
        private Button RegisterPageButton;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private LinkLabel ForgotPasswordLinkLable;

        #region Designer
        protected override void Initialize(List<String> Title)
        {

            Title.Add("Sign In");

            Int32 Yoffset = 40;
            base.Initialize(Title);

            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            LoginButton = new Button();
            RegisterPageButton = new Button();
            ForgotPasswordLinkLable = new LinkLabel();

            LoginLabel.Location = new Point(145, 70 + Yoffset);
            LoginLabel.Name = "UsernameTextBox";
            LoginLabel.Size = new Size(300, 40);
            LoginLabel.Font = new Font("Arial", 27);
            LoginLabel.Text = "Log in";

            UsernameLabel.Location = new Point(150, 130 + Yoffset);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(300, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";

            UsernameTextBox.Location = new Point(150, 150 + Yoffset);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(300, 50);
            UsernameTextBox.TabIndex = 1;

            PasswordLabel.Location = new Point(150, 180 + Yoffset);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(300, 15);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Password";

            PasswordTextBox.Location = new Point(150, 200 + Yoffset);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(300, 50);
            PasswordTextBox.TabIndex = 2;

            LoginButton.Location = new Point(150, 230 + Yoffset);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(300, 30);
            //LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;

            ForgotPasswordLinkLable.Location = new Point(150, 260 + Yoffset);
            ForgotPasswordLinkLable.Name = "ForgotPasswordLinkLable";
            ForgotPasswordLinkLable.Size = new Size(86, 13);
            ForgotPasswordLinkLable.Text = "Forgot Password";

            RegisterPageButton.Location = new Point(150, 290 + Yoffset);
            RegisterPageButton.Name = "RegisterPageButton";
            RegisterPageButton.Size = new Size(300, 30);
            RegisterPageButton.TabIndex = 4;
            RegisterPageButton.Text = "Create an Account";
            RegisterPageButton.UseVisualStyleBackColor = true;

            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(LoginButton);
            Controls.Add(RegisterPageButton);
            Controls.Add(ForgotPasswordLinkLable);

        }

        #endregion

    }

}
