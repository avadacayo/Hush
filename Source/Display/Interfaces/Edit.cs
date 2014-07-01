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
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button TemplateChange;
        private System.Windows.Forms.Button CategoryChange;
        private System.Windows.Forms.GroupBox RecordGroupBox;
        private System.Windows.Forms.DataGridView EditDataGridView;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label Template;
        private Int32 RecordIndex;
        private System.Windows.Forms.ComboBox TemplateComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;

        #region Designer

        public Edit() { }

        public Edit(Int32 RcIndex) {
            RecordIndex = RcIndex;   
        }

        protected override void Initialize(List<String> Title)
        {
            Title.Add("Edit");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.Category = new System.Windows.Forms.Label();
            this.TemplateChange = new System.Windows.Forms.Button();
            this.CategoryChange = new System.Windows.Forms.Button();
            this.RecordGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditDataGridView = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Template = new System.Windows.Forms.Label();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RecordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(55, 58);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(60, 13);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category";
            // 
            // TemplateChange
            // 
            this.TemplateChange.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateChange.Location = new System.Drawing.Point(520, 19);
            this.TemplateChange.Name = "TemplateChange";
            this.TemplateChange.Size = new System.Drawing.Size(75, 23);
            this.TemplateChange.TabIndex = 4;
            this.TemplateChange.Text = "Change";
            this.TemplateChange.UseVisualStyleBackColor = true;
            // 
            // CategoryChange
            // 
            this.CategoryChange.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryChange.Location = new System.Drawing.Point(520, 59);
            this.CategoryChange.Name = "CategoryChange";
            this.CategoryChange.Size = new System.Drawing.Size(75, 23);
            this.CategoryChange.TabIndex = 5;
            this.CategoryChange.Text = "Change";
            this.CategoryChange.UseVisualStyleBackColor = true;
            // 
            // RecordGroupBox
            // 
            this.RecordGroupBox.Controls.Add(this.CancelButton);
            this.RecordGroupBox.Controls.Add(this.SaveButton);
            this.RecordGroupBox.Controls.Add(this.EditDataGridView);
            this.RecordGroupBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordGroupBox.Location = new System.Drawing.Point(53, 116);
            this.RecordGroupBox.Name = "RecordGroupBox";
            this.RecordGroupBox.Size = new System.Drawing.Size(575, 317);
            this.RecordGroupBox.TabIndex = 6;
            this.RecordGroupBox.TabStop = false;
            this.RecordGroupBox.Text = "Record";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(467, 259);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(337, 259);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditDataGridView
            // 
            this.EditDataGridView.AllowUserToOrderColumns = true;
            this.EditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.EditDataGridView.Location = new System.Drawing.Point(15, 19);
            this.EditDataGridView.Name = "EditDataGridView";
            this.EditDataGridView.Size = new System.Drawing.Size(527, 221);
            this.EditDataGridView.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
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
            this.Template.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Template.Location = new System.Drawing.Point(53, 19);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(59, 13);
            this.Template.TabIndex = 7;
            this.Template.Text = "Template";
            // 
            // TemplateComboBox
            // 
            this.TemplateComboBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateComboBox.FormattingEnabled = true;
            this.TemplateComboBox.Location = new System.Drawing.Point(121, 20);
            this.TemplateComboBox.Name = "TemplateComboBox";
            this.TemplateComboBox.Size = new System.Drawing.Size(326, 21);
            this.TemplateComboBox.TabIndex = 8;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(121, 55);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(326, 21);
            this.CategoryComboBox.TabIndex = 9;
            // 
            // Edit
            // 
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.RecordGroupBox);
            this.Controls.Add(this.CategoryChange);
            this.Controls.Add(this.TemplateChange);
            this.Controls.Add(this.Category);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(660, 458);
            this.RecordGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void displayRecord()
        {
            List<Field> fieldList = DataHolder.CurrentUser.Records[RecordIndex].Fields;
            DataTable DT = new DataTable();

            foreach (Field f in fieldList)
            {
                EditDataGridView.Rows.Add(f.Key.ToString(), f.Value.ToString());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            displayRecord();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataManager.ApplyRecordChanges(DataHolder.CurrentUser.Records[RecordIndex], EditDataGridView);
            displayRecord();
            Program.Window.ShowInterface(new MainScreen());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }


    }
}
