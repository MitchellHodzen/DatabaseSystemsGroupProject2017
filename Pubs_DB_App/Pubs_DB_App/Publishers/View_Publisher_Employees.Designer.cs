﻿namespace Pubs_DB_App.Publishers
{
    partial class View_Publisher_Employees
    {
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
            this.EmployeeSearch = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.JobList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_middle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeSearch
            // 
            this.EmployeeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeSearch.AutoSize = true;
            this.EmployeeSearch.Controls.Add(this.dataGridView1);
            this.EmployeeSearch.Controls.Add(this.btn_search);
            this.EmployeeSearch.Controls.Add(this.JobList);
            this.EmployeeSearch.Controls.Add(this.label5);
            this.EmployeeSearch.Controls.Add(this.tb_SSN);
            this.EmployeeSearch.Controls.Add(this.label4);
            this.EmployeeSearch.Controls.Add(this.tb_LName);
            this.EmployeeSearch.Controls.Add(this.label3);
            this.EmployeeSearch.Controls.Add(this.tb_middle);
            this.EmployeeSearch.Controls.Add(this.label2);
            this.EmployeeSearch.Controls.Add(this.tb_fName);
            this.EmployeeSearch.Controls.Add(this.label1);
            this.EmployeeSearch.Location = new System.Drawing.Point(12, 12);
            this.EmployeeSearch.Name = "EmployeeSearch";
            this.EmployeeSearch.Size = new System.Drawing.Size(523, 187);
            this.EmployeeSearch.TabIndex = 0;
            this.EmployeeSearch.TabStop = false;
            this.EmployeeSearch.Text = "Employee Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 162);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(111, 145);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // JobList
            // 
            this.JobList.FormattingEnabled = true;
            this.JobList.Location = new System.Drawing.Point(69, 118);
            this.JobList.Name = "JobList";
            this.JobList.Size = new System.Drawing.Size(117, 21);
            this.JobList.TabIndex = 9;
            this.JobList.SelectedIndexChanged += new System.EventHandler(this.JobList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Job";
            // 
            // tb_SSN
            // 
            this.tb_SSN.Location = new System.Drawing.Point(69, 91);
            this.tb_SSN.Name = "tb_SSN";
            this.tb_SSN.Size = new System.Drawing.Size(117, 20);
            this.tb_SSN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SSN";
            // 
            // tb_LName
            // 
            this.tb_LName.Location = new System.Drawing.Point(69, 39);
            this.tb_LName.Name = "tb_LName";
            this.tb_LName.Size = new System.Drawing.Size(117, 20);
            this.tb_LName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // tb_middle
            // 
            this.tb_middle.Location = new System.Drawing.Point(69, 65);
            this.tb_middle.Name = "tb_middle";
            this.tb_middle.Size = new System.Drawing.Size(21, 20);
            this.tb_middle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "M";
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(69, 13);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(117, 20);
            this.tb_fName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // View_Publisher_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(550, 203);
            this.Controls.Add(this.EmployeeSearch);
            this.Name = "View_Publisher_Employees";
            this.Text = "Publisher Employee Search";
            this.Load += new System.EventHandler(this.View_Publisher_Employees_Load);
            this.EmployeeSearch.ResumeLayout(false);
            this.EmployeeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fName;
        private System.Windows.Forms.TextBox tb_LName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_middle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JobList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
    }
}