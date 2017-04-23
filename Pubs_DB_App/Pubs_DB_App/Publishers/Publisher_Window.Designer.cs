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
            this.btn_hire = new System.Windows.Forms.Button();
            this.btn_makeSale = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_pubname
            // 
            this.tb_pubname.Location = new System.Drawing.Point(115, 98);
            this.tb_pubname.Name = "tb_pubname";
            this.tb_pubname.ReadOnly = true;
            this.tb_pubname.Size = new System.Drawing.Size(163, 20);
            this.tb_pubname.TabIndex = 1;
            this.tb_pubname.TextChanged += new System.EventHandler(this.tb_pubname_TextChanged);
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(115, 150);
            this.tb_city.Name = "tb_city";
            this.tb_city.ReadOnly = true;
            this.tb_city.Size = new System.Drawing.Size(163, 20);
            this.tb_city.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(115, 176);
            this.tb_state.Name = "tb_state";
            this.tb_state.ReadOnly = true;
            this.tb_state.Size = new System.Drawing.Size(163, 20);
            this.tb_state.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(115, 202);
            this.tb_country.Name = "tb_country";
            this.tb_country.ReadOnly = true;
            this.tb_country.Size = new System.Drawing.Size(163, 20);
            this.tb_country.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(303, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 268);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_jobs);
            this.tabPage1.Controls.Add(this.btn_titles);
            this.tabPage1.Controls.Add(this.btn_employees);
            this.tabPage1.Controls.Add(this.btn_sales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_jobs
            // 
            this.btn_jobs.Location = new System.Drawing.Point(6, 68);
            this.btn_jobs.Name = "btn_jobs";
            this.btn_jobs.Size = new System.Drawing.Size(230, 50);
            this.btn_jobs.TabIndex = 17;
            this.btn_jobs.Text = "Jobs";
            this.btn_jobs.UseVisualStyleBackColor = true;
            this.btn_jobs.Click += new System.EventHandler(this.btn_jobs_Click);
            // 
            // btn_titles
            // 
            this.btn_titles.Location = new System.Drawing.Point(6, 124);
            this.btn_titles.Name = "btn_titles";
            this.btn_titles.Size = new System.Drawing.Size(230, 50);
            this.btn_titles.TabIndex = 19;
            this.btn_titles.Text = "Titles";
            this.btn_titles.UseVisualStyleBackColor = true;
            this.btn_titles.Click += new System.EventHandler(this.btn_titles_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(6, 12);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(230, 50);
            this.btn_employees.TabIndex = 16;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(6, 180);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(230, 50);
            this.btn_sales.TabIndex = 18;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_newJob);
            this.tabPage2.Controls.Add(this.btn_submitTitle);
            this.tabPage2.Controls.Add(this.btn_hire);
            this.tabPage2.Controls.Add(this.btn_makeSale);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_newJob
            // 
            this.btn_newJob.Location = new System.Drawing.Point(6, 68);
            this.btn_newJob.Name = "btn_newJob";
            this.btn_newJob.Size = new System.Drawing.Size(230, 50);
            this.btn_newJob.TabIndex = 13;
            this.btn_newJob.Text = "Create New Job";
            this.btn_newJob.UseVisualStyleBackColor = true;
            this.btn_newJob.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_submitTitle
            // 
            this.btn_submitTitle.Location = new System.Drawing.Point(6, 124);
            this.btn_submitTitle.Name = "btn_submitTitle";
            this.btn_submitTitle.Size = new System.Drawing.Size(230, 50);
            this.btn_submitTitle.TabIndex = 15;
            this.btn_submitTitle.Text = "Submit Title";
            this.btn_submitTitle.UseVisualStyleBackColor = true;
            this.btn_submitTitle.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_hire
            // 
            this.btn_hire.Location = new System.Drawing.Point(6, 12);
            this.btn_hire.Name = "btn_hire";
            this.btn_hire.Size = new System.Drawing.Size(230, 50);
            this.btn_hire.TabIndex = 12;
            this.btn_hire.Text = "Hire Employees";
            this.btn_hire.UseVisualStyleBackColor = true;
            this.btn_hire.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_makeSale
            // 
            this.btn_makeSale.Location = new System.Drawing.Point(6, 180);
            this.btn_makeSale.Name = "btn_makeSale";
            this.btn_makeSale.Size = new System.Drawing.Size(230, 50);
            this.btn_makeSale.TabIndex = 14;
            this.btn_makeSale.Text = "Make Sale";
            this.btn_makeSale.UseVisualStyleBackColor = true;
            this.btn_makeSale.Click += new System.EventHandler(this.button8_Click);
            // 
            // tb_pubid
            // 
            this.tb_pubid.Location = new System.Drawing.Point(115, 124);
            this.tb_pubid.Name = "tb_pubid";
            this.tb_pubid.ReadOnly = true;
            this.tb_pubid.Size = new System.Drawing.Size(163, 20);
            this.tb_pubid.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Publisher ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Publisher_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 321);
            this.Controls.Add(this.tb_pubid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pubname);
            this.Controls.Add(this.label1);
            this.Name = "Publisher_Window";
            this.Text = "Publisher_Window";
            this.Load += new System.EventHandler(this.Publisher_Window_Load);
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
        private System.Windows.Forms.Button btn_hire;
        private System.Windows.Forms.Button btn_makeSale;
        private System.Windows.Forms.Button btn_jobs;
        private System.Windows.Forms.Button btn_titles;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.TextBox tb_pubid;
        private System.Windows.Forms.Label label6;
    }
}