namespace Pubs_DB_App.Publishers
{
    partial class Insert_Window_Employee
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
            this.combo_job = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.tb_lName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_middle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_employee = new System.Windows.Forms.Button();
            this.tb_SSN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_job = new System.Windows.Forms.Button();
            this.tb_pubID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_hireDateY = new System.Windows.Forms.TextBox();
            this.combo_hireDateD = new System.Windows.Forms.ComboBox();
            this.combo_hiredateM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_joblvl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_job
            // 
            this.combo_job.FormattingEnabled = true;
            this.combo_job.Location = new System.Drawing.Point(79, 45);
            this.combo_job.Name = "combo_job";
            this.combo_job.Size = new System.Drawing.Size(121, 21);
            this.combo_job.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(79, 18);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(117, 20);
            this.tb_fName.TabIndex = 4;
            // 
            // tb_lName
            // 
            this.tb_lName.Location = new System.Drawing.Point(79, 44);
            this.tb_lName.Name = "tb_lName";
            this.tb_lName.Size = new System.Drawing.Size(175, 20);
            this.tb_lName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "M";
            // 
            // tb_middle
            // 
            this.tb_middle.Location = new System.Drawing.Point(224, 18);
            this.tb_middle.Name = "tb_middle";
            this.tb_middle.Size = new System.Drawing.Size(30, 20);
            this.tb_middle.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_employee);
            this.groupBox1.Controls.Add(this.tb_SSN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_lName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_middle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_fName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // btn_employee
            // 
            this.btn_employee.Enabled = false;
            this.btn_employee.Location = new System.Drawing.Point(224, 70);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(30, 24);
            this.btn_employee.TabIndex = 15;
            this.btn_employee.Text = "->";
            this.btn_employee.UseVisualStyleBackColor = true;
            // 
            // tb_SSN
            // 
            this.tb_SSN.Enabled = false;
            this.tb_SSN.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SSN.Location = new System.Drawing.Point(79, 70);
            this.tb_SSN.MaxLength = 3;
            this.tb_SSN.Name = "tb_SSN";
            this.tb_SSN.PasswordChar = '*';
            this.tb_SSN.Size = new System.Drawing.Size(138, 23);
            this.tb_SSN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_job);
            this.groupBox2.Controls.Add(this.tb_pubID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_hireDateY);
            this.groupBox2.Controls.Add(this.combo_hireDateD);
            this.groupBox2.Controls.Add(this.combo_hiredateM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_joblvl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combo_job);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 132);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Details";
            // 
            // btn_job
            // 
            this.btn_job.Location = new System.Drawing.Point(224, 16);
            this.btn_job.Name = "btn_job";
            this.btn_job.Size = new System.Drawing.Size(30, 23);
            this.btn_job.TabIndex = 39;
            this.btn_job.Text = "->";
            this.btn_job.UseVisualStyleBackColor = true;
            // 
            // tb_pubID
            // 
            this.tb_pubID.Location = new System.Drawing.Point(79, 19);
            this.tb_pubID.Name = "tb_pubID";
            this.tb_pubID.Size = new System.Drawing.Size(139, 20);
            this.tb_pubID.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Publisher ID";
            // 
            // tb_hireDateY
            // 
            this.tb_hireDateY.Location = new System.Drawing.Point(176, 99);
            this.tb_hireDateY.MaxLength = 4;
            this.tb_hireDateY.Name = "tb_hireDateY";
            this.tb_hireDateY.Size = new System.Drawing.Size(47, 20);
            this.tb_hireDateY.TabIndex = 8;
            // 
            // combo_hireDateD
            // 
            this.combo_hireDateD.FormattingEnabled = true;
            this.combo_hireDateD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.combo_hireDateD.Location = new System.Drawing.Point(131, 98);
            this.combo_hireDateD.Name = "combo_hireDateD";
            this.combo_hireDateD.Size = new System.Drawing.Size(39, 21);
            this.combo_hireDateD.TabIndex = 7;
            // 
            // combo_hiredateM
            // 
            this.combo_hiredateM.FormattingEnabled = true;
            this.combo_hiredateM.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.combo_hiredateM.Location = new System.Drawing.Point(79, 98);
            this.combo_hiredateM.Name = "combo_hiredateM";
            this.combo_hiredateM.Size = new System.Drawing.Size(46, 21);
            this.combo_hiredateM.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Hire Date";
            // 
            // tb_joblvl
            // 
            this.tb_joblvl.Location = new System.Drawing.Point(79, 72);
            this.tb_joblvl.Name = "tb_joblvl";
            this.tb_joblvl.Size = new System.Drawing.Size(100, 20);
            this.tb_joblvl.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Job Level";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(12, 261);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(260, 23);
            this.btn_submit.TabIndex = 17;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Insert_Window_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Insert_Window_Employee";
            this.Text = "Hire New Employee";
            this.Load += new System.EventHandler(this.Insert_Window_Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_job;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_fName;
        private System.Windows.Forms.TextBox tb_lName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_middle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SSN;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_hireDateY;
        private System.Windows.Forms.ComboBox combo_hireDateD;
        private System.Windows.Forms.ComboBox combo_hiredateM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_joblvl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tb_pubID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_job;
    }
}