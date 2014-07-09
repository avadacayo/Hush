using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hush;
using Hush.Client;

namespace Hush.Display.Interfaces
{
    class UserProfile : Interface
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label userProfile;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.ErrCurrentPasswordLabel = new System.Windows.Forms.Label();
            this.ErrNewPasswordLabel = new System.Windows.Forms.Label();
            this.ErrRepeatPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordChangedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(42, 353);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.ConfirmPasswordTextBox.TabIndex = 15;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(42, 303);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.NewPasswordTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Repeat Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Password";
            // 
            // CurrentPasswordLabel
            // 
            this.CurrentPasswordLabel.AutoSize = true;
            this.CurrentPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordLabel.Location = new System.Drawing.Point(42, 225);
            this.CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            this.CurrentPasswordLabel.Size = new System.Drawing.Size(160, 20);
            this.CurrentPasswordLabel.TabIndex = 6;
            this.CurrentPasswordLabel.Text = "Current Password";
            // 
            // CurrentPasswordTextBox
            // 
            this.CurrentPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordTextBox.Location = new System.Drawing.Point(42, 245);
            this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            this.CurrentPasswordTextBox.PasswordChar = '*';
            this.CurrentPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.CurrentPasswordTextBox.TabIndex = 8;
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
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.Location = new System.Drawing.Point(205, 188);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(175, 25);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 99);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(338, 28);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextBox.Location = new System.Drawing.Point(42, 153);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(338, 28);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 79);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(42, 133);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(96, 20);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(205, 389);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(175, 25);
            this.ChangePasswordButton.TabIndex = 17;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(201, 283);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(115, 15);
            this.PasswordStrengthLabel.TabIndex = 10;
            this.PasswordStrengthLabel.Text = " ";
            // 
            // ErrCurrentPasswordLabel
            // 
            this.ErrCurrentPasswordLabel.AutoSize = true;
            this.ErrCurrentPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrCurrentPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrCurrentPasswordLabel.Location = new System.Drawing.Point(210, 225);
            this.ErrCurrentPasswordLabel.Name = "ErrCurrentPasswordLabel";
            this.ErrCurrentPasswordLabel.Size = new System.Drawing.Size(170, 20);
            this.ErrCurrentPasswordLabel.TabIndex = 7;
            this.ErrCurrentPasswordLabel.Text = "Password incorrect";
            this.ErrCurrentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrCurrentPasswordLabel.Visible = false;
            // 
            // ErrNewPasswordLabel
            // 
           this.ErrNewPasswordLabel.AutoSize = true;
            this.ErrNewPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrNewPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrNewPasswordLabel.Location = new System.Drawing.Point(197, 283);
            this.ErrNewPasswordLabel.Name = "ErrNewPasswordLabel";
            this.ErrNewPasswordLabel.Size = new System.Drawing.Size(183, 20);
            this.ErrNewPasswordLabel.TabIndex = 11;
            this.ErrNewPasswordLabel.Text = "Enter new password";
            this.ErrNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrNewPasswordLabel.Visible = false;
            // 
            // ErrRepeatPasswordLabel
            // 
            this.ErrRepeatPasswordLabel.AutoSize = true;
            this.ErrRepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrRepeatPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrRepeatPasswordLabel.Location = new System.Drawing.Point(172, 333);
            this.ErrRepeatPasswordLabel.Name = "ErrRepeatPasswordLabel";
            this.ErrRepeatPasswordLabel.Size = new System.Drawing.Size(208, 20);
            this.ErrRepeatPasswordLabel.TabIndex = 14;
            this.ErrRepeatPasswordLabel.Text = "Passwords must match";
            this.ErrRepeatPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrRepeatPasswordLabel.Visible = false;
            // 
            // ConfirmPasswordChangedLabel
            // 
            this.ConfirmPasswordChangedLabel.AutoSize = true;
            this.ConfirmPasswordChangedLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordChangedLabel.Location = new System.Drawing.Point(42, 391);
            this.ConfirmPasswordChangedLabel.Name = "ConfirmPasswordChangedLabel";
            this.ConfirmPasswordChangedLabel.Size = new System.Drawing.Size(187, 20);
            this.ConfirmPasswordChangedLabel.TabIndex = 16;
            this.ConfirmPasswordChangedLabel.Text = "Password changed";
            this.ConfirmPasswordChangedLabel.Visible = false;
            // 
            // UserProfile
            // 
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
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            success = Client.DataManager.SaveUserProfileChanges(UsernameTextBox.Text, FullNameTextBox.Text);
            if (success)
            {
                // success msg
            }
            else
            {
                // error msg
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ConfirmPasswordChangedLabel.Visible = false;
            ErrCurrentPasswordLabel.Visible = false;
            ErrRepeatPasswordLabel.Visible = false;
            ErrNewPasswordLabel.Visible = false;
            ErrRepeatPasswordLabel.Visible = false;

            string result;
            result = Client.DataManager.SaveUserProfilePassword(CurrentPasswordTextBox.Text, NewPasswordTextBox.Text, ConfirmPasswordTextBox.Text);
            if (result == "password changed")
            {
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
            else if (result == "password blank")
            {
                ErrNewPasswordLabel.Visible = true;
            }
        }
    }
}
