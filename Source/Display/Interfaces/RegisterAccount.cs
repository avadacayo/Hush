using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using Hush.Client;
using System.Text.RegularExpressions;

namespace Hush.Display.Interfaces
{
    class RegisterAccount : Interface
    {
        private Label ErrorMsgsLabel;
        private Label RegisterLabel;
        private Label UsernameLabel;
        private Label PasswordStrengthLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label RepeatPasswordLabel;
        private TextBox RepeatPasswordTextBox;
        private Label SecretQuestionLabel;
        private TextBox SecretQuestionTextBox;
        private Label SecretAnswerLabel;
        private TextBox SecretAnswerTextBox;
        private Button RegisterButton;
        private Button SignInButton;
        private Label ErrUsernameLabel;
        private Label ErrPasswordLabel;

        private void RegisterButtonClick(Object Sender, EventArgs Args)
        {
            String pattern = "[a-zA-Z0-9]{3,15}$";
            Regex regex = new Regex(pattern);
            UsernameTextBox.Text = UsernameTextBox.Text.Trim();

            ErrUsernameLabel.Text = "";
            ErrPasswordLabel.Text = "";
            
            if (!regex.IsMatch(UsernameTextBox.Text))
                ErrUsernameLabel.Text = "*Enter a valid username. 5 - 25 characters";

            if (PasswordTextBox.Text.Length <= 5)
                ErrPasswordLabel.Text = "*Enter a valid password. 6-30 characters";
    
            if (!(PasswordTextBox.Text != "" && PasswordTextBox.Text == RepeatPasswordTextBox.Text))
                ErrPasswordLabel.Text = "*Passwords do not match";

            if (PasswordTextBox.Text.Equals(UsernameTextBox.Text))
                ErrPasswordLabel.Text = "*Password is the same as username";

            //TODO: Stop if weak password has been used?
            if (regex.IsMatch(UsernameTextBox.Text) && PasswordTextBox.Text.Length >= 6 
                && PasswordTextBox.Text == RepeatPasswordTextBox.Text
                && !PasswordTextBox.Text.Equals(UsernameTextBox.Text))
            {
                if (new DataManager().UniqueAccount(UsernameTextBox.Text))
                {

                    if (new DataManager().CreateAccount(UsernameTextBox.Text, PasswordTextBox.Text, SecretQuestionTextBox.Text,
                            SecretAnswerTextBox.Text))
                    {
                        Program.Window.ShowInterface(new MainScreen());
                    }
                }
                else
                    ErrUsernameLabel.Text = "*Username has been used";
            }
               
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

            if (UsernameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0 && RepeatPasswordTextBox.Text.Length > 0
                && SecretQuestionTextBox.Text.Length > 0 && SecretAnswerTextBox.Text.Length > 0)
            {
                RegisterButton.Enabled = true;
                               
            }
            else
                RegisterButton.Enabled = false;

        }

        private void SignInButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new SignIn());
            
        }

        #region Designer
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Register");
            base.Initialize(Title);
            RegisterButton.Enabled = false;
        }

        protected override void InitializeComponent()
        {
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SecretQuestionTextBox = new System.Windows.Forms.TextBox();
            this.SecretAnswerLabel = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.ErrorMsgsLabel = new System.Windows.Forms.Label();
            this.ErrUsernameLabel = new System.Windows.Forms.Label();
            this.ErrPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(145, 50);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(300, 40);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Register";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(150, 130);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(300, 15);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(150, 150);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(300, 20);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(378, 180);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(115, 15);
            this.PasswordStrengthLabel.TabIndex = 3;
            this.PasswordStrengthLabel.Text = " ";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(150, 180);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 200);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 20);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(150, 230);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.RepeatPasswordLabel.TabIndex = 5;
            this.RepeatPasswordLabel.Text = "Repeat Password";
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(150, 250);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(300, 20);
            this.RepeatPasswordTextBox.TabIndex = 6;
            this.RepeatPasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // SecretQuestionLabel
            // 
            this.SecretQuestionLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel.Location = new System.Drawing.Point(150, 280);
            this.SecretQuestionLabel.Name = "SecretQuestionLabel";
            this.SecretQuestionLabel.Size = new System.Drawing.Size(300, 15);
            this.SecretQuestionLabel.TabIndex = 7;
            this.SecretQuestionLabel.Text = "Secret Question";
            // 
            // SecretQuestionTextBox
            // 
            this.SecretQuestionTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionTextBox.Location = new System.Drawing.Point(150, 300);
            this.SecretQuestionTextBox.Name = "SecretQuestionTextBox";
            this.SecretQuestionTextBox.Size = new System.Drawing.Size(300, 20);
            this.SecretQuestionTextBox.TabIndex = 8;
            this.SecretQuestionTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // SecretAnswerLabel
            // 
            this.SecretAnswerLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerLabel.Location = new System.Drawing.Point(150, 330);
            this.SecretAnswerLabel.Name = "SecretAnswerLabel";
            this.SecretAnswerLabel.Size = new System.Drawing.Size(300, 15);
            this.SecretAnswerLabel.TabIndex = 9;
            this.SecretAnswerLabel.Text = "Answer";
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(150, 350);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(300, 20);
            this.SecretAnswerTextBox.TabIndex = 10;
            this.SecretAnswerTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(150, 390);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(300, 30);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(148, 435);
            this.SignInButton.Name = "CancelButton";
            this.SignInButton.Size = new System.Drawing.Size(70, 30);
            this.SignInButton.TabIndex = 12;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButtonClick);
            // 
            // ErrorMsgsLabel
            // 
            this.ErrorMsgsLabel.Location = new System.Drawing.Point(147, 30);
            this.ErrorMsgsLabel.Name = "ErrorMsgsLabel";
            this.ErrorMsgsLabel.Size = new System.Drawing.Size(300, 80);
            this.ErrorMsgsLabel.TabIndex = 0;
            // 
            // ErrUsernameLabel
            // 
            this.ErrUsernameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrUsernameLabel.Location = new System.Drawing.Point(450, 150);
            this.ErrUsernameLabel.Name = "ErrUsernameLabel";
            this.ErrUsernameLabel.Size = new System.Drawing.Size(300, 15);
            this.ErrUsernameLabel.TabIndex = 3;
            // 
            // ErrPasswordLabel
            // 
            this.ErrPasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrPasswordLabel.Location = new System.Drawing.Point(450, 200);
            this.ErrPasswordLabel.Name = "ErrPasswordLabel";
            this.ErrPasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.ErrPasswordLabel.TabIndex = 3;
            // 
            // RegisterAccount
            // 
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.SecretQuestionLabel);
            this.Controls.Add(this.SecretQuestionTextBox);
            this.Controls.Add(this.SecretAnswerLabel);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.ErrUsernameLabel);
            this.Controls.Add(this.ErrPasswordLabel);
            this.Name = "RegisterAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
#endregion
}
