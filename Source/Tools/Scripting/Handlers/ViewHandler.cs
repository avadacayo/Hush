using Hush.Display;
using Hush.Display.Interfaces;
using System;

namespace Hush.Tools.Scripting.Handlers
{

    class ViewHandler
    {

        private ScriptDialog _CurrentDialog;
        private HushScript _ParentScript;
        private ParentWindow _ParentWindow;

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

    }

}
