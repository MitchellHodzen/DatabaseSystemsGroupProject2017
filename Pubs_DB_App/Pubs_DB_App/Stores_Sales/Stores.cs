using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pubs_DB_App.Publishers;
using System.Data.SqlClient;
using Pubs_DB_App.Stores_Sales;

namespace Pubs_DB_App.Publishers
{
    public partial class Stores : Form
    {
        string storeid;
        public Stores(string storeID, string storeName, string address, string city, string state, string zip)
        {
            InitializeComponent();
            tb_storeID.Text = storeID;
            this.storeid = storeID;
            tb_storeName.Text = storeName;
            tb_address.Text = address;
            tb_city.Text = city;
            tb_state.Text = state;
            tb_zip.Text = zip;
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                using (SqlCommand showSales = new SqlCommand())
                {
                    showSales.Connection = connection;
                    showSales.CommandType = CommandType.Text;
                    showSales.CommandText = "SELECT * FROM SALE WHERE storeID = " + storeID;
                    SqlDataAdapter adapater = new SqlDataAdapter(showSales);
                    try
                    {
                        connection.Open();
                        int recordsAffected = showSales.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        adapater.Fill(table);
                        dvg_results.DataSource = table;
                        dvg_results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_addStore_Click(object sender, EventArgs e)
        {
            Insert_Window_Store addStoreWindow = new Insert_Window_Store();
            addStoreWindow.Show();
        }
        
        private void btn_view_sale_Click(object sender, EventArgs e)
        {

            Sales sale = new Sales((string)dvg_results.CurrentRow.Cells[0].Value,
                (string)dvg_results.CurrentRow.Cells[1].Value, 
                (string)dvg_results.CurrentRow.Cells[2].Value, 
                (DateTime)dvg_results.CurrentRow.Cells[3].Value, 
                (short)dvg_results.CurrentRow.Cells[4].Value, 
                (string)dvg_results.CurrentRow.Cells[5].Value);
            sale.Show();
        }

        private void btn_remove_store_Click(object sender, EventArgs e)
        {

        }

        private void btn_make_sale_Click(object sender, EventArgs e)
        {
            Insert_Window_Sale storeSale = new Insert_Window_Sale(storeid);
            storeSale.Show();
        }
    }

}
