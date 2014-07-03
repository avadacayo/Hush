using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Hush.Client;

/*
 * 1. front end 
 * 2. model classes / minimal utilities (such as file / serialize)
 * 3. data manager
 * 
 * 
 */

namespace Hush.Display.Interfaces
{

    class SignIn : Interface
    {
        private Label LoginLabel;
        private Button LoginButton;
        private LinkLabel RegisterPageButton;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private LinkLabel ForgotPasswordLinkLabel;
        private Button DemoButton;
        private Label ErrorMsgsLabel;
        
        private void LoginButtonClick(Object Sender, EventArgs Args)
        {
            if ((new DataManager().TryLogin(UsernameTextBox.Text, PasswordTextBox.Text)))
            {
                Program.Window.ShowInterface(new MainScreen());
            }

            else
                this.ErrorMsgsLabel.Text = "Please enter a valid username and password.";
            // show failed to login
        }

        public void RegisterPageButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new RegisterAccount());
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0)
                LoginButton.Enabled = true;

            else
                LoginButton.Enabled = false;
           
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            if ((new DataManager().TryLogin("demo", "demo")))
            {
                Program.Window.ShowInterface(new MainScreen());
                return;
            }

            else
            {
                if (new DataManager().CreateAccount("demo", "demo", "demo", "demo"))
                {
                    Program.Window.ShowInterface(new MainScreen());
                }
            }

        }
        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Sign In");

            base.Initialize(Title);
            LoginButton.Enabled = false;

        }

        protected override void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterPageButton = new System.Windows.Forms.LinkLabel();
            this.ForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ErrorMsgsLabel = new System.Windows.Forms.Label();
            this.DemoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Verdana", 27F);
            this.LoginLabel.Location = new System.Drawing.Point(302, 136);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(300, 66);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Log in";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(307, 272);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 21);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(307, 252);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(307, 222);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(300, 21);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(307, 202);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(300, 15);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(307, 302);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(300, 30);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // RegisterPageButton
            // 
            this.RegisterPageButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPageButton.Location = new System.Drawing.Point(307, 348);
            this.RegisterPageButton.Name = "RegisterPageButton";
            this.RegisterPageButton.Size = new System.Drawing.Size(300, 30);
            this.RegisterPageButton.TabIndex = 8;
            this.RegisterPageButton.TabStop = true;
            this.RegisterPageButton.Text = "Create an Account";
            this.RegisterPageButton.Click += new System.EventHandler(this.RegisterPageButtonClick);
            // 
            // ForgotPasswordLinkLabel
            // 
            this.ForgotPasswordLinkLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLinkLabel.Location = new System.Drawing.Point(307, 332);
            this.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            this.ForgotPasswordLinkLabel.Size = new System.Drawing.Size(122, 13);
            this.ForgotPasswordLinkLabel.TabIndex = 7;
            this.ForgotPasswordLinkLabel.TabStop = true;
            this.ForgotPasswordLinkLabel.Text = "Forgot Password";
            // 
            // ErrorMsgsLabel
            // 
            this.ErrorMsgsLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsgsLabel.Location = new System.Drawing.Point(150, 89);
            this.ErrorMsgsLabel.Name = "ErrorMsgsLabel";
            this.ErrorMsgsLabel.Size = new System.Drawing.Size(300, 80);
            this.ErrorMsgsLabel.TabIndex = 0;
            // 
            // DemoButton
            // 
            this.DemoButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemoButton.Location = new System.Drawing.Point(307, 452);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(300, 23);
            this.DemoButton.TabIndex = 9;
            this.DemoButton.Text = "Sign in as demo user";
            this.DemoButton.UseVisualStyleBackColor = true;
            this.DemoButton.Click += new System.EventHandler(this.DemoButton_Click);
            // 
            // SignIn
            // 
            this.Controls.Add(this.DemoButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterPageButton);
            this.Controls.Add(this.ForgotPasswordLinkLabel);
            this.Controls.Add(this.ErrorMsgsLabel);
            this.Name = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       

    }

}
