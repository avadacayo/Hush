using Hush.Client;
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
        private Label ErrPasswordLabel;
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
            this.ErrPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(36, 96);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(323, 28);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(33, 34);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(153, 20);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Delete record? ";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(259, 130);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 25);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
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
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPasswordLabel.Location = new System.Drawing.Point(33, 66);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(244, 20);
            this.EnterPasswordLabel.TabIndex = 1;
            this.EnterPasswordLabel.Text = "Enter password to confirm:";
            // 
            // ErrPasswordLabel
            // 
            this.ErrPasswordLabel.AutoSize = true;
            this.ErrPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrPasswordLabel.Location = new System.Drawing.Point(33, 127);
            this.ErrPasswordLabel.Name = "ErrPasswordLabel";
            this.ErrPasswordLabel.Size = new System.Drawing.Size(170, 20);
            this.ErrPasswordLabel.TabIndex = 5;
            this.ErrPasswordLabel.Text = "Password incorrect";
            this.ErrPasswordLabel.Visible = false;
            // 
            // Delete
            // 
            this.Controls.Add(this.ErrPasswordLabel);
            this.Controls.Add(this.EnterPasswordLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public override void PostInit()
        {
            base.PostInit();
            PasswordTextBox.Focus();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Boolean valid = DataManager.VerifyPassword(this.PasswordTextBox.Text);
            if (valid)
            {

                DataManager.DeleteRecord(DataManager.GetRecordByID(DataHolder.RecordNode));
                Program.Window.ShowInterface(new MainScreen());
            }
            else
                this.ErrPasswordLabel.Visible = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }
    }

}
