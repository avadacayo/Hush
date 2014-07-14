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
        private Label ChooseOptionLabel;
        private Button CancelButton;
        private Button SecretQuestionButton;
    

        #region Designer
        protected override void Initialize(List<String> Title)
        {
           Title.Add ("Forgot Password");

           base.Initialize(Title);
           AlternatePasswordButton.Visible = false;
           PatternButton.Visible = false;
           ChooseOptionLabel.Visible = false;
        }

        protected override void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.ChooseOptionLabel = new System.Windows.Forms.Label();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.AlternatePasswordButton = new System.Windows.Forms.Button();
            this.PatternButton = new System.Windows.Forms.Button();
            this.SecretQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChooseOptionLabel
            // 
            this.ChooseOptionLabel.AutoSize = true;
            this.ChooseOptionLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOptionLabel.Location = new System.Drawing.Point(42, 96);
            this.ChooseOptionLabel.Name = "ChooseOptionLabel";
            this.ChooseOptionLabel.Size = new System.Drawing.Size(313, 18);
            this.ChooseOptionLabel.TabIndex = 1;
            this.ChooseOptionLabel.Text = "Choose one of the following options:";
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(40, 30);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(300, 40);
            this.ForgotPasswordLabel.TabIndex = 0;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            // 
            // AlternatePasswordButton
            // 
            this.AlternatePasswordButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternatePasswordButton.Location = new System.Drawing.Point(42, 140);
            this.AlternatePasswordButton.Name = "AlternatePasswordButton";
            this.AlternatePasswordButton.Size = new System.Drawing.Size(338, 30);
            this.AlternatePasswordButton.TabIndex = 2;
            this.AlternatePasswordButton.Text = "Provide Alternate Password";
            this.AlternatePasswordButton.UseVisualStyleBackColor = true;
            // 
            // PatternButton
            // 
            this.PatternButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatternButton.Location = new System.Drawing.Point(42, 190);
            this.PatternButton.Name = "PatternButton";
            this.PatternButton.Size = new System.Drawing.Size(338, 30);
            this.PatternButton.TabIndex = 3;
            this.PatternButton.Text = "Enter Password Pattern";
            this.PatternButton.UseVisualStyleBackColor = true;
            // 
            // SecretQuestionButton
            // 
            this.SecretQuestionButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionButton.Location = new System.Drawing.Point(42, 240);
            this.SecretQuestionButton.Name = "SecretQuestionButton";
            this.SecretQuestionButton.Size = new System.Drawing.Size(338, 30);
            this.SecretQuestionButton.TabIndex = 4;
            this.SecretQuestionButton.Text = "Answer Secret Question";
            this.SecretQuestionButton.UseVisualStyleBackColor = true;
            this.SecretQuestionButton.Click += new System.EventHandler(this.SecretQuestionButton_Click);
            // 
            // ForgotPassword
            // 
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChooseOptionLabel);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.AlternatePasswordButton);
            this.Controls.Add(this.PatternButton);
            this.Controls.Add(this.SecretQuestionButton);
            this.Name = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }   
        #endregion

        public override void PostInit()
        {
            base.PostInit();
            SecretQuestionButton.Focus();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new SignIn());
        }

        private void SecretQuestionButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new SecretQuestion());
        }

    }
}
