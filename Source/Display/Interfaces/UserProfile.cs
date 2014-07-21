using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hush;
using Hush.Client;
using Hush.Tools;

namespace Hush.Display.Interfaces
{
    class UserProfile : Interface
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label userProfile;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label UserProfileLabel;
        private System.Windows.Forms.TextBox CurrentPasswordTextBox;
        private System.Windows.Forms.Label CurrentPasswordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Label PasswordStrengthLabel;
        private System.Windows.Forms.Label ErrCurrentPasswordLabel;
        private System.Windows.Forms.Label ErrNewPasswordLabel;
        private System.Windows.Forms.Label ErrRepeatPasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordChangedLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label ErrUsernameLabel;
        private System.Windows.Forms.Label ErrFirstNameLabel;
        private System.Windows.Forms.Label ErrLastNameLabel;
        private System.Windows.Forms.Label ConfirmUserChangedLabel;
        private System.Windows.Forms.Label ErrNewPasswordUserLabel;
        private System.Windows.Forms.LinkLabel SecretQuestionsLinkLabel;
        private System.Windows.Forms.Button CancelButton;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("User Profile");
            base.Initialize(Title);

            UsernameTextBox.Text = DataHolder.CurrentUser.Username;

        }

        protected override void InitializeComponent()
        {
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentPasswordLabel = new System.Windows.Forms.Label();
            this.CurrentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserProfileLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.ErrCurrentPasswordLabel = new System.Windows.Forms.Label();
            this.ErrNewPasswordLabel = new System.Windows.Forms.Label();
            this.ErrRepeatPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordChangedLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.ErrUsernameLabel = new System.Windows.Forms.Label();
            this.ErrFirstNameLabel = new System.Windows.Forms.Label();
            this.ErrLastNameLabel = new System.Windows.Forms.Label();
            this.ConfirmUserChangedLabel = new System.Windows.Forms.Label();
            this.ErrNewPasswordUserLabel = new System.Windows.Forms.Label();
            this.SecretQuestionsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(42, 380);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.ConfirmPasswordTextBox.TabIndex = 20;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(42, 330);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.NewPasswordTextBox.TabIndex = 17;
            this.NewPasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repeat Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "New Password";
            // 
            // CurrentPasswordLabel
            // 
            this.CurrentPasswordLabel.AutoSize = true;
            this.CurrentPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordLabel.Location = new System.Drawing.Point(42, 252);
            this.CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            this.CurrentPasswordLabel.Size = new System.Drawing.Size(160, 20);
            this.CurrentPasswordLabel.TabIndex = 12;
            this.CurrentPasswordLabel.Text = "Current Password";
            // 
            // CurrentPasswordTextBox
            // 
            this.CurrentPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordTextBox.Location = new System.Drawing.Point(42, 272);
            this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            this.CurrentPasswordTextBox.PasswordChar = '*';
            this.CurrentPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.CurrentPasswordTextBox.TabIndex = 14;
            // 
            // UserProfileLabel
            // 
            this.UserProfileLabel.AutoSize = true;
            this.UserProfileLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfileLabel.Location = new System.Drawing.Point(40, 30);
            this.UserProfileLabel.Name = "UserProfileLabel";
            this.UserProfileLabel.Size = new System.Drawing.Size(144, 25);
            this.UserProfileLabel.TabIndex = 0;
            this.UserProfileLabel.Text = "User Profile";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.Location = new System.Drawing.Point(205, 219);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(175, 25);
            this.SaveChangesButton.TabIndex = 11;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 80);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(338, 28);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(42, 132);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(338, 28);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 58);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(42, 112);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(103, 20);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(205, 416);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(175, 25);
            this.ChangePasswordButton.TabIndex = 22;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(201, 310);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(115, 15);
            this.PasswordStrengthLabel.TabIndex = 25;
            this.PasswordStrengthLabel.Text = " ";
            // 
            // ErrCurrentPasswordLabel
            // 
            this.ErrCurrentPasswordLabel.AutoSize = true;
            this.ErrCurrentPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrCurrentPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrCurrentPasswordLabel.Location = new System.Drawing.Point(210, 252);
            this.ErrCurrentPasswordLabel.Name = "ErrCurrentPasswordLabel";
            this.ErrCurrentPasswordLabel.Size = new System.Drawing.Size(170, 20);
            this.ErrCurrentPasswordLabel.TabIndex = 13;
            this.ErrCurrentPasswordLabel.Text = "Password incorrect";
            this.ErrCurrentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrCurrentPasswordLabel.Visible = false;
            // 
            // ErrNewPasswordLabel
            // 
            this.ErrNewPasswordLabel.AutoSize = true;
            this.ErrNewPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrNewPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrNewPasswordLabel.Location = new System.Drawing.Point(197, 310);
            this.ErrNewPasswordLabel.Name = "ErrNewPasswordLabel";
            this.ErrNewPasswordLabel.Size = new System.Drawing.Size(183, 20);
            this.ErrNewPasswordLabel.TabIndex = 16;
            this.ErrNewPasswordLabel.Text = "Enter new password";
            this.ErrNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrNewPasswordLabel.Visible = false;
            // 
            // ErrRepeatPasswordLabel
            // 
            this.ErrRepeatPasswordLabel.AutoSize = true;
            this.ErrRepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrRepeatPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrRepeatPasswordLabel.Location = new System.Drawing.Point(172, 360);
            this.ErrRepeatPasswordLabel.Name = "ErrRepeatPasswordLabel";
            this.ErrRepeatPasswordLabel.Size = new System.Drawing.Size(208, 20);
            this.ErrRepeatPasswordLabel.TabIndex = 19;
            this.ErrRepeatPasswordLabel.Text = "Passwords must match";
            this.ErrRepeatPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrRepeatPasswordLabel.Visible = false;
            // 
            // ConfirmPasswordChangedLabel
            // 
            this.ConfirmPasswordChangedLabel.AutoSize = true;
            this.ConfirmPasswordChangedLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordChangedLabel.Location = new System.Drawing.Point(42, 418);
            this.ConfirmPasswordChangedLabel.Name = "ConfirmPasswordChangedLabel";
            this.ConfirmPasswordChangedLabel.Size = new System.Drawing.Size(187, 20);
            this.ConfirmPasswordChangedLabel.TabIndex = 21;
            this.ConfirmPasswordChangedLabel.Text = "Password changed";
            this.ConfirmPasswordChangedLabel.Visible = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(42, 166);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(100, 20);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(42, 186);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(338, 28);
            this.LastNameTextBox.TabIndex = 9;
            // 
            // ErrUsernameLabel
            // 
            this.ErrUsernameLabel.AutoSize = true;
            this.ErrUsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrUsernameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrUsernameLabel.Location = new System.Drawing.Point(143, 58);
            this.ErrUsernameLabel.Name = "ErrUsernameLabel";
            this.ErrUsernameLabel.Size = new System.Drawing.Size(61, 20);
            this.ErrUsernameLabel.TabIndex = 2;
            this.ErrUsernameLabel.Text = "label1";
            this.ErrUsernameLabel.Visible = false;
            // 
            // ErrFirstNameLabel
            // 
            this.ErrFirstNameLabel.AutoSize = true;
            this.ErrFirstNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrFirstNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrFirstNameLabel.Location = new System.Drawing.Point(143, 112);
            this.ErrFirstNameLabel.Name = "ErrFirstNameLabel";
            this.ErrFirstNameLabel.Size = new System.Drawing.Size(61, 20);
            this.ErrFirstNameLabel.TabIndex = 5;
            this.ErrFirstNameLabel.Text = "label4";
            this.ErrFirstNameLabel.Visible = false;
            // 
            // ErrLastNameLabel
            // 
            this.ErrLastNameLabel.AutoSize = true;
            this.ErrLastNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLastNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrLastNameLabel.Location = new System.Drawing.Point(140, 166);
            this.ErrLastNameLabel.Name = "ErrLastNameLabel";
            this.ErrLastNameLabel.Size = new System.Drawing.Size(61, 20);
            this.ErrLastNameLabel.TabIndex = 8;
            this.ErrLastNameLabel.Text = "label5";
            this.ErrLastNameLabel.Visible = false;
            // 
            // ConfirmUserChangedLabel
            // 
            this.ConfirmUserChangedLabel.AutoSize = true;
            this.ConfirmUserChangedLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmUserChangedLabel.Location = new System.Drawing.Point(42, 219);
            this.ConfirmUserChangedLabel.Name = "ConfirmUserChangedLabel";
            this.ConfirmUserChangedLabel.Size = new System.Drawing.Size(67, 20);
            this.ConfirmUserChangedLabel.TabIndex = 10;
            this.ConfirmUserChangedLabel.Text = "label6";
            this.ConfirmUserChangedLabel.Visible = false;
            // 
            // ErrNewPasswordUserLabel
            // 
            this.ErrNewPasswordUserLabel.AutoSize = true;
            this.ErrNewPasswordUserLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrNewPasswordUserLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrNewPasswordUserLabel.Location = new System.Drawing.Point(178, 310);
            this.ErrNewPasswordUserLabel.Name = "ErrNewPasswordUserLabel";
            this.ErrNewPasswordUserLabel.Size = new System.Drawing.Size(238, 20);
            this.ErrNewPasswordUserLabel.TabIndex = 26;
            this.ErrNewPasswordUserLabel.Text = "Must differ from username";
            this.ErrNewPasswordUserLabel.Visible = false;
            // 
            // SecretQuestionsLinkLabel
            // 
            this.SecretQuestionsLinkLabel.AutoSize = true;
            this.SecretQuestionsLinkLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionsLinkLabel.Location = new System.Drawing.Point(45, 447);
            this.SecretQuestionsLinkLabel.MaximumSize = new System.Drawing.Size(150, 45);
            this.SecretQuestionsLinkLabel.Name = "SecretQuestionsLinkLabel";
            this.SecretQuestionsLinkLabel.Size = new System.Drawing.Size(129, 45);
            this.SecretQuestionsLinkLabel.TabIndex = 27;
            this.SecretQuestionsLinkLabel.TabStop = true;
            this.SecretQuestionsLinkLabel.Text = "View/Change Secret Questions";
            this.SecretQuestionsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SecretQuestionsLinkLabel_LinkClicked);
            // 
            // UserProfile
            // 
            this.Controls.Add(this.SecretQuestionsLinkLabel);
            this.Controls.Add(this.ErrNewPasswordUserLabel);
            this.Controls.Add(this.ConfirmUserChangedLabel);
            this.Controls.Add(this.ErrLastNameLabel);
            this.Controls.Add(this.ErrFirstNameLabel);
            this.Controls.Add(this.ErrUsernameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.ConfirmPasswordChangedLabel);
            this.Controls.Add(this.ErrRepeatPasswordLabel);
            this.Controls.Add(this.ErrNewPasswordLabel);
            this.Controls.Add(this.ErrCurrentPasswordLabel);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPasswordLabel);
            this.Controls.Add(this.CurrentPasswordTextBox);
            this.Controls.Add(this.UserProfileLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public override void PostInit()
        {
            base.PostInit();
            UsernameTextBox.Focus();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            bool result = true;
            bool change = false;

            ErrUsernameLabel.Visible = false;
            ErrFirstNameLabel.Visible = false;
            ErrLastNameLabel.Visible = false;
            ConfirmUserChangedLabel.Visible = false;
            
            string username = UsernameTextBox.Text.Trim();
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();

            UsernameTextBox.Text = username;
            FirstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;

            if (username != DataHolder.CurrentUser.Username)
            {
                if (!(new CheckString().AccountExists(username)))
                {
                    ErrUsernameLabel.Text = "Username already exists";
                    ErrUsernameLabel.Visible = true;
                    result = false;
                }
                else if (!DataManager.ValidateUsernameLength(username))
                {
                    ErrUsernameLabel.Text = "Username must be 3-25 characters";
                    ErrUsernameLabel.Visible = true;
                    result = false;
                }

                change = true;
            }

            if (firstName != DataHolder.CurrentUser.FirstName)
            {
                if (!DataManager.ValidateFirstName(firstName))
                {
                    ErrFirstNameLabel.Text = "Must be 2-25 alphabetic characters";
                    ErrFirstNameLabel.Visible = true;
                    result = false;
                }

                change = true;
            }

            if (lastName != DataHolder.CurrentUser.LastName)
            {
                if (!DataManager.ValidateLastName(lastName))
                {
                    ErrLastNameLabel.Text = "Must be 2-25 alphabetic characters";
                    ErrLastNameLabel.Visible = true;
                    result = false;
                }

                change = true;
            }

            if (!change)
            {
                ConfirmUserChangedLabel.Text = "No changes made";
                ConfirmUserChangedLabel.Visible = true;
            }
            else if (result)
            {
                DataManager.SaveUserProfileChanges(username, firstName, lastName);
                new Client.DataManager().SaveUser(Client.DataHolder.CurrentUser);
                ConfirmUserChangedLabel.Text = "Changes saved";
                ConfirmUserChangedLabel.Visible = true;
                
            }
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text.Length > 0)
            {
                
                int x = new CheckString().PasswordStrength(NewPasswordTextBox.Text);
                if (x <= 0)
                {
                    PasswordStrengthLabel.Text = "Very weak";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Crimson;
                }
                else if (x == 1)
                {
                    PasswordStrengthLabel.Text = "Weak";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                }
                else if (x == 2)
                {
                    PasswordStrengthLabel.Text = "Fair";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Gold;
                }
                else if (x == 3)
                {
                    PasswordStrengthLabel.Text = "Strong";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.YellowGreen;
                }
                else if (x == 4)
                {
                    PasswordStrengthLabel.Text = "Very Strong";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                }
            }

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ConfirmPasswordChangedLabel.Visible = false;
            ErrCurrentPasswordLabel.Visible = false;
            ErrRepeatPasswordLabel.Visible = false;
            ErrNewPasswordLabel.Visible = false;
            ErrRepeatPasswordLabel.Visible = false;
            ErrNewPasswordUserLabel.Visible = false;

            NewPasswordTextBox.Text = NewPasswordTextBox.Text.Trim();
            
            string result;
            result = Client.DataManager.SaveUserProfilePassword(CurrentPasswordTextBox.Text, NewPasswordTextBox.Text, ConfirmPasswordTextBox.Text);
            if (result == "password changed")
            {
                DataHolder.CurrentUser.Password = NewPasswordTextBox.Text;
                new Client.DataManager().SaveUser(Client.DataHolder.CurrentUser);
                // success stuff
                ConfirmPasswordChangedLabel.Visible = true;
            }
            else if (result == "new passwords don't match")
            {
                // fail stuff
                ErrRepeatPasswordLabel.Visible = true;
            }
            else if (result == "password incorrect")
            {
                // fail stuff
                ErrCurrentPasswordLabel.Visible = true;
            }
            else if (result == "password length")
            {
                ErrNewPasswordLabel.Visible = true;
            }
            else if (result == "matches username")
            {
                ErrNewPasswordUserLabel.Visible = true;
            }
        }

        private void SecretQuestionsLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Program.Window.ShowInterface(new EditSecretQuestion());
        }

    }
}
