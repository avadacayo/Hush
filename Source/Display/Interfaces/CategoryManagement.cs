using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Hush;

namespace Hush.Display.Interfaces
{
    class CategoryManagement : Interface
    {
        private Button AddButton;
        private Button CancelButton;
        private ListBox CategoryListBox;
        private Button DeleteButton;
        private Button EditButton;
        private Label CategoryManagementLabel;

        private bool EditDeleteEnabled = true;

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Manage Categories");
            base.Initialize(Title);

        }
        public override void PostInit()
        {
            base.PostInit();
            CategoryListBox.Focus();
        }
        protected override void InitializeComponent()
        {
            this.CategoryManagementLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryManagementLabel
            // 
            this.CategoryManagementLabel.AutoSize = true;
            this.CategoryManagementLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryManagementLabel.Location = new System.Drawing.Point(40, 30);
            this.CategoryManagementLabel.Name = "CategoryManagementLabel";
            this.CategoryManagementLabel.Size = new System.Drawing.Size(316, 29);
            this.CategoryManagementLabel.TabIndex = 0;
            this.CategoryManagementLabel.Text = "Category Management";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(42, 387);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 25);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBox.ItemHeight = 18;
            this.CategoryListBox.Location = new System.Drawing.Point(42, 65);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(338, 310);
            this.CategoryListBox.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(280, 387);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 25);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(161, 387);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 25);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CategoryManagement
            // 
            this.Controls.Add(this.CategoryManagementLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Name = "CategoryManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnLoad(EventArgs e)
        {
            AddCategoriesToListBox();

            this.DeleteButton.Enabled = EditDeleteEnabled;
            this.EditButton.Enabled = EditDeleteEnabled;
        }

        void AddCategoriesToListBox()
        {
            this.CategoryListBox.Items.Clear();
            try
            {
                List<Client.Model.Category> categoryList = Client.DataHolder.CurrentUser.Categories;

                if (categoryList == null || categoryList.Count == 0)
                {
                    this.CategoryListBox.Items.Add("no categories found");
                    EditDeleteEnabled = false;
                }
                else 
                {
                    foreach (Client.Model.Category c in categoryList)
                    {
                        this.CategoryListBox.Items.Add(c.Name.ToString());
                    };
                    EditDeleteEnabled = true;
                    this.CategoryListBox.SetSelected(0, true);
                }
            }
            catch (Exception ex)
            {
                this.CategoryListBox.Items.Add("exception");
            };
        }

        void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.CategoryListBox.SelectedItem != null)
            {
                Client.DataManager.ProcessCategory(this.CategoryListBox.SelectedItem.ToString(), "", Client.DataHolder.updateMode.Delete);
                new Client.DataManager().SaveUser(Client.DataHolder.CurrentUser);
                AddCategoriesToListBox();
            }
        }


        void EditButton_Click(object sender, EventArgs e)
        {
            if (this.CategoryListBox.SelectedItem != null)
            {
                Client.DataHolder.updateCategory = this.CategoryListBox.SelectedItem.ToString();
                Client.DataHolder.update = Client.DataHolder.updateMode.Edit;
                Program.Window.ShowInterface(new CategoryPrompt(this.CategoryListBox.SelectedItem.ToString()));
                Client.DataHolder.updateCategory = "";

            }
        }

        void AddButton_Click(object sender, EventArgs e)
        {
            Client.DataHolder.update = Client.DataHolder.updateMode.Add;
            Program.Window.ShowInterface(new CategoryPrompt());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }
               
    }
}
