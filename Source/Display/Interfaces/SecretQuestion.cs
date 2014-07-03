using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using System.Collections.Generic;
using Hush.Client;
using System.Text.RegularExpressions;

namespace Hush.Display.Interfaces
{
    class SecretQuestion : Interface
    {
        private Label SecretQuestionLabel;
        private TextBox SecretAnswerTextBox;
        private Button ContinueButton;
        private Button SaveButton;
        private Label PasswordLabel;
        private Label RepeatPasswordLabel;
        private TextBox PasswordTextBox;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Button AnswerQuestionButton;
        private Label PasswordStrengthLabel;
        private Label SecretQuestionHeaderLabel;
        private Button CancelButton;
        private TextBox RepeatPasswordTextBox;
    

        #region Designer
        protected override void Initialize(List<String> Title)
        {
            Title.Add ("Secret Question");

            base.Initialize(Title);

            SecretQuestionLabel.Visible = false;
            SecretAnswerTextBox.Visible = false;
            ContinueButton.Visible = false;
            PasswordLabel.Visible = false;
            RepeatPasswordLabel.Visible = false;
            PasswordTextBox.Visible = false;
            RepeatPasswordTextBox.Visible = false;
            SaveButton.Visible = false;
            SaveButton.Enabled = false;
        }

        protected override void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.SecretQuestionHeaderLabel = new System.Windows.Forms.Label();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.AnswerQuestionButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SecretQuestionHeaderLabel
            // 
            this.SecretQuestionHeaderLabel.AutoSize = true;
            this.SecretQuestionHeaderLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionHeaderLabel.Location = new System.Drawing.Point(40, 30);
            this.SecretQuestionHeaderLabel.Name = "SecretQuestionHeaderLabel";
            this.SecretQuestionHeaderLabel.Size = new System.Drawing.Size(192, 25);
            this.SecretQuestionHeaderLabel.TabIndex = 12;
            this.SecretQuestionHeaderLabel.Text = "Reset Password";
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(296, 271);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(115, 15);
            this.PasswordStrengthLabel.TabIndex = 11;
            this.PasswordStrengthLabel.Text = " ";
            // 
            // AnswerQuestionButton
            // 
            this.AnswerQuestionButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerQuestionButton.Location = new System.Drawing.Point(280, 113);
            this.AnswerQuestionButton.Name = "AnswerQuestionButton";
            this.AnswerQuestionButton.Size = new System.Drawing.Size(100, 25);
            this.AnswerQuestionButton.TabIndex = 10;
            this.AnswerQuestionButton.Text = "Continue";
            this.AnswerQuestionButton.UseVisualStyleBackColor = true;
            this.AnswerQuestionButton.Click += new System.EventHandler(this.AnswerQuestionButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 83);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(338, 28);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 63);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(147, 20);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Enter Username";
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(42, 344);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.RepeatPasswordTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(42, 289);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(338, 28);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(42, 324);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(155, 20);
            this.RepeatPasswordLabel.TabIndex = 5;
            this.RepeatPasswordLabel.Text = "Repeat Password";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(42, 271);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(132, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "New Password";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(42, 380);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(338, 25);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save and Log In";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(280, 218);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(100, 25);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.Continue_Click);
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(42, 184);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(338, 28);
            this.SecretAnswerTextBox.TabIndex = 1;
            // 
            // SecretQuestionLabel
            // 
            this.SecretQuestionLabel.AutoSize = true;
            this.SecretQuestionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel.Location = new System.Drawing.Point(41, 161);
            this.SecretQuestionLabel.Name = "SecretQuestionLabel";
            this.SecretQuestionLabel.Size = new System.Drawing.Size(146, 20);
            this.SecretQuestionLabel.TabIndex = 0;
            this.SecretQuestionLabel.Text = "Secret Question";
            // 
            // SecretQuestion
            // 
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SecretQuestionHeaderLabel);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.AnswerQuestionButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.SecretQuestionLabel);
            this.Name = "SecretQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }   
        #endregion

        private void Continue_Click(object sender, EventArgs e)
        {
            if ((new DataManager().CheckSecretAnswer(UsernameTextBox.Text, SecretAnswerTextBox.Text)))
            {
                PasswordLabel.Visible = true;
                RepeatPasswordLabel.Visible = true;
                PasswordTextBox.Visible = true;
                RepeatPasswordTextBox.Visible = true;
                SaveButton.Visible = true;
            }

            else
                MessageBox.Show("Please enter the correct answer");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String pattern = "[a-zA-Z0-9]{3,15}$",
                   message = "";
            Regex regex = new Regex(pattern);

            if (PasswordTextBox.Text.Length <= 5)
                message = "*Enter a valid password. 6-30 characters";

            if (!(PasswordTextBox.Text != "" && PasswordTextBox.Text == RepeatPasswordTextBox.Text))
                message = "*Passwords do not match";


            if (PasswordTextBox.Text.Length >= 6
                && PasswordTextBox.Text == RepeatPasswordTextBox.Text
                && !PasswordTextBox.Text.Equals(DataHolder.CurrentUser.Username))
            {


                if (new DataManager().ForgotPassword(UsernameTextBox.Text, PasswordTextBox.Text))
                {
                    MessageBox.Show("Password has been changed.");
                    Program.Window.ShowInterface(new MainScreen());
                }

                else
                    MessageBox.Show("Password is the same as username.");

            }

            else
                MessageBox.Show(message);
        }

        private void AnswerQuestionButton_Click(object sender, EventArgs e)
        {
            String Question = new DataManager().GetSecretQuestion(UsernameTextBox.Text);

            if (!Question.Equals(""))
            {
                SecretQuestionLabel.Visible = true;
                SecretAnswerTextBox.Visible = true;
                ContinueButton.Visible = true;
                PasswordLabel.Visible = false;
                RepeatPasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;
                RepeatPasswordTextBox.Visible = false;
                SaveButton.Visible = false;
                SecretQuestionLabel.Text = Question;
            }

            else
                MessageBox.Show("Username cannot be found");
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length > 0)
            {
                int x = new DataManager().PasswordStrength(PasswordTextBox.Text);
                if (x <= 0)
                    PasswordStrengthLabel.Text = "  Very weak";

                else if (x == 1)
                    PasswordStrengthLabel.Text = "         Weak";

                else if (x == 2)
                    PasswordStrengthLabel.Text = "            Fair";

                else if (x == 3)
                    PasswordStrengthLabel.Text = "        Strong";

                else if (x == 4)
                    PasswordStrengthLabel.Text = "Very Strong";
            }

            if (PasswordTextBox.Text.Length > 0 && RepeatPasswordTextBox.Text.Length > 0)
            {
                SaveButton.Enabled = true;

            }
            else
                SaveButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

    }
}
