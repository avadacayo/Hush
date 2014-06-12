using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using Hush.Client;

namespace Hush.Display.Interfaces
{
    class RegisterAccount : Interface
    {
        private Label ErrorMsgsLabel;
        private Label RegisterLabel;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label RepeatPasswordLabel;
        private TextBox RepeatPasswordTextBox;
        private Label SecretQuestionLabel;
        private TextBox SecretQuestionTextBox;
        private Label SecretAnswerLabel;
        private TextBox SecretAnswerTextBox;
        private Button RegisterButton;
        private Button CancelButton;
        private Label ErrFirstNameLabel;
        private Label ErrPasswordLabel;

        private void RegisterButtonClick(Object Sender, EventArgs Args)
        {
            //TODO: Finish error messages
            if (FirstNameTextBox.Text != "")
            {
                ErrFirstNameLabel.Text = "";
                ErrPasswordLabel.Text = "";
                if (new DataManager().UniqueAccount(FirstNameTextBox.Text))
                {
                    if (PasswordTextBox.Text != "" && PasswordTextBox.Text == RepeatPasswordTextBox.Text)
                    {
                        if (new DataManager().CreateAccount(FirstNameTextBox.Text, PasswordTextBox.Text, SecretQuestionTextBox.Text,
                            SecretAnswerTextBox.Text))
                        {
                            Program.Window.ShowInterface(new MainScreen());
                        }
                    }

                    else
                        ErrPasswordLabel.Text = "*Please make sure passwords are the same";
                }

                else
                    ErrFirstNameLabel.Text = "*FirstName has been used";
            }

            else
            {
                ErrFirstNameLabel.Text = "*Enter a username";
                if (!(PasswordTextBox.Text != "" && PasswordTextBox.Text == RepeatPasswordTextBox.Text))
                ErrPasswordLabel.Text = "";
            }
                return;
        }

        private void CancelButtonClick(Object Sender, EventArgs Args)
        {
           // this.Close();
        }
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Register");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SecretQuestionTextBox = new System.Windows.Forms.TextBox();
            this.SecretAnswerLabel = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErrorMsgsLabel = new System.Windows.Forms.Label();
            this.ErrFirstNameLabel = new System.Windows.Forms.Label();
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
            // FirstNameLabel
            // 
            this.FirstNameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(150, 130);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(300, 15);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Username";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(150, 150);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(300, 20);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // ErrFirstNameLabel
            // 
            this.ErrFirstNameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrFirstNameLabel.Location = new System.Drawing.Point(450, 150);
            this.ErrFirstNameLabel.Name = "ErrFirstNameLabel";
            this.ErrFirstNameLabel.Size = new System.Drawing.Size(300, 15);
            this.ErrFirstNameLabel.TabIndex = 3;
            this.ErrFirstNameLabel.Text = "";
            
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
            // 
            // ErrPasswordLabel
            // 
            this.ErrPasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrPasswordLabel.Location = new System.Drawing.Point(450, 200);
            this.ErrPasswordLabel.Name = "ErrPasswordLabel";
            this.ErrPasswordLabel.Size = new System.Drawing.Size(300, 15);
            this.ErrPasswordLabel.TabIndex = 3;
            this.ErrPasswordLabel.Text = "";
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
            this.RegisterButton.Click += RegisterButtonClick;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(148, 435);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(70, 30);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ErrorMsgsLabel
            // 
            this.ErrorMsgsLabel.Location = new System.Drawing.Point(147, 30);
            this.ErrorMsgsLabel.Name = "ErrorMsgsLabel";
            this.ErrorMsgsLabel.Size = new System.Drawing.Size(300, 80);
            this.ErrorMsgsLabel.TabIndex = 0;
            this.ErrorMsgsLabel.Text = "";
            // 
            // RegisterAccount
            // 
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.SecretQuestionLabel);
            this.Controls.Add(this.SecretQuestionTextBox);
            this.Controls.Add(this.SecretAnswerLabel);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ErrFirstNameLabel);
            this.Controls.Add(this.ErrPasswordLabel);
            this.Name = "RegisterAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
