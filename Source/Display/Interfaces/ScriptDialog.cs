using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hush.Display.Controls;
using System.Windows.Forms;
using System.Drawing;
using Hush.Tools.Scripting;
using Hush.Client.Model;

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

        protected void Resize(Int32 NewHeight)
        {

            ClientSize = new Size(500, NewHeight);
            ButtonFlowLayoutPanel.Location = new Point(10, ClientSize.Height - 35);

        }

        protected void AddButton(Button ToAdd)
        {

            ButtonFlowLayoutPanel.BringToFront();
            ButtonFlowLayoutPanel.SuspendLayout();
            ButtonFlowLayoutPanel.Controls.Add(ToAdd);
            ButtonFlowLayoutPanel.ResumeLayout(true);

        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Popup Dialog");
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

    class ScriptDialogInit : ScriptDialog
    {

        #region Controls

        private Label TextLabel;

        #endregion

        public ScriptDialogInit(HushScript ParentScript, Record Record)
            : base(ParentScript)
        {

            String Text = String.Empty;
            Text = String.Format("This script is requesting access to the record named \"{0}\". ", Record.Name);

            if (Record.Fields.Count > 0)
            {

                Text += "This record has the following fields:\n\n";
                foreach (Field Item in Record.Fields)
                {
                    Text += Item.Key + "\n";
                }

            }

            else
            {

                Text += "This record has no data.";

            }

            TextLabel = new Label();
            TextLabel.AutoSize = true;
            TextLabel.BackColor = SystemColors.Control;
            TextLabel.BorderStyle = BorderStyle.None;
            TextLabel.Font = new Font("Verdana", 11f, FontStyle.Regular);
            TextLabel.Location = new Point(0, 0);
            TextLabel.MaximumSize = new Size(480, 0);
            TextLabel.Text = Text;

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(TextLabel);
            ContentPanel.ResumeLayout();

        }

        #region Events

        private void OkButtonClick(Object Sender, EventArgs Args)
        {

            _ParentScript.RunBody(1, "");

        }

        private void CancelButtonClick(Object Sender, EventArgs Args)
        {

            Close();

        }

        #endregion

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            base.Initialize(Title);
            AddButton(OkButton);
            AddButton(CancelButton);

            OkButton.Click += OkButtonClick;
            CancelButton.Click += CancelButtonClick;

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
            TextLabel.AutoSize = true;
            TextLabel.BackColor = SystemColors.Control;
            TextLabel.BorderStyle = BorderStyle.None;
            TextLabel.Font = new Font("Verdana", 11f, FontStyle.Regular);
            TextLabel.Location = new Point(0, 0);
            TextLabel.MaximumSize = new Size(480, 0);
            TextLabel.Text = Text;

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(TextLabel);
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

    class ScriptDialogImage : ScriptDialog
    {

        #region Controls

        private PictureBox ImagePictureBox;
        private TextBox InputTextBox;

        #endregion

        public ScriptDialogImage(HushScript ParentScript, Image Image)
            : base(ParentScript)
        {

            ImagePictureBox = new PictureBox();
            ImagePictureBox.BackColor = SystemColors.ControlDark;
            ImagePictureBox.Image = Image;
            ImagePictureBox.Location = new Point(0, 0);
            ImagePictureBox.Size = new Size(480, 150);
            ImagePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            InputTextBox = new TextBox();
            InputTextBox.Location = new Point(10, 165);
            InputTextBox.Size = new Size(200, 25);

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(ImagePictureBox);
            ContentPanel.ResumeLayout();

            Controls.Add(InputTextBox);

            Resize(230);

        }

        public ScriptDialogImage(HushScript ParentScript, String Image)
            : base(ParentScript)
        {

            ImagePictureBox = new PictureBox();
            ImagePictureBox.BackColor = SystemColors.ControlDark;
            ImagePictureBox.Load(Image);
            ImagePictureBox.Location = new Point(0, 0);
            ImagePictureBox.Size = new Size(480, 150);
            ImagePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            InputTextBox = new TextBox();
            InputTextBox.Location = new Point(10, 165);
            InputTextBox.Size = new Size(200, 25);

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(ImagePictureBox);
            ContentPanel.ResumeLayout();

            Controls.Add(InputTextBox);

            Resize(230);

        }

        #region Events

        private void OkButtonClick(Object Sender, EventArgs Args)
        {

            _ParentScript.RunBody(1, InputTextBox.Text);

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

    class ScriptDialogInput : ScriptDialog
    {

        #region Controls

        private Label TextLabel;
        private TextBox InputTextBox;

        #endregion

        public ScriptDialogInput(HushScript ParentScript, String Text)
            : base(ParentScript)
        {

            if (Text.Length > 40)
            {
                Text = Text.Substring(0, 40);
            }

            TextLabel = new Label();
            TextLabel.AutoSize = false;
            TextLabel.AutoEllipsis = true;
            TextLabel.BackColor = SystemColors.Control;
            TextLabel.BorderStyle = BorderStyle.None;
            TextLabel.Font = new Font("Verdana", 9f, FontStyle.Regular);
            TextLabel.Location = new Point(0, 0);
            TextLabel.Size = new Size(480, 25);
            TextLabel.Text = Text;
            TextLabel.TextAlign = ContentAlignment.MiddleLeft;

            InputTextBox = new TextBox();
            InputTextBox.Location = new Point(0, 25);
            InputTextBox.Size = new Size(200, 25);

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Add(TextLabel);
            ContentPanel.Controls.Add(InputTextBox);
            ContentPanel.ResumeLayout();

            Resize(100);

        }

        #region Events

        private void OkButtonClick(Object Sender, EventArgs Args)
        {

            _ParentScript.RunBody(1, InputTextBox.Text);

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

}
