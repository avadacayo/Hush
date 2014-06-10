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

namespace Hush.Display.Interfaces
{
    class Add : Interface
    {
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Temp;
        private System.Windows.Forms.TextBox textBox_Cat;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private DataGridView dataGridViewRecords;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private Button save;
        private Button cancel;
        private GroupBox recordList;
        private System.Windows.Forms.Label label1;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("Add");
            base.Initialize(Title);

        }

        #endregion

        protected override void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Temp = new System.Windows.Forms.TextBox();
            this.textBox_Cat = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.recordList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.recordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // textBox_Temp
            // 
            this.textBox_Temp.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Temp.Location = new System.Drawing.Point(121, 23);
            this.textBox_Temp.Name = "textBox_Temp";
            this.textBox_Temp.Size = new System.Drawing.Size(326, 20);
            this.textBox_Temp.TabIndex = 2;
            // 
            // textBox_Cat
            // 
            this.textBox_Cat.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cat.Location = new System.Drawing.Point(121, 58);
            this.textBox_Cat.Name = "textBox_Cat";
            this.textBox_Cat.Size = new System.Drawing.Size(326, 20);
            this.textBox_Cat.TabIndex = 3;
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(520, 19);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(520, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Template";
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToOrderColumns = true;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dataGridViewRecords.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.Size = new System.Drawing.Size(527, 221);
            this.dataGridViewRecords.TabIndex = 0;
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
            // save
            // 
            this.save.Location = new System.Drawing.Point(337, 259);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(467, 259);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // recordList
            // 
            this.recordList.Controls.Add(this.cancel);
            this.recordList.Controls.Add(this.save);
            this.recordList.Controls.Add(this.dataGridViewRecords);
            this.recordList.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordList.Location = new System.Drawing.Point(53, 116);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(575, 317);
            this.recordList.TabIndex = 6;
            this.recordList.TabStop = false;
            this.recordList.Text = "RecordList";
            // 
            // Add
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.textBox_Cat);
            this.Controls.Add(this.textBox_Temp);
            this.Controls.Add(this.label2);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(660, 458);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.recordList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaveButtonClick(Object Sender, EventArgs Args)
        {
             //if ()
                //{
                    DataManager.AddRecord(dataGridViewRecords.CurrentCell.RowIndex, "", "");
                    MessageBox.Show("Saved");
                //}
            //else
        }
    }


}
