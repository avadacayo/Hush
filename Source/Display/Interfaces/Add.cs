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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Temp;
        private System.Windows.Forms.TextBox textBox_Cat;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private Button save;
        private Button cancel;
        private GroupBox record;
        private DataGridView dataGridViewRecords;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private Label recordName;
        private TextBox RecordTextBox;
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
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.GroupBox();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.recordName = new System.Windows.Forms.Label();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
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
            // save
            // 
            this.save.Location = new System.Drawing.Point(336, 288);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(467, 288);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // record
            // 
            this.record.Controls.Add(this.RecordTextBox);
            this.record.Controls.Add(this.recordName);
            this.record.Controls.Add(this.cancel);
            this.record.Controls.Add(this.save);
            this.record.Controls.Add(this.dataGridViewRecords);
            this.record.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(53, 116);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(575, 317);
            this.record.TabIndex = 6;
            this.record.TabStop = false;
            this.record.Text = "Record";
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Location = new System.Drawing.Point(68, 29);
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.Size = new System.Drawing.Size(170, 20);
            this.RecordTextBox.TabIndex = 4;
            // 
            // recordName
            // 
            this.recordName.AutoSize = true;
            this.recordName.Location = new System.Drawing.Point(15, 29);
            this.recordName.Name = "recordName";
            this.recordName.Size = new System.Drawing.Size(45, 13);
            this.recordName.TabIndex = 3;
            this.recordName.Text = "Name:";
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToOrderColumns = true;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dataGridViewRecords.Location = new System.Drawing.Point(15, 61);
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
            // Add
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.record);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.textBox_Cat);
            this.Controls.Add(this.textBox_Temp);
            this.Controls.Add(this.label2);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(660, 458);
            this.record.ResumeLayout(false);
            this.record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnLoad(EventArgs e)
        {
            //this.CategoryTextBox.Text = Client.DataHolder.updateCategory;
        }

        //private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Get all rows entered on each press of Enter.
        //    var collection = this.dataGridViewRecords.Rows;
        //    string output = "";
        //    foreach (DataGridViewRow row in collection)
        //    {
        //        foreach (DataGridViewCell cell in row.Cells)
        //        {
        //            if (cell.Value != null)
        //            {
        //                output += cell.Value.ToString() + " ";
        //                DataManager.AddRecord(dataGridViewRecords.CurrentCell.RowIndex, this.Key.ToString(), this.Value.ToString());
        //            }
        //        }
        //    }
        //    // Display.
        //    this.Text = output;
        //}

        private void SaveButtonClick(Object Sender, EventArgs Args)
        {
            //DataTable dt = new DataTable();
           //dt = (this.dataGridViewRecords.DataSource as DataTable).Copy();
            //dt.Columns.Add("Key", typeof(string));
            //dt.Columns.Add("Value", typeof(string));
            Record rc = new Record();
            for (int i = 0; i < this.dataGridViewRecords.NewRowIndex; i++)
            {
                string k = this.dataGridViewRecords.Rows[i].Cells["Key"].Value.ToString();
                string v = this.dataGridViewRecords.Rows[i].Cells["Value"].Value.ToString();
                DataManager.AddField(rc, k, v);
                //DataManager.AddRecord(this.recordName.Text);

                //dt.Rows[i]["Key"] = this.dataGridViewRecords.Rows[i].Cells["Key"].Value;
                //dt.Rows[i]["Value"] = this.dataGridViewRecords.Rows[i].Cells["Value"].Value;
            }

            rc.Name = this.RecordTextBox.Text;
            DataHolder.CurrentUser.Records.Add(rc);
            //DataManager.AddRecord(dataGridViewRecords.CurrentCell.RowIndex, this.Key.ToString(), "");
           // this.dataGridViewRecords.DataSource = dt;

            //DataTable dt = new DataTable();
            //dt = (this.dataGridView1.DataSource as DataTable).Copy();
           // dt.Columns.Add("Address", typeof(string));
            //for (int i = 0; i < this.dataGridViewRecords.NewRowIndex; i++)
            //{
            //   // dt.Rows[i]["Address"] = this.dataGridViewRecords.Rows[i].Cells["Address"].Value;
            //    //DataManager.AddRecord(i, this.dataGridViewRecords.Rows[i].Cells["Key"].Value.ToString(), this.dataGridViewRecords.Rows[i].Cells["Value"].Value.ToString());
            //}

            //this.dataGridView2.DataSource = dt;

             //if ()
                //{
                   // DataManager.AddRecord(dataGridViewRecords.CurrentCell.RowIndex, this.Key.ToString(), "");
                    //MessageBox.Show("Saved");
                //}
            //else
            //DataManager.AddRecord(0, this.dataGridViewRecords);
                    //Client.DataManager.ProcessCategory(categoryName, this.CategoryTextBox.Text, Client.DataHolder.update);
                    //Client.DataHolder.update = Client.DataHolder.updateMode.None;
                    Program.Window.ShowInterface(new MainScreen());
        }
    }


}
