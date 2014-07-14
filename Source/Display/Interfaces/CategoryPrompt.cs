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
    class CategoryPrompt : Interface
    {
        private Label CategoryNameLabel;
        private TextBox CategoryTextBox;
        private Button SaveButton;
        private Button CancelButton;
        private Label AddCategoryLabel;
        private Label ErrorCategoryLabel;
        private string categoryName;

        public CategoryPrompt() { }

        public CategoryPrompt(string category)
        {
            categoryName = category;
        }

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Category Prompt");
            base.Initialize(Title);

        }

        public override void PostInit()
        {
            base.PostInit();
            CategoryTextBox.Focus();
        }

        protected override void InitializeComponent()
        {
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddCategoryLabel = new System.Windows.Forms.Label();
            this.ErrorCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameLabel.Location = new System.Drawing.Point(42, 98);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(340, 25);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "Category Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(150, 453);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 25);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(42, 126);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(338, 28);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCategoryLabel
            // 
            this.AddCategoryLabel.AutoSize = true;
            this.AddCategoryLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryLabel.Location = new System.Drawing.Point(40, 30);
            this.AddCategoryLabel.Name = "AddCategoryLabel";
            this.AddCategoryLabel.Size = new System.Drawing.Size(163, 25);
            this.AddCategoryLabel.TabIndex = 0;
            this.AddCategoryLabel.Text = "Add Category";
            // 
            // ErrorCategoryLabel
            // 
            this.ErrorCategoryLabel.AutoSize = true;
            this.ErrorCategoryLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCategoryLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorCategoryLabel.Location = new System.Drawing.Point(45, 161);
            this.ErrorCategoryLabel.Name = "ErrorCategoryLabel";
            this.ErrorCategoryLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorCategoryLabel.TabIndex = 5;
            // 
            // CategoryPrompt
            // 
            this.Controls.Add(this.ErrorCategoryLabel);
            this.Controls.Add(this.AddCategoryLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryTextBox);
            this.Name = "CategoryPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnLoad(EventArgs e)
        {
            this.CategoryTextBox.Text = Client.DataHolder.updateCategory;    
        } 

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ErrorCategoryLabel.Text = "";

            string newCategory = this.CategoryTextBox.Text.Trim();
            this.CategoryTextBox.Text = newCategory;
            
            if (!Client.DataManager.ValidateCategoryUnique(newCategory))
            {
                ErrorCategoryLabel.Text = "Category already exists";
            }
            else if (!Client.DataManager.ValidateCategoryLength(newCategory))
            {
                ErrorCategoryLabel.Text = "Category must be 3-25 characters long";
            }
            else
            {
                Client.DataManager.ProcessCategory(categoryName, newCategory, Client.DataHolder.update);
                Client.DataHolder.update = Client.DataHolder.updateMode.None;
                Program.Window.ShowInterface(new CategoryManagement());
            }
        }

        

        void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new CategoryManagement());
        }

        
    }
}
