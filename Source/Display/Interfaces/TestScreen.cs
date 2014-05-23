﻿using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;

namespace Hush.Display.Interfaces
{

    class TestScreen : Interface
    {

        private Button SettingsButton;
        private Button SignInButton;
        private Button RegisterAccountButton;

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

        #region Designer

        protected override void Initialize(String Title)
        {
            
            Title = "Test";

            base.Initialize(Title);

            SettingsButton = new Button();
            SignInButton = new Button();
            RegisterAccountButton = new Button();
            SuspendLayout();

            SettingsButton.Click += SettingsButtonClick;
            SettingsButton.Location = new Point(10, 10);
            SettingsButton.Text = "Settings Screen";
            SettingsButton.Size = new Size(150, 25);
            SettingsButton.UseVisualStyleBackColor = true;

            SignInButton.Click += SignInButtonClick;
            SignInButton.Location = new Point(10, 50);
            SignInButton.Text = "Sign In Screen";
            SignInButton.Size = new Size(150, 25);
            SignInButton.UseVisualStyleBackColor = true;

            RegisterAccountButton.Click += RegisterAccountButtonClick;
            RegisterAccountButton.Location = new Point(10, 90);
            RegisterAccountButton.Text = "Register Account Screen";
            RegisterAccountButton.Size = new Size(150, 25);
            RegisterAccountButton.UseVisualStyleBackColor = true;

            Controls.Add(SettingsButton);
            Controls.Add(SignInButton);
            Controls.Add(RegisterAccountButton);

            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
