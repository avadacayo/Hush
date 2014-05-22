using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;

namespace Hush.Display.Interfaces
{

    class Settings : Interface
    {

        private Label TitleLabel;

        #region Designer

        protected override void Initialize(String Name, String Text)
        {

            base.Initialize(Name, Text);

            TitleLabel = new Label();

            SuspendLayout();

            TitleLabel.BackColor = Color.FromArgb(70, 140, 210);
            TitleLabel.Font = GlobalFont;
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(10, 10);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Padding = new Padding(10, 0, 0, 0);
            TitleLabel.Size = new Size(580, 30);
            TitleLabel.Text = "Settings";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;

            Controls.Add(TitleLabel);

            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
