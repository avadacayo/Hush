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
        private LinkLabel LogoutLinkLabel;
        private Button ManageCategoriesButton;
        private Panel RecordFunctionsPanel;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Button SettingsButton;
        private Panel UserPanel;
        private Label UserLabel;
        private Label UsernameLabel;
        private LinkLabel ProfileLinkLabel;
        private Button ViewButton;
        List<Client.Model.Record> recordList;
        private Label AccountsStoredLabel;

        // listbox to replaced by custom control
        private ListBox RecordsListBox;
        
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Main");

            base.Initialize(Title);
            UsernameLabel.Text = DataHolder.CurrentUser.Username;
            
        }

        protected override void InitializeComponent()
        {
            this.AccountsStoredLabel = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ManageCategoriesButton = new System.Windows.Forms.Button();
            this.AdvancedSearchButton = new System.Windows.Forms.Button();
            this.RecordFunctionsPanel = new System.Windows.Forms.Panel();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.ProfileLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.RecordsListBox = new System.Windows.Forms.ListBox();
            this.RecordFunctionsPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountsStoredLabel
            // 
            this.AccountsStoredLabel.AutoSize = true;
            this.AccountsStoredLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.AccountsStoredLabel.Location = new System.Drawing.Point(29, 79);
            this.AccountsStoredLabel.Name = "AccountsStoredLabel";
            this.AccountsStoredLabel.Size = new System.Drawing.Size(130, 17);
            this.AccountsStoredLabel.TabIndex = 9;
            this.AccountsStoredLabel.Text = "Accounts stored:";
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(24, 333);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(126, 25);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View Record";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(24, 422);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(110, 47);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ManageCategoriesButton
            // 
            this.ManageCategoriesButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCategoriesButton.Location = new System.Drawing.Point(151, 422);
            this.ManageCategoriesButton.Name = "ManageCategoriesButton";
            this.ManageCategoriesButton.Size = new System.Drawing.Size(110, 47);
            this.ManageCategoriesButton.TabIndex = 7;
            this.ManageCategoriesButton.Text = "Manage Categories";
            this.ManageCategoriesButton.UseVisualStyleBackColor = true;
            this.ManageCategoriesButton.Click += new System.EventHandler(this.ManageCategoriesButton_Click);
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedSearchButton.Location = new System.Drawing.Point(273, 422);
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Size = new System.Drawing.Size(110, 47);
            this.AdvancedSearchButton.TabIndex = 8;
            this.AdvancedSearchButton.Text = "Advanced Search";
            this.AdvancedSearchButton.UseVisualStyleBackColor = true;
            this.AdvancedSearchButton.Click += new System.EventHandler(this.AdvancedSearchButton_Click);
            // 
            // RecordFunctionsPanel
            // 
            this.RecordFunctionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RecordFunctionsPanel.Controls.Add(this.AddRecordButton);
            this.RecordFunctionsPanel.Controls.Add(this.EditRecordButton);
            this.RecordFunctionsPanel.Controls.Add(this.DeleteRecordButton);
            this.RecordFunctionsPanel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordFunctionsPanel.Location = new System.Drawing.Point(156, 332);
            this.RecordFunctionsPanel.Name = "RecordFunctionsPanel";
            this.RecordFunctionsPanel.Size = new System.Drawing.Size(227, 29);
            this.RecordFunctionsPanel.TabIndex = 3;
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(0, 1);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(70, 25);
            this.AddRecordButton.TabIndex = 0;
            this.AddRecordButton.Text = "Add";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.Location = new System.Drawing.Point(79, 1);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(70, 25);
            this.EditRecordButton.TabIndex = 1;
            this.EditRecordButton.Text = "Edit";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(157, 1);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(70, 25);
            this.DeleteRecordButton.TabIndex = 2;
            this.DeleteRecordButton.Text = "Delete";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(273, 381);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(110, 25);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(24, 382);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(237, 24);
            this.SearchTextBox.TabIndex = 4;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.LightGray;
            this.UserPanel.Controls.Add(this.ProfileLinkLabel);
            this.UserPanel.Controls.Add(this.LogoutLinkLabel);
            this.UserPanel.Controls.Add(this.UsernameLabel);
            this.UserPanel.Controls.Add(this.UserLabel);
            this.UserPanel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPanel.Location = new System.Drawing.Point(24, 13);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(359, 54);
            this.UserPanel.TabIndex = 0;
            // 
            // ProfileLinkLabel
            // 
            this.ProfileLinkLabel.AutoSize = true;
            this.ProfileLinkLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLinkLabel.Location = new System.Drawing.Point(301, 10);
            this.ProfileLinkLabel.Name = "ProfileLinkLabel";
            this.ProfileLinkLabel.Size = new System.Drawing.Size(43, 13);
            this.ProfileLinkLabel.TabIndex = 2;
            this.ProfileLinkLabel.TabStop = true;
            this.ProfileLinkLabel.Text = "Profile";
            this.ProfileLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProfileLinkLabel_LinkClicked);
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLinkLabel.Location = new System.Drawing.Point(301, 31);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(4, 27);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "username";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(4, 7);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(49, 17);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User:";
            // 
            // RecordsListBox
            // 
            this.RecordsListBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsListBox.FormattingEnabled = true;
            this.RecordsListBox.ItemHeight = 16;
            this.RecordsListBox.Items.AddRange(new object[] {
            "LIST OF RECORDS"});
            this.RecordsListBox.Location = new System.Drawing.Point(24, 99);
            this.RecordsListBox.Name = "RecordsListBox";
            this.RecordsListBox.Size = new System.Drawing.Size(359, 212);
            this.RecordsListBox.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.Controls.Add(this.AccountsStoredLabel);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ManageCategoriesButton);
            this.Controls.Add(this.AdvancedSearchButton);
            this.Controls.Add(this.RecordFunctionsPanel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.RecordsListBox);
            this.Name = "MainScreen";
            this.RecordFunctionsPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Int32 RecordSelected { get; set; }

        private void ManageCategoriesButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new CategoryManagement());
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterfaceDialog(new Settings());
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (this.RecordsListBox.SelectedIndex >= 0)
            {
                DataHolder.RecordIndex = this.RecordsListBox.SelectedIndex;
                Program.Window.ShowInterface(new ViewRecord());
            }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new Add());
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            if (this.RecordsListBox.SelectedIndex >= 0)
            {
                DataHolder.RecordIndex = this.RecordsListBox.SelectedIndex;
                Program.Window.ShowInterface(new Edit());
            }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {

            if (this.RecordsListBox.SelectedIndex >= 0)
            {
                DataHolder.RecordIndex = this.RecordsListBox.SelectedIndex;
                Program.Window.ShowInterface(new Delete());

                AddRecordsToListBox();
            }
        }

        private void ProfileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Window.ShowInterface(new UserProfile());
        }

        protected override void OnLoad(EventArgs e)
        {
            AddRecordsToListBox();
            if (this.RecordsListBox.Items.Count == 0)
            {

                ViewButton.Enabled = false;
                EditRecordButton.Enabled = false;
                DeleteRecordButton.Enabled = false;
            }
            else
            {
                ViewButton.Enabled = true;
                EditRecordButton.Enabled = true;
                DeleteRecordButton.Enabled = true;
            }
        }

        void AddRecordsToListBox()
        {
            this.RecordsListBox.Items.Clear();
            try
            {
                //DataHolder.RecordList = Client.DataHolder.CurrentUser.Records;

                if (DataHolder.RecordList == null)
                {
                    //dont add text msg as a record, it will cause exception when there is no record to be operated. thinking..
                    //this.RecordsListBox.Items.Add("no accounts stored");
                }
                else
                {
                    foreach (Client.Model.Record r in DataHolder.RecordList)
                    {
                        this.RecordsListBox.Items.Add(r.Name.ToString());
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
       
        private void SearchButton_Click(object sender, EventArgs e)
        {
            String SearchName = this.SearchTextBox.Text;
            DataHolder.RecordList = DataManager.GetRecordListByName(SearchName);
            this.RecordsListBox.Items.Clear();
            if (DataHolder.RecordList == null)
            {
                MessageBox.Show("No Records");
            }
            else
            {
                foreach (Client.Model.Record r in DataHolder.RecordList)
                {
                    this.RecordsListBox.Items.Add(r.Name.ToString());
                };
            }
        }
        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new Search());
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client.DataManager.Logout();
            Program.Window.ShowInterface(new SignIn());
        }
    }

}
