using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Delete : Interface
    {
        private Button OkButton;
        private Label PasswordLabel;
        private Button CancelButton;
        private Label EnterPasswordLabel;
        private TextBox PasswordTextBox;


        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Delete Record");
            base.Initialize(Title);

        }

        protected override void InitializeComponent() {
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(36, 96);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(323, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(33, 34);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(143, 18);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Delete record? ";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(125, 153);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 25);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(259, 153);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.AutoSize = true;
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPasswordLabel.Location = new System.Drawing.Point(33, 66);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(247, 18);
            this.EnterPasswordLabel.TabIndex = 1;
            this.EnterPasswordLabel.Text = "Enter password to confirm:";
            // 
            // Delete
            // 
            this.Controls.Add(this.EnterPasswordLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "Delete";
            this.Size = new System.Drawing.Size(740, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void OkButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }
    }

}
