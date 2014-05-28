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
        private Button ForgotPasswordButton;
        private Button AddButton;
        private Button EditButton;
        private Button ViewButton;
        private Button DeleteButton;
        private Button ManageCategoriesButton;
        private Button SearchButton;
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

            SettingsButton = new Button();
            SignInButton = new Button();
            RegisterAccountButton = new Button();
            ForgotPasswordButton = new Button();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            ViewButton = new Button();
            ManageCategoriesButton = new Button();
            SearchButton = new Button();
            MainScreenButton = new Button();
            UserProfileButton = new Button();

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

            ForgotPasswordButton.Click += ForgotPasswordButtonClick;
            ForgotPasswordButton.Location = new Point(10, 130);
            ForgotPasswordButton.Text = "Forgot Password Screen";
            ForgotPasswordButton.Size = new Size(150, 25);
            ForgotPasswordButton.UseVisualStyleBackColor = true;

            AddButton.Click += AddButtonClick;
            AddButton.Location = new Point(10, 170);
            AddButton.Text = "Add Screen";
            AddButton.Size = new Size(150, 25);
            AddButton.UseVisualStyleBackColor = true;

            ManageCategoriesButton.Click += CategoryManagementButtonClick;
            ManageCategoriesButton.Location = new Point(10, 210);
            ManageCategoriesButton.Text = "Manage Categories";
            ManageCategoriesButton.Size = new Size(150, 25);
            ManageCategoriesButton.UseVisualStyleBackColor = true;

            SearchButton.Click += SearchButtonClick;
            SearchButton.Location = new Point(10, 250);
            SearchButton.Text = "Search";
            SearchButton.Size = new Size(150, 25);
            SearchButton.UseVisualStyleBackColor = true;

            MainScreenButton.Click += MainScreenButtonClick;
            MainScreenButton.Location = new Point(10, 290);
            MainScreenButton.Text = "Main";
            MainScreenButton.Size = new Size(150, 25);
            MainScreenButton.UseVisualStyleBackColor = true;

            EditButton.Click += EditButtonClick;
            EditButton.Location = new Point(10, 330);
            EditButton.Text = "Edit Screen";
            EditButton.Size = new Size(150, 25);
            EditButton.UseVisualStyleBackColor = true;

            DeleteButton.Click += DeleteButtonClick;
            DeleteButton.Location = new Point(10, 370);
            DeleteButton.Text = "Delete Screen";
            DeleteButton.Size = new Size(150, 25);
            DeleteButton.UseVisualStyleBackColor = true;

            ViewButton.Click += ViewButtonClick;
            ViewButton.Location = new Point(10, 410);
            ViewButton.Text = "View Screen";
            ViewButton.Size = new Size(150, 25);
            ViewButton.UseVisualStyleBackColor = true;

            UserProfileButton.Click += UserProfileButtonClick;
            UserProfileButton.Location = new Point(10, 450);
            UserProfileButton.Text = "User Profile Screen";
            UserProfileButton.Size = new Size(150, 25);
            UserProfileButton.UseVisualStyleBackColor = true;

            Controls.Add(SettingsButton);
            Controls.Add(SignInButton);
            Controls.Add(RegisterAccountButton);
            Controls.Add(ForgotPasswordButton);
            Controls.Add(AddButton);
            Controls.Add(ManageCategoriesButton);
            Controls.Add(SearchButton);
            Controls.Add(MainScreenButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(ViewButton);
            Controls.Add(UserProfileButton);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
