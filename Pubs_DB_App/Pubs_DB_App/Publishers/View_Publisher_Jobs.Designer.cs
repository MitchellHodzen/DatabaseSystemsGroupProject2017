namespace Pubs_DB_App.Publishers
{
    partial class View_Publisher_Jobs
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
            this.tb_minLvl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_maxLvl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_jobID = new System.Windows.Forms.TextBox();
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
            this.EmployeeSearch.Controls.Add(this.tb_minLvl);
            this.EmployeeSearch.Controls.Add(this.label3);
            this.EmployeeSearch.Controls.Add(this.tb_maxLvl);
            this.EmployeeSearch.Controls.Add(this.label2);
            this.EmployeeSearch.Controls.Add(this.tb_jobID);
            this.EmployeeSearch.Controls.Add(this.label1);
            this.EmployeeSearch.Location = new System.Drawing.Point(12, 12);
            this.EmployeeSearch.Name = "EmployeeSearch";
            this.EmployeeSearch.Size = new System.Drawing.Size(556, 133);
            this.EmployeeSearch.TabIndex = 1;
            this.EmployeeSearch.TabStop = false;
            this.EmployeeSearch.Text = "Job Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 101);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(39, 91);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_minLvl
            // 
            this.tb_minLvl.Location = new System.Drawing.Point(69, 39);
            this.tb_minLvl.Name = "tb_minLvl";
            this.tb_minLvl.Size = new System.Drawing.Size(45, 20);
            this.tb_minLvl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Level";
            // 
            // tb_maxLvl
            // 
            this.tb_maxLvl.Location = new System.Drawing.Point(70, 65);
            this.tb_maxLvl.Name = "tb_maxLvl";
            this.tb_maxLvl.Size = new System.Drawing.Size(44, 20);
            this.tb_maxLvl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Level";
            // 
            // tb_jobID
            // 
            this.tb_jobID.Location = new System.Drawing.Point(69, 13);
            this.tb_jobID.Name = "tb_jobID";
            this.tb_jobID.Size = new System.Drawing.Size(45, 20);
            this.tb_jobID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job ID";
            // 
            // View_Publisher_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 153);
            this.Controls.Add(this.EmployeeSearch);
            this.Name = "View_Publisher_Jobs";
            this.Text = "Job Search";
            this.Load += new System.EventHandler(this.View_Publisher_Jobs_Load);
            this.EmployeeSearch.ResumeLayout(false);
            this.EmployeeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_minLvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_maxLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_jobID;
        private System.Windows.Forms.Label label1;
    }
}