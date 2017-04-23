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

namespace Pubs_DB_App.Stores_Sales
{
    public partial class Insert_Window_Sale : Form
    {
        public Insert_Window_Sale()
        {
            InitializeComponent();
            string c1 = "select pubID from PUBLISHER";
            string c2 = "select titleID from title";
            string c3 = "select storeID from store";
            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand pubid = new SqlCommand(c1, connection);
                    SqlCommand titleid = new SqlCommand(c2, connection);
                    SqlCommand storeid = new SqlCommand(c3, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(pubid);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(titleid);
                    SqlDataAdapter adapter3 = new SqlDataAdapter(storeid);
                    //Fills comboboxes
                    DataTable dataTable = new DataTable();
                    DataTable dataTable2 = new DataTable();
                    DataTable dataTable3 = new DataTable();
                    adapter.Fill(dataTable);
                    adapter2.Fill(dataTable2);
                    adapter3.Fill(dataTable3);
                    pubidcombo.Items.Add("");
                    titleidcombo.Items.Add("");
                    storeidcombo.Items.Add("");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        pubidcombo.Items.Add(row[0]);
                    }
                    foreach (DataRow row in dataTable2.Rows)
                    {
                        titleidcombo.Items.Add(row[0]);
                    }
                    foreach (DataRow row in dataTable3.Rows)
                    {
                        storeidcombo.Items.Add(row[0]);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] order = new char[8];
            Random random = new Random();

            for (int i = 0; i < order.Length; i++)
            {
                order[i] = chars[random.Next(chars.Length)];
            }

            string finalorderno = new String(order);
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                using (SqlCommand insertSale = new SqlCommand())
                {
                    insertSale.Connection = connection;
                    insertSale.CommandType = CommandType.Text;
                    insertSale.CommandText = "INSERT INTO SALE(orderno, titleid, storeid, orderdate, quantity, payterms) VALUES(@orderno, @titleid, @storeID, @orderdate, @quantity, @payterms)";
                    insertSale.Parameters.AddWithValue("@storeID", storeidcombo.Text);
                    insertSale.Parameters.AddWithValue("@orderno", finalorderno);
                    insertSale.Parameters.AddWithValue("@pubid", pubidcombo.Text);
                    insertSale.Parameters.AddWithValue("@titleid", titleidcombo.Text);
                    insertSale.Parameters.AddWithValue("@quantity", tb_qty.Text);
                    insertSale.Parameters.AddWithValue("@orderdate", tb_salesDateY.Text + combo_salesDateM.Text + combo_salesDateD.Text);
                    insertSale.Parameters.AddWithValue("@payterms", tb_payTerms.Text);
                    try
                    {
                        connection.Open();
                        int recordsAffected = insertSale.ExecuteNonQuery();
                        this.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Window_Sale_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
