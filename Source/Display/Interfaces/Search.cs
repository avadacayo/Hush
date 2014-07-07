using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Hush;
using Hush.Client;
using Hush.Client.Model;

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
        private Label AdvancedSearchLabel;
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
            this.AdvancedSearchLabel = new System.Windows.Forms.Label();
            this.DateRangeGroupBox.SuspendLayout();
            this.SearchFieldGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryCheckBox
            // 
            this.CategoryCheckBox.Location = new System.Drawing.Point(7, 28);
            this.CategoryCheckBox.Name = "CategoryCheckBox";
            this.CategoryCheckBox.Size = new System.Drawing.Size(86, 25);
            this.CategoryCheckBox.TabIndex = 0;
            this.CategoryCheckBox.Text = "Category";
            this.CategoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(295, 448);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DateFromDateTimePicker
            // 
            this.DateFromDateTimePicker.Location = new System.Drawing.Point(64, 37);
            this.DateFromDateTimePicker.Name = "DateFromDateTimePicker";
            this.DateFromDateTimePicker.Size = new System.Drawing.Size(235, 24);
            this.DateFromDateTimePicker.TabIndex = 1;
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.Location = new System.Drawing.Point(7, 20);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(78, 14);
            this.DateFromLabel.TabIndex = 0;
            this.DateFromLabel.Text = "From";
            // 
            // DateRangeGroupBox
            // 
            this.DateRangeGroupBox.Controls.Add(this.DateToDateTimePicker);
            this.DateRangeGroupBox.Controls.Add(this.DateFromDateTimePicker);
            this.DateRangeGroupBox.Controls.Add(this.DateToLabel);
            this.DateRangeGroupBox.Controls.Add(this.DateFromLabel);
            this.DateRangeGroupBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRangeGroupBox.Location = new System.Drawing.Point(16, 310);
            this.DateRangeGroupBox.Name = "DateRangeGroupBox";
            this.DateRangeGroupBox.Size = new System.Drawing.Size(354, 132);
            this.DateRangeGroupBox.TabIndex = 4;
            this.DateRangeGroupBox.TabStop = false;
            this.DateRangeGroupBox.Text = "Date Range";
            // 
            // DateToDateTimePicker
            // 
            this.DateToDateTimePicker.Location = new System.Drawing.Point(64, 87);
            this.DateToDateTimePicker.Name = "DateToDateTimePicker";
            this.DateToDateTimePicker.Size = new System.Drawing.Size(235, 24);
            this.DateToDateTimePicker.TabIndex = 3;
            // 
            // DateToLabel
            // 
            this.DateToLabel.Location = new System.Drawing.Point(7, 67);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(69, 17);
            this.DateToLabel.TabIndex = 2;
            this.DateToLabel.Text = "To";
            // 
            // FieldCheckBox
            // 
            this.FieldCheckBox.Location = new System.Drawing.Point(7, 97);
            this.FieldCheckBox.Name = "FieldCheckBox";
            this.FieldCheckBox.Size = new System.Drawing.Size(86, 33);
            this.FieldCheckBox.TabIndex = 3;
            this.FieldCheckBox.Text = "Field:";
            this.FieldCheckBox.UseVisualStyleBackColor = true;
            // 
            // FieldSearchTextBox
            // 
            this.FieldSearchTextBox.Location = new System.Drawing.Point(27, 136);
            this.FieldSearchTextBox.Name = "FieldSearchTextBox";
            this.FieldSearchTextBox.Size = new System.Drawing.Size(306, 24);
            this.FieldSearchTextBox.TabIndex = 4;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.Location = new System.Drawing.Point(7, 74);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(86, 31);
            this.NameCheckBox.TabIndex = 2;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(189, 448);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 25);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchFieldGroupBox
            // 
            this.SearchFieldGroupBox.Controls.Add(this.FieldSearchTextBox);
            this.SearchFieldGroupBox.Controls.Add(this.FieldCheckBox);
            this.SearchFieldGroupBox.Controls.Add(this.NameCheckBox);
            this.SearchFieldGroupBox.Controls.Add(this.TagsCheckBox);
            this.SearchFieldGroupBox.Controls.Add(this.CategoryCheckBox);
            this.SearchFieldGroupBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFieldGroupBox.Location = new System.Drawing.Point(16, 124);
            this.SearchFieldGroupBox.Name = "SearchFieldGroupBox";
            this.SearchFieldGroupBox.Size = new System.Drawing.Size(354, 180);
            this.SearchFieldGroupBox.TabIndex = 3;
            this.SearchFieldGroupBox.TabStop = false;
            this.SearchFieldGroupBox.Text = "Search By";
            // 
            // TagsCheckBox
            // 
            this.TagsCheckBox.Location = new System.Drawing.Point(7, 51);
            this.TagsCheckBox.Name = "TagsCheckBox";
            this.TagsCheckBox.Size = new System.Drawing.Size(86, 30);
            this.TagsCheckBox.TabIndex = 1;
            this.TagsCheckBox.Text = "Tags";
            this.TagsCheckBox.UseVisualStyleBackColor = true;
            this.TagsCheckBox.Enabled = false;
            // 
            // SearchTermLabel
            // 
            this.SearchTermLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTermLabel.Location = new System.Drawing.Point(20, 59);
            this.SearchTermLabel.Name = "SearchTermLabel";
            this.SearchTermLabel.Size = new System.Drawing.Size(144, 26);
            this.SearchTermLabel.TabIndex = 1;
            this.SearchTermLabel.Text = "Search Terms:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(9, 88);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(361, 24);
            this.SearchTextBox.TabIndex = 2;
            // 
            // AdvancedSearchLabel
            // 
            this.AdvancedSearchLabel.AutoSize = true;
            this.AdvancedSearchLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedSearchLabel.Location = new System.Drawing.Point(40, 27);
            this.AdvancedSearchLabel.Name = "AdvancedSearchLabel";
            this.AdvancedSearchLabel.Size = new System.Drawing.Size(160, 18);
            this.AdvancedSearchLabel.TabIndex = 0;
            this.AdvancedSearchLabel.Text = "Advanced Search";
            // 
            // Search
            // 
            this.Controls.Add(this.AdvancedSearchLabel);
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
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String SearchName = this.SearchTextBox.Text;
            if (DateFromDateTimePicker.Value > (DateToDateTimePicker.Value.Add(new TimeSpan(0, 0, 0, 10))) || DateFromDateTimePicker.Value > DateTime.Now || DateToDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid date period");
            }
            else
            {

                DataHolder.RecordList = DataHolder.CurrentUser.Records.Where<Record>(r => r.Created > DateFromDateTimePicker.Value && r.Created < DateToDateTimePicker.Value);
                if (NameCheckBox.Checked && CategoryCheckBox.Checked && FieldCheckBox.Checked)
                {
                    DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Name.Contains(SearchName) || r.Category.Name.Contains(SearchName) || r.Fields.Any(f => f.Key.Contains(FieldSearchTextBox.Text)));
                }
                else if (NameCheckBox.Checked && CategoryCheckBox.Checked)
                {
                    DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Name.Contains(SearchName) || r.Category.Name.Contains(SearchName));
                }
                else if (NameCheckBox.Checked && FieldCheckBox.Checked)
                {
                    DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Name.Contains(SearchName) || r.Fields.Any(f => f.Key.Contains(FieldSearchTextBox.Text)));
                }
                else if (CategoryCheckBox.Checked && FieldCheckBox.Checked)
                {
                    DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Category.Name.Contains(SearchName) || r.Fields.Any(f => f.Key.Contains(FieldSearchTextBox.Text)));
                }
                else
                {
                    
                    if (CategoryCheckBox.Checked)
                        DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Category.Name.Contains(SearchName));
                        
                    else if (FieldCheckBox.Checked)
                        DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Fields.Any(f => f.Key.Contains(FieldSearchTextBox.Text)));
                    else
                        DataHolder.RecordList = DataHolder.RecordList.Where<Record>(r => r.Name.Contains(SearchName));
                }

            }
            Program.Window.ShowInterface(new MainScreen());
        }

    }

}

