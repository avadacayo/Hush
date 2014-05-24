using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Collections.Generic;

namespace Hush.Display.Interfaces
{

    class Settings : Interface
    {

        private Panel ContentPanel;
        private Button GeneralButton;
        private Panel MenuPanel;
        private Label TitleLabel;
        private Button ThemeButton;
        private Button SaveSettingsButton;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Settings");

            base.Initialize(Title);

            ContentPanel = new Panel();
            GeneralButton = new Button();
            MenuPanel = new Panel();
            TitleLabel = new Label();
            ThemeButton = new Button();
            SaveSettingsButton = new Button();

            MenuPanel.SuspendLayout();
            SuspendLayout();

            ContentPanel.BackColor = Color.FromArgb(230, 230, 230);
            ContentPanel.Location = new Point(180, 40);
            ContentPanel.Size = new Size(410, 550);

            GeneralButton.UseVisualStyleBackColor = true;
            GeneralButton.Location = new Point(1, 1);
            GeneralButton.Size = new Size(168, 30);
            GeneralButton.Text = "General Settings";

            MenuPanel.BackColor = Color.FromArgb(150, 150, 150);
            MenuPanel.Location = new Point(10, 40);
            MenuPanel.Size = new Size(170, 550);

            TitleLabel.BackColor = Color.FromArgb(70, 140, 210);
            TitleLabel.Font = GlobalFont;
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(10, 10);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Padding = new Padding(10, 0, 0, 0);
            TitleLabel.Size = new Size(580, 30);
            TitleLabel.Text = "Settings";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;

            ThemeButton.UseVisualStyleBackColor = true;
            ThemeButton.Location = new Point(1, 30);
            ThemeButton.Size = new Size(168, 30);
            ThemeButton.Text = "Change Theme";

            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Location = new Point(1, 59);
            SaveSettingsButton.Size = new Size(168, 30);
            SaveSettingsButton.Text = "Save Settings";

            MenuPanel.Controls.Add(GeneralButton);
            MenuPanel.Controls.Add(ThemeButton);
            MenuPanel.Controls.Add(SaveSettingsButton);

            Controls.Add(ContentPanel);
            Controls.Add(MenuPanel);
            Controls.Add(TitleLabel);

            ContentPanel.ResumeLayout(true);
            MenuPanel.ResumeLayout(true);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
