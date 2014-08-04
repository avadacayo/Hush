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
    class RegisterAccount : Interface
    {
        private Label ErrorMsgsLabel;
        private Label RegisterLabel;
        private Label UsernameLabel;
        private Label PasswordStrengthLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label RepeatPasswordLabel;
        private TextBox RepeatPasswordTextBox;
        private Label SecretQuestionLabel;
        private TextBox SecretQuestionTextBox;
        private Label SecretAnswerLabel;
        private TextBox SecretAnswerTextBox;
        private Button RegisterButton;
        private Button SignInButton;
        private Label ErrUsernameLabel;
        private Label ErrPasswordLabel;
        private LinkLabel GeneratePasswordLinkLabel;
        private Label SecretQuestionLabel2;
        private TextBox SecretQuestionTextBox2;
        private Label SecretAnswerLabel2;
        private TextBox SecretAnswerTextBox2;
        private Button ToolButton;
        private ToolTip Tooltip;
        private System.ComponentModel.IContainer components;
        private Label ErrSQ1Label;
        private Label ErrSA1Label;
        private Label ErrSQ2Label;
        private Label ErrSA2Label;
	    private Button CancelButton;
        private static String UsernameHolder;
        private static String PasswordHolder;
        private static String RepeatPasswordHolder;
        private static String SecretQuestionHolder;
        private static String SecretQuestion2Holder;
        private static String SecretAnswerHolder;
        private static String SecretAnswer1Holder;

        public void UseGeneratedPassword(String GeneratedPassword)
        {
            PasswordHolder = GeneratedPassword;
            RepeatPasswordHolder = GeneratedPassword;
        }
        private void RegisterButtonClick(Object Sender, EventArgs Args)
        {
            UsernameTextBox.Text = UsernameTextBox.Text.Trim();
            SecretQuestionTextBox.Text = SecretQuestionTextBox.Text.Trim();
            SecretAnswerTextBox.Text = SecretAnswerTextBox.Text.Trim();
            SecretQuestionTextBox2.Text = SecretQuestionTextBox2.Text.Trim();
            SecretAnswerTextBox2.Text = SecretAnswerTextBox2.Text.Trim();
            
            String ErrUsername = new CheckString().ValidateUsername(UsernameTextBox.Text);
            String ErrPassword = new CheckString().ValidPasswordCheck(UsernameTextBox.Text, PasswordTextBox.Text, RepeatPasswordTextBox.Text);
            String ErrQ1 = new CheckString().ValidateSecretQuestion(SecretQuestionTextBox.Text);
            String ErrSA1 = new CheckString().ValidateSecretAnswer(SecretAnswerTextBox.Text, UsernameTextBox.Text);
            String ErrQ2 = new CheckString().ValidateSecretQuestion(SecretQuestionTextBox2.Text);
            String ErrSA2 = new CheckString().ValidateSecretAnswer(SecretAnswerTextBox2.Text, UsernameTextBox.Text);

            //TODO: Stop if weak password has been used?
            if (ErrUsername.Equals("") && ErrPassword.Equals("") && ErrQ1.Equals("") &&
                ErrSA1.Equals("") && ErrQ2.Equals("") && ErrSA2.Equals(""))
            {
                if (new DataManager().CreateAccount(UsernameTextBox.Text, PasswordTextBox.Text, 
                    SecretQuestionTextBox.Text, SecretAnswerTextBox.Text,
                    SecretQuestionTextBox2.Text, SecretAnswerTextBox2.Text))
                {
                    Program.Window.ShowInterface(new MainScreen());
                    UsernameHolder = "";
            	    PasswordHolder = "";
                    RepeatPasswordHolder = "";
                    SecretQuestionHolder = "";
                    SecretQuestion2Holder = "";
                    SecretAnswerHolder = "";
                    SecretAnswer1Holder = "";
                }
              
            }
            else
            {
                ErrUsernameLabel.Text = ErrUsername;
                ErrPasswordLabel.Text = ErrPassword;
                ErrSQ1Label.Text = ErrQ1;
                ErrSA1Label.Text = ErrSA1;
                ErrSQ2Label.Text = ErrQ2;
                ErrSA2Label.Text = ErrSA2;

                ErrUsernameLabel.Visible = true;
                ErrPasswordLabel.Visible = true;
                ErrSQ1Label.Visible = true;
                ErrSA1Label.Visible = true;
                ErrSQ2Label.Visible = true;
                ErrSA2Label.Visible = true;
            }  
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length > 0)
            {   
                int x = new CheckString().PasswordStrength(PasswordTextBox.Text);
                if (x <= 0)
                {
                    PasswordStrengthLabel.Text = "Very weak";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Crimson;
                }
                else if (x == 1)
                {
                    PasswordStrengthLabel.Text = "Weak";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                }
                else if (x == 2)
                {
                    PasswordStrengthLabel.Text = "Fair";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Gold;
                }
                else if (x == 3)
                {
                    PasswordStrengthLabel.Text = "Strong";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.YellowGreen;
                }
                else if (x == 4)
                {
                    PasswordStrengthLabel.Text = "Very Strong";
                    this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                }
            }

            if (UsernameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0 && RepeatPasswordTextBox.Text.Length > 0
                && SecretQuestionTextBox.Text.Length > 0 && SecretAnswerTextBox.Text.Length > 0
                && SecretQuestionTextBox2.Text.Length > 0 && SecretAnswerTextBox2.Text.Length > 0)
            {
                RegisterButton.Enabled = true;
                               
            }
            else
                RegisterButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new SignIn());

	}
        private void SignInButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new SignIn());
            
        }

        public override void PostInit()
        {
            base.PostInit();
            UsernameTextBox.Focus();
        }

        #region Designer
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Register");
            base.Initialize(Title);
            RegisterButton.Enabled = false;

            UsernameTextBox.Text = UsernameHolder;
            PasswordTextBox.Text = PasswordHolder;
            RepeatPasswordTextBox.Text = RepeatPasswordHolder;
            SecretQuestionTextBox.Text = SecretQuestionHolder;
            SecretQuestionTextBox2.Text = SecretQuestion2Holder;
            SecretAnswerTextBox.Text = SecretAnswerHolder;
            SecretAnswerTextBox2.Text = SecretAnswer1Holder;

            
        }

        protected override void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ErrorMsgsLabel = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolButton = new System.Windows.Forms.Button();
            this.SecretQuestionLabel2 = new System.Windows.Forms.Label();
            this.SecretQuestionTextBox2 = new System.Windows.Forms.TextBox();
            this.SecretAnswerLabel2 = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox2 = new System.Windows.Forms.TextBox();
            this.GeneratePasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SecretQuestionLabel = new System.Windows.Forms.Label();
            this.SecretQuestionTextBox = new System.Windows.Forms.TextBox();
            this.SecretAnswerLabel = new System.Windows.Forms.Label();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.ErrUsernameLabel = new System.Windows.Forms.Label();
            this.ErrPasswordLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErrSQ1Label = new System.Windows.Forms.Label();
            this.ErrSA1Label = new System.Windows.Forms.Label();
            this.ErrSQ2Label = new System.Windows.Forms.Label();
            this.ErrSA2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorMsgsLabel
            // 
            this.ErrorMsgsLabel.Location = new System.Drawing.Point(147, 30);
            this.ErrorMsgsLabel.Name = "ErrorMsgsLabel";
            this.ErrorMsgsLabel.Size = new System.Drawing.Size(300, 80);
            this.ErrorMsgsLabel.TabIndex = 0;
            // 
            // ToolButton
            // 
            this.ToolButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolButton.FlatAppearance.BorderSize = 5;
            this.ToolButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolButton.Image = global::Hush.Properties.Resources.Andy_Tools_Hammer_Spanner3;
            this.ToolButton.Location = new System.Drawing.Point(385, 12);
            this.ToolButton.Name = "ToolButton";
            this.ToolButton.Size = new System.Drawing.Size(26, 26);
            this.ToolButton.TabIndex = 127;
            this.ToolButton.UseVisualStyleBackColor = true;
            this.ToolButton.Click += new System.EventHandler(this.ToolButton_Click);
            this.ToolButton.MouseHover += new System.EventHandler(this.ToolButton_MouseHover);
            // 
            // SecretQuestionLabel2
            // 
            this.SecretQuestionLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel2.Location = new System.Drawing.Point(42, 310);
            this.SecretQuestionLabel2.Name = "SecretQuestionLabel2";
            this.SecretQuestionLabel2.Size = new System.Drawing.Size(300, 15);
            this.SecretQuestionLabel2.TabIndex = 118;
            this.SecretQuestionLabel2.Text = "Secret Question #2";
            // 
            // SecretQuestionTextBox2
            // 
            this.SecretQuestionTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionTextBox2.Location = new System.Drawing.Point(42, 329);
            this.SecretQuestionTextBox2.Name = "SecretQuestionTextBox2";
            this.SecretQuestionTextBox2.Size = new System.Drawing.Size(334, 24);
            this.SecretQuestionTextBox2.TabIndex = 5;
            this.SecretQuestionTextBox2.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.SecretQuestionTextBox2.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            this.SecretQuestionTextBox2.MaxLength = 70;
            // 
            // SecretAnswerLabel2
            // 
            this.SecretAnswerLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerLabel2.Location = new System.Drawing.Point(42, 356);
            this.SecretAnswerLabel2.Name = "SecretAnswerLabel2";
            this.SecretAnswerLabel2.Size = new System.Drawing.Size(300, 15);
            this.SecretAnswerLabel2.TabIndex = 119;
            this.SecretAnswerLabel2.Text = "Answer #2";
            // 
            // SecretAnswerTextBox2
            // 
            this.SecretAnswerTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox2.Location = new System.Drawing.Point(42, 375);
            this.SecretAnswerTextBox2.Name = "SecretAnswerTextBox2";
            this.SecretAnswerTextBox2.Size = new System.Drawing.Size(334, 24);
            this.SecretAnswerTextBox2.TabIndex = 6;
            this.SecretAnswerTextBox2.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.SecretAnswerTextBox2.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            // 
            // GeneratePasswordLinkLabel
            // 
            this.GeneratePasswordLinkLabel.AutoSize = true;
            this.GeneratePasswordLinkLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePasswordLinkLabel.Location = new System.Drawing.Point(42, 461);
            this.GeneratePasswordLinkLabel.Name = "GeneratePasswordLinkLabel";
            this.GeneratePasswordLinkLabel.Size = new System.Drawing.Size(144, 17);
            this.GeneratePasswordLinkLabel.TabIndex = 16;
            this.GeneratePasswordLinkLabel.TabStop = true;
            this.GeneratePasswordLinkLabel.Text = "Generate Password";
            this.GeneratePasswordLinkLabel.Visible = false;
            this.GeneratePasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GeneratePasswordLinkLabel_LinkClicked);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(40, 30);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(114, 40);
            this.RegisterLabel.TabIndex = 120;
            this.RegisterLabel.Text = "Register";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 77);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(107, 17);
            this.UsernameLabel.TabIndex = 121;
            this.UsernameLabel.Text = "Username";
            
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 96);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(334, 24);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.UsernameTextBox.MaxLength = 30;
            this.UsernameTextBox.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Crimson;
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(264, 169);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(112, 18);
            this.PasswordStrengthLabel.TabIndex = 122;
            this.PasswordStrengthLabel.Text = " ";
            this.PasswordStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(42, 123);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 15);
            this.PasswordLabel.TabIndex = 123;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(42, 143);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(334, 24);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(42, 170);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(300, 17);
            this.RepeatPasswordLabel.TabIndex = 124;
            this.RepeatPasswordLabel.Text = "Repeat Password";

            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(42, 190);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(334, 24);
            this.RepeatPasswordTextBox.TabIndex = 2;
            this.RepeatPasswordTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.RepeatPasswordTextBox.MaxLength = 30;
            this.RepeatPasswordTextBox.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            // 
            // SecretQuestionLabel
            // 
            this.SecretQuestionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionLabel.Location = new System.Drawing.Point(42, 218);
            this.SecretQuestionLabel.Name = "SecretQuestionLabel";
            this.SecretQuestionLabel.Size = new System.Drawing.Size(300, 15);
            this.SecretQuestionLabel.TabIndex = 125;
            this.SecretQuestionLabel.Text = "Secret Question #1";
            // 
            // SecretQuestionTextBox
            // 
            this.SecretQuestionTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretQuestionTextBox.Location = new System.Drawing.Point(42, 237);
            this.SecretQuestionTextBox.Name = "SecretQuestionTextBox";
            this.SecretQuestionTextBox.Size = new System.Drawing.Size(334, 24);
            this.SecretQuestionTextBox.TabIndex = 3;
            this.SecretQuestionTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.SecretQuestionTextBox.MaxLength = 70;
            this.SecretQuestionTextBox.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            // 
            // SecretAnswerLabel
            // 
            this.SecretAnswerLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerLabel.Location = new System.Drawing.Point(42, 263);
            this.SecretAnswerLabel.Name = "SecretAnswerLabel";
            this.SecretAnswerLabel.Size = new System.Drawing.Size(300, 15);
            this.SecretAnswerLabel.TabIndex = 126;
            this.SecretAnswerLabel.Text = "Answer #1";
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(42, 282);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(334, 24);
            this.SecretAnswerTextBox.TabIndex = 4;
            this.SecretAnswerTextBox.TextChanged += new System.EventHandler(this.Fields_TextChanged);
            this.SecretAnswerTextBox.KeyDown += (Sender, Args) =>
            {
                if (Args.KeyCode == Keys.Return && RegisterButton.Enabled == true)
                {
                    RegisterButtonClick(null, null);
                }
            };
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(42, 409);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(334, 25);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(141, 453);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(70, 30);
            this.SignInButton.TabIndex = 12;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Visible = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButtonClick);
            // 
            // ErrUsernameLabel
            // 
            this.ErrUsernameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrUsernameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrUsernameLabel.Location = new System.Drawing.Point(187, 78);
            this.ErrUsernameLabel.Name = "ErrUsernameLabel";
            this.ErrUsernameLabel.Size = new System.Drawing.Size(300, 15);
            this.ErrUsernameLabel.TabIndex = 2;
            this.ErrUsernameLabel.Text = "Error";
            this.ErrUsernameLabel.Visible = false;
            // 
            // ErrPasswordLabel
            // 
            this.ErrPasswordLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrPasswordLabel.Location = new System.Drawing.Point(187, 125);
            this.ErrPasswordLabel.Name = "ErrPasswordLabel";
            this.ErrPasswordLabel.Size = new System.Drawing.Size(275, 15);
            this.ErrPasswordLabel.TabIndex = 5;
            this.ErrPasswordLabel.Text = "Error";
            this.ErrPasswordLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErrSQ1Label
            // 
            this.ErrSQ1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrSQ1Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrSQ1Label.Location = new System.Drawing.Point(187, 217);
            this.ErrSQ1Label.Name = "ErrSQ1Label";
            this.ErrSQ1Label.Size = new System.Drawing.Size(224, 17);
            this.ErrSQ1Label.TabIndex = 128;
            this.ErrSQ1Label.Text = "Error";
            this.ErrSQ1Label.Visible = false;
            // 
            // ErrSA1Label
            // 
            this.ErrSA1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrSA1Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrSA1Label.Location = new System.Drawing.Point(187, 263);
            this.ErrSA1Label.Name = "ErrSA1Label";
            this.ErrSA1Label.Size = new System.Drawing.Size(224, 17);
            this.ErrSA1Label.TabIndex = 129;
            this.ErrSA1Label.Text = "Error";
            this.ErrSA1Label.Visible = false;
            // 
            // ErrSQ2Label
            // 
            this.ErrSQ2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrSQ2Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrSQ2Label.Location = new System.Drawing.Point(187, 310);
            this.ErrSQ2Label.Name = "ErrSQ2Label";
            this.ErrSQ2Label.Size = new System.Drawing.Size(224, 17);
            this.ErrSQ2Label.TabIndex = 130;
            this.ErrSQ2Label.Text = "Error";
            this.ErrSQ2Label.Visible = false;
            // 
            // ErrSA2Label
            // 
            this.ErrSA2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrSA2Label.ForeColor = System.Drawing.Color.Crimson;
            this.ErrSA2Label.Location = new System.Drawing.Point(187, 356);
            this.ErrSA2Label.Name = "ErrSA2Label";
            this.ErrSA2Label.Size = new System.Drawing.Size(224, 17);
            this.ErrSA2Label.TabIndex = 131;
            this.ErrSA2Label.Text = "Error";
            this.ErrSA2Label.Visible = false;
            // 
            // RegisterAccount
            // 
            this.Controls.Add(this.ErrSA2Label);
            this.Controls.Add(this.ErrSQ2Label);
            this.Controls.Add(this.ErrSA1Label);
            this.Controls.Add(this.ErrSQ1Label);
            this.Controls.Add(this.ToolButton);
            this.Controls.Add(this.SecretQuestionLabel2);
            this.Controls.Add(this.SecretQuestionTextBox2);
            this.Controls.Add(this.SecretAnswerLabel2);
            this.Controls.Add(this.SecretAnswerTextBox2);
            this.Controls.Add(this.GeneratePasswordLinkLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.SecretQuestionLabel);
            this.Controls.Add(this.SecretQuestionTextBox);
            this.Controls.Add(this.SecretAnswerLabel);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.ErrUsernameLabel);
            this.Controls.Add(this.ErrPasswordLabel);
            this.Controls.Add(this.CancelButton);
            this.Name = "RegisterAccount";
            this.Load += new System.EventHandler(this.RegisterAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GeneratePasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Window.ShowInterface(new GeneratePassword());
        }

        private void ToolButton_Click(object sender, EventArgs e)
        {
            
            UsernameHolder = UsernameTextBox.Text;
            PasswordHolder = PasswordTextBox.Text;
            RepeatPasswordHolder = RepeatPasswordTextBox.Text;
            SecretQuestionHolder = SecretQuestionTextBox.Text;
            SecretQuestion2Holder = SecretQuestionTextBox2.Text;
            SecretAnswerHolder = SecretAnswerTextBox.Text;
            SecretAnswer1Holder = SecretAnswerTextBox2.Text;

            Program.Window.ShowInterface(new GeneratePassword());
        }

        private void ToolButton_MouseHover(object sender, EventArgs e)
        {
            Tooltip.Show("Tools", ToolButton);
        }

        private void RegisterAccount_Load(object sender, EventArgs e)
        {

        }


    }
#endregion
}
