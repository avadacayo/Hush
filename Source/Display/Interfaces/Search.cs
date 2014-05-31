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

        }

        protected override void InitializeComponent()
        {
            this.CategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateFromLabel = new System.Windows.Forms.Label();
            this.DateRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.DateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateToLabel = new System.Windows.Forms.Label();
            this.FieldCheckBox = new System.Windows.Forms.CheckBox();
            this.FieldSearchTextBox = new System.Windows.Forms.TextBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchFieldGroupBox = new System.Windows.Forms.GroupBox();
            this.TagsCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchTermLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DateRangeGroupBox.SuspendLayout();
            this.SearchFieldGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryCheckBox
            // 
            this.CategoryCheckBox.Location = new System.Drawing.Point(7, 28);
            this.CategoryCheckBox.Name = "CategoryCheckBox";
            this.CategoryCheckBox.Size = new System.Drawing.Size(68, 17);
            this.CategoryCheckBox.TabIndex = 4;
            this.CategoryCheckBox.Text = "Category";
            this.CategoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(298, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // DateFromDateTimePicker
            // 
            this.DateFromDateTimePicker.Location = new System.Drawing.Point(10, 37);
            this.DateFromDateTimePicker.Name = "DateFromDateTimePicker";
            this.DateFromDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.DateFromDateTimePicker.TabIndex = 1;
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.Location = new System.Drawing.Point(7, 20);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(30, 13);
            this.DateFromLabel.TabIndex = 3;
            this.DateFromLabel.Text = "From";
            // 
            // DateRangeGroupBox
            // 
            this.DateRangeGroupBox.Controls.Add(this.DateToDateTimePicker);
            this.DateRangeGroupBox.Controls.Add(this.DateFromDateTimePicker);
            this.DateRangeGroupBox.Controls.Add(this.DateToLabel);
            this.DateRangeGroupBox.Controls.Add(this.DateFromLabel);
            this.DateRangeGroupBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRangeGroupBox.Location = new System.Drawing.Point(183, 51);
            this.DateRangeGroupBox.Name = "DateRangeGroupBox";
            this.DateRangeGroupBox.Size = new System.Drawing.Size(190, 114);
            this.DateRangeGroupBox.TabIndex = 1;
            this.DateRangeGroupBox.TabStop = false;
            this.DateRangeGroupBox.Text = "Date Range";
            // 
            // DateToDateTimePicker
            // 
            this.DateToDateTimePicker.Location = new System.Drawing.Point(10, 87);
            this.DateToDateTimePicker.Name = "DateToDateTimePicker";
            this.DateToDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.DateToDateTimePicker.TabIndex = 0;
            // 
            // DateToLabel
            // 
            this.DateToLabel.Location = new System.Drawing.Point(7, 67);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(20, 13);
            this.DateToLabel.TabIndex = 2;
            this.DateToLabel.Text = "To";
            // 
            // FieldCheckBox
            // 
            this.FieldCheckBox.Location = new System.Drawing.Point(7, 97);
            this.FieldCheckBox.Name = "FieldCheckBox";
            this.FieldCheckBox.Size = new System.Drawing.Size(51, 17);
            this.FieldCheckBox.TabIndex = 1;
            this.FieldCheckBox.Text = "Field:";
            this.FieldCheckBox.UseVisualStyleBackColor = true;
            // 
            // FieldSearchTextBox
            // 
            this.FieldSearchTextBox.Location = new System.Drawing.Point(27, 120);
            this.FieldSearchTextBox.Name = "FieldSearchTextBox";
            this.FieldSearchTextBox.Size = new System.Drawing.Size(122, 20);
            this.FieldSearchTextBox.TabIndex = 0;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.Location = new System.Drawing.Point(7, 74);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.NameCheckBox.TabIndex = 2;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(193, 185);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchFieldGroupBox
            // 
            this.SearchFieldGroupBox.Controls.Add(this.FieldSearchTextBox);
            this.SearchFieldGroupBox.Controls.Add(this.FieldCheckBox);
            this.SearchFieldGroupBox.Controls.Add(this.NameCheckBox);
            this.SearchFieldGroupBox.Controls.Add(this.TagsCheckBox);
            this.SearchFieldGroupBox.Controls.Add(this.CategoryCheckBox);
            this.SearchFieldGroupBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFieldGroupBox.Location = new System.Drawing.Point(12, 51);
            this.SearchFieldGroupBox.Name = "SearchFieldGroupBox";
            this.SearchFieldGroupBox.Size = new System.Drawing.Size(165, 157);
            this.SearchFieldGroupBox.TabIndex = 3;
            this.SearchFieldGroupBox.TabStop = false;
            this.SearchFieldGroupBox.Text = "Search By";
            // 
            // TagsCheckBox
            // 
            this.TagsCheckBox.Location = new System.Drawing.Point(7, 51);
            this.TagsCheckBox.Name = "TagsCheckBox";
            this.TagsCheckBox.Size = new System.Drawing.Size(50, 17);
            this.TagsCheckBox.TabIndex = 3;
            this.TagsCheckBox.Text = "Tags";
            this.TagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchTermLabel
            // 
            this.SearchTermLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTermLabel.Location = new System.Drawing.Point(12, 9);
            this.SearchTermLabel.Name = "SearchTermLabel";
            this.SearchTermLabel.Size = new System.Drawing.Size(76, 13);
            this.SearchTermLabel.TabIndex = 5;
            this.SearchTermLabel.Text = "Search Terms:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 25);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(361, 20);
            this.SearchTextBox.TabIndex = 4;
            // 
            // Search
            // 
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DateRangeGroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchFieldGroupBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchTermLabel);
            this.Name = "Search";
            this.DateRangeGroupBox.ResumeLayout(false);
            this.SearchFieldGroupBox.ResumeLayout(false);
            this.SearchFieldGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

}

