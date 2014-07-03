using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hush;

namespace Hush.Display.Interfaces
{
    class UserProfile : Interface
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label userProfile;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox RealNameTextBox;
        private System.Windows.Forms.TextBox HandleTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label UserProfileLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CurrentPasswordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cancel;

        #region Designer

        protected override void Initialize(List<String> Title)
        {
            Title.Add("User Profile");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentPasswordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UserProfileLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.HandleTextBox = new System.Windows.Forms.TextBox();
            this.RealNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(42, 353);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 27);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(42, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 27);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Repeat New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password";
            // 
            // CurrentPasswordLabel
            // 
            this.CurrentPasswordLabel.AutoSize = true;
            this.CurrentPasswordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordLabel.Location = new System.Drawing.Point(42, 225);
            this.CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            this.CurrentPasswordLabel.Size = new System.Drawing.Size(151, 18);
            this.CurrentPasswordLabel.TabIndex = 5;
            this.CurrentPasswordLabel.Text = "Current Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 27);
            this.textBox1.TabIndex = 6;
            // 
            // UserProfileLabel
            // 
            this.UserProfileLabel.AutoSize = true;
            this.UserProfileLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfileLabel.Location = new System.Drawing.Point(40, 30);
            this.UserProfileLabel.Name = "UserProfileLabel";
            this.UserProfileLabel.Size = new System.Drawing.Size(170, 29);
            this.UserProfileLabel.TabIndex = 0;
            this.UserProfileLabel.Text = "User Profile";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(280, 453);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 25);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(150, 453);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 25);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // HandleTextBox
            // 
            this.HandleTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandleTextBox.Location = new System.Drawing.Point(42, 153);
            this.HandleTextBox.Name = "HandleTextBox";
            this.HandleTextBox.Size = new System.Drawing.Size(338, 27);
            this.HandleTextBox.TabIndex = 4;
            // 
            // RealNameTextBox
            // 
            this.RealNameTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealNameTextBox.Location = new System.Drawing.Point(42, 99);
            this.RealNameTextBox.Name = "RealNameTextBox";
            this.RealNameTextBox.Size = new System.Drawing.Size(338, 27);
            this.RealNameTextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 79);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(90, 18);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(42, 133);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(90, 18);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserProfile
            // 
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPasswordLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UserProfileLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.HandleTextBox);
            this.Controls.Add(this.RealNameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }
    }
}
