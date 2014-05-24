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
<<<<<<< HEAD
            Title = "Register";
=======

            Title.Add("Register");

            Int32 Xoffset = -20;
>>>>>>> 10b793549ae8231aadebcf4b7164165c865c4a62
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

            //RegisterLabel.Font = GlobalFont; //TO DO: Add new font
            RegisterLabel.Location = new Point(145, 70);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(300, 40);
            RegisterLabel.Font = new Font("Arial", 27);
            RegisterLabel.Text = "Register";
            
            UsernameLabel.Font = GlobalFont;
            UsernameLabel.Location = new Point(150, 130);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(300, 15);
            UsernameLabel.Text = "Username";

            UsernameTextBox.Font = GlobalFont;
            UsernameTextBox.Location = new Point(150, 150);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(300, 40);

            RegisterLabel.Font = GlobalFont;
            PasswordLabel.Location = new Point(150, 180);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(300, 15);
            PasswordLabel.Text = "Password";

            PasswordTextBox.Font = GlobalFont;
            PasswordTextBox.Location = new Point(150, 200);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(300, 30);

            RepeatPasswordLabel.Font = GlobalFont;
            RepeatPasswordLabel.Location = new Point(150, 230);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(300, 15);
            RepeatPasswordLabel.Text = "Repeat Password";

            RepeatPasswordTextBox.Font = GlobalFont;
            RepeatPasswordTextBox.Location = new Point(150, 250);
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.PasswordChar = '*';
            RepeatPasswordTextBox.Size = new Size(300, 30);

            SecretQuestionLabel.Location = new Point(150, 280);
            SecretQuestionLabel.Name = "SecretQuestionLabel";
            SecretQuestionLabel.Size = new Size(300, 15);
            SecretQuestionLabel.Text = "Secret Question";

            SecretQuestionTextBox.Font = GlobalFont;
            SecretQuestionTextBox.Location = new Point(150, 300);
            SecretQuestionTextBox.Name = "SecretQuestionTextBox";
            SecretQuestionTextBox.Size = new Size(300, 30);

            SecretAnswerLabel.Font = GlobalFont;
            SecretAnswerLabel.Location = new Point(150, 330);
            SecretAnswerLabel.Name = "SecretAnswerLabel";
            SecretAnswerLabel.Size = new Size(300, 15);
            SecretAnswerLabel.Text = "Answer";

            SecretAnswerTextBox.Font = GlobalFont;
            SecretAnswerTextBox.Location = new Point(150, 350);
            SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            SecretAnswerTextBox.Size = new Size(300, 30);

            RegisterButton.Font = GlobalFont;
            RegisterButton.Location = new Point(150, 390);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(300, 30);
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;

            CancelButton.Font = GlobalFont;
            CancelButton.Location = new Point(150, 450);
            CancelButton.Name = "RegisterButton";
            CancelButton.Size = new Size(70, 30);
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
