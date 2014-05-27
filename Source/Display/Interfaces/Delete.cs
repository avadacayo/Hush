using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using System.Collections.Generic;

namespace Hush.Display.Interfaces
{

    class Delete : Interface
    {
        private Button OkButton;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;


        #region Designer
        protected override void Initialize(List<String> Title)
        {

            Title.Add("Delete Record");

            base.Initialize(Title);

            OkButton = new Button();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();

            OkButton.Font = GlobalFont;
            this.OkButton.Location = new Point(497, 336);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;

            PasswordLabel.Font = GlobalFont;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new Point(118, 59);
            this.PasswordLabel.Name = "label1";
            this.PasswordLabel.Size = new Size(83, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Enter password:";

            PasswordTextBox.Font = GlobalFont;
            this.PasswordTextBox.Location = new Point(218, 59);
            this.PasswordTextBox.Name = "textBox1";
            this.PasswordTextBox.Size = new Size(323, 20);
            this.PasswordTextBox.TabIndex = 2;
   
            this.ClientSize = new Size(663, 434);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.OkButton);
        }

        #endregion

    }

}
