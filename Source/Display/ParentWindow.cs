using System;
using System.Drawing;
using System.Windows.Forms;

using Hush.Display.Interfaces;
using System.ComponentModel;

namespace Hush.Display
{

    class ParentWindow : Form
    {

        private Interface CurrentInterface = null;

        public ParentWindow()
        {

            //BackColor = Color.FromArgb(255, 255, 255);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen; 

            ShowInterface(new TestScreen());

        }

        public void ShowInterface(Interface ToShow)
        {

            SuspendLayout();

            if (CurrentInterface != null)
                Controls.Remove(CurrentInterface);

            ClientSize = new Size(ToShow.Width, ToShow.Height);
            CurrentInterface = ToShow;
            Text = ToShow.Text;

            Controls.Add(ToShow);

            ResumeLayout(true);
            return;

        }

        #region Overrides

        protected override void OnClosing(CancelEventArgs Args)
        {

            base.OnClosing(Args);

            if (CurrentInterface is CategoryPrompt)
            {

                ShowInterface(new CategoryManagement());
                Args.Cancel = true;

            }
            else if (CurrentInterface is Add || CurrentInterface is Edit
                || CurrentInterface is Delete || CurrentInterface is Hush.Display.Interfaces.View
                || CurrentInterface is Search || CurrentInterface is Settings
                || CurrentInterface is CategoryManagement || CurrentInterface is UserProfile)
            {

                ShowInterface(new MainScreen());
                Args.Cancel = true;

            }
            else if (!(CurrentInterface is TestScreen))
            {

                ShowInterface(new TestScreen());
                Args.Cancel = true;

            }

        }

        #endregion

    }

}
