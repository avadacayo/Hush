using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Hush;

namespace Hush.Display.Interfaces
{
    class RegisterAccount : Interface
    {
        private Label RegisterLabel;
        private Label UsernameLabel;
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
        private Button CancelButton;

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Register");

            Int32 Xoffset = -20;
            base.Initialize(Title);

            RegisterLabel = new Label();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            RepeatPasswordLabel = new Label();
            RepeatPasswordTextBox = new TextBox();
            SecretQuestionLabel = new Label();
            SecretQuestionTextBox = new TextBox();
            SecretAnswerLabel = new Label();
            SecretAnswerTextBox = new TextBox();
            RegisterButton = new Button();
            CancelButton = new Button();

            RegisterLabel.Location = new Point(165 + Xoffset, 70);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(300, 40);
            RegisterLabel.Font = new Font("Arial", 27);
            RegisterLabel.Text = "Register";

            UsernameLabel.Location = new Point(170 + Xoffset, 130);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(300, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";

            UsernameTextBox.Location = new Point(170 + Xoffset, 150);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(300, 40);
            UsernameTextBox.TabIndex = 1;

            PasswordLabel.Location = new Point(170 + Xoffset, 180);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(300, 15);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Password";

            PasswordTextBox.Location = new Point(170 + Xoffset, 200);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(300, 30);
            PasswordTextBox.TabIndex = 2;

            RepeatPasswordLabel.Location = new Point(170 + Xoffset, 230);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(300, 15);
            RepeatPasswordLabel.TabIndex = 0;
            RepeatPasswordLabel.Text = "Repeat Password";

            RepeatPasswordTextBox.Location = new Point(170 + Xoffset, 250);
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.PasswordChar = '*';
            RepeatPasswordTextBox.Size = new Size(300, 30);
            RepeatPasswordTextBox.TabIndex = 2;

            SecretQuestionLabel.Location = new Point(170 + Xoffset, 280);
            SecretQuestionLabel.Name = "SecretQuestionLabel";
            SecretQuestionLabel.Size = new Size(300, 15);
            SecretQuestionLabel.TabIndex = 0;
            SecretQuestionLabel.Text = "Secret Question";

            SecretQuestionTextBox.Location = new Point(170 + Xoffset, 300);
            SecretQuestionTextBox.Name = "SecretQuestionTextBox";
            SecretQuestionTextBox.Size = new Size(300, 30);
            SecretQuestionTextBox.TabIndex = 2;

            SecretAnswerLabel.Location = new Point(170 + Xoffset, 330);
            SecretAnswerLabel.Name = "SecretAnswerLabel";
            SecretAnswerLabel.Size = new Size(300, 15);
            SecretAnswerLabel.TabIndex = 0;
            SecretAnswerLabel.Text = "Answer";

            SecretAnswerTextBox.Location = new Point(170 + Xoffset, 350);
            SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            SecretAnswerTextBox.Size = new Size(300, 30);
            SecretAnswerTextBox.TabIndex = 2;

            RegisterButton.Location = new Point(170 + Xoffset, 390);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(300, 30);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;

            CancelButton.Location = new Point(170 + Xoffset, 450);
            CancelButton.Name = "RegisterButton";
            CancelButton.Size = new Size(70, 30);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;

            Controls.Add(RegisterLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(RepeatPasswordTextBox);
            Controls.Add(SecretQuestionLabel);
            Controls.Add(SecretQuestionTextBox);
            Controls.Add(SecretAnswerLabel);
            Controls.Add(SecretAnswerTextBox);
            Controls.Add(RegisterButton);
            Controls.Add(CancelButton);
        }
    }
}
