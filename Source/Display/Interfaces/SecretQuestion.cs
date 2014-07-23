using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using System.Collections.Generic;
using Hush.Client;
using System.Text.RegularExpressions;
using Hush.Tools;
using System.IO;

namespace Hush.Display.Interfaces
{
    class SecretQuestion : Interface
    {
        private Label SecretQuestionLabel;
        private TextBox SecretAnswerTextBox;
        private Button SecretAnswerContinueButton;
        private Button SaveButton;
        private Label PasswordLabel;
        private Label RepeatPasswordLabel;
        private TextBox PasswordTextBox;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Button UsernameContinueButton;
        private Label PasswordStrengthLabel;
        private Label SecretQuestionHeaderLabel;
        private Button CancelButton;
        private TextBox SecretAnswerTextBox2;
        private Label SecretQuestionLabel2;
        private Label ErrPasswordLabel;
        private Label ErrUsernameLabel;
        private Label ErrSQ1Label;
        private TextBox RepeatPasswordTextBox;
    

        #region Designer
        protected override void Initialize(List<String> Title)
        {
            Title.Add ("Secret Question");

            base.Initialize(Title);

            SecretQuestionLabel.Visible = false;
            SecretAnswerTextBox.Visible = false;
            SecretQuestionLabel2.Visible = false;
            SecretAnswerTextBox2.Visible = false;
            SecretAnswerContinueButton.Visible = false;
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
            this.UsernameContinueButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SecretAnswerContinueButton = new System.Windows.Forms.Button();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox2 = new System.Windows.Forms.TextBox();
            this.SecretQuestionLabel2 = new System.Windows.Forms.Label();
            this.ErrPasswordLabel = new System.Windows.Forms.Label();
            this.ErrUsernameLabel = new System.Windows.Forms.Label();
            this.ErrSQ1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 8;
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
            this.SecretQuestionHeaderLabel.Size = new System.Drawing.Size(151, 18);
            this.SecretQuestionHeaderLabel.TabIndex = 12;
            this.SecretQuestionHeaderLabel.Text = "Reset Password";
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(296, 318);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(115, 15);
            this.PasswordStrengthLabel.TabIndex = 11;
            this.PasswordStrengthLabel.Text = " ";
            // 
            // UsernameContinueButton
            // 
            this.UsernameContinueButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameContinueButton.Location = new System.Drawing.Point(280, 105);
            this.UsernameContinueButton.Name = "UsernameContinueButton";
            this.UsernameContinueButton.Size = new System.Drawing.Size(100, 25);
            this.UsernameContinueButton.TabIndex = 1;
            this.UsernameContinueButton.Text = "Continue";
            this.UsernameContinueButton.UseVisualStyleBackColor = true;
            this.UsernameContinueButton.Click += new System.EventHandler(this.UsernameContinueButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 75);
            this.UsernameTextBox.MaxLength = 30;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(338, 24);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 55);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(121, 17);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Enter Username";
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(42, 384);
            this.RepeatPasswordTextBox.MaxLength = 30;
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(338, 24);
            this.RepeatPasswordTextBox.TabIndex = 6;
            this.RepeatPasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(42, 336);
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(338, 24);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(42, 364);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(129, 17);
            this.RepeatPasswordLabel.TabIndex = 5;
            this.RepeatPasswordLabel.Text = "Repeat Password";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(42, 318);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(109, 17);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "New Password";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(42, 420);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(338, 25);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save and Log In";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SecretAnswerContinueButton
            // 
            this.SecretAnswerContinueButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerContinueButton.Location = new System.Drawing.Point(280, 289);
            this.SecretAnswerContinueButton.Name = "SecretAnswerContinueButton";
            this.SecretAnswerContinueButton.Size = new System.Drawing.Size(100, 25);
            this.SecretAnswerContinueButton.TabIndex = 4;
            this.SecretAnswerContinueButton.Text = "Continue";
            this.SecretAnswerContinueButton.UseVisualStyleBackColor = true;
            this.SecretAnswerContinueButton.Click += new System.EventHandler(this.AnswersContinue_Click);
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(42, 184);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(338, 24);
            this.SecretAnswerTextBox.TabIndex = 2;
            // 
            // SecretQuestionLabel
            // 
            this.SecretQuestionLabel.AutoSize = true;
            this.SecretQuestionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel.Location = new System.Drawing.Point(42, 142);
            this.SecretQuestionLabel.MaximumSize = new System.Drawing.Size(330, 40);
            this.SecretQuestionLabel.MinimumSize = new System.Drawing.Size(330, 40);
            this.SecretQuestionLabel.Name = "SecretQuestionLabel";
            this.SecretQuestionLabel.Size = new System.Drawing.Size(330, 40);
            this.SecretQuestionLabel.TabIndex = 0;
            this.SecretQuestionLabel.Text = "Secret Question #1";
            this.SecretQuestionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SecretAnswerTextBox2
            // 
            this.SecretAnswerTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox2.Location = new System.Drawing.Point(43, 259);
            this.SecretAnswerTextBox2.Name = "SecretAnswerTextBox2";
            this.SecretAnswerTextBox2.Size = new System.Drawing.Size(338, 24);
            this.SecretAnswerTextBox2.TabIndex = 3;
            // 
            // SecretQuestionLabel2
            // 
            this.SecretQuestionLabel2.AutoSize = true;
            this.SecretQuestionLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel2.Location = new System.Drawing.Point(42, 218);
            this.SecretQuestionLabel2.MaximumSize = new System.Drawing.Size(330, 40);
            this.SecretQuestionLabel2.MinimumSize = new System.Drawing.Size(330, 40);
            this.SecretQuestionLabel2.Name = "SecretQuestionLabel2";
            this.SecretQuestionLabel2.Size = new System.Drawing.Size(330, 40);
            this.SecretQuestionLabel2.TabIndex = 17;
            this.SecretQuestionLabel2.Text = "Secret Question #2";
            this.SecretQuestionLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ErrPasswordLabel
            // 
            this.ErrPasswordLabel.AutoSize = true;
            this.ErrPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrPasswordLabel.Location = new System.Drawing.Point(42, 294);
            this.ErrPasswordLabel.Name = "ErrPasswordLabel";
            this.ErrPasswordLabel.Size = new System.Drawing.Size(44, 17);
            this.ErrPasswordLabel.TabIndex = 18;
            this.ErrPasswordLabel.Text = "Error";
            this.ErrPasswordLabel.Visible = false;
            // 
            // ErrUsernameLabel
            // 
            this.ErrUsernameLabel.AutoSize = true;
            this.ErrUsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrUsernameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrUsernameLabel.Location = new System.Drawing.Point(187, 55);
            this.ErrUsernameLabel.Name = "ErrUsernameLabel";
            this.ErrUsernameLabel.Size = new System.Drawing.Size(44, 17);
            this.ErrUsernameLabel.TabIndex = 19;
            this.ErrUsernameLabel.Text = "Error";
            this.ErrUsernameLabel.Visible = false;
            // 
            // ErrSQ1Label
            // 
            this.ErrSQ1Label.AutoSize = true;
            this.ErrSQ1Label.BackColor = System.Drawing.Color.Transparent;
            this.ErrSQ1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrSQ1Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrSQ1Label.Location = new System.Drawing.Point(42, 133);
            this.ErrSQ1Label.Name = "ErrSQ1Label";
            this.ErrSQ1Label.Size = new System.Drawing.Size(44, 17);
            this.ErrSQ1Label.TabIndex = 20;
            this.ErrSQ1Label.Text = "Error";
            this.ErrSQ1Label.Visible = false;
            // 
            // SecretQuestion
            // 
            this.Controls.Add(this.ErrSQ1Label);
            this.Controls.Add(this.ErrUsernameLabel);
            this.Controls.Add(this.ErrPasswordLabel);
            this.Controls.Add(this.SecretAnswerTextBox2);
            this.Controls.Add(this.SecretQuestionLabel2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SecretQuestionHeaderLabel);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.UsernameContinueButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SecretAnswerContinueButton);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.SecretQuestionLabel);
            this.Name = "SecretQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }   
        #endregion

        public override void PostInit()
        {
            base.PostInit();
            UsernameTextBox.Focus();
        }
        private void AnswersContinue_Click(object sender, EventArgs e)
        {
            if (new DataManager().LoadUser(UsernameTextBox.Text, "", SecretAnswerTextBox.Text + "\n" + SecretAnswerTextBox2.Text))
            {
                PasswordLabel.Visible = true;
                RepeatPasswordLabel.Visible = true;
                PasswordTextBox.Visible = true;
                RepeatPasswordTextBox.Visible = true;
                SaveButton.Visible = true;
                SecretAnswerTextBox.Enabled = false;
                SecretAnswerTextBox2.Enabled = false;
                SecretAnswerContinueButton.Enabled = false;
                ErrSQ1Label.Text = "";
            }

            else
            {
                ErrSQ1Label.Text = "*Please enter the correct answers";
                ErrSQ1Label.Visible = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String message = new CheckString().ValidPasswordCheck(UsernameTextBox.Text, PasswordTextBox.Text, RepeatPasswordTextBox.Text);

            if (message.Equals(""))
            {
                if (new DataManager().ChangePassword(UsernameTextBox.Text, PasswordTextBox.Text))
                {
                    MessageBox.Show("Password has been changed.");
                    new DataManager().SaveUser(DataHolder.CurrentUser);
                    Program.Window.ShowInterface(new MainScreen());
                }
            }

            else
            {
                ErrPasswordLabel.Text = message;
                ErrPasswordLabel.Visible = true;
            }
        }

        private void UsernameContinueButton_Click(object sender, EventArgs e)
        {
            List<String> Question;
            if (new CheckString().AccountExists(UsernameTextBox.Text.Trim()))
            {
                Question = new DataManager().GetSecretQuestion(UsernameTextBox.Text);

                SecretQuestionLabel.Visible = true;
                SecretAnswerTextBox.Visible = true;
                SecretAnswerContinueButton.Visible = true;
                SecretQuestionLabel2.Visible = true;
                SecretAnswerTextBox2.Visible = true;
                PasswordLabel.Visible = false;
                RepeatPasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;
                RepeatPasswordTextBox.Visible = false;
                SaveButton.Visible = false;
                SecretQuestionLabel.Text = Question[0];
                SecretQuestionLabel2.Text = Question[1];
                UsernameTextBox.Enabled = false;
                UsernameContinueButton.Enabled = false;
                ErrUsernameLabel.Text = "";
            }
            else
            {
                ErrUsernameLabel.Text = "*Username cannot be found";
                ErrUsernameLabel.Visible = true;
            }
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length > 0)
            {
                int x = new CheckString().PasswordStrength(PasswordTextBox.Text);
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

            if (PasswordTextBox.Text.Length > 0 && RepeatPasswordTextBox.Text.Length > 0)
            {
                SaveButton.Enabled = true;

            }
            else
                SaveButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new SignIn());
        }

    }
}
