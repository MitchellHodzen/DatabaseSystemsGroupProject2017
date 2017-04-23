namespace Pubs_DB_App.Stores_Sales
{
    partial class Insert_Window_Sale
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.storeidcombo = new System.Windows.Forms.ComboBox();
            this.titleidcombo = new System.Windows.Forms.ComboBox();
            this.tb_payTerms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 198);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(260, 23);
            this.btn_Submit.TabIndex = 20;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.storeidcombo);
            this.groupBox2.Controls.Add(this.titleidcombo);
            this.groupBox2.Controls.Add(this.tb_payTerms);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_qty);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 171);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Details";
            // 
            // storeidcombo
            // 
            this.storeidcombo.FormattingEnabled = true;
            this.storeidcombo.Location = new System.Drawing.Point(147, 51);
            this.storeidcombo.Name = "storeidcombo";
            this.storeidcombo.Size = new System.Drawing.Size(175, 21);
            this.storeidcombo.TabIndex = 42;
            // 
            // titleidcombo
            // 
            this.titleidcombo.FormattingEnabled = true;
            this.titleidcombo.Location = new System.Drawing.Point(147, 25);
            this.titleidcombo.Name = "titleidcombo";
            this.titleidcombo.Size = new System.Drawing.Size(175, 21);
            this.titleidcombo.TabIndex = 41;
            // 
            // tb_payTerms
            // 
            this.tb_payTerms.Location = new System.Drawing.Point(147, 103);
            this.tb_payTerms.MaxLength = 20;
            this.tb_payTerms.Name = "tb_payTerms";
            this.tb_payTerms.Size = new System.Drawing.Size(175, 20);
            this.tb_payTerms.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Pay Terms";
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(147, 77);
            this.tb_qty.MaxLength = 4;
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(175, 20);
            this.tb_qty.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Store ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Title ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sale Date (MM/DD/YYYY)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 43;
            // 
            // Insert_Window_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 233);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox2);
            this.Name = "Insert_Window_Sale";
            this.Text = "Make Sale";
            this.Load += new System.EventHandler(this.Insert_Window_Sale_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_payTerms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox titleidcombo;
        private System.Windows.Forms.ComboBox storeidcombo;
        private System.Windows.Forms.TextBox textBox1;
    }
}