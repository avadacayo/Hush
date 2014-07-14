using Hush.Client;
using Hush.Display.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display
{

    class ParentWindow : Form
    {

        private Interface _CurrentInterface = null;
        private ParentWindow _Dialog = null;
        private ParentWindow _Parent = null;

        // set to false to view test screen
        // set to true to open with sign in page
        private bool demo_setup = false;

        public ParentWindow(ParentWindow Parent = null)
        {

            _Parent = Parent;

            if (Parent == null)
            {

                _Dialog = new ParentWindow(this);

            }

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;

            if (demo_setup) 
            { 
                ShowInterface(new SignIn()); 
            }
            else
                ShowInterface(new TestScreen());
            

        }

        public void ShowInterface(Interface ToShow)
        {

            SuspendLayout();

            if (_CurrentInterface != null)
            {

                Controls.Remove(_CurrentInterface);

            }

            ClientSize = new Size(ToShow.Width, ToShow.Height);
            ToShow.ParentWindow = this;
            Text = ToShow.Text;
            Controls.Add(ToShow);
            ResumeLayout(true);

            

            _CurrentInterface = ToShow;

        }

        public void ShowInterfaceDialog(Interface ToShow)
        {

            if (_Dialog == null || _Dialog.IsDisposed)
            {

                _Dialog = new ParentWindow(this);

            }

            _Dialog.ShowInterface(ToShow);

            if (!_Dialog.Visible)
            {

                _Dialog.ShowDialog(this);

            }

        }

        #region Overrides

        protected override void OnClosing(CancelEventArgs Args)
        {

            if (_CurrentInterface != null && _CurrentInterface.HasClosingSave == true)
            {

                String SaveOption = DataManager.GetUserSaveOption();

                if (SaveOption == "Automatic")
                {
                    _CurrentInterface.ClosingSave();
                }

                if (SaveOption == "Prompt")
                {

                    DialogResult Result = MessageBox.Show("Changes have been made, do you wish to save?", "", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        _CurrentInterface.ClosingSave();
                    }

                }

            }

            base.OnClosing(Args);

            if (_Dialog != null)
            {

                _Dialog.Close();

            }

            if (_Parent == null)
            {

                switch (_CurrentInterface.GetType().Name)
                {

                    case "CategoryPrompt":
                        ShowInterface(new CategoryManagement());
                        Args.Cancel = true;
                        break;

                    case "Add":
                    case "Edit":
                    case "Delete":
                    case "View":
                    case "Search":
                    case "CategoryManagement":
                    case "UserProfile":
                        ShowInterface(new MainScreen());
                        Args.Cancel = true;
                        break;

                    case "Settings":
                    case "TestScreen":
                    case "SignIn":
                        break;

                    default:
                        if (demo_setup)
                        {
                            ShowInterface(new SignIn());
                        }
                        else
                        {
                            ShowInterface(new TestScreen());
                        }
                        Args.Cancel = true;
                        break;

                }

            }

            else
            {

                _Parent.Focus();

            }

        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ParentWindow
            // 
            this.ClientSize = new System.Drawing.Size(740, 415);
            this.Name = "ParentWindow";
            this.ResumeLayout(false);

        }

    }

}
