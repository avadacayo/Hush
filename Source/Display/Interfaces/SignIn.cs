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
<<<<<<< HEAD
            Title = "Sign In";
=======

            Title.Add("Sign In");

            Int32 Yoffset = 40;
>>>>>>> 10b793549ae8231aadebcf4b7164165c865c4a62
            base.Initialize(Title);

            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            LoginButton = new Button();
            RegisterPageButton = new Button();
            ForgotPasswordLinkLable = new LinkLabel();

            LoginLabel.Location = new Point(145, 110);
            LoginLabel.Name = "UsernameTextBox";
            LoginLabel.Size = new Size(300, 40);
            LoginLabel.Font = new Font("Arial", 27);
            LoginLabel.Text = "Log in";

            UsernameLabel.Font = GlobalFont;
            UsernameLabel.Location = new Point(150, 170);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(300, 15);
            UsernameLabel.Text = "Username";

            UsernameTextBox.Font = GlobalFont;
            UsernameTextBox.Location = new Point(150, 190);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(300, 50);
            UsernameTextBox.TabIndex = 1;

            PasswordLabel.Font = GlobalFont;
            PasswordLabel.Location = new Point(150, 220);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(300, 15);
            PasswordLabel.Text = "Password";

            PasswordTextBox.Font = GlobalFont;
            PasswordTextBox.Location = new Point(150, 240);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(300, 50);

            PasswordTextBox.Font = GlobalFont;
            LoginButton.Location = new Point(150, 270);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(300, 30);
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;

            ForgotPasswordLinkLable.Font = GlobalFont;
            ForgotPasswordLinkLable.Location = new Point(150, 300);
            ForgotPasswordLinkLable.Name = "ForgotPasswordLinkLable";
            ForgotPasswordLinkLable.Size = new Size(86, 13);
            ForgotPasswordLinkLable.Text = "Forgot Password";

            RegisterPageButton.Font = GlobalFont;
            RegisterPageButton.Location = new Point(150, 330);
            RegisterPageButton.Name = "RegisterPageButton";
            RegisterPageButton.Size = new Size(300, 30);
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
