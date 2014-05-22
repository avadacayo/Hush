using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hush.Source.Display.Interfaces
{
    public partial class Login : Form
    {
        private Label LoginLabel;
        private Button LoginButton;
        private Button RegisterPageButton;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private LinkLabel ForgotPasswordLinkLable;

        public Login()
        {
            InitializeComponent();

            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            LoginButton = new Button();
            RegisterPageButton = new Button();
            ForgotPasswordLinkLable = new LinkLabel();

            LoginLabel.Location = new Point(165, 70);
            LoginLabel.Name = "UsernameTextBox";
            LoginLabel.Size = new Size(300, 40);
            LoginLabel.Font = new Font("Arial", 27);
            LoginLabel.Text = "Log in";

            UsernameLabel.Location = new Point(170, 130);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(300, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";

            UsernameTextBox.Location = new Point(170, 150);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(300, 40);
            UsernameTextBox.TabIndex = 1;

            PasswordLabel.Location = new Point(170, 180);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(300, 15);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Password";

            PasswordTextBox.Location = new Point(170, 200);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(300, 30);
            PasswordTextBox.TabIndex = 2;

            LoginButton.Location = new Point(170, 230);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(300, 30);
            //LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;

            ForgotPasswordLinkLable.Location = new Point(170, 260);
            ForgotPasswordLinkLable.Name = "ForgotPasswordLinkLable";
            ForgotPasswordLinkLable.Size = new Size(86, 13);
            ForgotPasswordLinkLable.Text = "Forgot Password";

            RegisterPageButton.Location = new Point(170, 290);
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
    }
}
