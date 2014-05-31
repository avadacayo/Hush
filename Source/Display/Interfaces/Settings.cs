using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Collections.Generic;

namespace Hush.Display.Interfaces
{

    class Settings : Interface
    {

        private Panel ContentPanel;
        private Label TitleLabel;

        private Label ThemeLabel;
        private Panel ThemePanel;
        private ComboBox ThemeComboBox;

        private Label SaveLabel;
        private Panel SavePanel;
        private RadioButton ManualSaveRadioButton;
        private RadioButton AutomaticSaveRadioButton;
        private RadioButton PromptSaveRadioButton;

        private Label SyncLabel;
        private Panel SyncPanel;
        private RadioButton ManualSyncRadioButton;
        private RadioButton AutomaticSyncRadioButton;
        private RadioButton PromptSyncRadioButton;

        private Label UpdateLabel;
        private Panel UpdatePanel;
        private RadioButton ManualUpdateRadioButton;
        private RadioButton AutomaticUpdateRadioButton;
        private RadioButton PromptUpdateRadioButton;

        private Label ScriptLabel;
        private Panel ScriptPanel;
        private RadioButton ManualScriptRadioButton;
        private RadioButton AutomaticScriptRadioButton;
        private RadioButton PromptScriptRadioButton;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Settings");

            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {

            BackColor = Color.White;
            Height = 600;
            Width = 500;

            ContentPanel = new Panel();
            TitleLabel = new Label();

            ThemeLabel = new Label();
            ThemePanel = new Panel();
            ThemeComboBox = new ComboBox();

            SaveLabel = new Label();
            SavePanel = new Panel();
            ManualSaveRadioButton = new RadioButton();
            AutomaticSaveRadioButton = new RadioButton();
            PromptSaveRadioButton = new RadioButton();

            SyncLabel = new Label();
            SyncPanel = new Panel();
            ManualSyncRadioButton = new RadioButton();
            AutomaticSyncRadioButton = new RadioButton();
            PromptSyncRadioButton = new RadioButton();

            UpdateLabel = new Label();
            UpdatePanel = new Panel();
            ManualUpdateRadioButton = new RadioButton();
            AutomaticUpdateRadioButton = new RadioButton();
            PromptUpdateRadioButton = new RadioButton();

            ScriptLabel = new Label();
            ScriptPanel = new Panel();
            ManualScriptRadioButton = new RadioButton();
            AutomaticScriptRadioButton = new RadioButton();
            PromptScriptRadioButton = new RadioButton();

            ContentPanel.SuspendLayout();
            SuspendLayout();

            ContentPanel.AutoScroll = false;
            ContentPanel.HorizontalScroll.Enabled = false;
            ContentPanel.AutoScroll = true;
            //ContentPanel.BackColor = Color.FromArgb(100, 140, 255);
            ContentPanel.Location = new Point(10, 40);
            ContentPanel.Size = new Size(Width - 20, 550);

            TitleLabel.BackColor = Color.FromArgb(70, 140, 210);
            TitleLabel.Font = GetFontVariant(true);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(10, 10);
            TitleLabel.Padding = new Padding(10, 0, 0, 0);
            TitleLabel.Size = new Size(Width - 20, 30);
            TitleLabel.Text = "Settings";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;

            ThemeLabel.BackColor = Color.FromArgb(200, 200, 200);
            ThemeLabel.Font = GetFontVariant(true);
            ThemeLabel.ForeColor = Color.White;
            ThemeLabel.Location = new Point(0, 0);
            ThemeLabel.Padding = new Padding(20, 0, 0, 0);
            ThemeLabel.Size = new Size(Width - 20, 30);
            ThemeLabel.Text = "Theme Options";
            ThemeLabel.TextAlign = ContentAlignment.MiddleLeft;

            ThemePanel.BackColor = Color.FromArgb(230, 230, 230);
            ThemePanel.Size = new Size(Width - 20, 41);
            PlaceBelow(ThemeLabel, ThemePanel);

            ThemeComboBox.Location = new Point(10, 10);

            SaveLabel.BackColor = Color.FromArgb(200, 200, 200);
            SaveLabel.Font = GetFontVariant(true);
            SaveLabel.ForeColor = Color.White;
            SaveLabel.Padding = new Padding(20, 0, 0, 0);
            SaveLabel.Size = new Size(Width - 20, 30);
            SaveLabel.Text = "Save Options";
            SaveLabel.TextAlign = ContentAlignment.MiddleLeft;
            PlaceBelow(ThemePanel, SaveLabel);

            SavePanel.BackColor = Color.FromArgb(230, 230, 230);
            SavePanel.Size = new Size(Width - 20, 92);
            PlaceBelow(SaveLabel, SavePanel);

            ManualSaveRadioButton.Font = GetFontVariant(false);
            ManualSaveRadioButton.Location = new Point(10, 10);
            ManualSaveRadioButton.Size = new Size(300, 24);
            ManualSaveRadioButton.Text = "Manual Save";

            AutomaticSaveRadioButton.Font = GetFontVariant(false);
            AutomaticSaveRadioButton.Size = new Size(300, 24);
            AutomaticSaveRadioButton.Text = "Automatic Save";
            PlaceBelow(ManualSaveRadioButton, AutomaticSaveRadioButton);

            PromptSaveRadioButton.Font = GetFontVariant(false);
            PromptSaveRadioButton.Size = new Size(300, 24);
            PromptSaveRadioButton.Text = "Prompt Save";
            PlaceBelow(AutomaticSaveRadioButton, PromptSaveRadioButton);

            SyncLabel.BackColor = Color.FromArgb(200, 200, 200);
            SyncLabel.Font = GetFontVariant(true);
            SyncLabel.ForeColor = Color.White;
            SyncLabel.Padding = new Padding(20, 0, 0, 0);
            SyncLabel.Size = new Size(Width - 20, 30);
            SyncLabel.Text = "Sync Options";
            SyncLabel.TextAlign = ContentAlignment.MiddleLeft;
            PlaceBelow(SavePanel, SyncLabel);

            SyncPanel.BackColor = Color.FromArgb(230, 230, 230);
            SyncPanel.Size = new Size(Width - 20, 92);
            PlaceBelow(SyncLabel, SyncPanel);

            ManualSyncRadioButton.Font = GetFontVariant(false);
            ManualSyncRadioButton.Location = new Point(10, 10);
            ManualSyncRadioButton.Size = new Size(300, 24);
            ManualSyncRadioButton.Text = "Manual Save";

            AutomaticSyncRadioButton.Font = GetFontVariant(false);
            AutomaticSyncRadioButton.Size = new Size(300, 24);
            AutomaticSyncRadioButton.Text = "Automatic Save";
            PlaceBelow(ManualSyncRadioButton, AutomaticSyncRadioButton);

            PromptSyncRadioButton.Font = GetFontVariant(false);
            PromptSyncRadioButton.Size = new Size(300, 24);
            PromptSyncRadioButton.Text = "Prompt Save";
            PlaceBelow(AutomaticSyncRadioButton, PromptSyncRadioButton);

            UpdateLabel.BackColor = Color.FromArgb(200, 200, 200);
            UpdateLabel.Font = GetFontVariant(true);
            UpdateLabel.ForeColor = Color.White;
            UpdateLabel.Padding = new Padding(20, 0, 0, 0);
            UpdateLabel.Size = new Size(Width - 20, 30);
            UpdateLabel.Text = "Update Options";
            UpdateLabel.TextAlign = ContentAlignment.MiddleLeft;
            PlaceBelow(SyncPanel, UpdateLabel);

            UpdatePanel.BackColor = Color.FromArgb(230, 230, 230);
            UpdatePanel.Size = new Size(Width - 20, 92);
            PlaceBelow(UpdateLabel, UpdatePanel);

            ManualUpdateRadioButton.Font = GetFontVariant(false);
            ManualUpdateRadioButton.Location = new Point(10, 10);
            ManualUpdateRadioButton.Size = new Size(300, 24);
            ManualUpdateRadioButton.Text = "Manual Save";

            AutomaticUpdateRadioButton.Font = GetFontVariant(false);
            AutomaticUpdateRadioButton.Size = new Size(300, 24);
            AutomaticUpdateRadioButton.Text = "Automatic Save";
            PlaceBelow(ManualUpdateRadioButton, AutomaticUpdateRadioButton);

            PromptUpdateRadioButton.Font = GetFontVariant(false);
            PromptUpdateRadioButton.Size = new Size(300, 24);
            PromptUpdateRadioButton.Text = "Prompt Save";
            PlaceBelow(AutomaticUpdateRadioButton, PromptUpdateRadioButton);

            //
            ScriptLabel.BackColor = Color.FromArgb(200, 200, 200);
            ScriptLabel.Font = GetFontVariant(true);
            ScriptLabel.ForeColor = Color.White;
            ScriptLabel.Padding = new Padding(20, 0, 0, 0);
            ScriptLabel.Size = new Size(Width - 20, 30);
            ScriptLabel.Text = "Script Options";
            ScriptLabel.TextAlign = ContentAlignment.MiddleLeft;
            PlaceBelow(UpdatePanel, ScriptLabel);

            ScriptPanel.BackColor = Color.FromArgb(230, 230, 230);
            ScriptPanel.Size = new Size(Width - 20, 92);
            PlaceBelow(ScriptLabel, ScriptPanel);

            ManualScriptRadioButton.Font = GetFontVariant(false);
            ManualScriptRadioButton.Location = new Point(10, 10);
            ManualScriptRadioButton.Size = new Size(300, 24);
            ManualScriptRadioButton.Text = "Manual Save";

            AutomaticScriptRadioButton.Font = GetFontVariant(false);
            AutomaticScriptRadioButton.Size = new Size(300, 24);
            AutomaticScriptRadioButton.Text = "Automatic Save";
            PlaceBelow(ManualScriptRadioButton, AutomaticScriptRadioButton);

            PromptScriptRadioButton.Font = GetFontVariant(false);
            PromptScriptRadioButton.Size = new Size(300, 24);
            PromptScriptRadioButton.Text = "Prompt Save";
            PlaceBelow(AutomaticScriptRadioButton, PromptScriptRadioButton);

            ThemePanel.Controls.Add(ThemeComboBox);

            SavePanel.Controls.Add(ManualSaveRadioButton);
            SavePanel.Controls.Add(AutomaticSaveRadioButton);
            SavePanel.Controls.Add(PromptSaveRadioButton);

            SyncPanel.Controls.Add(ManualSyncRadioButton);
            SyncPanel.Controls.Add(AutomaticSyncRadioButton);
            SyncPanel.Controls.Add(PromptSyncRadioButton);

            UpdatePanel.Controls.Add(ManualUpdateRadioButton);
            UpdatePanel.Controls.Add(AutomaticUpdateRadioButton);
            UpdatePanel.Controls.Add(PromptUpdateRadioButton);

            ScriptPanel.Controls.Add(ManualScriptRadioButton);
            ScriptPanel.Controls.Add(AutomaticScriptRadioButton);
            ScriptPanel.Controls.Add(PromptScriptRadioButton);

            ContentPanel.Controls.Add(ThemeLabel);
            ContentPanel.Controls.Add(ThemePanel);
            ContentPanel.Controls.Add(SaveLabel);
            ContentPanel.Controls.Add(SavePanel);
            ContentPanel.Controls.Add(SyncLabel);
            ContentPanel.Controls.Add(SyncPanel);
            ContentPanel.Controls.Add(UpdateLabel);
            ContentPanel.Controls.Add(UpdatePanel);
            ContentPanel.Controls.Add(ScriptLabel);
            ContentPanel.Controls.Add(ScriptPanel);

            Controls.Add(ContentPanel);
            Controls.Add(TitleLabel);

            ContentPanel.ResumeLayout(true);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

    }

}
