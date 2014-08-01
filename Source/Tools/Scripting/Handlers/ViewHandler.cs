using Hush.Display;
using Hush.Display.Interfaces;
using System;
using System.Drawing;

namespace Hush.Tools.Scripting.Handlers
{

    class ViewHandler
    {

        private ScriptDialog _CurrentDialog;
        private HushScript _ParentScript;
        private ParentWindow _ParentWindow;

        public ScriptDialog CurrentDialog
        {

            get { return _CurrentDialog; }
            set { _CurrentDialog = value; }

        }

        public ViewHandler()
        {

            _CurrentDialog = null;
            _ParentScript = null;
            _ParentWindow = null;

        }

        public ViewHandler(HushScript ParentScript, ParentWindow ParentWindow)
        {

            _CurrentDialog = null;
            _ParentScript = ParentScript;
            _ParentWindow = ParentWindow;

        }

        ~ViewHandler()
        {

            Close();

        }

        public void Close()
        {

            if (_CurrentDialog != null)
            {

                _CurrentDialog.Close();
                _CurrentDialog = null;

            }

        }

        public void ShowTextDialog(String Text)
        {

            _CurrentDialog = new ScriptDialogText(_ParentScript, Text);
            _ParentWindow.ShowInterfaceDialog(_CurrentDialog);

        }

        public void ShowInputDialog(String Text)
        {

            _CurrentDialog = new ScriptDialogInput(_ParentScript, Text);
            _ParentWindow.ShowInterfaceDialog(_CurrentDialog);

        }

        public void ShowImageDialog(String URL)
        {

            _CurrentDialog = new ScriptDialogImage(_ParentScript, URL);
            _ParentWindow.ShowInterfaceDialog(_CurrentDialog);

        }


        public void ShowImageDialog(Image Image)
        {

            _CurrentDialog = new ScriptDialogImage(_ParentScript, Image);
            _ParentWindow.ShowInterfaceDialog(_CurrentDialog);

        }

    }

}
