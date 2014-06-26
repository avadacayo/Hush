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

        protected FlowLayoutPanel ButtonFlowLayoutPanel;
        protected ScriptContentPanel ContentPanel;

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

        protected void AddButton(Button ToAdd)
        {

            ButtonFlowLayoutPanel.SuspendLayout();
            ButtonFlowLayoutPanel.Controls.Add(ToAdd);
            ButtonFlowLayoutPanel.ResumeLayout(true);

        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            base.Initialize(Title);

            SuspendLayout();
            ClientSize = new Size(500, 200);

            ContentPanel = new ScriptContentPanel();
            ContentPanel.AutoScroll = true;
            ContentPanel.Location = new Point(10, 10);
            ContentPanel.Size = new Size(ClientSize.Width - 20, 1);

            ButtonFlowLayoutPanel = new FlowLayoutPanel();
            ButtonFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            ButtonFlowLayoutPanel.Location = new Point(10, 165);
            ButtonFlowLayoutPanel.Size = new Size(ClientSize.Width - 20, 25);

            BackButton = new Button();
            BackButton.Text = "Back";

            CancelButton = new Button();
            CancelButton.Text = "Cancel";

            ConfirmButton = new Button();
            ConfirmButton.Text = "Confirm";

            NextButton = new Button();
            NextButton.Text = "Next";

            OkButton = new Button();
            OkButton.Text = "Ok";

            PreviousButton = new Button();
            PreviousButton.Text = "Previous";

            Controls.Add(ContentPanel);
            Controls.Add(ButtonFlowLayoutPanel);
            ResumeLayout(true);

        }

        #endregion

    }

    class ScriptDialogText : ScriptDialog
    {

        #region Controls

        private RichTextBox TextRichTextBox;

        #endregion

        public ScriptDialogText(HushScript ParentScript, String Text)
            : base(ParentScript)
        {

            TextRichTextBox = new RichTextBox();
            TextRichTextBox.BackColor = SystemColors.Control;
            TextRichTextBox.BorderStyle = BorderStyle.None;
            TextRichTextBox.Font = new Font("Verdana", 11f, FontStyle.Regular);
            TextRichTextBox.Location = new Point(0, 0);
            TextRichTextBox.ReadOnly = true;
            TextRichTextBox.Size = new Size(480, 150);
            TextRichTextBox.Text = Text;

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(TextRichTextBox);
            ContentPanel.ResumeLayout();

        }

        #region Events

        private void OkButtonClick(Object Sender, EventArgs Args)
        {

            _ParentScript.RunBody(1, "");

        }

        #endregion

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            base.Initialize(Title);
            AddButton(OkButton);

            OkButton.Click += OkButtonClick;

        }

        #endregion

    }

    class ScriptDialogPrompt : ScriptDialog
    {
    }

}
