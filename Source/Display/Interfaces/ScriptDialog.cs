using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hush.Display.Controls;
using System.Windows.Forms;
using System.Drawing;

namespace Hush.Display.Interfaces
{

    class ScriptDialog : Interface
    {

        protected Boolean HasButtons;

        #region Controls

        protected Button BackButton;
        protected Button CancelButton;
        protected Button NextButton;
        protected Button OkButton;
        protected ExtendoPanel ContentPanel;

        #endregion

        public ScriptDialog()
        {

            HasButtons = false;

        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            base.Initialize(Title);
            SuspendLayout();
            ContentPanel = new ExtendoPanel();
            ContentPanel.Location = new Point(10, 10);
            Controls.Add(ContentPanel);
            ClientSize = new Size(500, 200);
            ResumeLayout(true);

        }

        #endregion

    }

    class ScriptDialogText : ScriptDialog
    {
    }

    class ScriptDialogPrompt : ScriptDialog
    {
    }

}
