using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hush.Display.Controls;
using System.Windows.Forms;
using System.Drawing;
using Hush.Tools.Scripting;

namespace Hush.Display.Interfaces
{

    class ScriptDialog : Interface
    {

        protected HushScript _ParentScript;

        #region Controls

        protected Button BackButton;
        protected Button CancelButton;
        protected Button ConfirmButton;
        protected Button NextButton;
        protected Button OkButton;
        protected Button PreviousButton;

        protected ExtendoPanel ContentPanel;

        #endregion

        public ScriptDialog()
        {
        }

        public ScriptDialog(HushScript ParentScript)
        {

            _ParentScript = ParentScript;

            BackButton = null;
            CancelButton = null;
            ConfirmButton = null;
            NextButton = null;
            OkButton = null;
            PreviousButton = null;

        }

        protected void AddButton(String ButtonType)
        {

            switch (ButtonType)
            {

                case "Ok":
                    OkButton = new Button();
                    break;

            }

        }

        private void TOKBCLICK(Object S, EventArgs E)
        {
            _ParentScript.RunBody(5, 5);
        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            base.Initialize(Title);

            SuspendLayout();
            ClientSize = new Size(500, 200);

            ContentPanel = new ExtendoPanel();
//            ContentPanel.BackColor = Color.DarkCyan;
            ContentPanel.Location = new Point(10, 10);
            ContentPanel.Size = new Size(ClientSize.Width - 20, 1);

            OkButton = new Button();
            OkButton.Text = "Ok";
            OkButton.Location = new Point(450, 170);
            OkButton.Click += TOKBCLICK;

            Controls.Add(ContentPanel);
            Controls.Add(OkButton);
            ResumeLayout(true);

        }

        #endregion

    }

    class ScriptDialogText : ScriptDialog
    {

        #region Controls

        private Label TextLabel;

        #endregion

        public ScriptDialogText(HushScript ParentScript, String Text)
            : base(ParentScript)
        {

            TextLabel = new Label();
            TextLabel.Location = new Point(0, 0);
            TextLabel.AutoSize = true;
            TextLabel.AutoSizeChanged += TextLabelAutoSizeChanged;
            TextLabel.Text = Text;

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(TextLabel);
            ContentPanel.ResumeLayout();

        }

        #region Events

        private void TextLabelAutoSizeChanged(Object Sender, EventArgs Args)
        {

            // limit textbox size

        }

        #endregion

    }

    class ScriptDialogPrompt : ScriptDialog
    {
    }

}
