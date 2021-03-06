﻿using Hush.Client.Model;
using Hush.Tools;
using Hush.Tools.Scripting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Hush.Display.Interfaces
{

    class TestScreen : Interface
    {
        private Button SignInButton;
        private Button RegisterAccountButton;
        private Button GeneratePasswordButton;
        private PictureBox pictureBox1;
        private Button ForgotPasswordButton;

        private void SettingsButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Settings());
        }

        private void SignInButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new SignIn());
        }

        private void RegisterAccountButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new RegisterAccount());
        }


        private void AddButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Add());
        }

        private void EditButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Edit());
        }

        private void DeleteButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Delete());
        }

        private void CategoryManagementButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new CategoryManagement());
        }

        private void SearchButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Search());
        }

        private void MainScreenButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void UserProfileButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new UserProfile());
        }

        private void GeneratePasswordButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new GeneratePassword());
        }
        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Test");

            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.SignInButton = new System.Windows.Forms.Button();
            this.RegisterAccountButton = new System.Windows.Forms.Button();
            this.ForgotPasswordButton = new System.Windows.Forms.Button();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(10, 41);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(150, 25);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.Text = "Sign In Screen";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButtonClick);
            // 
            // RegisterAccountButton
            // 
            this.RegisterAccountButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccountButton.Location = new System.Drawing.Point(10, 72);
            this.RegisterAccountButton.Name = "RegisterAccountButton";
            this.RegisterAccountButton.Size = new System.Drawing.Size(150, 25);
            this.RegisterAccountButton.TabIndex = 2;
            this.RegisterAccountButton.Text = "Register Account Screen";
            this.RegisterAccountButton.UseVisualStyleBackColor = true;
            this.RegisterAccountButton.Click += new System.EventHandler(this.RegisterAccountButtonClick);
            
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePasswordButton.Location = new System.Drawing.Point(10, 133);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(150, 25);
            this.GeneratePasswordButton.TabIndex = 3;
            this.GeneratePasswordButton.Text = "Generate Password Screen";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox1.Location = new System.Drawing.Point(247, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 183);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Load("http://c.thumbs.redditmedia.com/u8MK1Z85ECxMd0gt.png");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            // 
            // TestScreen
            // 
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.RegisterAccountButton);
            this.Controls.Add(this.ForgotPasswordButton);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Name = "TestScreen";
            this.Size = new System.Drawing.Size(740, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {


            Record R = new Record();
            for (int i = 0; i < 10; i++)
            {
                Field A = new Field();
                A.Key = "key" + i.ToString();
                A.Value = "value" + i.ToString();
                R.Fields.Add(A);
            }
            R.Name = "Testing Record";

            // this is testing code to run the testing.js file
            if (File.Exists("Data/test.js"))
            {
                HushScript x = new HushScript(Program.Window, R);
                x.Name = "Data/test";
                ReturnValue status = x.Load();
                //    if (status.Success == false)
                //  {
                //   MessageBox.Show(status.Message);
                // }
                x.Run();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }

}
