﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Hush.Client;
using Hush.Tools;

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
        private Button ToolButton;
        private Label ErrorMsgsLabel;
        private System.ComponentModel.IContainer components;
        private ToolTip Tooltip;

        private void LoginButtonClick(Object Sender, EventArgs Args)
        {
            UsernameTextBox.Text = UsernameTextBox.Text.Trim();
            if ((new DataManager().LoadUser(UsernameTextBox.Text, PasswordTextBox.Text)))
            {
                Program.Window.ShowInterface(new MainScreen());
            }

            else
            {
                this.ErrorMsgsLabel.Text = "Please enter a valid username and password.";
                this.ErrorMsgsLabel.Visible = true;
            }
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

        private void ToolButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new GeneratePassword());
        }

        private void ToolButton_MouseHover(object sender, EventArgs e)
        {
            Tooltip.Show("Tools", ToolButton);
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            if (new CheckString().AccountExists("demo"))
            {
                if ((new DataManager().LoadUser("demo", "demo")))
                {
                    Program.Window.ShowInterface(new MainScreen());
                    return;
                }

                
            }
            else
            {
                if (new DataManager().CreateAccount("demo", "demo", "demo", "demo", "demo", "demo"))
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
            this.components = new System.ComponentModel.Container();
            this.DemoButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterPageButton = new System.Windows.Forms.LinkLabel();
            this.ForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ErrorMsgsLabel = new System.Windows.Forms.Label();
            this.ToolButton = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // DemoButton
            // 
            this.DemoButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemoButton.Location = new System.Drawing.Point(45, 435);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(321, 36);
            this.DemoButton.TabIndex = 10;
            this.DemoButton.Text = "Sign in as demo user";
            this.DemoButton.UseVisualStyleBackColor = true;
            this.DemoButton.Visible = false;
            this.DemoButton.Click += new System.EventHandler(this.DemoButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(40, 30);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(300, 40);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Sign In";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.PasswordTextBox.Location = new System.Drawing.Point(42, 144);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(324, 24);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.PasswordTextBox.KeyDown += (Sender, Args) => 
            {
                if (Args.KeyCode == Keys.Return && LoginButton.Enabled == true)
                {
                    LoginButtonClick(null, null);
                }
            };
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.PasswordLabel.Location = new System.Drawing.Point(42, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(300, 20);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 90);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(324, 24);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.MaxLength = 30;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.UsernameTextBox.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && LoginButton.Enabled == true)
                {
                    LoginButtonClick(null, null);
                }
            };
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.UsernameLabel.Location = new System.Drawing.Point(42, 70);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(98, 22);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(43, 178);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(324, 30);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // RegisterPageButton
            // 
            this.RegisterPageButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPageButton.Location = new System.Drawing.Point(39, 283);
            this.RegisterPageButton.Name = "RegisterPageButton";
            this.RegisterPageButton.Size = new System.Drawing.Size(300, 30);
            this.RegisterPageButton.TabIndex = 9;
            this.RegisterPageButton.TabStop = true;
            this.RegisterPageButton.Text = "Create New Account";
            this.RegisterPageButton.Click += new System.EventHandler(this.RegisterPageButtonClick);
            // 
            // ForgotPasswordLinkLabel
            // 
            this.ForgotPasswordLinkLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.ForgotPasswordLinkLabel.Location = new System.Drawing.Point(39, 249);
            this.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            this.ForgotPasswordLinkLabel.Size = new System.Drawing.Size(158, 25);
            this.ForgotPasswordLinkLabel.TabIndex = 7;
            this.ForgotPasswordLinkLabel.TabStop = true;
            this.ForgotPasswordLinkLabel.Text = "Forgot Password";
            this.ForgotPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLinkLabel_LinkClicked);
            // 
            // ErrorMsgsLabel
            // 
            this.ErrorMsgsLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsgsLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorMsgsLabel.Location = new System.Drawing.Point(41, 211);
            this.ErrorMsgsLabel.Name = "ErrorMsgsLabel";
            this.ErrorMsgsLabel.Size = new System.Drawing.Size(370, 24);
            this.ErrorMsgsLabel.TabIndex = 6;
            this.ErrorMsgsLabel.Text = "Error";
            this.ErrorMsgsLabel.Visible = false;
            // 
            // ToolButton
            // 
            this.ToolButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolButton.FlatAppearance.BorderSize = 5;
            this.ToolButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolButton.Image = global::Hush.Properties.Resources.Andy_Tools_Hammer_Spanner3;
            this.ToolButton.Location = new System.Drawing.Point(385, 12);
            this.ToolButton.Name = "ToolButton";
            this.ToolButton.Size = new System.Drawing.Size(26, 26);
            this.ToolButton.TabIndex = 12;
            this.ToolButton.UseVisualStyleBackColor = true;
            this.ToolButton.Click += new System.EventHandler(this.ToolButton_Click);
            this.ToolButton.MouseHover += new System.EventHandler(this.ToolButton_MouseHover);
            this.ToolButton.Visible = false;
            // 
            // SignIn
            // 
            this.Controls.Add(this.ToolButton);
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

 public override void PostInit()
        {
            base.PostInit();
            UsernameTextBox.Focus();
        }       

        private void ForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Window.ShowInterface(new SecretQuestion());
        }

      

    }

}
