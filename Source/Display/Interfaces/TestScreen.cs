using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Hush.Display.Interfaces
{

    class TestScreen : Interface
    {

        private Button SettingsButton;
        private Button SignInButton;
        private Button RegisterAccountButton;
        private Button AddButton;

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

        private void AddButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Add());
        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Test");

            base.Initialize(Title);

            SettingsButton = new Button();
            SignInButton = new Button();
            RegisterAccountButton = new Button();
            AddButton = new Button();
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

            AddButton.Click += AddButtonClick;
            AddButton.Location = new Point(10, 130);
            AddButton.Text = "Add Screen";
            AddButton.Size = new Size(150, 25);
            AddButton.UseVisualStyleBackColor = true;

            Controls.Add(SettingsButton);
            Controls.Add(SignInButton);
            Controls.Add(RegisterAccountButton);
            Controls.Add(AddButton);

            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
