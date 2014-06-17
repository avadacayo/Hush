using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        }

        protected override void InitializeComponent() {
            this.OkButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(466, 228);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(118, 59);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Enter password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(218, 59);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(323, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // Delete
            // 
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "Delete";
            this.Size = new System.Drawing.Size(923, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void OkButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

    }

}
