namespace Pubs_DB_App
{
    partial class Start_Window
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
            this.pubTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_pub_country = new System.Windows.Forms.TextBox();
            this.btn_pub_search = new System.Windows.Forms.Button();
            this.cb_pub_country = new System.Windows.Forms.CheckBox();
            this.tb_pub_state = new System.Windows.Forms.TextBox();
            this.cb_pub_state = new System.Windows.Forms.CheckBox();
            this.tb_pub_city = new System.Windows.Forms.TextBox();
            this.cb_pub_city = new System.Windows.Forms.CheckBox();
            this.tb_pub_name = new System.Windows.Forms.TextBox();
            this.cb_pub_pubName = new System.Windows.Forms.CheckBox();
            this.btn_pub_selectPub = new System.Windows.Forms.Button();
            this.dgv_pub = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_title_addTitle = new System.Windows.Forms.Button();
            this.btn_title_search = new System.Windows.Forms.Button();
            this.tb_title_pubDate = new System.Windows.Forms.TextBox();
            this.cb_title_pubDate = new System.Windows.Forms.CheckBox();
            this.tb_title_type = new System.Windows.Forms.TextBox();
            this.cb_title_Type = new System.Windows.Forms.CheckBox();
            this.tb_title_LName = new System.Windows.Forms.TextBox();
            this.cb_title_LName = new System.Windows.Forms.CheckBox();
            this.tb_title_FName = new System.Windows.Forms.TextBox();
            this.cb_title_FName = new System.Windows.Forms.CheckBox();
            this.btn_title_selectTitle = new System.Windows.Forms.Button();
            this.dgv_title = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_authors_addNewAuthor = new System.Windows.Forms.Button();
            this.btn_authors_search = new System.Windows.Forms.Button();
            this.tb_authors_state = new System.Windows.Forms.TextBox();
            this.cb_authors_state = new System.Windows.Forms.CheckBox();
            this.tb_authors_city = new System.Windows.Forms.TextBox();
            this.cb_authors_city = new System.Windows.Forms.CheckBox();
            this.tb_authors_LName = new System.Windows.Forms.TextBox();
            this.cb_authors_LName = new System.Windows.Forms.CheckBox();
            this.tb_authors_FName = new System.Windows.Forms.TextBox();
            this.cb_authors_FName = new System.Windows.Forms.CheckBox();
            this.btn_authors_selectAuthor = new System.Windows.Forms.Button();
            this.dgv_authors = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tb_title_title = new System.Windows.Forms.TextBox();
            this.cb_title_title = new System.Windows.Forms.CheckBox();
            this.pubTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pub)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_title)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pubTabs
            // 
            this.pubTabs.Controls.Add(this.tabPage1);
            this.pubTabs.Controls.Add(this.tabPage2);
            this.pubTabs.Controls.Add(this.tabPage3);
            this.pubTabs.Controls.Add(this.tabPage4);
            this.pubTabs.Location = new System.Drawing.Point(16, 15);
            this.pubTabs.Margin = new System.Windows.Forms.Padding(4);
            this.pubTabs.Name = "pubTabs";
            this.pubTabs.SelectedIndex = 0;
            this.pubTabs.Size = new System.Drawing.Size(1028, 446);
            this.pubTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1020, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Publishers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_pub_country);
            this.splitContainer1.Panel1.Controls.Add(this.btn_pub_search);
            this.splitContainer1.Panel1.Controls.Add(this.cb_pub_country);
            this.splitContainer1.Panel1.Controls.Add(this.tb_pub_state);
            this.splitContainer1.Panel1.Controls.Add(this.cb_pub_state);
            this.splitContainer1.Panel1.Controls.Add(this.tb_pub_city);
            this.splitContainer1.Panel1.Controls.Add(this.cb_pub_city);
            this.splitContainer1.Panel1.Controls.Add(this.tb_pub_name);
            this.splitContainer1.Panel1.Controls.Add(this.cb_pub_pubName);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_pub_selectPub);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_pub);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 409);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tb_pub_country
            // 
            this.tb_pub_country.Location = new System.Drawing.Point(145, 132);
            this.tb_pub_country.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pub_country.Name = "tb_pub_country";
            this.tb_pub_country.Size = new System.Drawing.Size(185, 22);
            this.tb_pub_country.TabIndex = 9;
            // 
            // btn_pub_search
            // 
            this.btn_pub_search.Location = new System.Drawing.Point(4, 164);
            this.btn_pub_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pub_search.Name = "btn_pub_search";
            this.btn_pub_search.Size = new System.Drawing.Size(328, 33);
            this.btn_pub_search.TabIndex = 0;
            this.btn_pub_search.Text = "Search";
            this.btn_pub_search.UseVisualStyleBackColor = true;
            this.btn_pub_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_pub_country
            // 
            this.cb_pub_country.AutoSize = true;
            this.cb_pub_country.Location = new System.Drawing.Point(4, 134);
            this.cb_pub_country.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pub_country.Name = "cb_pub_country";
            this.cb_pub_country.Size = new System.Drawing.Size(79, 21);
            this.cb_pub_country.TabIndex = 8;
            this.cb_pub_country.Text = "Country";
            this.cb_pub_country.UseVisualStyleBackColor = true;
            // 
            // tb_pub_state
            // 
            this.tb_pub_state.Location = new System.Drawing.Point(145, 100);
            this.tb_pub_state.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pub_state.Name = "tb_pub_state";
            this.tb_pub_state.Size = new System.Drawing.Size(185, 22);
            this.tb_pub_state.TabIndex = 7;
            // 
            // cb_pub_state
            // 
            this.cb_pub_state.AutoSize = true;
            this.cb_pub_state.Location = new System.Drawing.Point(4, 102);
            this.cb_pub_state.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pub_state.Name = "cb_pub_state";
            this.cb_pub_state.Size = new System.Drawing.Size(63, 21);
            this.cb_pub_state.TabIndex = 6;
            this.cb_pub_state.Text = "State";
            this.cb_pub_state.UseVisualStyleBackColor = true;
            // 
            // tb_pub_city
            // 
            this.tb_pub_city.Location = new System.Drawing.Point(145, 68);
            this.tb_pub_city.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pub_city.Name = "tb_pub_city";
            this.tb_pub_city.Size = new System.Drawing.Size(185, 22);
            this.tb_pub_city.TabIndex = 5;
            // 
            // cb_pub_city
            // 
            this.cb_pub_city.AutoSize = true;
            this.cb_pub_city.Location = new System.Drawing.Point(4, 70);
            this.cb_pub_city.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pub_city.Name = "cb_pub_city";
            this.cb_pub_city.Size = new System.Drawing.Size(53, 21);
            this.cb_pub_city.TabIndex = 4;
            this.cb_pub_city.Text = "City";
            this.cb_pub_city.UseVisualStyleBackColor = true;
            this.cb_pub_city.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tb_pub_name
            // 
            this.tb_pub_name.Location = new System.Drawing.Point(145, 36);
            this.tb_pub_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pub_name.Name = "tb_pub_name";
            this.tb_pub_name.Size = new System.Drawing.Size(185, 22);
            this.tb_pub_name.TabIndex = 2;
            // 
            // cb_pub_pubName
            // 
            this.cb_pub_pubName.AutoSize = true;
            this.cb_pub_pubName.Location = new System.Drawing.Point(4, 38);
            this.cb_pub_pubName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pub_pubName.Name = "cb_pub_pubName";
            this.cb_pub_pubName.Size = new System.Drawing.Size(130, 21);
            this.cb_pub_pubName.TabIndex = 0;
            this.cb_pub_pubName.Text = "Publisher Name";
            this.cb_pub_pubName.UseVisualStyleBackColor = true;
            // 
            // btn_pub_selectPub
            // 
            this.btn_pub_selectPub.Location = new System.Drawing.Point(4, 369);
            this.btn_pub_selectPub.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pub_selectPub.Name = "btn_pub_selectPub";
            this.btn_pub_selectPub.Size = new System.Drawing.Size(660, 28);
            this.btn_pub_selectPub.TabIndex = 2;
            this.btn_pub_selectPub.Text = "Select Publisher";
            this.btn_pub_selectPub.UseVisualStyleBackColor = true;
            // 
            // dgv_pub
            // 
            this.dgv_pub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pub.Location = new System.Drawing.Point(4, 4);
            this.dgv_pub.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pub.Name = "dgv_pub";
            this.dgv_pub.Size = new System.Drawing.Size(660, 358);
            this.dgv_pub.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1020, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Titles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tb_title_title);
            this.splitContainer2.Panel1.Controls.Add(this.cb_title_title);
            this.splitContainer2.Panel1.Controls.Add(this.btn_title_addTitle);
            this.splitContainer2.Panel1.Controls.Add(this.btn_title_search);
            this.splitContainer2.Panel1.Controls.Add(this.tb_title_pubDate);
            this.splitContainer2.Panel1.Controls.Add(this.cb_title_pubDate);
            this.splitContainer2.Panel1.Controls.Add(this.tb_title_type);
            this.splitContainer2.Panel1.Controls.Add(this.cb_title_Type);
            this.splitContainer2.Panel1.Controls.Add(this.tb_title_LName);
            this.splitContainer2.Panel1.Controls.Add(this.cb_title_LName);
            this.splitContainer2.Panel1.Controls.Add(this.tb_title_FName);
            this.splitContainer2.Panel1.Controls.Add(this.cb_title_FName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_title_selectTitle);
            this.splitContainer2.Panel2.Controls.Add(this.dgv_title);
            this.splitContainer2.Size = new System.Drawing.Size(1012, 409);
            this.splitContainer2.SplitterDistance = 336;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_title_addTitle
            // 
            this.btn_title_addTitle.Location = new System.Drawing.Point(6, 368);
            this.btn_title_addTitle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_title_addTitle.Name = "btn_title_addTitle";
            this.btn_title_addTitle.Size = new System.Drawing.Size(328, 33);
            this.btn_title_addTitle.TabIndex = 28;
            this.btn_title_addTitle.Text = "Add New Title";
            this.btn_title_addTitle.UseVisualStyleBackColor = true;
            // 
            // btn_title_search
            // 
            this.btn_title_search.Location = new System.Drawing.Point(6, 190);
            this.btn_title_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_title_search.Name = "btn_title_search";
            this.btn_title_search.Size = new System.Drawing.Size(328, 33);
            this.btn_title_search.TabIndex = 27;
            this.btn_title_search.Text = "Search";
            this.btn_title_search.UseVisualStyleBackColor = true;
            this.btn_title_search.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_title_pubDate
            // 
            this.tb_title_pubDate.Location = new System.Drawing.Point(147, 159);
            this.tb_title_pubDate.Margin = new System.Windows.Forms.Padding(4);
            this.tb_title_pubDate.Name = "tb_title_pubDate";
            this.tb_title_pubDate.Size = new System.Drawing.Size(185, 22);
            this.tb_title_pubDate.TabIndex = 26;
            this.tb_title_pubDate.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // cb_title_pubDate
            // 
            this.cb_title_pubDate.AutoSize = true;
            this.cb_title_pubDate.Location = new System.Drawing.Point(6, 161);
            this.cb_title_pubDate.Margin = new System.Windows.Forms.Padding(4);
            this.cb_title_pubDate.Name = "cb_title_pubDate";
            this.cb_title_pubDate.Size = new System.Drawing.Size(126, 21);
            this.cb_title_pubDate.TabIndex = 25;
            this.cb_title_pubDate.Text = "Published Date";
            this.cb_title_pubDate.UseVisualStyleBackColor = true;
            this.cb_title_pubDate.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // tb_title_type
            // 
            this.tb_title_type.Location = new System.Drawing.Point(147, 127);
            this.tb_title_type.Margin = new System.Windows.Forms.Padding(4);
            this.tb_title_type.Name = "tb_title_type";
            this.tb_title_type.Size = new System.Drawing.Size(185, 22);
            this.tb_title_type.TabIndex = 24;
            this.tb_title_type.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // cb_title_Type
            // 
            this.cb_title_Type.AutoSize = true;
            this.cb_title_Type.Location = new System.Drawing.Point(6, 129);
            this.cb_title_Type.Margin = new System.Windows.Forms.Padding(4);
            this.cb_title_Type.Name = "cb_title_Type";
            this.cb_title_Type.Size = new System.Drawing.Size(62, 21);
            this.cb_title_Type.TabIndex = 23;
            this.cb_title_Type.Text = "Type";
            this.cb_title_Type.UseVisualStyleBackColor = true;
            this.cb_title_Type.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // tb_title_LName
            // 
            this.tb_title_LName.Location = new System.Drawing.Point(147, 95);
            this.tb_title_LName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_title_LName.Name = "tb_title_LName";
            this.tb_title_LName.Size = new System.Drawing.Size(185, 22);
            this.tb_title_LName.TabIndex = 22;
            this.tb_title_LName.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // cb_title_LName
            // 
            this.cb_title_LName.AutoSize = true;
            this.cb_title_LName.Location = new System.Drawing.Point(6, 97);
            this.cb_title_LName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_title_LName.Name = "cb_title_LName";
            this.cb_title_LName.Size = new System.Drawing.Size(144, 21);
            this.cb_title_LName.TabIndex = 21;
            this.cb_title_LName.Text = "Author Last Name";
            this.cb_title_LName.UseVisualStyleBackColor = true;
            this.cb_title_LName.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // tb_title_FName
            // 
            this.tb_title_FName.Location = new System.Drawing.Point(147, 63);
            this.tb_title_FName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_title_FName.Name = "tb_title_FName";
            this.tb_title_FName.Size = new System.Drawing.Size(185, 22);
            this.tb_title_FName.TabIndex = 20;
            this.tb_title_FName.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // cb_title_FName
            // 
            this.cb_title_FName.AutoSize = true;
            this.cb_title_FName.Location = new System.Drawing.Point(6, 65);
            this.cb_title_FName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_title_FName.Name = "cb_title_FName";
            this.cb_title_FName.Size = new System.Drawing.Size(144, 21);
            this.cb_title_FName.TabIndex = 19;
            this.cb_title_FName.Text = "Author First Name";
            this.cb_title_FName.UseVisualStyleBackColor = true;
            this.cb_title_FName.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // btn_title_selectTitle
            // 
            this.btn_title_selectTitle.Location = new System.Drawing.Point(4, 370);
            this.btn_title_selectTitle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_title_selectTitle.Name = "btn_title_selectTitle";
            this.btn_title_selectTitle.Size = new System.Drawing.Size(660, 28);
            this.btn_title_selectTitle.TabIndex = 4;
            this.btn_title_selectTitle.Text = "Select Title";
            this.btn_title_selectTitle.UseVisualStyleBackColor = true;
            // 
            // dgv_title
            // 
            this.dgv_title.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_title.Location = new System.Drawing.Point(4, 4);
            this.dgv_title.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_title.Name = "dgv_title";
            this.dgv_title.Size = new System.Drawing.Size(660, 358);
            this.dgv_title.TabIndex = 2;
            this.dgv_title.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1020, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Authors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 4);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_authors_addNewAuthor);
            this.splitContainer3.Panel1.Controls.Add(this.btn_authors_search);
            this.splitContainer3.Panel1.Controls.Add(this.tb_authors_state);
            this.splitContainer3.Panel1.Controls.Add(this.cb_authors_state);
            this.splitContainer3.Panel1.Controls.Add(this.tb_authors_city);
            this.splitContainer3.Panel1.Controls.Add(this.cb_authors_city);
            this.splitContainer3.Panel1.Controls.Add(this.tb_authors_LName);
            this.splitContainer3.Panel1.Controls.Add(this.cb_authors_LName);
            this.splitContainer3.Panel1.Controls.Add(this.tb_authors_FName);
            this.splitContainer3.Panel1.Controls.Add(this.cb_authors_FName);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_authors_selectAuthor);
            this.splitContainer3.Panel2.Controls.Add(this.dgv_authors);
            this.splitContainer3.Size = new System.Drawing.Size(1012, 409);
            this.splitContainer3.SplitterDistance = 336;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_authors_addNewAuthor
            // 
            this.btn_authors_addNewAuthor.Location = new System.Drawing.Point(6, 365);
            this.btn_authors_addNewAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_authors_addNewAuthor.Name = "btn_authors_addNewAuthor";
            this.btn_authors_addNewAuthor.Size = new System.Drawing.Size(328, 33);
            this.btn_authors_addNewAuthor.TabIndex = 19;
            this.btn_authors_addNewAuthor.Text = "Add New Author";
            this.btn_authors_addNewAuthor.UseVisualStyleBackColor = true;
            // 
            // btn_authors_search
            // 
            this.btn_authors_search.Location = new System.Drawing.Point(6, 159);
            this.btn_authors_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_authors_search.Name = "btn_authors_search";
            this.btn_authors_search.Size = new System.Drawing.Size(328, 33);
            this.btn_authors_search.TabIndex = 18;
            this.btn_authors_search.Text = "Search";
            this.btn_authors_search.UseVisualStyleBackColor = true;
            // 
            // tb_authors_state
            // 
            this.tb_authors_state.Location = new System.Drawing.Point(147, 128);
            this.tb_authors_state.Margin = new System.Windows.Forms.Padding(4);
            this.tb_authors_state.Name = "tb_authors_state";
            this.tb_authors_state.Size = new System.Drawing.Size(185, 22);
            this.tb_authors_state.TabIndex = 17;
            // 
            // cb_authors_state
            // 
            this.cb_authors_state.AutoSize = true;
            this.cb_authors_state.Location = new System.Drawing.Point(6, 130);
            this.cb_authors_state.Margin = new System.Windows.Forms.Padding(4);
            this.cb_authors_state.Name = "cb_authors_state";
            this.cb_authors_state.Size = new System.Drawing.Size(63, 21);
            this.cb_authors_state.TabIndex = 16;
            this.cb_authors_state.Text = "State";
            this.cb_authors_state.UseVisualStyleBackColor = true;
            // 
            // tb_authors_city
            // 
            this.tb_authors_city.Location = new System.Drawing.Point(147, 96);
            this.tb_authors_city.Margin = new System.Windows.Forms.Padding(4);
            this.tb_authors_city.Name = "tb_authors_city";
            this.tb_authors_city.Size = new System.Drawing.Size(185, 22);
            this.tb_authors_city.TabIndex = 15;
            // 
            // cb_authors_city
            // 
            this.cb_authors_city.AutoSize = true;
            this.cb_authors_city.Location = new System.Drawing.Point(6, 98);
            this.cb_authors_city.Margin = new System.Windows.Forms.Padding(4);
            this.cb_authors_city.Name = "cb_authors_city";
            this.cb_authors_city.Size = new System.Drawing.Size(53, 21);
            this.cb_authors_city.TabIndex = 14;
            this.cb_authors_city.Text = "City";
            this.cb_authors_city.UseVisualStyleBackColor = true;
            // 
            // tb_authors_LName
            // 
            this.tb_authors_LName.Location = new System.Drawing.Point(147, 64);
            this.tb_authors_LName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_authors_LName.Name = "tb_authors_LName";
            this.tb_authors_LName.Size = new System.Drawing.Size(185, 22);
            this.tb_authors_LName.TabIndex = 13;
            // 
            // cb_authors_LName
            // 
            this.cb_authors_LName.AutoSize = true;
            this.cb_authors_LName.Location = new System.Drawing.Point(6, 66);
            this.cb_authors_LName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_authors_LName.Name = "cb_authors_LName";
            this.cb_authors_LName.Size = new System.Drawing.Size(98, 21);
            this.cb_authors_LName.TabIndex = 12;
            this.cb_authors_LName.Text = "Last Name";
            this.cb_authors_LName.UseVisualStyleBackColor = true;
            // 
            // tb_authors_FName
            // 
            this.tb_authors_FName.Location = new System.Drawing.Point(147, 32);
            this.tb_authors_FName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_authors_FName.Name = "tb_authors_FName";
            this.tb_authors_FName.Size = new System.Drawing.Size(185, 22);
            this.tb_authors_FName.TabIndex = 11;
            // 
            // cb_authors_FName
            // 
            this.cb_authors_FName.AutoSize = true;
            this.cb_authors_FName.Location = new System.Drawing.Point(6, 34);
            this.cb_authors_FName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_authors_FName.Name = "cb_authors_FName";
            this.cb_authors_FName.Size = new System.Drawing.Size(98, 21);
            this.cb_authors_FName.TabIndex = 10;
            this.cb_authors_FName.Text = "First Name";
            this.cb_authors_FName.UseVisualStyleBackColor = true;
            this.cb_authors_FName.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // btn_authors_selectAuthor
            // 
            this.btn_authors_selectAuthor.Location = new System.Drawing.Point(4, 370);
            this.btn_authors_selectAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_authors_selectAuthor.Name = "btn_authors_selectAuthor";
            this.btn_authors_selectAuthor.Size = new System.Drawing.Size(660, 28);
            this.btn_authors_selectAuthor.TabIndex = 3;
            this.btn_authors_selectAuthor.Text = "Select Author";
            this.btn_authors_selectAuthor.UseVisualStyleBackColor = true;
            // 
            // dgv_authors
            // 
            this.dgv_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_authors.Location = new System.Drawing.Point(7, 4);
            this.dgv_authors.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_authors.Name = "dgv_authors";
            this.dgv_authors.Size = new System.Drawing.Size(660, 358);
            this.dgv_authors.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1020, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stores";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(4, 4);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Size = new System.Drawing.Size(1012, 409);
            this.splitContainer4.SplitterDistance = 336;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // tb_title_title
            // 
            this.tb_title_title.Location = new System.Drawing.Point(147, 33);
            this.tb_title_title.Margin = new System.Windows.Forms.Padding(4);
            this.tb_title_title.Name = "tb_title_title";
            this.tb_title_title.Size = new System.Drawing.Size(185, 22);
            this.tb_title_title.TabIndex = 30;
            // 
            // cb_title_title
            // 
            this.cb_title_title.AutoSize = true;
            this.cb_title_title.Location = new System.Drawing.Point(6, 35);
            this.cb_title_title.Margin = new System.Windows.Forms.Padding(4);
            this.cb_title_title.Name = "cb_title_title";
            this.cb_title_title.Size = new System.Drawing.Size(57, 21);
            this.cb_title_title.TabIndex = 29;
            this.cb_title_title.Text = "Title";
            this.cb_title_title.UseVisualStyleBackColor = true;
            // 
            // Start_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 475);
            this.Controls.Add(this.pubTabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start_Window";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Window_Load);
            this.pubTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pub)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_title)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pubTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dgv_pub;
        private System.Windows.Forms.Button btn_pub_search;
        private System.Windows.Forms.TextBox tb_pub_state;
        private System.Windows.Forms.CheckBox cb_pub_state;
        private System.Windows.Forms.TextBox tb_pub_city;
        private System.Windows.Forms.CheckBox cb_pub_city;
        private System.Windows.Forms.TextBox tb_pub_name;
        private System.Windows.Forms.CheckBox cb_pub_pubName;
        private System.Windows.Forms.TextBox tb_pub_country;
        private System.Windows.Forms.CheckBox cb_pub_country;
        private System.Windows.Forms.Button btn_pub_selectPub;
        private System.Windows.Forms.Button btn_title_search;
        private System.Windows.Forms.TextBox tb_title_pubDate;
        private System.Windows.Forms.CheckBox cb_title_pubDate;
        private System.Windows.Forms.TextBox tb_title_type;
        private System.Windows.Forms.CheckBox cb_title_Type;
        private System.Windows.Forms.TextBox tb_title_LName;
        private System.Windows.Forms.CheckBox cb_title_LName;
        private System.Windows.Forms.TextBox tb_title_FName;
        private System.Windows.Forms.CheckBox cb_title_FName;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_authors_search;
        private System.Windows.Forms.TextBox tb_authors_state;
        private System.Windows.Forms.CheckBox cb_authors_state;
        private System.Windows.Forms.TextBox tb_authors_city;
        private System.Windows.Forms.CheckBox cb_authors_city;
        private System.Windows.Forms.TextBox tb_authors_LName;
        private System.Windows.Forms.CheckBox cb_authors_LName;
        private System.Windows.Forms.TextBox tb_authors_FName;
        private System.Windows.Forms.CheckBox cb_authors_FName;
        private System.Windows.Forms.Button btn_authors_selectAuthor;
        private System.Windows.Forms.DataGridView dgv_authors;
        private System.Windows.Forms.Button btn_title_selectTitle;
        private System.Windows.Forms.DataGridView dgv_title;
        private System.Windows.Forms.Button btn_authors_addNewAuthor;
        private System.Windows.Forms.Button btn_title_addTitle;
        private System.Windows.Forms.TextBox tb_title_title;
        private System.Windows.Forms.CheckBox cb_title_title;
    }
}

