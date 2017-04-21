namespace Pubs_DB_App
{
    partial class Insert_Window_Title
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_pubID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_currentDate = new System.Windows.Forms.Button();
            this.tb_dateYear = new System.Windows.Forms.TextBox();
            this.combo_dateDay = new System.Windows.Forms.ComboBox();
            this.combo_dateMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_notes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_typeList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(16, 385);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(347, 28);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_pubID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_currentDate);
            this.groupBox2.Controls.Add(this.tb_dateYear);
            this.groupBox2.Controls.Add(this.combo_dateDay);
            this.groupBox2.Controls.Add(this.combo_dateMonth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(16, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(347, 133);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publisher Details";
            // 
            // tb_pubID
            // 
            this.tb_pubID.Location = new System.Drawing.Point(95, 23);
            this.tb_pubID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pubID.Name = "tb_pubID";
            this.tb_pubID.Size = new System.Drawing.Size(232, 22);
            this.tb_pubID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Publisher ID";
            // 
            // btn_currentDate
            // 
            this.btn_currentDate.Location = new System.Drawing.Point(95, 89);
            this.btn_currentDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_currentDate.Name = "btn_currentDate";
            this.btn_currentDate.Size = new System.Drawing.Size(233, 28);
            this.btn_currentDate.TabIndex = 21;
            this.btn_currentDate.Text = "Current Date";
            this.btn_currentDate.UseVisualStyleBackColor = true;
            // 
            // tb_dateYear
            // 
            this.tb_dateYear.Location = new System.Drawing.Point(224, 57);
            this.tb_dateYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_dateYear.MaxLength = 4;
            this.tb_dateYear.Name = "tb_dateYear";
            this.tb_dateYear.Size = new System.Drawing.Size(103, 22);
            this.tb_dateYear.TabIndex = 8;
            // 
            // combo_dateDay
            // 
            this.combo_dateDay.FormattingEnabled = true;
            this.combo_dateDay.Items.AddRange(new object[] {
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
            this.combo_dateDay.Location = new System.Drawing.Point(164, 55);
            this.combo_dateDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_dateDay.Name = "combo_dateDay";
            this.combo_dateDay.Size = new System.Drawing.Size(51, 24);
            this.combo_dateDay.TabIndex = 7;
            // 
            // combo_dateMonth
            // 
            this.combo_dateMonth.FormattingEnabled = true;
            this.combo_dateMonth.Items.AddRange(new object[] {
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
            this.combo_dateMonth.Location = new System.Drawing.Point(95, 55);
            this.combo_dateMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_dateMonth.Name = "combo_dateMonth";
            this.combo_dateMonth.Size = new System.Drawing.Size(60, 24);
            this.combo_dateMonth.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_notes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_typeList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(347, 226);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title Details";
            // 
            // rtb_notes
            // 
            this.rtb_notes.Location = new System.Drawing.Point(95, 151);
            this.rtb_notes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_notes.Name = "rtb_notes";
            this.rtb_notes.Size = new System.Drawing.Size(232, 56);
            this.rtb_notes.TabIndex = 13;
            this.rtb_notes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Notes";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(95, 119);
            this.tb_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(232, 22);
            this.tb_price.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // tb_typeList
            // 
            this.tb_typeList.Location = new System.Drawing.Point(95, 87);
            this.tb_typeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_typeList.Name = "tb_typeList";
            this.tb_typeList.Size = new System.Drawing.Size(232, 22);
            this.tb_typeList.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type List";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(95, 55);
            this.tb_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(232, 22);
            this.tb_type.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(95, 23);
            this.tb_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(232, 22);
            this.tb_title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title";
            // 
            // Insert_Window_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 427);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Insert_Window_Title";
            this.Text = "Insert New Title";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_dateYear;
        private System.Windows.Forms.ComboBox combo_dateDay;
        private System.Windows.Forms.ComboBox combo_dateMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_typeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_currentDate;
        private System.Windows.Forms.RichTextBox rtb_notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pubID;
        private System.Windows.Forms.Label label6;
    }
}