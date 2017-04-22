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
            this.btn_storeSearch = new System.Windows.Forms.Button();
            this.dvg_results = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_remove_store = new System.Windows.Forms.Button();
            this.btn_edit_store = new System.Windows.Forms.Button();
            this.btn_view_sales = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_saleSearch = new System.Windows.Forms.Button();
            this.dgv_sale = new System.Windows.Forms.DataGridView();
            this.tb_saleNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_results)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).BeginInit();
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
            this.tb_storeID.Size = new System.Drawing.Size(158, 20);
            this.tb_storeID.TabIndex = 6;
            // 
            // tb_storeName
            // 
            this.tb_storeName.Location = new System.Drawing.Point(77, 32);
            this.tb_storeName.Name = "tb_storeName";
            this.tb_storeName.Size = new System.Drawing.Size(158, 20);
            this.tb_storeName.TabIndex = 7;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(89, 90);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(158, 20);
            this.tb_address.TabIndex = 8;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(88, 116);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(158, 20);
            this.tb_city.TabIndex = 9;
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(88, 142);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(158, 20);
            this.tb_state.TabIndex = 10;
            // 
            // tb_zip
            // 
            this.tb_zip.Location = new System.Drawing.Point(88, 168);
            this.tb_zip.Name = "tb_zip";
            this.tb_zip.Size = new System.Drawing.Size(158, 20);
            this.tb_zip.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Results";
            // 
            // btn_storeSearch
            // 
            this.btn_storeSearch.Location = new System.Drawing.Point(88, 200);
            this.btn_storeSearch.Name = "btn_storeSearch";
            this.btn_storeSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_storeSearch.TabIndex = 13;
            this.btn_storeSearch.Text = "Search";
            this.btn_storeSearch.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.btn_remove_store);
            this.groupBox1.Controls.Add(this.btn_edit_store);
            this.groupBox1.Controls.Add(this.btn_view_sales);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_storeName);
            this.groupBox1.Controls.Add(this.tb_storeID);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 232);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Store Info";
            // 
            // btn_remove_store
            // 
            this.btn_remove_store.Location = new System.Drawing.Point(410, 194);
            this.btn_remove_store.Name = "btn_remove_store";
            this.btn_remove_store.Size = new System.Drawing.Size(75, 23);
            this.btn_remove_store.TabIndex = 2;
            this.btn_remove_store.Text = "Remove";
            this.btn_remove_store.UseVisualStyleBackColor = true;
            // 
            // btn_edit_store
            // 
            this.btn_edit_store.Location = new System.Drawing.Point(329, 194);
            this.btn_edit_store.Name = "btn_edit_store";
            this.btn_edit_store.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_store.TabIndex = 1;
            this.btn_edit_store.Text = "Edit";
            this.btn_edit_store.UseVisualStyleBackColor = true;
            // 
            // btn_view_sales
            // 
            this.btn_view_sales.Location = new System.Drawing.Point(241, 194);
            this.btn_view_sales.Name = "btn_view_sales";
            this.btn_view_sales.Size = new System.Drawing.Size(82, 23);
            this.btn_view_sales.TabIndex = 0;
            this.btn_view_sales.Text = "View Sales";
            this.btn_view_sales.UseVisualStyleBackColor = true;
            this.btn_view_sales.Click += new System.EventHandler(this.btn_view_sales_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_saleSearch);
            this.groupBox2.Controls.Add(this.dgv_sale);
            this.groupBox2.Controls.Add(this.tb_saleNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 150);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By Sales No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Results";
            // 
            // btn_saleSearch
            // 
            this.btn_saleSearch.Location = new System.Drawing.Point(76, 73);
            this.btn_saleSearch.Name = "btn_saleSearch";
            this.btn_saleSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_saleSearch.TabIndex = 17;
            this.btn_saleSearch.Text = "Search";
            this.btn_saleSearch.UseVisualStyleBackColor = true;
            // 
            // dgv_sale
            // 
            this.dgv_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sale.Location = new System.Drawing.Point(241, 38);
            this.dgv_sale.Name = "dgv_sale";
            this.dgv_sale.Size = new System.Drawing.Size(240, 89);
            this.dgv_sale.TabIndex = 15;
            // 
            // tb_saleNum
            // 
            this.tb_saleNum.Location = new System.Drawing.Point(76, 45);
            this.tb_saleNum.Name = "tb_saleNum";
            this.tb_saleNum.Size = new System.Drawing.Size(158, 20);
            this.tb_saleNum.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sale Number";
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dvg_results);
            this.Controls.Add(this.btn_storeSearch);
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
            this.Text = "Stores";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_results)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).EndInit();
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
        private System.Windows.Forms.Button btn_storeSearch;
        private System.Windows.Forms.DataGridView dvg_results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_saleNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_saleSearch;
        private System.Windows.Forms.DataGridView dgv_sale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_view_sales;
        private System.Windows.Forms.Button btn_remove_store;
        private System.Windows.Forms.Button btn_edit_store;
    }
}