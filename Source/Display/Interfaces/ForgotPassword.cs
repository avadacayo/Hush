using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;

namespace Hush.Display.Interfaces
{
    class ForgotPassword : Interface
    {
        private Label ForgotPasswordLabel;
        private Button AlternatePasswordButton;
        private Button PatternButton;
        private Button SecretQuestionButton;
    

        #region Designer
        //protected override void Initialize(List<String> Title)
        protected override void Initialize(String Title)
        {
            //Title.Add ("Forgot Password");
            Title = "Forgot Password";
                
            base.Initialize(Title);

            ForgotPasswordLabel = new Label();
            AlternatePasswordButton = new Button();
            PatternButton = new Button();
            SecretQuestionButton = new Button();

            ForgotPasswordLabel.Location = new Point(145, 70);
            ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            ForgotPasswordLabel.Size = new Size(300, 40);
            ForgotPasswordLabel.Font = new Font("Arial", 27);
            ForgotPasswordLabel.Text = "Forgot Password";

            AlternatePasswordButton.Font = GlobalFont;
            AlternatePasswordButton.Location = new Point(150, 130);
            AlternatePasswordButton.Name = "AlternatePasswordButton";
            AlternatePasswordButton.Size = new Size(300, 30);
            AlternatePasswordButton.Text = "Provide Alternate Password";
            AlternatePasswordButton.UseVisualStyleBackColor = true;

            PatternButton.Font = GlobalFont;
            PatternButton.Location = new Point(150, 170);
            PatternButton.Name = "PatternButton";
            PatternButton.Size = new Size(300, 30);
            PatternButton.Text = "Enter Password Pattern";
            PatternButton.UseVisualStyleBackColor = true;

            SecretQuestionButton.Font = GlobalFont;
            SecretQuestionButton.Location = new Point(150, 210);
            SecretQuestionButton.Name = "SecretQuestionButton";
            SecretQuestionButton.Size = new Size(300, 30);
            SecretQuestionButton.Text = "Answer Secret Question";
            SecretQuestionButton.UseVisualStyleBackColor = true;

            Controls.Add(ForgotPasswordLabel);
            Controls.Add(AlternatePasswordButton);
            Controls.Add(PatternButton);
            Controls.Add(SecretQuestionButton);

        }   
        #endregion

    }
}
