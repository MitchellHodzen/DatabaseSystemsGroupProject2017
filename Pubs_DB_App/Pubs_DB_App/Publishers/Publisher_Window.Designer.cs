namespace Pubs_DB_App.Publishers
{
    partial class Publisher_Window
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pubname = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_jobs = new System.Windows.Forms.Button();
            this.btn_titles = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_newJob = new System.Windows.Forms.Button();
            this.btn_submitTitle = new System.Windows.Forms.Button();
            this.btn_hireEmployees = new System.Windows.Forms.Button();
            this.btn_makeSale = new System.Windows.Forms.Button();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_pubid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_pubname
            // 
            this.tb_pubname.Enabled = false;
            this.tb_pubname.Location = new System.Drawing.Point(153, 32);
            this.tb_pubname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pubname.Name = "tb_pubname";
            this.tb_pubname.Size = new System.Drawing.Size(216, 22);
            this.tb_pubname.TabIndex = 1;
            this.tb_pubname.TextChanged += new System.EventHandler(this.tb_pubname_TextChanged);
            // 
            // tb_city
            // 
            this.tb_city.Enabled = false;
            this.tb_city.Location = new System.Drawing.Point(153, 96);
            this.tb_city.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(216, 22);
            this.tb_city.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // tb_state
            // 
            this.tb_state.Enabled = false;
            this.tb_state.Location = new System.Drawing.Point(153, 128);
            this.tb_state.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(216, 22);
            this.tb_state.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // tb_country
            // 
            this.tb_country.Enabled = false;
            this.tb_country.Location = new System.Drawing.Point(153, 160);
            this.tb_country.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(216, 22);
            this.tb_country.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(404, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 330);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_jobs);
            this.tabPage1.Controls.Add(this.btn_titles);
            this.tabPage1.Controls.Add(this.btn_employees);
            this.tabPage1.Controls.Add(this.btn_sales);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(325, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_jobs
            // 
            this.btn_jobs.Location = new System.Drawing.Point(8, 84);
            this.btn_jobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_jobs.Name = "btn_jobs";
            this.btn_jobs.Size = new System.Drawing.Size(307, 62);
            this.btn_jobs.TabIndex = 17;
            this.btn_jobs.Text = "Jobs";
            this.btn_jobs.UseVisualStyleBackColor = true;
            // 
            // btn_titles
            // 
            this.btn_titles.Location = new System.Drawing.Point(8, 153);
            this.btn_titles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_titles.Name = "btn_titles";
            this.btn_titles.Size = new System.Drawing.Size(307, 62);
            this.btn_titles.TabIndex = 19;
            this.btn_titles.Text = "Titles";
            this.btn_titles.UseVisualStyleBackColor = true;
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(8, 15);
            this.btn_employees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(307, 62);
            this.btn_employees.TabIndex = 16;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(8, 222);
            this.btn_sales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(307, 62);
            this.btn_sales.TabIndex = 18;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_newJob);
            this.tabPage2.Controls.Add(this.btn_submitTitle);
            this.tabPage2.Controls.Add(this.btn_hireEmployees);
            this.tabPage2.Controls.Add(this.btn_makeSale);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(325, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_newJob
            // 
            this.btn_newJob.Location = new System.Drawing.Point(8, 84);
            this.btn_newJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_newJob.Name = "btn_newJob";
            this.btn_newJob.Size = new System.Drawing.Size(307, 62);
            this.btn_newJob.TabIndex = 13;
            this.btn_newJob.Text = "Create New Job";
            this.btn_newJob.UseVisualStyleBackColor = true;
            this.btn_newJob.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_submitTitle
            // 
            this.btn_submitTitle.Location = new System.Drawing.Point(8, 153);
            this.btn_submitTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_submitTitle.Name = "btn_submitTitle";
            this.btn_submitTitle.Size = new System.Drawing.Size(307, 62);
            this.btn_submitTitle.TabIndex = 15;
            this.btn_submitTitle.Text = "Submit Title";
            this.btn_submitTitle.UseVisualStyleBackColor = true;
            this.btn_submitTitle.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_hireEmployees
            // 
            this.btn_hireEmployees.Location = new System.Drawing.Point(8, 15);
            this.btn_hireEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_hireEmployees.Name = "btn_hireEmployees";
            this.btn_hireEmployees.Size = new System.Drawing.Size(307, 62);
            this.btn_hireEmployees.TabIndex = 12;
            this.btn_hireEmployees.Text = "Hire Employees";
            this.btn_hireEmployees.UseVisualStyleBackColor = true;
            this.btn_hireEmployees.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_makeSale
            // 
            this.btn_makeSale.Location = new System.Drawing.Point(8, 222);
            this.btn_makeSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_makeSale.Name = "btn_makeSale";
            this.btn_makeSale.Size = new System.Drawing.Size(307, 62);
            this.btn_makeSale.TabIndex = 14;
            this.btn_makeSale.Text = "Make Sale";
            this.btn_makeSale.UseVisualStyleBackColor = true;
            this.btn_makeSale.Click += new System.EventHandler(this.button8_Click);
            // 
            // rtb_info
            // 
            this.rtb_info.Enabled = false;
            this.rtb_info.Location = new System.Drawing.Point(153, 192);
            this.rtb_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.Size = new System.Drawing.Size(216, 133);
            this.rtb_info.TabIndex = 13;
            this.rtb_info.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Info";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(41, 334);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(153, 28);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(217, 334);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(153, 28);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button10_Click);
            // 
            // tb_pubid
            // 
            this.tb_pubid.Enabled = false;
            this.tb_pubid.Location = new System.Drawing.Point(153, 64);
            this.tb_pubid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pubid.Name = "tb_pubid";
            this.tb_pubid.Size = new System.Drawing.Size(216, 22);
            this.tb_pubid.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Publisher ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Publisher_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 395);
            this.Controls.Add(this.tb_pubid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_info);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pubname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Publisher_Window";
            this.Text = "Publisher_Window";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pubname;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_newJob;
        private System.Windows.Forms.Button btn_submitTitle;
        private System.Windows.Forms.Button btn_hireEmployees;
        private System.Windows.Forms.Button btn_makeSale;
        private System.Windows.Forms.Button btn_jobs;
        private System.Windows.Forms.Button btn_titles;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_pubid;
        private System.Windows.Forms.Label label6;
    }
}