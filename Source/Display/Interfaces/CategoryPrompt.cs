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

        protected override void InitializeComponent()
        {
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameLabel.Location = new System.Drawing.Point(8, 15);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(106, 25);
            this.CategoryNameLabel.TabIndex = 0;
            this.CategoryNameLabel.Text = "Category Name:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(226, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 25);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(120, 15);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(206, 20);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // CategoryPrompt
            // 
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
            Client.DataManager.ProcessCategory(categoryName, this.CategoryTextBox.Text, Client.DataHolder.update);
            Client.DataHolder.update = Client.DataHolder.updateMode.None;
            Program.Window.ShowInterface(new CategoryManagement());
        }

        

        void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new CategoryManagement());
        }


        
    }
}
