using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Hush;
using Hush.Client;
using Hush.Client.Model;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace Hush.Display.Interfaces
{
    class Add : Interface
    {


        private List<String> _AddedFields = new List<String>();

        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button button5;
        private Button Save;
        private Button Cancel;
        private DataGridView RecordsDataGridView;
        private Label RecordName;
        private TextBox RecordTextBox;
        private ComboBox TemplateComboBox;
        private ComboBox CategoryComboBox;
        private Label AddRecordLabel;
        private System.Windows.Forms.Label Template;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private Label ErrorCategoryLabel;
        private Label InvalidRecordName;
        private Record rc = new Record();

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Add");
            base.Initialize(Title);
            DataManager.PopulateTemplateBox(TemplateComboBox, new Record());
            DataManager.PopulateCategoryBox(CategoryComboBox, new Record());
        }

        #endregion

        public override void PostInit()
        {
            base.PostInit();
            RecordTextBox.Focus();
        }

        protected override void InitializeComponent()
        {
            this.InvalidRecordName = new System.Windows.Forms.Label();
            this.ErrorCategoryLabel = new System.Windows.Forms.Label();
            this.AddRecordLabel = new System.Windows.Forms.Label();
            this.RecordName = new System.Windows.Forms.Label();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.RecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Template = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InvalidRecordName
            // 
            this.InvalidRecordName.AutoSize = true;
            this.InvalidRecordName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidRecordName.ForeColor = System.Drawing.Color.Crimson;
            this.InvalidRecordName.Location = new System.Drawing.Point(137, 75);
            this.InvalidRecordName.Name = "InvalidRecordName";
            this.InvalidRecordName.Size = new System.Drawing.Size(151, 17);
            this.InvalidRecordName.TabIndex = 11;
            this.InvalidRecordName.Text = "Invalid Record Name";
            this.InvalidRecordName.Visible = false;
            // 
            // ErrorCategoryLabel
            // 
            this.ErrorCategoryLabel.AutoSize = true;
            this.ErrorCategoryLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCategoryLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorCategoryLabel.Location = new System.Drawing.Point(134, 127);
            this.ErrorCategoryLabel.Name = "ErrorCategoryLabel";
            this.ErrorCategoryLabel.Size = new System.Drawing.Size(190, 17);
            this.ErrorCategoryLabel.TabIndex = 10;
            this.ErrorCategoryLabel.Text = "Value must be 3-25 chars";
            this.ErrorCategoryLabel.Visible = false;
            // 
            // AddRecordLabel
            // 
            this.AddRecordLabel.AutoSize = true;
            this.AddRecordLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordLabel.Location = new System.Drawing.Point(40, 30);
            this.AddRecordLabel.Name = "AddRecordLabel";
            this.AddRecordLabel.Size = new System.Drawing.Size(110, 18);
            this.AddRecordLabel.TabIndex = 0;
            this.AddRecordLabel.Text = "Add Record";
            // 
            // RecordName
            // 
            this.RecordName.AutoSize = true;
            this.RecordName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordName.Location = new System.Drawing.Point(42, 73);
            this.RecordName.Name = "RecordName";
            this.RecordName.Size = new System.Drawing.Size(47, 17);
            this.RecordName.TabIndex = 1;
            this.RecordName.Text = "Name";
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordTextBox.Location = new System.Drawing.Point(42, 94);
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.Size = new System.Drawing.Size(334, 24);
            this.RecordTextBox.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(162, 453);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 25);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(280, 453);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 25);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(42, 148);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(334, 24);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.ValueMember = "Name";
            // 
            // TemplateComboBox
            // 
            this.TemplateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemplateComboBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.TemplateComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TemplateComboBox.FormattingEnabled = true;
            this.TemplateComboBox.Location = new System.Drawing.Point(42, 201);
            this.TemplateComboBox.Name = "TemplateComboBox";
            this.TemplateComboBox.Size = new System.Drawing.Size(334, 24);
            this.TemplateComboBox.TabIndex = 6;
            this.TemplateComboBox.SelectedValueChanged += new System.EventHandler(this.TemplateComboBoxSelectedValueChanged);
            // 
            // RecordsDataGridView
            // 
            this.RecordsDataGridView.AllowUserToDeleteRows = false;
            this.RecordsDataGridView.AllowUserToOrderColumns = true;
            this.RecordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.RecordsDataGridView.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsDataGridView.GridColor = System.Drawing.Color.White;
            this.RecordsDataGridView.Location = new System.Drawing.Point(43, 251);
            this.RecordsDataGridView.Name = "RecordsDataGridView";
            this.RecordsDataGridView.Size = new System.Drawing.Size(342, 180);
            this.RecordsDataGridView.TabIndex = 7;
            // 
            // Key
            // 
            this.Key.HeaderText = "Field";
            this.Key.Name = "Key";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Template
            // 
            this.Template.AutoSize = true;
            this.Template.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Template.Location = new System.Drawing.Point(42, 181);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(70, 17);
            this.Template.TabIndex = 5;
            this.Template.Text = "Template";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(42, 127);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(72, 17);
            this.Category.TabIndex = 3;
            this.Category.Text = "Category";
            // 
            // Add
            // 
            this.Controls.Add(this.InvalidRecordName);
            this.Controls.Add(this.ErrorCategoryLabel);
            this.Controls.Add(this.AddRecordLabel);
            this.Controls.Add(this.RecordName);
            this.Controls.Add(this.RecordTextBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.RecordsDataGridView);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.Category);
            this.Name = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaveButtonClick(Object Sender, EventArgs Args)
        {
            if (!this.RecordTextBox.Text.Trim().Equals(string.Empty) && Regex.IsMatch(RecordTextBox.Text.Trim(), @"^[\p{L}][\p{L} \.'\-]{0,50}$"))
            {
                OnSave();
                this.InvalidRecordName.Visible = false;
            }
            else
            {
                this.InvalidRecordName.Visible = true;
            }
        }

        private void OnSave()
        {

            string category = this.CategoryComboBox.Text.Trim();
            this.CategoryComboBox.Text = category;

            ErrorCategoryLabel.Visible = false;
            string k, v;

            if (category.Equals("") || DataManager.ValidateRecordCategory(category))
            {
    
                for (int i = 0; i < this.RecordsDataGridView.NewRowIndex; i++)
                {
                    if (this.RecordsDataGridView.Rows[i].Cells["Key"].Value == null)
                        k = "";
                    else
                        k = this.RecordsDataGridView.Rows[i].Cells["Key"].Value.ToString();
                    if (this.RecordsDataGridView.Rows[i].Cells["Value"].Value == null)
                        v = "";
                    else
                        v = this.RecordsDataGridView.Rows[i].Cells["Value"].Value.ToString();
                    DataManager.AddField(rc, k, v);
                }
            

                rc.Name = this.RecordTextBox.Text;
                rc.ID = Guid.NewGuid().ToString();
                if (TemplateComboBox.Enabled == true)
                    rc.Template = this.TemplateComboBox.Text;
                rc.Category = category;
                DataHolder.CurrentUser.Records.Add(rc);
                DataHolder.RecordList = Client.DataHolder.CurrentUser.Records;
                new DataManager().SaveUser(DataHolder.CurrentUser);

                DataHolder.RecordNode = rc.ID;
                Program.Window.ShowInterface(new MainScreen());
               }
               else
               {
                    ErrorCategoryLabel.Visible = true;
               }
        
        }

        //private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Category cat = DataHolder.CurrentUser.Categories.Where(c => c.Name.Equals(CategoryComboBox.SelectedValue)).FirstOrDefault<Category>();

        //    if (cat != null)
        //    {
        //        rc.Category = cat;
        //    }
        //}

        private void CancelButtonClick(Object Sender, EventArgs Args)
        {

            Program.Window.ShowInterface(new MainScreen());

        }

        private void TemplateComboBoxSelectedValueChanged(Object Sender, EventArgs Args)
        {

            DataManager.ProcessTemplateChange(_AddedFields, TemplateComboBox.Text, RecordsDataGridView);

        }

    }

}
