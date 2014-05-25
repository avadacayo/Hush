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
        private Button EditButton;
        private Button DeleteButton;
        private ListBox CategoryListBox;
        private Button BackButton;

        protected override void Initialize(List<String> Title)
        {
            Title.Add("Manage Categories");

            base.Initialize(Title);

            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            CategoryListBox = new ListBox();
            BackButton = new Button();

            AddButton.Font = GlobalFont;
            AddButton.Location = new Point(10, 10);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 25);
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;

            EditButton.Font = GlobalFont;
            EditButton.Location = new Point(120, 10);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(100, 25);
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;

            DeleteButton.Font = GlobalFont;
            DeleteButton.Location = new Point(230, 10);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 25);
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;

            CategoryListBox.Location = new Point(10, 45);
            CategoryListBox.Name = "CategoryListBox";
            CategoryListBox.Size = new Size(320, 330);
            

            BackButton.Font = GlobalFont;
            BackButton.Location = new Point(230, 385);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(100, 25);
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;

            Controls.Add(AddButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(CategoryListBox);
            Controls.Add(BackButton);
        }


    }
}
