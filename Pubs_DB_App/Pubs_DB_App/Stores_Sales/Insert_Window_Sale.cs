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
                    SqlCommand titleid = new SqlCommand(c2, connection);
                    SqlCommand storeid = new SqlCommand(c3, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter2 = new SqlDataAdapter(titleid);
                    SqlDataAdapter adapter3 = new SqlDataAdapter(storeid);
                    //Fills comboboxes
                    DataTable dataTable = new DataTable();
                    DataTable dataTable2 = new DataTable();
                    DataTable dataTable3 = new DataTable();
                    adapter2.Fill(dataTable2);
                    adapter3.Fill(dataTable3);
                    titleidcombo.Items.Add("");
                    storeidcombo.Items.Add("");
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

            if (!string.IsNullOrWhiteSpace(titleidcombo.Text) && !string.IsNullOrWhiteSpace(storeidcombo.Text) && 
                !string.IsNullOrWhiteSpace(tb_qty.Text) && !string.IsNullOrWhiteSpace(tb_payTerms.Text) && 
                !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string command = "insert into sale " +
                    "VALUES (" + "'" + finalorderno + "', '" + titleidcombo.Text + "', '" + storeidcombo.Text + "', '" + textBox1.Text + "', '" + tb_qty.Text + "', '" + tb_payTerms.Text + "')";
                //Connets to the database using the connection string from the connection page
                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //Open the database
                        connection.Open();
                        //Creates SQL command using the command string generated earlier
                        SqlCommand insertSale = new SqlCommand(command, connection);
                        //Executes command
                        insertSale.ExecuteNonQuery();
                        //Display success message
                        MessageBox.Show("Sale was added to database!", "Sale Created",
                        MessageBoxButtons.OK);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
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
