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
    class Search : Interface
    {
        private CheckBox CategoryCheckBox;
        private Button CancelButton;
        private Label DateFromLabel;
        private DateTimePicker DateFromDateTimePicker;
        private GroupBox DateRangeGroupBox;
        private DateTimePicker DateToDateTimePicker;
        private Label DateToLabel;
        private CheckBox FieldCheckBox;
        private TextBox FieldSearchTextBox;
        private CheckBox NameCheckBox;
        private Button SearchButton;
        private GroupBox SearchFieldGroupBox;
        private Label SearchTermLabel;
        private TextBox SearchTextBox;
        private CheckBox TagsCheckBox;
        
        protected override void Initialize(List<String> Title)
        {
            Title.Add("Advanced Search");

            base.Initialize(Title);

            CategoryCheckBox = new CheckBox();
            CancelButton = new Button();
            DateFromDateTimePicker = new DateTimePicker();
            DateFromLabel = new Label();
            DateRangeGroupBox = new GroupBox();
            DateToDateTimePicker = new DateTimePicker();
            DateToLabel = new Label();
            FieldCheckBox = new CheckBox();
            FieldSearchTextBox = new TextBox();
            NameCheckBox = new CheckBox();
            SearchButton = new Button();
            SearchFieldGroupBox = new GroupBox();
            SearchTermLabel = new Label();
            SearchTextBox = new TextBox();
            TagsCheckBox = new CheckBox();


            CancelButton.Location = new System.Drawing.Point(289, 185);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            
            CategoryCheckBox.Location = new System.Drawing.Point(7, 28);
            CategoryCheckBox.Name = "CategoryCheckBox";
            CategoryCheckBox.Size = new System.Drawing.Size(68, 17);
            CategoryCheckBox.Text = "Category";
            CategoryCheckBox.UseVisualStyleBackColor = true;

            DateFromDateTimePicker.Location = new System.Drawing.Point(10, 37);
            DateFromDateTimePicker.Name = "DateFromDateTimePicker";
            DateFromDateTimePicker.Size = new System.Drawing.Size(171, 20);

            DateFromLabel.Location = new System.Drawing.Point(7, 20);
            DateFromLabel.Name = "DateFromLabel";
            DateFromLabel.Size = new System.Drawing.Size(30, 13);
            DateFromLabel.Text = "From";

            DateRangeGroupBox.Controls.Add(DateToDateTimePicker);
            DateRangeGroupBox.Controls.Add(DateFromDateTimePicker);
            DateRangeGroupBox.Controls.Add(DateToLabel);
            DateRangeGroupBox.Controls.Add(DateFromLabel);
            DateRangeGroupBox.Location = new System.Drawing.Point(183, 51);
            DateRangeGroupBox.Name = "DateRangeGroupBox";
            DateRangeGroupBox.Size = new System.Drawing.Size(190, 114);
            DateRangeGroupBox.TabStop = false;
            DateRangeGroupBox.Text = "Date Range";

            DateToDateTimePicker.Location = new System.Drawing.Point(10, 87);
            DateToDateTimePicker.Name = "DateToDateTimePicker";
            DateToDateTimePicker.Size = new System.Drawing.Size(171, 20);

            DateToLabel.Location = new System.Drawing.Point(7, 67);
            DateToLabel.Name = "DateToLabel";
            DateToLabel.Size = new System.Drawing.Size(20, 13);
            DateToLabel.Text = "To";
            
            FieldCheckBox.Location = new System.Drawing.Point(7, 97);
            FieldCheckBox.Name = "FieldCheckBox";
            FieldCheckBox.Size = new System.Drawing.Size(51, 17);
            FieldCheckBox.Text = "Field:";
            FieldCheckBox.UseVisualStyleBackColor = true;

            FieldSearchTextBox.Location = new System.Drawing.Point(27, 120);
            FieldSearchTextBox.Name = "FieldSearchTextBox";
            FieldSearchTextBox.Size = new System.Drawing.Size(122, 20);
        
            NameCheckBox.Location = new System.Drawing.Point(7, 74);
            NameCheckBox.Name = "NameCheckBox";
            NameCheckBox.Size = new System.Drawing.Size(54, 17);
            NameCheckBox.Text = "Name";
            NameCheckBox.UseVisualStyleBackColor = true;

            SearchButton.Location = new System.Drawing.Point(193, 185);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(75, 23);
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;

            SearchFieldGroupBox.Controls.Add(FieldSearchTextBox);
            SearchFieldGroupBox.Controls.Add(FieldCheckBox);
            SearchFieldGroupBox.Controls.Add(NameCheckBox);
            SearchFieldGroupBox.Controls.Add(TagsCheckBox);
            SearchFieldGroupBox.Controls.Add(CategoryCheckBox);
            SearchFieldGroupBox.Location = new System.Drawing.Point(12, 51);
            SearchFieldGroupBox.Name = "SearchFieldGroupBox";
            SearchFieldGroupBox.Size = new System.Drawing.Size(165, 157);
            SearchFieldGroupBox.TabStop = false;
            SearchFieldGroupBox.Text = "Search By";

            SearchTermLabel.Location = new System.Drawing.Point(12, 9);
            SearchTermLabel.Name = "SearchTermLabel";
            SearchTermLabel.Size = new System.Drawing.Size(76, 13);
            SearchTermLabel.Text = "Search Terms:";

            SearchTextBox.Location = new System.Drawing.Point(12, 25);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new System.Drawing.Size(361, 20);

            TagsCheckBox.Location = new System.Drawing.Point(7, 51);
            TagsCheckBox.Name = "TagsCheckBox";
            TagsCheckBox.Size = new System.Drawing.Size(50, 17);
            TagsCheckBox.Text = "Tags";
            TagsCheckBox.UseVisualStyleBackColor = true;

            Controls.Add(CancelButton);
            Controls.Add(DateRangeGroupBox);
            Controls.Add(SearchButton);
            Controls.Add(SearchFieldGroupBox);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchTermLabel);
        }

    }

}

