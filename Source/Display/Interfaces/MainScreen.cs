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
            
            AddRecordButton = new Button();
            AdvancedSearchButton = new Button();
            DeleteRecordButton = new Button();
            EditRecordButton = new Button();
            GeneralFunctionsPanel = new Panel();
            LogoutLinkLabel = new LinkLabel();
            ManageCategoriesButton = new Button();
            RecordFunctionsPanel = new Panel();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            SettingsButton = new Button();
            SyncButton = new Button();
            UserPanel = new Panel();
            UserLabel = new Label();
            UsernameLabel = new Label();

            listBox1 = new ListBox();
            
            AddRecordButton.Location = new System.Drawing.Point(2, 3);
            AddRecordButton.Name = "AddRecordButton";
            AddRecordButton.Size = new System.Drawing.Size(53, 23);
            AddRecordButton.Text = "add";
            AddRecordButton.UseVisualStyleBackColor = true;

            AdvancedSearchButton.Location = new System.Drawing.Point(616, 10);
            AdvancedSearchButton.Name = "AdvancedSearchButton";
            AdvancedSearchButton.Size = new System.Drawing.Size(101, 23);
            AdvancedSearchButton.Text = "advanced search";
            AdvancedSearchButton.UseVisualStyleBackColor = true;

            DeleteRecordButton.Location = new System.Drawing.Point(119, 3);
            DeleteRecordButton.Name = "DeleteRecordButton";
            DeleteRecordButton.Size = new System.Drawing.Size(53, 23);
            DeleteRecordButton.Text = "delete";
            DeleteRecordButton.UseVisualStyleBackColor = true;

            EditRecordButton.Location = new System.Drawing.Point(61, 3);
            EditRecordButton.Name = "EditRecordButton";
            EditRecordButton.Size = new System.Drawing.Size(53, 23);
            EditRecordButton.Text = "edit";
            EditRecordButton.UseVisualStyleBackColor = true;
             
            GeneralFunctionsPanel.BackColor = System.Drawing.Color.White;
            GeneralFunctionsPanel.Controls.Add(SyncButton);
            GeneralFunctionsPanel.Controls.Add(ManageCategoriesButton);
            GeneralFunctionsPanel.Controls.Add(SettingsButton);
            GeneralFunctionsPanel.Location = new System.Drawing.Point(10, 111);
            GeneralFunctionsPanel.Name = "GeneralFunctionsPanel";
            GeneralFunctionsPanel.Size = new System.Drawing.Size(175, 284); 
            
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Location = new System.Drawing.Point(4, 28);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            LogoutLinkLabel.Text = "Logout";

            ManageCategoriesButton.Location = new System.Drawing.Point(4, 61);
            ManageCategoriesButton.Name = "ManageCategoriesButton";
            ManageCategoriesButton.Size = new System.Drawing.Size(168, 23);
            ManageCategoriesButton.Text = "Manage Categories";
            ManageCategoriesButton.UseVisualStyleBackColor = true;

            RecordFunctionsPanel.BackColor = System.Drawing.SystemColors.Control;
            RecordFunctionsPanel.Controls.Add(AddRecordButton);
            RecordFunctionsPanel.Controls.Add(EditRecordButton);
            RecordFunctionsPanel.Controls.Add(DeleteRecordButton);
            RecordFunctionsPanel.Location = new System.Drawing.Point(10, 76);
            RecordFunctionsPanel.Name = "RecordFunctionsPanel";
            RecordFunctionsPanel.Size = new System.Drawing.Size(175, 29);
            
            SearchButton.Location = new System.Drawing.Point(562, 10);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(47, 23);
            SearchButton.Text = "search";
            SearchButton.UseVisualStyleBackColor = true;

            SearchTextBox.Location = new System.Drawing.Point(197, 12);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new System.Drawing.Size(359, 20);
             
            SettingsButton.Location = new System.Drawing.Point(4, 33);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new System.Drawing.Size(169, 23);
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            
            SyncButton.Location = new System.Drawing.Point(4, 5);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new System.Drawing.Size(168, 23);
            SyncButton.Text = "Online Sync";
            SyncButton.UseVisualStyleBackColor = true;

            UserLabel.AutoSize = true;
            UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UserLabel.Location = new System.Drawing.Point(4, 7);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new System.Drawing.Size(45, 16);
            UserLabel.Text = "User:";

            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(55, 9);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(53, 13);
            UsernameLabel.Text = "username";

            UserPanel.BackColor = System.Drawing.Color.White;
            UserPanel.Controls.Add(LogoutLinkLabel);
            UserPanel.Controls.Add(UsernameLabel);
            UserPanel.Controls.Add(UserLabel);
            UserPanel.Location = new System.Drawing.Point(10, 12);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new System.Drawing.Size(175, 58);

            // 
            // listBox1 --- USED AS PLACEHOLDER ONLY
            //              WILL BE REPLACED BY CUSTOM CONTROL
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(197, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(520, 355);
            listBox1.TabIndex = 5;
            //
            //

            Controls.Add(AdvancedSearchButton);
            Controls.Add(GeneralFunctionsPanel);
            Controls.Add(RecordFunctionsPanel);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(UserPanel);
            
            Controls.Add(listBox1);
            
        }

    }

}
