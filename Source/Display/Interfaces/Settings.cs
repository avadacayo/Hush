using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Collections.Generic;
using Hush.Client;

namespace Hush.Display.Interfaces
{

    class Settings : Interface
    {

        private Boolean _SyncSaved = true;
        private Boolean _SaveSaved = true;

        private GroupBox SaveGroupBox;
        private RadioButton AutomaticSaveRadioButton;
        private RadioButton ManualSaveRadioButton;
        private RadioButton PromptSaveRadioButton;
        private GroupBox SyncGroupBox;
        private Button SyncButton;
        private RadioButton ManualSyncRadioButton;
        private RadioButton PromptSyncRadioButton;
        private RadioButton AutomaticSyncRadioButton;
        private Button SaveButton;

        public override void ClosingSave()
        {

            SaveButtonClick(new Object(), new EventArgs());
            SyncButtonClick(new Object(), new EventArgs());
            _HasClosingSave = false;

        }

        public override void PostInit()
        {
            base.PostInit();
            AutomaticSaveRadioButton.Focus();
        }

        #region Designer

        protected override void Initialize(List<String> Title)
        {
            _SizeOverride = true;

            Title.Add("Settings");
            base.Initialize(Title);

            String SaveOption = DataManager.GetUserSaveOption();
            String SyncOption = DataManager.GetUserSyncOption();

            if (SaveOption == "Manual") { ManualSaveRadioButton.Checked = true; }
            else if (SaveOption == "Prompt") { PromptSaveRadioButton.Checked = true; }
            else { AutomaticSaveRadioButton.Checked = true; }

            if (SyncOption == "Manual") { ManualSyncRadioButton.Checked = true; }
            else if (SyncOption == "Prompt") { PromptSyncRadioButton.Checked = true; }
            else { AutomaticSyncRadioButton.Checked = true; }

            _HasClosingSave = false;

        }

        protected override void InitializeComponent()
        {
            this.SaveGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ManualSaveRadioButton = new System.Windows.Forms.RadioButton();
            this.PromptSaveRadioButton = new System.Windows.Forms.RadioButton();
            this.AutomaticSaveRadioButton = new System.Windows.Forms.RadioButton();
            this.SyncGroupBox = new System.Windows.Forms.GroupBox();
            this.SyncButton = new System.Windows.Forms.Button();
            this.ManualSyncRadioButton = new System.Windows.Forms.RadioButton();
            this.PromptSyncRadioButton = new System.Windows.Forms.RadioButton();
            this.AutomaticSyncRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveGroupBox.SuspendLayout();
            this.SyncGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveGroupBox
            // 
            this.SaveGroupBox.Controls.Add(this.SaveButton);
            this.SaveGroupBox.Controls.Add(this.ManualSaveRadioButton);
            this.SaveGroupBox.Controls.Add(this.PromptSaveRadioButton);
            this.SaveGroupBox.Controls.Add(this.AutomaticSaveRadioButton);
            this.SaveGroupBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SaveGroupBox.Name = "SaveGroupBox";
            this.SaveGroupBox.Size = new System.Drawing.Size(382, 94);
            this.SaveGroupBox.TabIndex = 0;
            this.SaveGroupBox.TabStop = false;
            this.SaveGroupBox.Text = "Save Settings";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(301, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 75);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // ManualSaveRadioButton
            // 
            this.ManualSaveRadioButton.AutoSize = true;
            this.ManualSaveRadioButton.Location = new System.Drawing.Point(6, 66);
            this.ManualSaveRadioButton.Name = "ManualSaveRadioButton";
            this.ManualSaveRadioButton.Size = new System.Drawing.Size(74, 21);
            this.ManualSaveRadioButton.TabIndex = 2;
            this.ManualSaveRadioButton.TabStop = true;
            this.ManualSaveRadioButton.Text = "Manual";
            this.ManualSaveRadioButton.UseVisualStyleBackColor = true;
            this.ManualSaveRadioButton.CheckedChanged += new System.EventHandler(this.SetSaveChanged);
            // 
            // PromptSaveRadioButton
            // 
            this.PromptSaveRadioButton.AutoSize = true;
            this.PromptSaveRadioButton.Location = new System.Drawing.Point(6, 43);
            this.PromptSaveRadioButton.Name = "PromptSaveRadioButton";
            this.PromptSaveRadioButton.Size = new System.Drawing.Size(77, 21);
            this.PromptSaveRadioButton.TabIndex = 1;
            this.PromptSaveRadioButton.TabStop = true;
            this.PromptSaveRadioButton.Text = "Prompt";
            this.PromptSaveRadioButton.UseVisualStyleBackColor = true;
            this.PromptSaveRadioButton.CheckedChanged += new System.EventHandler(this.SetSaveChanged);
            // 
            // AutomaticSaveRadioButton
            // 
            this.AutomaticSaveRadioButton.AutoSize = true;
            this.AutomaticSaveRadioButton.Location = new System.Drawing.Point(6, 20);
            this.AutomaticSaveRadioButton.Name = "AutomaticSaveRadioButton";
            this.AutomaticSaveRadioButton.Size = new System.Drawing.Size(97, 21);
            this.AutomaticSaveRadioButton.TabIndex = 0;
            this.AutomaticSaveRadioButton.TabStop = true;
            this.AutomaticSaveRadioButton.Text = "Automatic";
            this.AutomaticSaveRadioButton.UseVisualStyleBackColor = true;
            this.AutomaticSaveRadioButton.CheckedChanged += new System.EventHandler(this.SetSaveChanged);
            // 
            // SyncGroupBox
            // 
            this.SyncGroupBox.Controls.Add(this.SyncButton);
            this.SyncGroupBox.Controls.Add(this.ManualSyncRadioButton);
            this.SyncGroupBox.Controls.Add(this.PromptSyncRadioButton);
            this.SyncGroupBox.Controls.Add(this.AutomaticSyncRadioButton);
            this.SyncGroupBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncGroupBox.Location = new System.Drawing.Point(3, 103);
            this.SyncGroupBox.Name = "SyncGroupBox";
            this.SyncGroupBox.Size = new System.Drawing.Size(382, 94);
            this.SyncGroupBox.TabIndex = 4;
            this.SyncGroupBox.TabStop = false;
            this.SyncGroupBox.Text = "Sync Settings";
            // 
            // SyncButton
            // 
            this.SyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SyncButton.Location = new System.Drawing.Point(301, 13);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(75, 75);
            this.SyncButton.TabIndex = 3;
            this.SyncButton.Text = "Save";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButtonClick);
            // 
            // ManualSyncRadioButton
            // 
            this.ManualSyncRadioButton.AutoSize = true;
            this.ManualSyncRadioButton.Location = new System.Drawing.Point(6, 66);
            this.ManualSyncRadioButton.Name = "ManualSyncRadioButton";
            this.ManualSyncRadioButton.Size = new System.Drawing.Size(74, 21);
            this.ManualSyncRadioButton.TabIndex = 2;
            this.ManualSyncRadioButton.TabStop = true;
            this.ManualSyncRadioButton.Text = "Manual";
            this.ManualSyncRadioButton.UseVisualStyleBackColor = true;
            this.ManualSyncRadioButton.CheckedChanged += new System.EventHandler(this.SetSyncChanged);
            // 
            // PromptSyncRadioButton
            // 
            this.PromptSyncRadioButton.AutoSize = true;
            this.PromptSyncRadioButton.Location = new System.Drawing.Point(6, 43);
            this.PromptSyncRadioButton.Name = "PromptSyncRadioButton";
            this.PromptSyncRadioButton.Size = new System.Drawing.Size(77, 21);
            this.PromptSyncRadioButton.TabIndex = 1;
            this.PromptSyncRadioButton.TabStop = true;
            this.PromptSyncRadioButton.Text = "Prompt";
            this.PromptSyncRadioButton.UseVisualStyleBackColor = true;
            this.PromptSyncRadioButton.CheckedChanged += new System.EventHandler(this.SetSyncChanged);
            // 
            // AutomaticSyncRadioButton
            // 
            this.AutomaticSyncRadioButton.AutoSize = true;
            this.AutomaticSyncRadioButton.Location = new System.Drawing.Point(6, 20);
            this.AutomaticSyncRadioButton.Name = "AutomaticSyncRadioButton";
            this.AutomaticSyncRadioButton.Size = new System.Drawing.Size(97, 21);
            this.AutomaticSyncRadioButton.TabIndex = 0;
            this.AutomaticSyncRadioButton.TabStop = true;
            this.AutomaticSyncRadioButton.Text = "Automatic";
            this.AutomaticSyncRadioButton.UseVisualStyleBackColor = true;
            this.AutomaticSyncRadioButton.CheckedChanged += new System.EventHandler(this.SetSyncChanged);
            // 
            // Settings
            // 
            this.Controls.Add(this.SyncGroupBox);
            this.Controls.Add(this.SaveGroupBox);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(388, 100);
            this.SaveGroupBox.ResumeLayout(false);
            this.SaveGroupBox.PerformLayout();
            this.SyncGroupBox.ResumeLayout(false);
            this.SyncGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Events

        private void SetSaveChanged(Object Sender, EventArgs Args)
        {

            _SaveSaved = false;
            _HasClosingSave = true;

        }

        private void SetSyncChanged(Object Sender, EventArgs Args)
        {

            _SyncSaved = false;
            _HasClosingSave = true;

        }

        private void SaveButtonClick(Object Sender, EventArgs Args)
        {

            _SaveSaved = true;
            if (_SyncSaved) { _HasClosingSave = false; }

            String NewSaveValue = "Automatic";

            if (ManualSaveRadioButton.Checked == true)
            {
                NewSaveValue = "Manual";
            }

            if (PromptSaveRadioButton.Checked == true)
            {
                NewSaveValue = "Prompt";
            }

            DataManager.SetUserSaveOption(NewSaveValue);

            _HasClosingSave = false;

        }

        private void SyncButtonClick(Object Sender, EventArgs Args)
        {

            _SyncSaved = true;
            if (_SaveSaved) { _HasClosingSave = false; }

            String NewSyncValue = "Automatic";

            if (ManualSyncRadioButton.Checked == true)
            {
                NewSyncValue = "Manual";
            }

            if (PromptSyncRadioButton.Checked == true)
            {
                NewSyncValue = "Prompt";
            }

            DataManager.SetUserSyncOption(NewSyncValue);

        }

        #endregion

    }

}
