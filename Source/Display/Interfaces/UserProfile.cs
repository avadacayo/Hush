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
        private System.Windows.Forms.Label RealName;
        private System.Windows.Forms.Label Handle;
        private System.Windows.Forms.TextBox RealNameTextBox;
        private System.Windows.Forms.TextBox HandleTextBox;
        private System.Windows.Forms.Button managePassword;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;

        #region Designer

        protected override void Initialize(List<String> Title)
        {
            Title.Add("User Profile");
            base.Initialize(Title);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userProfile = new System.Windows.Forms.Label();
            this.RealName = new System.Windows.Forms.Label();
            this.Handle = new System.Windows.Forms.Label();
            this.RealNameTextBox = new System.Windows.Forms.TextBox();
            this.HandleTextBox = new System.Windows.Forms.TextBox();
            this.managePassword = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userProfile
            // 
            this.userProfile.AutoSize = true;
            this.userProfile.Location = new System.Drawing.Point(268, 61);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(61, 13);
            this.userProfile.TabIndex = 1;
            this.userProfile.Text = "User Profile";
            // 
            // RealName
            // 
            this.RealName.AutoSize = true;
            this.RealName.Location = new System.Drawing.Point(107, 99);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(57, 13);
            this.RealName.TabIndex = 2;
            this.RealName.Text = "RealName";
            //this.RealName.Click += new System.EventHandler(this.RealName_Click);
            // 
            // Handle
            // 
            this.Handle.AutoSize = true;
            this.Handle.Location = new System.Drawing.Point(107, 152);
            this.Handle.Name = "Handle";
            this.Handle.Size = new System.Drawing.Size(41, 13);
            this.Handle.TabIndex = 3;
            this.Handle.Text = "Handle";
            // 
            // RealNameTextBox
            // 
            this.RealNameTextBox.Location = new System.Drawing.Point(217, 99);
            this.RealNameTextBox.Name = "RealNameTextBox";
            this.RealNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.RealNameTextBox.TabIndex = 4;
            // 
            // HandleTextBox
            // 
            this.HandleTextBox.Location = new System.Drawing.Point(217, 152);
            this.HandleTextBox.Name = "HandleTextBox";
            this.HandleTextBox.Size = new System.Drawing.Size(234, 20);
            this.HandleTextBox.TabIndex = 5;
            // 
            // managePassword
            // 
            this.managePassword.Location = new System.Drawing.Point(217, 223);
            this.managePassword.Name = "managePassword";
            this.managePassword.Size = new System.Drawing.Size(140, 23);
            this.managePassword.TabIndex = 6;
            this.managePassword.Text = "Manage Password(s)";
            this.managePassword.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(376, 223);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(472, 223);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            //this.cancel.Click += new System.EventHandler(this.cancel_Click);

            this.ClientSize = new System.Drawing.Size(583, 271);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.managePassword);
            this.Controls.Add(this.HandleTextBox);
            this.Controls.Add(this.RealNameTextBox);
            this.Controls.Add(this.Handle);
            this.Controls.Add(this.RealName);
            this.Controls.Add(this.userProfile);
            this.Controls.Add(this.menuStrip1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
