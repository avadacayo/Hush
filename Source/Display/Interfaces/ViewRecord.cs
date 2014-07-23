using Hush.Client;
using Hush.Client.Model;
using Hush.Tools;
using Hush.Tools.Scripting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Hush.Display.Interfaces
{

    class ViewRecord : Interface
    {

        private System.Windows.Forms.ComboBox ScriptComboBox;
        private System.Windows.Forms.Label ViewRecordLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox RecordTextBox;
        private System.Windows.Forms.ComboBox TemplateComboBox;
        private System.Windows.Forms.Label Template;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView ViewDataGridView;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button RunButton;
        private Record CurrentRecord;

        #region Designer

        public ViewRecord() { }

        protected override void Initialize(List<String> Title)
        {
            Title.Add("Edit");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.ScriptComboBox = new System.Windows.Forms.ComboBox();
            this.ViewRecordLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.Template = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScriptComboBox
            // 
            this.ScriptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScriptComboBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptComboBox.FormattingEnabled = true;
            this.ScriptComboBox.Location = new System.Drawing.Point(36, 453);
            this.ScriptComboBox.Name = "ScriptComboBox";
            this.ScriptComboBox.Size = new System.Drawing.Size(161, 24);
            this.ScriptComboBox.TabIndex = 8;
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
            this.CancelButton.Location = new System.Drawing.Point(279, 452);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 26);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Enabled = false;
            this.RecordTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordTextBox.Location = new System.Drawing.Point(42, 94);
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.Size = new System.Drawing.Size(334, 24);
            this.RecordTextBox.TabIndex = 2;
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
            this.Category.Location = new System.Drawing.Point(42, 128);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(72, 17);
            this.Category.TabIndex = 3;
            this.Category.Text = "Category";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(42, 74);
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
            // CategoryTextBox
            // 
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(42, 148);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(334, 24);
            this.CategoryTextBox.TabIndex = 11;
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(198, 452);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(51, 26);
            this.RunButton.TabIndex = 12;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButtonClick);
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
            // ViewRecord
            // 
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.ViewDataGridView);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RecordTextBox);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ScriptComboBox);
            this.Controls.Add(this.ViewRecordLabel);
            this.Name = "ViewRecord";
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public override void PostInit()
        {
            base.PostInit();
            ScriptComboBox.Focus();
        }

        private void DisplayRecord()
        {
            CurrentRecord = DataManager.GetRecordByID(DataHolder.RecordNode);
            List<Field> FieldList = CurrentRecord.Fields;
            CategoryTextBox.Text = CurrentRecord.Category.ToString();
            

            TemplateComboBox.Enabled = false;
            TemplateComboBox.Items.Clear();
            TemplateComboBox.Items.Add(CurrentRecord.Template);
            TemplateComboBox.SelectedText = CurrentRecord.Template;
            foreach (Field Item in FieldList)
            {
                ViewDataGridView.Rows.Add(Item.Key.ToString(), Item.Value.ToString());
            }

            RecordTextBox.Text = CurrentRecord.Name;
        }

        protected override void OnLoad(EventArgs Args)
        {

            DisplayRecord();
            DataManager.PopulateScriptBox(ScriptComboBox, RunButton, DataManager.GetRecordByID(DataHolder.RecordNode).Template);

        }

        private void CancelButtonClick(Object Sender, EventArgs Args)
        {

            Program.Window.ShowInterface(new MainScreen());

        }

        private void RunButtonClick(Object Sender, EventArgs Args)
        {

            if (ScriptComboBox.Text != "Select..." && ScriptComboBox.SelectedIndex != 0)
            {

                HushScript x = new HushScript(Program.Window, DataHolder.RecordList.ElementAt(DataHolder.RecordIndex));
                x.Name = ScriptComboBox.Text;
                x.Template = DataHolder.RecordList.ElementAt(DataHolder.RecordIndex).Template;
                ReturnValue status = x.Load();
                x.Run();

            }

        }

    }

}
