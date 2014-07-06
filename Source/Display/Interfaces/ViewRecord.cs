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
    class ViewRecord : Interface
    {
        private String recordName;
        //private Int32 RecordIndex;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ViewRecordLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox RecordTextBox;
        private System.Windows.Forms.ComboBox TemplateComboBox;
        private System.Windows.Forms.Label Template;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView ViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private Record record;

        #region Designer

        public ViewRecord() { }

        protected override void Initialize(List<String> Title)
        {
            Title.Add("Edit");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ViewRecordLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.Template = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "run";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 453);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // ViewRecordLabel
            // 
            this.ViewRecordLabel.AutoSize = true;
            this.ViewRecordLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecordLabel.Location = new System.Drawing.Point(40, 30);
            this.ViewRecordLabel.Name = "ViewRecordLabel";
            this.ViewRecordLabel.Size = new System.Drawing.Size(119, 18);
            this.ViewRecordLabel.TabIndex = 0;
            this.ViewRecordLabel.Text = "View Record";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(280, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Enabled = false;
            this.RecordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordTextBox.Location = new System.Drawing.Point(42, 94);
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.Size = new System.Drawing.Size(334, 24);
            this.RecordTextBox.TabIndex = 2;
            this.RecordTextBox.Text = DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Name.ToString();
            // 
            // TemplateComboBox
            // 
            this.TemplateComboBox.Enabled = false;
            this.TemplateComboBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.TemplateComboBox.FormattingEnabled = true;
            this.TemplateComboBox.Location = new System.Drawing.Point(42, 201);
            this.TemplateComboBox.Name = "TemplateComboBox";
            this.TemplateComboBox.Size = new System.Drawing.Size(334, 24);
            this.TemplateComboBox.TabIndex = 6;
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
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(42, 73);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // ViewDataGridView
            // 
            this.ViewDataGridView.AllowUserToDeleteRows = false;
            this.ViewDataGridView.AllowUserToOrderColumns = true;
            this.ViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.ViewDataGridView.Enabled = false;
            this.ViewDataGridView.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDataGridView.GridColor = System.Drawing.Color.White;
            this.ViewDataGridView.Location = new System.Drawing.Point(37, 254);
            this.ViewDataGridView.Name = "ViewDataGridView";
            this.ViewDataGridView.Size = new System.Drawing.Size(342, 180);
            this.ViewDataGridView.TabIndex = 7;
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
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(45, 148);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(331, 24);
            this.CategoryTextBox.TabIndex = 11;
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Text = DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Category.Name.ToString();
            // 
            // ViewRecord
            // 
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.ViewDataGridView);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RecordTextBox);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewRecordLabel);
            this.Name = "ViewRecord";
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void displayRecord()
        {
            List<Field> fieldList = DataHolder.CurrentUser.Records[DataHolder.RecordIndex].Fields;
            DataTable DT = new DataTable();

            foreach (Field f in fieldList)
            {
                ViewDataGridView.Rows.Add(f.Key.ToString(), f.Value.ToString());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            displayRecord();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }


    }
}
