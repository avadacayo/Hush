using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Hush;
using Hush.Client.Model;
using System.Data;
using Hush.Client;

namespace Hush.Display.Interfaces
{
    class Edit : Interface
    {

        private List<String> _AddedFields = new List<String>();

        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button CategoryChange;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Template;
        private System.Windows.Forms.ComboBox TemplateComboBox;
        private System.Windows.Forms.DataGridView EditDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label EditRecordLabel;
        private System.Windows.Forms.Label RecordName;
        private System.Windows.Forms.TextBox RecordTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;

        #region Designer

        public Edit() { }

        protected override void Initialize(List<String> Title)
        {
            Title.Add("Edit");
            base.Initialize(Title);

            if (DataHolder.CurrentUser.Records.Count >= DataHolder.RecordIndex)
                this.RecordTextBox.Text = DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Name.ToString();

            DataManager.PopulateTemplateBox(TemplateComboBox, DataHolder.CurrentUser.Records[DataHolder.RecordIndex]);

        }

        protected override void InitializeComponent()
        {
            this.Category = new System.Windows.Forms.Label();
            this.CategoryChange = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Template = new System.Windows.Forms.Label();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.EditDataGridView = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRecordLabel = new System.Windows.Forms.Label();
            this.RecordName = new System.Windows.Forms.Label();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // CategoryChange
            // 
            this.CategoryChange.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryChange.Location = new System.Drawing.Point(299, 148);
            this.CategoryChange.Name = "CategoryChange";
            this.CategoryChange.Size = new System.Drawing.Size(80, 27);
            this.CategoryChange.TabIndex = 5;
            this.CategoryChange.Text = "Change";
            this.CategoryChange.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(162, 453);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 25);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Template
            // 
            this.Template.AutoSize = true;
            this.Template.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Template.Location = new System.Drawing.Point(42, 181);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(72, 17);
            this.Template.TabIndex = 6;
            this.Template.Text = "Template";
            // 
            // TemplateComboBox
            // 
            this.TemplateComboBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.TemplateComboBox.FormattingEnabled = true;
            this.TemplateComboBox.Location = new System.Drawing.Point(42, 201);
            this.TemplateComboBox.Name = "TemplateComboBox";
            this.TemplateComboBox.Size = new System.Drawing.Size(334, 24);
            this.TemplateComboBox.TabIndex = 7;
            this.TemplateComboBox.SelectedValueChanged += new System.EventHandler(this.TemplateComboBoxSelectedValueChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.IntegralHeight = false;
            this.CategoryComboBox.Location = new System.Drawing.Point(42, 148);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(250, 24);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.ValueMember = "Name";
            // 
            // EditDataGridView
            // 
            this.EditDataGridView.AllowUserToDeleteRows = false;
            this.EditDataGridView.AllowUserToOrderColumns = true;
            this.EditDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EditDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.EditDataGridView.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDataGridView.GridColor = System.Drawing.Color.White;
            this.EditDataGridView.Location = new System.Drawing.Point(37, 254);
            this.EditDataGridView.Name = "EditDataGridView";
            this.EditDataGridView.Size = new System.Drawing.Size(342, 180);
            this.EditDataGridView.TabIndex = 9;
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
            // EditRecordLabel
            // 
            this.EditRecordLabel.AutoSize = true;
            this.EditRecordLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRecordLabel.Location = new System.Drawing.Point(42, 28);
            this.EditRecordLabel.Name = "EditRecordLabel";
            this.EditRecordLabel.Size = new System.Drawing.Size(109, 18);
            this.EditRecordLabel.TabIndex = 0;
            this.EditRecordLabel.Text = "Edit Record";
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
            // Edit
            // 
            this.Controls.Add(this.RecordName);
            this.Controls.Add(this.RecordTextBox);
            this.Controls.Add(this.EditRecordLabel);
            this.Controls.Add(this.EditDataGridView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.CategoryChange);
            this.Controls.Add(this.Category);
            this.Name = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void DisplayRecord()
        {
            List<Field> fieldList = DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Fields;
            DataTable DT = new DataTable();
            DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Name = this.RecordTextBox.Text;
            foreach (Field f in fieldList)
            {
                EditDataGridView.Rows.Add(f.Key.ToString(), f.Value.ToString());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            DisplayRecord();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = DataHolder.CurrentUser.Categories.Where(c => c.Name.Equals(CategoryComboBox.SelectedValue)).FirstOrDefault<Category>();

            if (cat != null)
            {
                DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Category = cat;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataManager.ApplyRecordChanges(DataHolder.CurrentUser.Records[DataHolder.RecordIndex], EditDataGridView, TemplateComboBox);
            DisplayRecord();
            Program.Window.ShowInterface(new MainScreen());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }

        private void TemplateComboBoxSelectedValueChanged(Object Sender, EventArgs Args)
        {

            DataManager.ProcessTemplateChange(_AddedFields, TemplateComboBox.Text, EditDataGridView);

        }


    }
}
