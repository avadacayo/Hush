namespace Hush.Display.Interfaces
{

    class Search : Interface
    {
    }
        /*
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpSearchField = new System.Windows.Forms.GroupBox();
            this.ckCategory = new System.Windows.Forms.CheckBox();
            this.ckTags = new System.Windows.Forms.CheckBox();
            this.ckName = new System.Windows.Forms.CheckBox();
            this.ckField = new System.Windows.Forms.CheckBox();
            this.txtFieldSearch = new System.Windows.Forms.TextBox();
            this.grpDateRange = new System.Windows.Forms.GroupBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.grpSearchField.SuspendLayout();
            this.grpDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(361, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // grpSearchField
            // 
            this.grpSearchField.Controls.Add(this.txtFieldSearch);
            this.grpSearchField.Controls.Add(this.ckField);
            this.grpSearchField.Controls.Add(this.ckName);
            this.grpSearchField.Controls.Add(this.ckTags);
            this.grpSearchField.Controls.Add(this.ckCategory);
            this.grpSearchField.Location = new System.Drawing.Point(12, 51);
            this.grpSearchField.Name = "grpSearchField";
            this.grpSearchField.Size = new System.Drawing.Size(165, 157);
            this.grpSearchField.TabIndex = 1;
            this.grpSearchField.TabStop = false;
            this.grpSearchField.Text = "Search By";
            // 
            // ckCategory
            // 
            this.ckCategory.AutoSize = true;
            this.ckCategory.Location = new System.Drawing.Point(7, 28);
            this.ckCategory.Name = "ckCategory";
            this.ckCategory.Size = new System.Drawing.Size(68, 17);
            this.ckCategory.TabIndex = 0;
            this.ckCategory.Text = "Category";
            this.ckCategory.UseVisualStyleBackColor = true;
            // 
            // ckTags
            // 
            this.ckTags.AutoSize = true;
            this.ckTags.Location = new System.Drawing.Point(7, 51);
            this.ckTags.Name = "ckTags";
            this.ckTags.Size = new System.Drawing.Size(50, 17);
            this.ckTags.TabIndex = 1;
            this.ckTags.Text = "Tags";
            this.ckTags.UseVisualStyleBackColor = true;
            // 
            // ckName
            // 
            this.ckName.AutoSize = true;
            this.ckName.Location = new System.Drawing.Point(7, 74);
            this.ckName.Name = "ckName";
            this.ckName.Size = new System.Drawing.Size(54, 17);
            this.ckName.TabIndex = 2;
            this.ckName.Text = "Name";
            this.ckName.UseVisualStyleBackColor = true;
            // 
            // ckField
            // 
            this.ckField.AutoSize = true;
            this.ckField.Location = new System.Drawing.Point(7, 97);
            this.ckField.Name = "ckField";
            this.ckField.Size = new System.Drawing.Size(51, 17);
            this.ckField.TabIndex = 3;
            this.ckField.Text = "Field:";
            this.ckField.UseVisualStyleBackColor = true;
            // 
            // txtFieldSearch
            // 
            this.txtFieldSearch.Location = new System.Drawing.Point(27, 120);
            this.txtFieldSearch.Name = "txtFieldSearch";
            this.txtFieldSearch.Size = new System.Drawing.Size(122, 20);
            this.txtFieldSearch.TabIndex = 4;
            // 
            // grpDateRange
            // 
            this.grpDateRange.Controls.Add(this.dtpDateTo);
            this.grpDateRange.Controls.Add(this.dtpDateFrom);
            this.grpDateRange.Controls.Add(this.lblDateTo);
            this.grpDateRange.Controls.Add(this.lblDateFrom);
            this.grpDateRange.Location = new System.Drawing.Point(183, 51);
            this.grpDateRange.Name = "grpDateRange";
            this.grpDateRange.Size = new System.Drawing.Size(190, 114);
            this.grpDateRange.TabIndex = 2;
            this.grpDateRange.TabStop = false;
            this.grpDateRange.Text = "Date Range";
            this.grpDateRange.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(7, 20);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(30, 13);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "From";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(7, 67);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(20, 13);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "To";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(10, 37);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(171, 20);
            this.dtpDateFrom.TabIndex = 2;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(10, 87);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(171, 20);
            this.dtpDateTo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(12, 9);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(76, 13);
            this.lblSearchTerm.TabIndex = 5;
            this.lblSearchTerm.Text = "Search Terms:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 223);
            this.Controls.Add(this.lblSearchTerm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpDateRange);
            this.Controls.Add(this.grpSearchField);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Advanced Search";
            this.grpSearchField.ResumeLayout(false);
            this.grpSearchField.PerformLayout();
            this.grpDateRange.ResumeLayout(false);
            this.grpDateRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpSearchField;
        private System.Windows.Forms.TextBox txtFieldSearch;
        private System.Windows.Forms.CheckBox ckField;
        private System.Windows.Forms.CheckBox ckName;
        private System.Windows.Forms.CheckBox ckTags;
        private System.Windows.Forms.CheckBox ckCategory;
        private System.Windows.Forms.GroupBox grpDateRange;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSearchTerm;
    }*/
}

