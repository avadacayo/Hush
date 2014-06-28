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
        private System.Windows.Forms.GroupBox recordGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private String recordName;
        private Int32 recordIndex;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Record record;

        #region Designer

        public ViewRecord() { }

        public ViewRecord(Int32 rcIndex) {
            recordIndex = rcIndex;   
        }

        protected override void Initialize(List<String> Title)
        {
            Title.Add("Edit");
            base.Initialize(Title);

        }

        protected override void InitializeComponent()
        {
            this.recordGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // recordGroupBox
            // 
            this.recordGroupBox.Controls.Add(this.label1);
            this.recordGroupBox.Controls.Add(this.comboBox1);
            this.recordGroupBox.Controls.Add(this.closeBtn);
            this.recordGroupBox.Controls.Add(this.dataGridView1);
            this.recordGroupBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordGroupBox.Location = new System.Drawing.Point(53, 116);
            this.recordGroupBox.Name = "recordGroupBox";
            this.recordGroupBox.Size = new System.Drawing.Size(575, 317);
            this.recordGroupBox.TabIndex = 6;
            this.recordGroupBox.TabStop = false;
            this.recordGroupBox.Text = "Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "run";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(447, 259);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(527, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // ViewRecord
            // 
            this.Controls.Add(this.recordGroupBox);
            this.Name = "ViewRecord";
            this.Size = new System.Drawing.Size(660, 458);
            this.recordGroupBox.ResumeLayout(false);
            this.recordGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void displayRecord()
        {
            List<Field> fieldList = DataHolder.CurrentUser.Records[recordIndex].Fields;
            DataTable DT = new DataTable();

            foreach (Field f in fieldList)
            {
                dataGridView1.Rows.Add(f.Key.ToString(), f.Value.ToString());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            displayRecord();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Program.Window.ShowInterface(new MainScreen());
        }


    }
}
