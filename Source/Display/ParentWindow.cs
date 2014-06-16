using System;
using System.Drawing;
using System.Windows.Forms;

using Hush.Display.Interfaces;
using System.ComponentModel;

namespace Hush.Display
{

    class ParentWindow : Form
    {

        private Interface _CurrentInterface = null;
        private ParentWindow _DialogChild = null;
        private ParentWindow _DialogParent = null;

        public ParentWindow(ParentWindow DialogParent = null)
        {

            _DialogParent = DialogParent;

            if (DialogParent == null)
            {
                _DialogChild = new ParentWindow(this);
            }

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen; 

            ShowInterface(new TestScreen());

        }

        public void ShowInterface(Interface ToShow)
        {

            SuspendLayout();

            if (_CurrentInterface != null)
                Controls.Remove(_CurrentInterface);

            ClientSize = new Size(ToShow.Width, ToShow.Height);
            _CurrentInterface = ToShow;
            Text = ToShow.Text;

            Controls.Add(ToShow);

            ResumeLayout(true);
            return;

        }

        public void ShowInterfaceDialog(Interface ToShow)
        {

            if (_DialogChild != null)
            {

                _DialogChild.Hide();
                _DialogChild.ShowInterface(ToShow);
                _DialogChild.ShowDialog(this);

            }

        }

        #region Overrides

        protected override void OnClosing(CancelEventArgs Args)
        {

            base.OnClosing(Args);

            if (_DialogParent != null)
            {
                return;
            }

            if (_CurrentInterface is CategoryPrompt)
            {

                ShowInterface(new CategoryManagement());
                Args.Cancel = true;

            }
            else if (_CurrentInterface is Add || _CurrentInterface is Edit
                || _CurrentInterface is Delete || _CurrentInterface is Hush.Display.Interfaces.View
                || _CurrentInterface is Search || _CurrentInterface is Settings
                || _CurrentInterface is CategoryManagement || _CurrentInterface is UserProfile)
            {

                ShowInterface(new MainScreen());
                Args.Cancel = true;

            }
            else if (!(_CurrentInterface is TestScreen))
            {

                ShowInterface(new TestScreen());
                Args.Cancel = true;

            }

        }

        #endregion

    }

}
