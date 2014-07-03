using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Security;
using System.Linq;

using Hush.Client;
using System.Text.RegularExpressions;

/*
 * 1. front end 
 * 2. model classes / minimal utilities (such as file / serialize)
 * 3. data manager
 * 
 * 
 */

namespace Hush.Display.Interfaces
{

    class GeneratePassword : Interface
    {
        private Label PasswordLengthLabel;
        private TextBox PasswordLengthTextBox;
        private TextBox SpecialCharactersTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label SpecialCharactersLabel;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private LinkLabel AddRecordLinkLabel;
        private Button GenerateButton;
        

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Sign In");

            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.PasswordLengthTextBox = new System.Windows.Forms.TextBox();
            this.SpecialCharactersTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SpecialCharactersLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.AddRecordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.Location = new System.Drawing.Point(0, 0);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(100, 23);
            this.PasswordLengthLabel.TabIndex = 0;
            // 
            // PasswordLengthTextBox
            // 
            this.PasswordLengthTextBox.Location = new System.Drawing.Point(0, 0);
            this.PasswordLengthTextBox.Name = "PasswordLengthTextBox";
            this.PasswordLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordLengthTextBox.TabIndex = 0;
            // 
            // SpecialCharactersTextBox
            // 
            this.SpecialCharactersTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialCharactersTextBox.Location = new System.Drawing.Point(307, 222);
            this.SpecialCharactersTextBox.Name = "SpecialCharactersTextBox";
            this.SpecialCharactersTextBox.Size = new System.Drawing.Size(300, 21);
            this.SpecialCharactersTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(307, 272);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 115);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(307, 252);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Generated Password";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(307, 393);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(300, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SpecialCharactersLabel
            // 
            this.SpecialCharactersLabel.AutoSize = true;
            this.SpecialCharactersLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialCharactersLabel.Location = new System.Drawing.Point(307, 206);
            this.SpecialCharactersLabel.Name = "SpecialCharactersLabel";
            this.SpecialCharactersLabel.Size = new System.Drawing.Size(234, 13);
            this.SpecialCharactersLabel.TabIndex = 7;
            this.SpecialCharactersLabel.Text = "Minimum Number of Special Characters";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthTextBox.Location = new System.Drawing.Point(307, 170);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(300, 21);
            this.LengthTextBox.TabIndex = 8;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.Location = new System.Drawing.Point(307, 151);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(103, 13);
            this.LengthLabel.TabIndex = 9;
            this.LengthLabel.Text = "Password Length";
            // 
            // AddRecordLinkLabel
            // 
            this.AddRecordLinkLabel.AutoSize = true;
            this.AddRecordLinkLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordLinkLabel.Location = new System.Drawing.Point(307, 455);
            this.AddRecordLinkLabel.Name = "AddRecordLinkLabel";
            this.AddRecordLinkLabel.Size = new System.Drawing.Size(64, 13);
            this.AddRecordLinkLabel.TabIndex = 10;
            this.AddRecordLinkLabel.TabStop = true;
            this.AddRecordLinkLabel.Text = "Use Password and add record";
            this.AddRecordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddRecordLinkLabel_LinkClicked);
            // 
            // GeneratePassword
            // 
            this.Controls.Add(this.AddRecordLinkLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.SpecialCharactersLabel);
            this.Controls.Add(this.SpecialCharactersTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "GeneratePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Int32 PwdLength = 8, NoOfSpecialChar = 2;
            String pattern = "^[0-9]+$";
            Regex regex = new Regex(pattern);

            Boolean test = regex.IsMatch(LengthTextBox.Text);
            Boolean test2 = regex.IsMatch(SpecialCharactersTextBox.Text);

            if (regex.IsMatch(LengthTextBox.Text) && regex.IsMatch(SpecialCharactersTextBox.Text))
            {
                PwdLength = Convert.ToInt32(LengthTextBox.Text);
                NoOfSpecialChar = Convert.ToInt32(SpecialCharactersTextBox.Text);
                PasswordTextBox.Text = Membership.GeneratePassword(PwdLength, NoOfSpecialChar);
            }
            else
            {
                String message = "";

                if (LengthTextBox.Text.Length <= 0 || SpecialCharactersTextBox.Text.Length <= 0)
                    message = "Please enter a value";

                else if(!regex.IsMatch(LengthTextBox.Text) || !regex.IsMatch(SpecialCharactersTextBox.Text))
                    message = "Invalid input. Only numbers are allowed.";

                    MessageBox.Show(message);
            }
        }

        private void AddRecordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataHolder.CurrentUser != null)
                Program.Window.ShowInterface(new Add());

            else
                Program.Window.ShowInterface(new SignIn());
        }
        
    }

}
