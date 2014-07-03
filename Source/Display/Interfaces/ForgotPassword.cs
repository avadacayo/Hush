using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using System.Collections.Generic;

namespace Hush.Display.Interfaces
{
    class ForgotPassword : Interface
    {
        private Label ForgotPasswordLabel;
        private Button AlternatePasswordButton;
        private Button PatternButton;
        private Button SecretQuestionButton;
    

        #region Designer
        protected override void Initialize(List<String> Title)
        {
           Title.Add ("Forgot Password");

           base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.AlternatePasswordButton = new System.Windows.Forms.Button();
            this.PatternButton = new System.Windows.Forms.Button();
            this.SecretQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(145, 70);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(300, 40);
            this.ForgotPasswordLabel.TabIndex = 0;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            // 
            // AlternatePasswordButton
            // 
            this.AlternatePasswordButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternatePasswordButton.Location = new System.Drawing.Point(305, 173);
            this.AlternatePasswordButton.Name = "AlternatePasswordButton";
            this.AlternatePasswordButton.Size = new System.Drawing.Size(300, 30);
            this.AlternatePasswordButton.TabIndex = 1;
            this.AlternatePasswordButton.Text = "Provide Alternate Password";
            this.AlternatePasswordButton.UseVisualStyleBackColor = true;
            // 
            // PatternButton
            // 
            this.PatternButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatternButton.Location = new System.Drawing.Point(305, 211);
            this.PatternButton.Name = "PatternButton";
            this.PatternButton.Size = new System.Drawing.Size(300, 30);
            this.PatternButton.TabIndex = 2;
            this.PatternButton.Text = "Enter Password Pattern";
            this.PatternButton.UseVisualStyleBackColor = true;
            // 
            // SecretQuestionButton
            // 
            this.SecretQuestionButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionButton.Location = new System.Drawing.Point(305, 249);
            this.SecretQuestionButton.Name = "SecretQuestionButton";
            this.SecretQuestionButton.Size = new System.Drawing.Size(300, 30);
            this.SecretQuestionButton.TabIndex = 3;
            this.SecretQuestionButton.Text = "Answer Secret Question";
            this.SecretQuestionButton.UseVisualStyleBackColor = true;
            this.SecretQuestionButton.Click += new System.EventHandler(this.SecretQuestionButton_Click);
            // 
            // ForgotPassword
            // 
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.AlternatePasswordButton);
            this.Controls.Add(this.PatternButton);
            this.Controls.Add(this.SecretQuestionButton);
            this.Name = "ForgotPassword";
            this.ResumeLayout(false);

        }   
        #endregion

        private void SecretQuestionButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new SecretQuestion());
        }

    }
}
