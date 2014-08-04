using Hush.Client;
using Hush.Client.Model;
using Hush.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
        private Label AccountsStoredLabel;
        private Button ToolButton;
        private TreeView RecordsTreeView;
        private System.ComponentModel.IContainer components;
        private Button ShowAllButton;
        private ToolTip Tooltip;
        // listbox to replaced by custom control
        
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Main");

            base.Initialize(Title);
            UsernameLabel.Text = DataHolder.CurrentUser.Username;
            if(!DataHolder.Filter)
                DataHolder.RecordList = DataHolder.CurrentUser.Records;
            DataHolder.Filter = false;
            SearchButton.Enabled = false;
            
        }

        protected override void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.ToolButton = new System.Windows.Forms.Button();
            this.RecordsTreeView = new System.Windows.Forms.TreeView();
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
            this.RecordFunctionsPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.Location = new System.Drawing.Point(302, 333);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(81, 25);
            this.ShowAllButton.TabIndex = 8;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ToolButton
            // 
            this.ToolButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolButton.FlatAppearance.BorderSize = 5;
            this.ToolButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolButton.Image = global::Hush.Properties.Resources.Andy_Tools_Hammer_Spanner3;
            this.ToolButton.Location = new System.Drawing.Point(385, 12);
            this.ToolButton.Name = "ToolButton";
            this.ToolButton.Size = new System.Drawing.Size(26, 26);
            this.ToolButton.TabIndex = 1;
            this.ToolButton.UseVisualStyleBackColor = true;
            this.ToolButton.Click += new System.EventHandler(this.ToolButton_Click);
            this.ToolButton.MouseHover += new System.EventHandler(this.ToolButton_MouseHover);
            // 
            // RecordsTreeView
            // 
            this.RecordsTreeView.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsTreeView.Location = new System.Drawing.Point(24, 99);
            this.RecordsTreeView.Name = "RecordsTreeView";
            this.RecordsTreeView.Size = new System.Drawing.Size(359, 212);
            this.RecordsTreeView.TabIndex = 3;
            this.RecordsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RecordsTreeView_AfterSelect);
            // 
            // AccountsStoredLabel
            // 
            this.AccountsStoredLabel.AutoSize = true;
            this.AccountsStoredLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.AccountsStoredLabel.Location = new System.Drawing.Point(29, 79);
            this.AccountsStoredLabel.Name = "AccountsStoredLabel";
            this.AccountsStoredLabel.Size = new System.Drawing.Size(130, 17);
            this.AccountsStoredLabel.TabIndex = 2;
            this.AccountsStoredLabel.Text = "Accounts stored:";
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(24, 332);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(53, 25);
            this.ViewButton.TabIndex = 4;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(24, 422);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(110, 47);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ManageCategoriesButton
            // 
            this.ManageCategoriesButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCategoriesButton.Location = new System.Drawing.Point(150, 422);
            this.ManageCategoriesButton.Name = "ManageCategoriesButton";
            this.ManageCategoriesButton.Size = new System.Drawing.Size(110, 47);
            this.ManageCategoriesButton.TabIndex = 10;
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
            this.AdvancedSearchButton.TabIndex = 11;
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
            this.RecordFunctionsPanel.Location = new System.Drawing.Point(75, 333);
            this.RecordFunctionsPanel.Name = "RecordFunctionsPanel";
            this.RecordFunctionsPanel.Size = new System.Drawing.Size(204, 29);
            this.RecordFunctionsPanel.TabIndex = 5;
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordButton.Location = new System.Drawing.Point(8, -1);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(66, 25);
            this.AddRecordButton.TabIndex = 0;
            this.AddRecordButton.Text = "Add";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.Location = new System.Drawing.Point(80, -1);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(58, 25);
            this.EditRecordButton.TabIndex = 1;
            this.EditRecordButton.Text = "Edit";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(144, 0);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(60, 25);
            this.DeleteRecordButton.TabIndex = 2;
            this.DeleteRecordButton.Text = "Delete";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(302, 381);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(81, 25);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(24, 382);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(255, 24);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.Search_TextChanged);
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
            // MainScreen
            // 
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.ToolButton);
            this.Controls.Add(this.RecordsTreeView);
            this.Controls.Add(this.AccountsStoredLabel);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ManageCategoriesButton);
            this.Controls.Add(this.AdvancedSearchButton);
            this.Controls.Add(this.RecordFunctionsPanel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UserPanel);
            this.Name = "MainScreen";
            this.RecordFunctionsPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Length > 0)
                SearchButton.Enabled = true;

            else
                SearchButton.Enabled = false;

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
            if (this.RecordsTreeView.SelectedNode != null && !this.RecordsTreeView.SelectedNode.Name.Contains("category::"))
            {
                DataHolder.RecordNode = RecordsTreeView.SelectedNode.Name;
                Program.Window.ShowInterface(new ViewRecord());
            }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new Add());
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            if (this.RecordsTreeView.SelectedNode != null && !this.RecordsTreeView.SelectedNode.Name.Contains("category::"))
            {
                DataHolder.RecordNode = RecordsTreeView.SelectedNode.Name;
                Program.Window.ShowInterface(new Edit());
                PopulateTreeView();
            }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (this.RecordsTreeView.SelectedNode != null && !this.RecordsTreeView.SelectedNode.Name.Contains("category::"))
            {
                DataHolder.RecordNode = RecordsTreeView.SelectedNode.Name;
                Program.Window.ShowInterface(new Delete());
                PopulateTreeView();
            }
        }

        private void ProfileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Window.ShowInterface(new UserProfile());
        }

        public override void PostInit()
        {
            base.PostInit();
        }
        protected override void OnLoad(EventArgs e)
        {
            PopulateTreeView();
            if (this.RecordsTreeView.Nodes.Count == 0 || this.RecordsTreeView.SelectedNode.Name.Contains("category::"))
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

                if (DataManager.GetRecordByID(DataHolder.RecordNode) != null)
                    GetNode(this.RecordsTreeView.Nodes, DataManager.GetRecordByID(DataHolder.RecordNode).Name);
                
            }

            if (this.RecordsTreeView.Nodes.Count == 0 || SearchTextBox.Text.Trim().Equals(string.Empty))
                SearchButton.Enabled = false;
            else if (!SearchTextBox.Text.Trim().Equals(string.Empty))
                SearchButton.Enabled = true;
        }

        public void GetNode(TreeNodeCollection nodes, string NodeName)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.Contains(NodeName))
                {
                    RecordsTreeView.SelectedNode = node;
                    TreeNode ParentNode = node.Parent;
                    while (ParentNode != null)
                    {
                        ParentNode.Expand();
                        ParentNode = ParentNode.Parent;
                    }
                    break;
                }
                GetNode(node.Nodes, NodeName);
            }
        }

        private void PopulateTreeView()
        {
            RecordsTreeView.BeginUpdate();
            RecordsTreeView.Nodes.Clear();
            if (DataHolder.RecordList == null)
            {
                return;
            }
            foreach (Record Item in DataHolder.RecordList)
            {
                AddNestedNode(RecordsTreeView, Item);
            }

            RecordsTreeView.EndUpdate();
            RecordsTreeView.Sort();
            RecordsTreeView.Focus();
            RecordsTreeView.ExpandAll();
        }

        private void AddNestedNode(TreeView Control, Record Item)
        {
            String CategoryName = Item.Category;
            System.Console.WriteLine(CategoryName);
            if (CategoryName.Length < 1)
            {
                Control.Nodes.Add(Item.ID, Item.Name);
            }

            else
            {

                if (!Control.Nodes.ContainsKey("category::" + CategoryName))
                {
                    Control.Nodes.Add("category::" + CategoryName, CategoryName);
                }

                Control.Nodes["category::" + CategoryName].Nodes.Add(Item.ID, Item.Name);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String SearchName = this.SearchTextBox.Text;
            DataHolder.RecordList = DataManager.GetRecordsByName(SearchName);
            PopulateTreeView();
        }
        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new Search());
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataHolder.CurrentUser != null)
            {
                new Client.DataManager().SaveUser(Client.DataHolder.CurrentUser);
                Client.DataManager.Logout();
            }

            Program.Window.ShowInterface(new SignIn());
        }

        private void ToolButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new GeneratePassword());
        }

        private void ToolButton_MouseHover(object sender, EventArgs e)
        {
            Tooltip.Show("Tools", ToolButton);
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            this.SearchTextBox.Text = "";
            DataHolder.RecordList = DataHolder.CurrentUser.Records;
            PopulateTreeView();
        }

        private void RecordsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.RecordsTreeView.SelectedNode != null && !this.RecordsTreeView.SelectedNode.Name.Contains("category::"))
            {
                ViewButton.Enabled = true;
                EditRecordButton.Enabled = true;
                DeleteRecordButton.Enabled = true;
            }
            else
            {
                ViewButton.Enabled = false;
                EditRecordButton.Enabled = false;
                DeleteRecordButton.Enabled = false;
            }
        }


     }

}
