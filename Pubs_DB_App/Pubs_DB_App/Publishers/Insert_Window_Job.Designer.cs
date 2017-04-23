namespace Pubs_DB_App.Publishers
{
    partial class Insert_Window_Job
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
            this.tb_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_pubID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_maxLvl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_minLvl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_submit
            // 
            this.tb_submit.Location = new System.Drawing.Point(12, 156);
            this.tb_submit.Name = "tb_submit";
            this.tb_submit.Size = new System.Drawing.Size(260, 23);
            this.tb_submit.TabIndex = 23;
            this.tb_submit.Text = "Submit";
            this.tb_submit.UseVisualStyleBackColor = true;
            this.tb_submit.Click += new System.EventHandler(this.tb_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pubID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_maxLvl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_minLvl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 138);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Details     * - denotes required field";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_pubID
            // 
            this.tb_pubID.Location = new System.Drawing.Point(72, 26);
            this.tb_pubID.Name = "tb_pubID";
            this.tb_pubID.Size = new System.Drawing.Size(174, 20);
            this.tb_pubID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pub ID *";
            // 
            // tb_maxLvl
            // 
            this.tb_maxLvl.Location = new System.Drawing.Point(72, 104);
            this.tb_maxLvl.Name = "tb_maxLvl";
            this.tb_maxLvl.Size = new System.Drawing.Size(174, 20);
            this.tb_maxLvl.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max LVL *";
            // 
            // tb_minLvl
            // 
            this.tb_minLvl.Location = new System.Drawing.Point(72, 78);
            this.tb_minLvl.Name = "tb_minLvl";
            this.tb_minLvl.Size = new System.Drawing.Size(174, 20);
            this.tb_minLvl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Min LVL *";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(72, 52);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(174, 20);
            this.tb_description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description *";
            // 
            // Insert_Window_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.tb_submit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Insert_Window_Job";
            this.Text = "Create New Job";
            this.Load += new System.EventHandler(this.Insert_Window_Job_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tb_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pubID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_maxLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_minLvl;
        private System.Windows.Forms.Label label1;
    }
}