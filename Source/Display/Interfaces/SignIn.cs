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
        private Button RegisterPageButton;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private LinkLabel ForgotPasswordLinkLable;

        private void LoginButtonClick(Object Sender, EventArgs Args)
        {
            //if ((new DataManager().TryLogin(UsernameTextBox.Text, PasswordTextBox.Text)) {
            //    Program.Window.ShowInterface(new MainScreen());
            //    return;
            //}
            // show failed to login
        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Sign In");

            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterPageButton = new System.Windows.Forms.Button();
            this.ForgotPasswordLinkLable = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 27F);
            this.LoginLabel.Location = new System.Drawing.Point(145, 110);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(300, 40);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Log in";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 240);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(150, 220);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(150, 190);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(300, 20);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(150, 170);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(300, 15);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(150, 270);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(300, 30);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // RegisterPageButton
            // 
            this.RegisterPageButton.Location = new System.Drawing.Point(150, 316);
            this.RegisterPageButton.Name = "RegisterPageButton";
            this.RegisterPageButton.Size = new System.Drawing.Size(300, 30);
            this.RegisterPageButton.TabIndex = 5;
            this.RegisterPageButton.Text = "Create an Account";
            this.RegisterPageButton.UseVisualStyleBackColor = true;
            // 
            // ForgotPasswordLinkLable
            // 
            this.ForgotPasswordLinkLable.Location = new System.Drawing.Point(150, 300);
            this.ForgotPasswordLinkLable.Name = "ForgotPasswordLinkLable";
            this.ForgotPasswordLinkLable.Size = new System.Drawing.Size(86, 13);
            this.ForgotPasswordLinkLable.TabIndex = 6;
            this.ForgotPasswordLinkLable.TabStop = true;
            this.ForgotPasswordLinkLable.Text = "Forgot Password";
            // 
            // SignIn
            // 
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterPageButton);
            this.Controls.Add(this.ForgotPasswordLinkLable);
            this.Name = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }

}
