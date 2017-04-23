namespace Pubs_DB_App
{
    partial class Sales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pubid = new System.Windows.Forms.TextBox();
            this.btn_create_sale = new System.Windows.Forms.Button();
            this.btn_view_title_Click = new System.Windows.Forms.Button();
            this.btn_clear_text = new System.Windows.Forms.Button();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_orderDate = new System.Windows.Forms.TextBox();
            this.tb_store = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_orderNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.dgv_sales);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_pubid);
            this.groupBox1.Controls.Add(this.btn_create_sale);
            this.groupBox1.Controls.Add(this.btn_view_title_Click);
            this.groupBox1.Controls.Add(this.btn_clear_text);
            this.groupBox1.Controls.Add(this.tb_discount);
            this.groupBox1.Controls.Add(this.tb_quantity);
            this.groupBox1.Controls.Add(this.tb_orderDate);
            this.groupBox1.Controls.Add(this.tb_store);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.tb_orderNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "* denotes required field";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(20, 237);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 23);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_sales
            // 
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Location = new System.Drawing.Point(260, 19);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.Size = new System.Drawing.Size(298, 177);
            this.dgv_sales.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "* Publisher ID";
            // 
            // tb_pubid
            // 
            this.tb_pubid.Location = new System.Drawing.Point(96, 98);
            this.tb_pubid.Name = "tb_pubid";
            this.tb_pubid.Size = new System.Drawing.Size(158, 20);
            this.tb_pubid.TabIndex = 18;
            // 
            // btn_create_sale
            // 
            this.btn_create_sale.Location = new System.Drawing.Point(407, 234);
            this.btn_create_sale.Name = "btn_create_sale";
            this.btn_create_sale.Size = new System.Drawing.Size(145, 26);
            this.btn_create_sale.TabIndex = 17;
            this.btn_create_sale.Text = "Create New Sale";
            this.btn_create_sale.UseVisualStyleBackColor = true;
            this.btn_create_sale.Click += new System.EventHandler(this.btn_create_sale_Click);
            // 
            // btn_view_title_Click
            // 
            this.btn_view_title_Click.Location = new System.Drawing.Point(260, 234);
            this.btn_view_title_Click.Name = "btn_view_title_Click";
            this.btn_view_title_Click.Size = new System.Drawing.Size(141, 26);
            this.btn_view_title_Click.TabIndex = 16;
            this.btn_view_title_Click.Text = "View Title Info";
            this.btn_view_title_Click.UseVisualStyleBackColor = true;
            this.btn_view_title_Click.Click += new System.EventHandler(this.btn_view_title_info_Click);
            // 
            // btn_clear_text
            // 
            this.btn_clear_text.Location = new System.Drawing.Point(147, 236);
            this.btn_clear_text.Name = "btn_clear_text";
            this.btn_clear_text.Size = new System.Drawing.Size(107, 24);
            this.btn_clear_text.TabIndex = 12;
            this.btn_clear_text.Text = "Clear Text";
            this.btn_clear_text.UseVisualStyleBackColor = true;
            this.btn_clear_text.Click += new System.EventHandler(this.btn_clear_text_Click);
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(96, 176);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(158, 20);
            this.tb_discount.TabIndex = 11;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(96, 150);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(158, 20);
            this.tb_quantity.TabIndex = 10;
            // 
            // tb_orderDate
            // 
            this.tb_orderDate.Location = new System.Drawing.Point(96, 124);
            this.tb_orderDate.Name = "tb_orderDate";
            this.tb_orderDate.Size = new System.Drawing.Size(158, 20);
            this.tb_orderDate.TabIndex = 9;
            // 
            // tb_store
            // 
            this.tb_store.Location = new System.Drawing.Point(96, 72);
            this.tb_store.Name = "tb_store";
            this.tb_store.Size = new System.Drawing.Size(158, 20);
            this.tb_store.TabIndex = 8;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(96, 46);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(158, 20);
            this.tb_title.TabIndex = 7;
            // 
            // tb_orderNum
            // 
            this.tb_orderNum.Location = new System.Drawing.Point(96, 20);
            this.tb_orderNum.Name = "tb_orderNum";
            this.tb_orderNum.Size = new System.Drawing.Size(158, 20);
            this.tb_orderNum.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payterms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales";
            this.Text = "View Sale";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_orderDate;
        private System.Windows.Forms.TextBox tb_store;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_orderNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear_text;
        private System.Windows.Forms.Button btn_view_title_Click;
        private System.Windows.Forms.Button btn_create_sale;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_pubid;
        private System.Windows.Forms.Label label8;
    }
}