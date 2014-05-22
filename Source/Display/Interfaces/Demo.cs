using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;

namespace Hush.Display.Interfaces
{

    class Demo : Interface
    {

        // controls are named <Name><Type>
        // for example <Login><Button>

        private Panel BorderPanel;
        private Panel ControlPanel;
        private Button LoginButton;
        private Button RegisterButton;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;

        // event methods are named <Control><Action>
        // for example <LoginButton><Click>

        private void LoginButtonClick(Object Sender, EventArgs Args)
        {
        }

        #region Overrides

        // overridden methods go here

        #endregion

        #region Designer

        protected override void Initialize(String Title)
        {

            base.Initialize(Title);

            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            BorderPanel = new Panel();
            ControlPanel = new Panel();
            LoginButton = new Button();
            RegisterButton = new Button();

            ControlPanel.SuspendLayout();
            SuspendLayout();

            UsernameTextBox.Font = GlobalFont;
            UsernameTextBox.Location = new Point(10, 25);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(172, 20);
            UsernameTextBox.TabIndex = 1;

            UsernameLabel.Font = GlobalFont;
            UsernameLabel.Location = new Point(10, 10);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(172, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";

            PasswordTextBox.Font = GlobalFont;
            PasswordTextBox.Location = new Point(10, 70);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(172, 20);
            PasswordTextBox.TabIndex = 2;

            PasswordLabel.Font = GlobalFont;
            PasswordLabel.Location = new Point(10, 55);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(172, 15);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Password";

            BorderPanel.BackColor = SystemColors.ControlDark;
            BorderPanel.Dock = DockStyle.Right;
            BorderPanel.Location = new Point(193, 0);
            BorderPanel.Name = "BorderPanel";
            BorderPanel.Size = new Size(1, 102);

            ControlPanel.BackColor = SystemColors.ControlLight;
            ControlPanel.Controls.Add(LoginButton);
            ControlPanel.Controls.Add(RegisterButton);
            ControlPanel.Dock = DockStyle.Right;
            ControlPanel.Location = new Point(194, 0);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(90, 102);

            LoginButton.Font = GlobalFont;
            LoginButton.Location = new Point(10, 10);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(70, 50);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "login";
            LoginButton.UseVisualStyleBackColor = true;

            RegisterButton.Font = GlobalFont;
            RegisterButton.Location = new Point(10, 65);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(70, 27);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "register";
            RegisterButton.UseVisualStyleBackColor = true;

            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(BorderPanel);
            Controls.Add(ControlPanel);
            ControlPanel.ResumeLayout(false);

            Width = 500;
            Height = 500;

            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
