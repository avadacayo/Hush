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

        }

        protected override void InitializeComponent()
        {
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.RegisterAccountButton = new System.Windows.Forms.Button();
            this.ForgotPasswordButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ManageCategoriesButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainScreenButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UserProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(10, 10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(150, 25);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Settings Screen";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
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
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(10, 134);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 25);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add Screen";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // ManageCategoriesButton
            // 
            this.ManageCategoriesButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCategoriesButton.Location = new System.Drawing.Point(10, 165);
            this.ManageCategoriesButton.Name = "ManageCategoriesButton";
            this.ManageCategoriesButton.Size = new System.Drawing.Size(150, 25);
            this.ManageCategoriesButton.TabIndex = 5;
            this.ManageCategoriesButton.Text = "Manage Categories";
            this.ManageCategoriesButton.UseVisualStyleBackColor = true;
            this.ManageCategoriesButton.Click += new System.EventHandler(this.CategoryManagementButtonClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(10, 196);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(150, 25);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
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
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(10, 258);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 25);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit Screen";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(10, 289);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 25);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Screen";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
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
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.RegisterAccountButton);
            this.Controls.Add(this.ForgotPasswordButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ManageCategoriesButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MainScreenButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.UserProfileButton);
            this.Name = "TestScreen";
            this.ResumeLayout(false);

        }

        #endregion

    }

}
