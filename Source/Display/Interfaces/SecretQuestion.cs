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
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.AnswerQuestionButton = new System.Windows.Forms.Button();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecretQuestionLabel
            // 
            this.SecretQuestionLabel.AutoSize = true;
            this.SecretQuestionLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel.Location = new System.Drawing.Point(294, 199);
            this.SecretQuestionLabel.Name = "SecretQuestionLabel";
            this.SecretQuestionLabel.Size = new System.Drawing.Size(124, 13);
            this.SecretQuestionLabel.TabIndex = 0;
            this.SecretQuestionLabel.Text = "SecretQuestionLabel";
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(297, 217);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(331, 21);
            this.SecretAnswerTextBox.TabIndex = 1;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(297, 244);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.Continue_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(294, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(331, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save and Log In";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(294, 306);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "PasswordLabel";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(294, 362);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(131, 13);
            this.RepeatPasswordLabel.TabIndex = 5;
            this.RepeatPasswordLabel.Text = "RepeatPasswordLabel";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(297, 323);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(328, 21);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(297, 379);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(328, 21);
            this.RepeatPasswordTextBox.TabIndex = 7;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(294, 108);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 13);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "UsernameLabel";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(297, 124);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(328, 21);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // AnswerQuestionButton
            // 
            this.AnswerQuestionButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerQuestionButton.Location = new System.Drawing.Point(297, 151);
            this.AnswerQuestionButton.Name = "AnswerQuestionButton";
            this.AnswerQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.AnswerQuestionButton.TabIndex = 10;
            this.AnswerQuestionButton.Text = "Continue";
            this.AnswerQuestionButton.UseVisualStyleBackColor = true;
            this.AnswerQuestionButton.Click += new System.EventHandler(this.AnswerQuestionButton_Click);
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(548, 306);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(115, 15);
            this.PasswordStrengthLabel.TabIndex = 11;
            this.PasswordStrengthLabel.Text = " ";
            // 
            // SecretQuestion
            // 
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


    }
}
