using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hush;

namespace Hush.Display.Interfaces
{
    class View : Interface
    {

        private System.Windows.Forms.ListBox RecordListBox;
        private System.Windows.Forms.ComboBox RunComboBox;
        private System.Windows.Forms.Label Run;
        private System.Windows.Forms.Button Close;

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            Title.Add("View Record");
            base.Initialize(Title);

        }

        protected override void InitializeComponent() {
            this.RecordListBox = new System.Windows.Forms.ListBox();
            this.RunComboBox = new System.Windows.Forms.ComboBox();
            this.Run = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecordListBox
            // 
            this.RecordListBox.FormattingEnabled = true;
            this.RecordListBox.Items.AddRange(new object[] {
            "Field1: value",
            "FIeld2: value",
            "Field3: value"});
            this.RecordListBox.Location = new System.Drawing.Point(54, 45);
            this.RecordListBox.Name = "RecordListBox";
            this.RecordListBox.Size = new System.Drawing.Size(531, 199);
            this.RecordListBox.TabIndex = 0;
            // 
            // RunComboBox
            // 
            this.RunComboBox.FormattingEnabled = true;
            this.RunComboBox.Location = new System.Drawing.Point(54, 277);
            this.RunComboBox.Name = "RunComboBox";
            this.RunComboBox.Size = new System.Drawing.Size(236, 21);
            this.RunComboBox.TabIndex = 1;
            // 
            // Run
            // 
            this.Run.AutoSize = true;
            this.Run.Location = new System.Drawing.Point(315, 282);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(22, 13);
            this.Run.TabIndex = 2;
            this.Run.Text = "run";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(510, 277);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 3;
            this.Close.Text = "close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.RunComboBox);
            this.Controls.Add(this.RecordListBox);
            this.Name = "View";
            this.Size = new System.Drawing.Size(638, 352);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
