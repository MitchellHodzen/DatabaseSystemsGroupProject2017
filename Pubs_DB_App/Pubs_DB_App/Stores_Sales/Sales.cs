using Pubs_DB_App.Stores_Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pubs_DB_App
{
    public partial class Sales : Form
    {
        string titleID, pubid;
        public Sales(string orderNO, 
            string titleID, 
            string storeID, 
            DateTime orderDate, 
            short quantity, 
            string payterms)
        {
            this.titleID = titleID;
            InitializeComponent();
            tb_orderNum.Text = orderNO;
            tb_title.Text = titleID;
            tb_store.Text = storeID;
            tb_orderDate.Text = orderDate.ToString("yyyy-mm-dd");
            tb_quantity.Text = quantity.ToString();
            tb_discount.Text = payterms;
            tb_pubid.Text = getPubID();
        }
        public Sales(string pubID)
        {
            InitializeComponent();
            tb_pubid.Text = pubID;
        }
        private string getPubID()
        {
            
            SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString);
            SqlCommand cmd = new SqlCommand("select pubid from title where titleid ='" + tb_title.Text + "'" + " ", connection);
            
            try
            {
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.pubid = (string)rdr[0];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return pubid;
        }
        private void btn_view_title_info_Click(object sender, EventArgs e)
        {
            Title_Info_Window titleWindow = new Title_Info_Window(titleID);
            this.Close();
            titleWindow.Show();
        }

        private void btn_create_sale_Click(object sender, EventArgs e)
        {
            Insert_Window_Sale newSale = new Insert_Window_Sale();
            this.Close();
            newSale.Show();
        }
        private void btn_clear_text_Click(object sender, EventArgs e)
        {
            tb_orderNum.Text = string.Empty;
            tb_title.Text = string.Empty;
            tb_store.Text = string.Empty;
            tb_orderDate.Text = string.Empty;
            tb_quantity.Text = string.Empty;
            tb_discount.Text = string.Empty;
            tb_pubid.Text = string.Empty;
        }
        private void btn_search_Click(Object sender, EventArgs e)
        {
            string cmd = "select orderNO, sale.titleID, storeID, title.pubID, orderDate, quantity, payterms from sale join title on sale.titleID = title.TitleID where pubid ='" + tb_pubid.Text + "'" + " ";
            string check = "";
            if(!string.IsNullOrWhiteSpace(tb_orderNum.Text))
            {
                check = check + "and orderNO = " + "'" + tb_orderNum.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_title.Text))
            {
                check = check + "and sale.titleid = " + "'" + tb_title.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_store.Text))
            {
                check = check + "and storeid = " + "'" + tb_store.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_orderDate.Text))
            {
                check = check + "and orderdate = " + "'" + tb_orderDate.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_quantity.Text))
            {
                check = check + "and quantity = " + "'" + tb_quantity.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_discount.Text))
            {
                check = check + "and payterms = " + "'" + tb_discount.Text + "'" + " ";
            }
            cmd = cmd + check;
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand viewJobsCommand = new SqlCommand(cmd, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(viewJobsCommand);

                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_sales.DataSource = dataTable;
                    dgv_sales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
    }
}
