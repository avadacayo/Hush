using System;
using System.Drawing;
using System.Windows.Forms;

using Hush;

namespace Hush.Display.Interfaces
{

    class TestScreen : Interface
    {

        private Button SettingsButton;

        private void SettingsButtonClick(Object Sender, EventArgs Args)
        {
            Program.Window.ShowInterface(new Settings());
        }

        #region Designer

        protected override void Initialize(String Text)
        {

            base.Initialize(Text);

            SettingsButton = new Button();
            SuspendLayout();

            SettingsButton.Click += SettingsButtonClick;
            SettingsButton.Location = new Point(10, 10);
            SettingsButton.Text = "Settings Screen";
            SettingsButton.Size = new Size(150, 25);

            Controls.Add(SettingsButton);

            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
