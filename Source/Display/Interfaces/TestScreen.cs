﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Hush.Display.Interfaces
{

    class TestScreen : Interface
    {
        private Button SignInButton;
        private Button RegisterAccountButton;
        private Button ForgotPasswordButton;
        private Button ViewButton;
        private Button MainScreenButton;
        private Button UserProfileButton;

        private void SettingsButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Settings());
        }

        private void SignInButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new SignIn());
        }

        private void RegisterAccountButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new RegisterAccount());
        }

        private void ForgotPasswordButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new ForgotPassword());
        }

        private void AddButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Add());
        }

        private void EditButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Edit());
        }

        private void DeleteButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Delete());
        }

        private void ViewButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new View());
        }

        private void CategoryManagementButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new CategoryManagement());
        }

        private void SearchButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Search());
        }

        private void MainScreenButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void UserProfileButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new UserProfile());
        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Test");

            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.SignInButton = new System.Windows.Forms.Button();
            this.RegisterAccountButton = new System.Windows.Forms.Button();
            this.ForgotPasswordButton = new System.Windows.Forms.Button();
            this.MainScreenButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UserProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(10, 41);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(150, 25);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.Text = "Sign In Screen";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButtonClick);
            // 
            // RegisterAccountButton
            // 
            this.RegisterAccountButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccountButton.Location = new System.Drawing.Point(10, 72);
            this.RegisterAccountButton.Name = "RegisterAccountButton";
            this.RegisterAccountButton.Size = new System.Drawing.Size(150, 25);
            this.RegisterAccountButton.TabIndex = 2;
            this.RegisterAccountButton.Text = "Register Account Screen";
            this.RegisterAccountButton.UseVisualStyleBackColor = true;
            this.RegisterAccountButton.Click += new System.EventHandler(this.RegisterAccountButtonClick);
            // 
            // ForgotPasswordButton
            // 
            this.ForgotPasswordButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordButton.Location = new System.Drawing.Point(10, 103);
            this.ForgotPasswordButton.Name = "ForgotPasswordButton";
            this.ForgotPasswordButton.Size = new System.Drawing.Size(150, 25);
            this.ForgotPasswordButton.TabIndex = 3;
            this.ForgotPasswordButton.Text = "Forgot Password Screen";
            this.ForgotPasswordButton.UseVisualStyleBackColor = true;
            this.ForgotPasswordButton.Click += new System.EventHandler(this.ForgotPasswordButtonClick);
            // 
            // MainScreenButton
            // 
            this.MainScreenButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenButton.Location = new System.Drawing.Point(10, 227);
            this.MainScreenButton.Name = "MainScreenButton";
            this.MainScreenButton.Size = new System.Drawing.Size(150, 25);
            this.MainScreenButton.TabIndex = 7;
            this.MainScreenButton.Text = "Main";
            this.MainScreenButton.UseVisualStyleBackColor = true;
            this.MainScreenButton.Click += new System.EventHandler(this.MainScreenButtonClick);
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(10, 320);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(150, 25);
            this.ViewButton.TabIndex = 10;
            this.ViewButton.Text = "View Screen";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButtonClick);
            // 
            // UserProfileButton
            // 
            this.UserProfileButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfileButton.Location = new System.Drawing.Point(10, 351);
            this.UserProfileButton.Name = "UserProfileButton";
            this.UserProfileButton.Size = new System.Drawing.Size(150, 25);
            this.UserProfileButton.TabIndex = 11;
            this.UserProfileButton.Text = "User Profile Screen";
            this.UserProfileButton.UseVisualStyleBackColor = true;
            this.UserProfileButton.Click += new System.EventHandler(this.UserProfileButtonClick);
            // 
            // TestScreen
            // 
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.RegisterAccountButton);
            this.Controls.Add(this.ForgotPasswordButton);
            this.Controls.Add(this.MainScreenButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.UserProfileButton);
            this.Name = "TestScreen";
            this.ResumeLayout(false);

        }

        #endregion

    }

}
