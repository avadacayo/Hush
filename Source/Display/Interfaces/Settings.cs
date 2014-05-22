using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;

namespace Hush.Display.Interfaces
{

    class Settings : Interface
    {

        private Panel ContentPanel;
        private Panel MenuPanel;
        private Label TitleLabel;

        #region Designer

        protected override void Initialize(String Title)
        {

            Title = "Settings";

            base.Initialize(Title);

            ContentPanel = new Panel();
            MenuPanel = new Panel();
            TitleLabel = new Label();

            MenuPanel.SuspendLayout();
            SuspendLayout();

            ContentPanel.BackColor = Color.FromArgb(200, 200, 200);
            ContentPanel.Location = new Point(180, 40);
            ContentPanel.Size = new Size(410, 550);

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
