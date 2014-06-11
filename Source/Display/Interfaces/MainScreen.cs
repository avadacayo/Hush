using Hush.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Hush.Display.Interfaces
{

    class MainScreen : Interface
    {
        private Button AddRecordButton;
        private Button AdvancedSearchButton;
        private Button DeleteRecordButton;
        private Button EditRecordButton;
        private Panel GeneralFunctionsPanel;
        private LinkLabel LogoutLinkLabel;
        private Button ManageCategoriesButton;
        private Panel RecordFunctionsPanel;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Button SettingsButton;
        private Button SyncButton;
        private Panel UserPanel;
        private Label UserLabel;
        private Label UsernameLabel;

        // listbox to replaced by custom control
        private ListBox listBox1;
        
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Main");

            base.Initialize(Title);
            UsernameLabel.Text = DataHolder.CurrentUser.FirstName;
            
        }

        protected override void InitializeComponent()
        {
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.AdvancedSearchButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.GeneralFunctionsPanel = new System.Windows.Forms.Panel();
            this.SyncButton = new System.Windows.Forms.Button();
            this.ManageCategoriesButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RecordFunctionsPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GeneralFunctionsPanel.SuspendLayout();
            this.RecordFunctionsPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(2, 3);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(53, 23);
            this.AddRecordButton.TabIndex = 0;
            this.AddRecordButton.Text = "add";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedSearchButton.Location = new System.Drawing.Point(616, 10);
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Size = new System.Drawing.Size(101, 23);
            this.AdvancedSearchButton.TabIndex = 0;
            this.AdvancedSearchButton.Text = "advanced search";
            this.AdvancedSearchButton.UseVisualStyleBackColor = true;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(119, 3);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(53, 23);
            this.DeleteRecordButton.TabIndex = 2;
            this.DeleteRecordButton.Text = "delete";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.Location = new System.Drawing.Point(61, 3);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(53, 23);
            this.EditRecordButton.TabIndex = 1;
            this.EditRecordButton.Text = "edit";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            // 
            // GeneralFunctionsPanel
            // 
            this.GeneralFunctionsPanel.BackColor = System.Drawing.Color.White;
            this.GeneralFunctionsPanel.Controls.Add(this.SyncButton);
            this.GeneralFunctionsPanel.Controls.Add(this.ManageCategoriesButton);
            this.GeneralFunctionsPanel.Controls.Add(this.SettingsButton);
            this.GeneralFunctionsPanel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralFunctionsPanel.Location = new System.Drawing.Point(10, 111);
            this.GeneralFunctionsPanel.Name = "GeneralFunctionsPanel";
            this.GeneralFunctionsPanel.Size = new System.Drawing.Size(175, 284);
            this.GeneralFunctionsPanel.TabIndex = 1;
            // 
            // SyncButton
            // 
            this.SyncButton.Location = new System.Drawing.Point(4, 5);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(168, 23);
            this.SyncButton.TabIndex = 0;
            this.SyncButton.Text = "Online Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            // 
            // ManageCategoriesButton
            // 
            this.ManageCategoriesButton.Location = new System.Drawing.Point(4, 61);
            this.ManageCategoriesButton.Name = "ManageCategoriesButton";
            this.ManageCategoriesButton.Size = new System.Drawing.Size(168, 23);
            this.ManageCategoriesButton.TabIndex = 1;
            this.ManageCategoriesButton.Text = "Manage Categories";
            this.ManageCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(4, 33);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(169, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(4, 28);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.LogoutLinkLabel.TabIndex = 0;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            // 
            // RecordFunctionsPanel
            // 
            this.RecordFunctionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RecordFunctionsPanel.Controls.Add(this.AddRecordButton);
            this.RecordFunctionsPanel.Controls.Add(this.EditRecordButton);
            this.RecordFunctionsPanel.Controls.Add(this.DeleteRecordButton);
            this.RecordFunctionsPanel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordFunctionsPanel.Location = new System.Drawing.Point(10, 76);
            this.RecordFunctionsPanel.Name = "RecordFunctionsPanel";
            this.RecordFunctionsPanel.Size = new System.Drawing.Size(175, 29);
            this.RecordFunctionsPanel.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(562, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(47, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(197, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(359, 20);
            this.SearchTextBox.TabIndex = 4;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.White;
            this.UserPanel.Controls.Add(this.LogoutLinkLabel);
            this.UserPanel.Controls.Add(this.UsernameLabel);
            this.UserPanel.Controls.Add(this.UserLabel);
            this.UserPanel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPanel.Location = new System.Drawing.Point(10, 12);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(175, 58);
            this.UserPanel.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(55, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(64, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "username";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(4, 7);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(45, 16);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "User:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(197, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 355);
            this.listBox1.TabIndex = 5;
            // 
            // MainScreen
            // 
            this.Controls.Add(this.AdvancedSearchButton);
            this.Controls.Add(this.GeneralFunctionsPanel);
            this.Controls.Add(this.RecordFunctionsPanel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.listBox1);
            this.Name = "MainScreen";
            this.GeneralFunctionsPanel.ResumeLayout(false);
            this.RecordFunctionsPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

}
