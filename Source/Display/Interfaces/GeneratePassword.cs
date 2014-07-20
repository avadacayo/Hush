using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Security;
using System.Linq;

using Hush.Client;
using System.Text.RegularExpressions;
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

    class GeneratePassword : Interface
    {
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private Label label1;
        private Button CancelButton;
        private Label label2;
        private TextBox EnteredPasswordTextBox;
        private Label EnterPasswordLabel;
        private Label PasswordStrengthLabel;
        private Button GenerateButton;
        

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Generate Password");

            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnteredPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(43, 132);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(338, 91);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(42, 112);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Generated Password";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(137, 81);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(243, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthTextBox.Location = new System.Drawing.Point(43, 80);
            this.LengthTextBox.MaxLength = 3;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(76, 24);
            this.LengthTextBox.TabIndex = 8;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.Location = new System.Drawing.Point(42, 60);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(129, 17);
            this.LengthLabel.TabIndex = 9;
            this.LengthLabel.Text = "Password Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Generate Password";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password Strength";
            // 
            // EnteredPasswordTextBox
            // 
            this.EnteredPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteredPasswordTextBox.Location = new System.Drawing.Point(43, 304);
            this.EnteredPasswordTextBox.Multiline = true;
            this.EnteredPasswordTextBox.Name = "EnteredPasswordTextBox";
            this.EnteredPasswordTextBox.Size = new System.Drawing.Size(337, 59);
            this.EnteredPasswordTextBox.TabIndex = 15;
            this.EnteredPasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.AutoSize = true;
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPasswordLabel.Location = new System.Drawing.Point(42, 285);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(118, 17);
            this.EnterPasswordLabel.TabIndex = 16;
            this.EnterPasswordLabel.Text = "Enter Password";
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.AutoSize = true;
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(45, 379);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(0, 17);
            this.PasswordStrengthLabel.TabIndex = 17;
            // 
            // GeneratePassword
            // 
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.EnterPasswordLabel);
            this.Controls.Add(this.EnteredPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "GeneratePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public override void PostInit()
        {
            base.PostInit();
            LengthTextBox.Focus();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Int32 PwdLength = 8, NoOfSpecialChar = 0;
            String pattern = "^[0-9]+$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(LengthTextBox.Text) && Convert.ToInt32(LengthTextBox.Text) <= 128 && Convert.ToInt32(LengthTextBox.Text) > 0)
            {
                PwdLength = Convert.ToInt32(LengthTextBox.Text);
                PasswordTextBox.Text = Membership.GeneratePassword(PwdLength, NoOfSpecialChar);
            }
            else
            {
                String message = "";

                if (LengthTextBox.Text.Length <= 0)
                    message = "Please enter a value";

                else if(!regex.IsMatch(LengthTextBox.Text))
                    message = "Invalid input. Only numbers are allowed.";

                else if (Convert.ToInt32(LengthTextBox.Text) > 128 || Convert.ToInt32(LengthTextBox.Text) < 1)
                    message = "Please enter a number between 1 - 128.";

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


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.Close();
            //Program.Window.ShowInterface(new SignIn());
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            if (EnteredPasswordTextBox.Text.Length > 0)
            {
                int x = new CheckString().PasswordStrength(EnteredPasswordTextBox.Text);
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
    }

}
