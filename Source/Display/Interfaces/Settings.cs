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
        private Label SaveLabel;
        private Panel SavePanel;
        private Label SyncLabel;
        private Panel SyncPanel;
        private Label TitleLabel;
        private Label UpdateLabel;
        private Panel UpdatePanel;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Settings");

            base.Initialize(Title);

            BackColor = Color.White;
            Height = 600;
            Width = 500;

            ContentPanel = new Panel();
            SaveLabel = new Label();
            SavePanel = new Panel();
            SyncLabel = new Label();
            SyncPanel = new Panel();
            TitleLabel = new Label();
            UpdateLabel = new Label();
            UpdatePanel = new Panel();

            ContentPanel.SuspendLayout();
            SuspendLayout();

            ContentPanel.AutoScroll = false;
            ContentPanel.HorizontalScroll.Enabled = false;
            ContentPanel.AutoScroll = true;
            ContentPanel.BackColor = Color.FromArgb(100, 140, 255);
            ContentPanel.Location = new Point(10, 40);
            ContentPanel.Size = new Size(Width - 20, 550);

            TitleLabel.BackColor = Color.FromArgb(70, 140, 210);
            TitleLabel.Font = GetFontVariant(true);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(10, 10);
            TitleLabel.Padding = new Padding(10, 0, 0, 0);
            TitleLabel.Size = new Size(Width - 20, 30);
            TitleLabel.Text = "Settings";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;

            SaveLabel.BackColor = Color.FromArgb(200, 200, 200);
            SaveLabel.Font = GetFontVariant(true);
            SaveLabel.ForeColor = Color.White;
            SaveLabel.Location = new Point(0, 0);
            SaveLabel.Padding = new Padding(20, 0, 0, 0);
            SaveLabel.Size = new Size(Width - 20, 30);
            SaveLabel.Text = "Save Options";
            SaveLabel.TextAlign = ContentAlignment.MiddleLeft;

            SavePanel.BackColor = Color.FromArgb(230, 230, 230);
            SavePanel.Location = new Point(0, 30);
            SavePanel.Size = new Size(Width - 20, 270);

            SyncLabel.BackColor = Color.FromArgb(200, 200, 200);
            SyncLabel.Font = GetFontVariant(true);
            SyncLabel.ForeColor = Color.White;
            SyncLabel.Location = new Point(0, 300);
            SyncLabel.Padding = new Padding(20, 0, 0, 0);
            SyncLabel.Size = new Size(Width - 20, 30);
            SyncLabel.Text = "Sync Options";
            SyncLabel.TextAlign = ContentAlignment.MiddleLeft;

            SyncPanel.BackColor = Color.FromArgb(230, 230, 230);
            SyncPanel.Location = new Point(0, 330);
            SyncPanel.Size = new Size(Width - 20, 270);

            UpdateLabel.BackColor = Color.FromArgb(200, 200, 200);
            UpdateLabel.Font = GetFontVariant(true);
            UpdateLabel.ForeColor = Color.White;
            UpdateLabel.Location = new Point(0, 600);
            UpdateLabel.Padding = new Padding(20, 0, 0, 0);
            UpdateLabel.Size = new Size(Width - 20, 30);
            UpdateLabel.Text = "Update Options";
            UpdateLabel.TextAlign = ContentAlignment.MiddleLeft;

            UpdatePanel.BackColor = Color.FromArgb(230, 230, 230);
            UpdatePanel.Location = new Point(0, 630);
            UpdatePanel.Size = new Size(Width - 20, 270);

            ContentPanel.Controls.Add(SaveLabel);
            ContentPanel.Controls.Add(SavePanel);
            ContentPanel.Controls.Add(SyncLabel);
            ContentPanel.Controls.Add(SyncPanel);
            ContentPanel.Controls.Add(UpdateLabel);
            ContentPanel.Controls.Add(UpdatePanel);

            Controls.Add(ContentPanel);
            Controls.Add(TitleLabel);

            ContentPanel.ResumeLayout(true);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
