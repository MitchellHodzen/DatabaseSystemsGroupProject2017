namespace Pubs_DB_App.Publishers
{
    partial class Stores
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_storeID = new System.Windows.Forms.TextBox();
            this.tb_storeName = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.tb_zip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dvg_results = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_make_sale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_results)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Store ID";
            // 
            // tb_storeID
            // 
            this.tb_storeID.Location = new System.Drawing.Point(77, 58);
            this.tb_storeID.Name = "tb_storeID";
            this.tb_storeID.ReadOnly = true;
            this.tb_storeID.Size = new System.Drawing.Size(158, 20);
            this.tb_storeID.TabIndex = 6;
            // 
            // tb_storeName
            // 
            this.tb_storeName.Location = new System.Drawing.Point(77, 32);
            this.tb_storeName.Name = "tb_storeName";
            this.tb_storeName.ReadOnly = true;
            this.tb_storeName.Size = new System.Drawing.Size(158, 20);
            this.tb_storeName.TabIndex = 7;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(89, 90);
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = true;
            this.tb_address.Size = new System.Drawing.Size(158, 20);
            this.tb_address.TabIndex = 8;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(88, 116);
            this.tb_city.Name = "tb_city";
            this.tb_city.ReadOnly = true;
            this.tb_city.Size = new System.Drawing.Size(158, 20);
            this.tb_city.TabIndex = 9;
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(88, 142);
            this.tb_state.Name = "tb_state";
            this.tb_state.ReadOnly = true;
            this.tb_state.Size = new System.Drawing.Size(158, 20);
            this.tb_state.TabIndex = 10;
            // 
            // tb_zip
            // 
            this.tb_zip.Location = new System.Drawing.Point(88, 168);
            this.tb_zip.Name = "tb_zip";
            this.tb_zip.ReadOnly = true;
            this.tb_zip.Size = new System.Drawing.Size(158, 20);
            this.tb_zip.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(250, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sales";
            // 
            // dvg_results
            // 
            this.dvg_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_results.Location = new System.Drawing.Point(253, 38);
            this.dvg_results.Name = "dvg_results";
            this.dvg_results.Size = new System.Drawing.Size(240, 150);
            this.dvg_results.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_make_sale);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_storeName);
            this.groupBox1.Controls.Add(this.tb_storeID);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 232);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Sale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_view_sale_Click);
            // 
            // btn_make_sale
            // 
            this.btn_make_sale.Location = new System.Drawing.Point(77, 188);
            this.btn_make_sale.Name = "btn_make_sale";
            this.btn_make_sale.Size = new System.Drawing.Size(157, 23);
            this.btn_make_sale.TabIndex = 16;
            this.btn_make_sale.Text = "Make a Sale";
            this.btn_make_sale.UseVisualStyleBackColor = true;
            this.btn_make_sale.Click += new System.EventHandler(this.btn_make_sale_Click);
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 250);
            this.Controls.Add(this.dvg_results);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_zip);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stores";
            this.Text = "Store Info";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_results)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_storeID;
        private System.Windows.Forms.TextBox tb_storeName;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.TextBox tb_zip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dvg_results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_make_sale;
    }
}