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
        private Button BackButton;
        private ListBox CategoryListBox;
        private Button DeleteButton;
        private Button EditButton;

        private bool EditDeleteEnabled = true;

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Manage Categories");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(10, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 25);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(230, 380);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 25);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBox.Location = new System.Drawing.Point(10, 45);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(320, 329);
            this.CategoryListBox.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(230, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 25);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(120, 10);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 25);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CategoryManagement
            // 
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Name = "CategoryManagement";
            this.ResumeLayout(false);

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

                if (categoryList == null)
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
                AddCategoriesToListBox();
            }
        }

        void BackButton_Click(object sender, EventArgs e)
        {
            Program.Window.Close();   
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
            Program.Window.ShowInterface(new CategoryPrompt());
        }


               
    }
}
