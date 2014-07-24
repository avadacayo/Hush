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
using Hush.Tools;

namespace Hush.Display.Interfaces
{
    class EditSecretQuestion : Interface
    {
        private Label EditQuestionsLabel;
        private Label SecretQuestionLabel;
        private TextBox SecretQuestionTextBox;
        private Label SecretAnswerLabel;
        private TextBox SecretAnswerTextBox;
        private Label SecretQuestionLabel2;
        private TextBox SecretQuestionTextBox2;
        private Label SecretAnswerLabel2;
        private TextBox SecretAnswerTextBox2;
        private Button SaveButton;
        private Label ErrorQuestion1Label;
        private Label ErrorAnswer1Label;
        private Label ErrorQuestion2Label;
        private Label ErrorAnswer2Label;
        private Label label1;
	    private Button CancelButton;

        private void SaveButton_Click(Object Sender, EventArgs Args)
        {
            string secretQuestion = SecretQuestionTextBox.Text.Trim();
            string secretQuestion2 = SecretQuestionTextBox2.Text.Trim();
            string secretAnswer = SecretAnswerTextBox.Text.Trim();
            string secretAnswer2 = SecretAnswerTextBox2.Text.Trim();

            SecretQuestionTextBox.Text = secretQuestion;
            SecretQuestionTextBox2.Text = secretQuestion2;
            SecretAnswerTextBox.Text = secretAnswer;
            SecretAnswerTextBox2.Text = secretAnswer2;

            String ErrQ1 = new CheckString().ValidateSecretQuestion(SecretQuestionTextBox.Text);
            String ErrSA1 = new CheckString().ValidateSecretAnswer(SecretAnswerTextBox.Text, DataHolder.CurrentUser.Username);
            String ErrQ2 = new CheckString().ValidateSecretQuestion(SecretQuestionTextBox2.Text);
            String ErrSA2 = new CheckString().ValidateSecretAnswer(SecretAnswerTextBox2.Text, DataHolder.CurrentUser.Username);

            ErrorQuestion1Label.Visible = true;
            ErrorQuestion2Label.Visible = true;
            ErrorAnswer1Label.Visible = true;
            ErrorAnswer2Label.Visible = true;

            ErrorQuestion1Label.Text = ErrQ1;
            ErrorQuestion2Label.Text = ErrQ2;
            ErrorAnswer1Label.Text = ErrSA1;
            ErrorAnswer2Label.Text = ErrSA2;
            //if (secretQuestion.Length == 0)
            //{
            //    ErrorQuestion1Label.Visible = true;
            //}
            //if (secretQuestion2.Length == 0)
            //{
            //    ErrorQuestion2Label.Visible = true;
            //}
            //if (secretAnswer.Length == 0)
            //{
            //    ErrorAnswer1Label.Visible = true;
            //}
            //if (secretAnswer2.Length == 0)
            //{
            //    ErrorAnswer2Label.Visible = true;
            //}
            if (ErrQ1.Equals("") && ErrSA1.Equals("") &&
                ErrQ2.Equals("") && ErrSA2.Equals(""))
            {
                DataManager.EditSecretQuestions(secretQuestion, secretQuestion2, secretAnswer, secretAnswer2);
                new DataManager().SaveUser(Client.DataHolder.CurrentUser);
                label1.Visible = true; 
            }

            else
            {
                ErrorQuestion1Label.Text = ErrQ1;
                ErrorQuestion2Label.Text = ErrQ2;
                ErrorAnswer1Label.Text = ErrSA1;
                ErrorAnswer2Label.Text = ErrSA2;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new UserProfile());
	    }

        #region Designer
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Edit Secret Questions");
            base.Initialize(Title);
            SecretQuestionTextBox.Text = DataHolder.CurrentUser.SecretQuestion;
            SecretAnswerTextBox.Text = DataHolder.CurrentUser.SecretAnswer;
            SecretQuestionTextBox2.Text = DataHolder.CurrentUser.SecretQuestion2;
            SecretAnswerTextBox2.Text = DataHolder.CurrentUser.SecretAnswer2;
        }

        public override void PostInit()
        {
            base.PostInit();
            SecretQuestionTextBox.Focus();
        }
        protected override void InitializeComponent()
        {
            this.SecretQuestionLabel2 = new System.Windows.Forms.Label();
            this.SecretQuestionTextBox2 = new System.Windows.Forms.TextBox();
            this.SecretAnswerLabel2 = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox2 = new System.Windows.Forms.TextBox();
            this.EditQuestionsLabel = new System.Windows.Forms.Label();
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SecretQuestionTextBox = new System.Windows.Forms.TextBox();
            this.SecretAnswerLabel = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ErrorQuestion1Label = new System.Windows.Forms.Label();
            this.ErrorAnswer1Label = new System.Windows.Forms.Label();
            this.ErrorQuestion2Label = new System.Windows.Forms.Label();
            this.ErrorAnswer2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecretQuestionLabel2
            // 
            this.SecretQuestionLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel2.Location = new System.Drawing.Point(42, 208);
            this.SecretQuestionLabel2.Name = "SecretQuestionLabel2";
            this.SecretQuestionLabel2.Size = new System.Drawing.Size(125, 20);
            this.SecretQuestionLabel2.TabIndex = 118;
            this.SecretQuestionLabel2.Text = "Question #2";
            // 
            // SecretQuestionTextBox2
            // 
            this.SecretQuestionTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionTextBox2.Location = new System.Drawing.Point(42, 228);
            this.SecretQuestionTextBox2.MaxLength = 70;
            this.SecretQuestionTextBox2.Name = "SecretQuestionTextBox2";
            this.SecretQuestionTextBox2.Size = new System.Drawing.Size(338, 28);
            this.SecretQuestionTextBox2.TabIndex = 5;
            // 
            // SecretAnswerLabel2
            // 
            this.SecretAnswerLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerLabel2.Location = new System.Drawing.Point(42, 262);
            this.SecretAnswerLabel2.Name = "SecretAnswerLabel2";
            this.SecretAnswerLabel2.Size = new System.Drawing.Size(111, 20);
            this.SecretAnswerLabel2.TabIndex = 119;
            this.SecretAnswerLabel2.Text = "Answer #2";
            // 
            // SecretAnswerTextBox2
            // 
            this.SecretAnswerTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox2.Location = new System.Drawing.Point(42, 282);
            this.SecretAnswerTextBox2.Name = "SecretAnswerTextBox2";
            this.SecretAnswerTextBox2.Size = new System.Drawing.Size(338, 28);
            this.SecretAnswerTextBox2.TabIndex = 6;
            // 
            // EditQuestionsLabel
            // 
            this.EditQuestionsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditQuestionsLabel.Location = new System.Drawing.Point(40, 30);
            this.EditQuestionsLabel.Name = "EditQuestionsLabel";
            this.EditQuestionsLabel.Size = new System.Drawing.Size(336, 40);
            this.EditQuestionsLabel.TabIndex = 120;
            this.EditQuestionsLabel.Text = "Edit Secret Questions";
            // 
            // SecretQuestionLabel
            // 
            this.SecretQuestionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel.Location = new System.Drawing.Point(42, 84);
            this.SecretQuestionLabel.Name = "SecretQuestionLabel";
            this.SecretQuestionLabel.Size = new System.Drawing.Size(125, 20);
            this.SecretQuestionLabel.TabIndex = 125;
            this.SecretQuestionLabel.Text = "Question #1";
            // 
            // SecretQuestionTextBox
            // 
            this.SecretQuestionTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionTextBox.Location = new System.Drawing.Point(42, 104);
            this.SecretQuestionTextBox.MaxLength = 70;
            this.SecretQuestionTextBox.Name = "SecretQuestionTextBox";
            this.SecretQuestionTextBox.Size = new System.Drawing.Size(338, 28);
            this.SecretQuestionTextBox.TabIndex = 3;
            // 
            // SecretAnswerLabel
            // 
            this.SecretAnswerLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerLabel.Location = new System.Drawing.Point(42, 138);
            this.SecretAnswerLabel.Name = "SecretAnswerLabel";
            this.SecretAnswerLabel.Size = new System.Drawing.Size(111, 20);
            this.SecretAnswerLabel.TabIndex = 126;
            this.SecretAnswerLabel.Text = "Answer #1";
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(42, 158);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(338, 28);
            this.SecretAnswerTextBox.TabIndex = 4;
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
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(215, 324);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(165, 30);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ErrorQuestion1Label
            // 
            this.ErrorQuestion1Label.AutoSize = true;
            this.ErrorQuestion1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorQuestion1Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorQuestion1Label.Location = new System.Drawing.Point(145, 82);
            this.ErrorQuestion1Label.Name = "ErrorQuestion1Label";
            this.ErrorQuestion1Label.Size = new System.Drawing.Size(223, 20);
            this.ErrorQuestion1Label.TabIndex = 127;
            this.ErrorQuestion1Label.Text = "Field must be completed";
            this.ErrorQuestion1Label.Visible = false;
            // 
            // ErrorAnswer1Label
            // 
            this.ErrorAnswer1Label.AutoSize = true;
            this.ErrorAnswer1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAnswer1Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorAnswer1Label.Location = new System.Drawing.Point(145, 138);
            this.ErrorAnswer1Label.Name = "ErrorAnswer1Label";
            this.ErrorAnswer1Label.Size = new System.Drawing.Size(223, 20);
            this.ErrorAnswer1Label.TabIndex = 128;
            this.ErrorAnswer1Label.Text = "Field must be completed";
            this.ErrorAnswer1Label.Visible = false;
            // 
            // ErrorQuestion2Label
            // 
            this.ErrorQuestion2Label.AutoSize = true;
            this.ErrorQuestion2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorQuestion2Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorQuestion2Label.Location = new System.Drawing.Point(145, 207);
            this.ErrorQuestion2Label.Name = "ErrorQuestion2Label";
            this.ErrorQuestion2Label.Size = new System.Drawing.Size(223, 20);
            this.ErrorQuestion2Label.TabIndex = 129;
            this.ErrorQuestion2Label.Text = "Field must be completed";
            this.ErrorQuestion2Label.Visible = false;
            // 
            // ErrorAnswer2Label
            // 
            this.ErrorAnswer2Label.AutoSize = true;
            this.ErrorAnswer2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAnswer2Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorAnswer2Label.Location = new System.Drawing.Point(145, 261);
            this.ErrorAnswer2Label.Name = "ErrorAnswer2Label";
            this.ErrorAnswer2Label.Size = new System.Drawing.Size(223, 20);
            this.ErrorAnswer2Label.TabIndex = 130;
            this.ErrorAnswer2Label.Text = "Field must be completed";
            this.ErrorAnswer2Label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 131;
            this.label1.Text = "Changes saved";
            this.label1.Visible = false;
            // 
            // EditSecretQuestion
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorAnswer2Label);
            this.Controls.Add(this.ErrorQuestion2Label);
            this.Controls.Add(this.ErrorAnswer1Label);
            this.Controls.Add(this.ErrorQuestion1Label);
            this.Controls.Add(this.SecretQuestionLabel2);
            this.Controls.Add(this.SecretQuestionTextBox2);
            this.Controls.Add(this.SecretAnswerLabel2);
            this.Controls.Add(this.SecretAnswerTextBox2);
            this.Controls.Add(this.EditQuestionsLabel);
            this.Controls.Add(this.SecretQuestionLabel);
            this.Controls.Add(this.SecretQuestionTextBox);
            this.Controls.Add(this.SecretAnswerLabel);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "EditSecretQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }




    }
#endregion
}
