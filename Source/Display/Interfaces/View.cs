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
        private System.Windows.Forms.Button CancelButton;

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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecordListBox
            // 
            this.RecordListBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordListBox.FormattingEnabled = true;
            this.RecordListBox.ItemHeight = 18;
            this.RecordListBox.Items.AddRange(new object[] {
            "Field1: value",
            "Field2: value",
            "Field3: value"});
            this.RecordListBox.Location = new System.Drawing.Point(54, 45);
            this.RecordListBox.Name = "RecordListBox";
            this.RecordListBox.Size = new System.Drawing.Size(531, 184);
            this.RecordListBox.TabIndex = 0;
            // 
            // RunComboBox
            // 
            this.RunComboBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunComboBox.FormattingEnabled = true;
            this.RunComboBox.Location = new System.Drawing.Point(54, 277);
            this.RunComboBox.Name = "RunComboBox";
            this.RunComboBox.Size = new System.Drawing.Size(236, 26);
            this.RunComboBox.TabIndex = 1;
            // 
            // Run
            // 
            this.Run.AutoSize = true;
            this.Run.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(315, 282);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(34, 18);
            this.Run.TabIndex = 2;
            this.Run.Text = "run";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(510, 333);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.RunComboBox);
            this.Controls.Add(this.RecordListBox);
            this.Name = "View";
            this.Size = new System.Drawing.Size(740, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public override void PostInit()
        {
            base.PostInit();
            RunComboBox.Focus();
        }
    }
}
