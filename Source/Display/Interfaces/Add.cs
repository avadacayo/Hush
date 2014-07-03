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

namespace Hush.Display.Interfaces
{
    class Add : Interface
    {
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button button5;
        private Button Save;
        private Button Cancel;
        private GroupBox Record;
        private DataGridView RecordsDataGridView;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private Label RecordName;
        private TextBox RecordTextBox;
        private ComboBox TemplateComboBox;
        private ComboBox CategoryComboBox;
        private System.Windows.Forms.Label Template;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Add");
            base.Initialize(Title);

        }

        #endregion

        protected override void InitializeComponent()
        {
            this.Category = new System.Windows.Forms.Label();
            this.Template = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.GroupBox();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.RecordName = new System.Windows.Forms.Label();
            this.RecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).BeginInit();
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
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(336, 288);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(467, 288);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Record
            // 
            this.Record.Controls.Add(this.RecordTextBox);
            this.Record.Controls.Add(this.RecordName);
            this.Record.Controls.Add(this.Cancel);
            this.Record.Controls.Add(this.Save);
            this.Record.Controls.Add(this.RecordsDataGridView);
            this.Record.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Location = new System.Drawing.Point(53, 116);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(575, 317);
            this.Record.TabIndex = 6;
            this.Record.TabStop = false;
            this.Record.Text = "Record";
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Location = new System.Drawing.Point(68, 29);
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.Size = new System.Drawing.Size(170, 20);
            this.RecordTextBox.TabIndex = 4;
            // 
            // RecordName
            // 
            this.RecordName.AutoSize = true;
            this.RecordName.Location = new System.Drawing.Point(15, 29);
            this.RecordName.Name = "RecordName";
            this.RecordName.Size = new System.Drawing.Size(45, 13);
            this.RecordName.TabIndex = 3;
            this.RecordName.Text = "Name:";
            // 
            // RecordsDataGridView
            // 
            this.RecordsDataGridView.AllowUserToOrderColumns = true;
            this.RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.RecordsDataGridView.Location = new System.Drawing.Point(15, 61);
            this.RecordsDataGridView.Name = "RecordsDataGridView";
            this.RecordsDataGridView.Size = new System.Drawing.Size(527, 221);
            this.RecordsDataGridView.TabIndex = 0;
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
            this.CategoryComboBox.Location = new System.Drawing.Point(121, 61);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(326, 21);
            this.CategoryComboBox.TabIndex = 9;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Category);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(660, 458);
            this.Record.ResumeLayout(false);
            this.Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaveButtonClick(Object Sender, EventArgs Args)
        {
            Record rc = new Record();
            string k, v;
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
            DataHolder.CurrentUser.Records.Add(rc);
            DataHolder.RecordList = Client.DataHolder.CurrentUser.Records;
            Program.Window.ShowInterface(new MainScreen());
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }
    }


}
