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
using Pubs_DB_App.Stores_Sales;
using System.Data.SqlClient;

namespace Pubs_DB_App
{
    public partial class Insert_Window_Store : Form
    {
        public Insert_Window_Store()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                using (SqlCommand insertStore = new SqlCommand())
                {
                    insertStore.Connection = connection;
                    insertStore.CommandType = CommandType.Text;
                    insertStore.CommandText = "INSERT INTO STORE(storeID, storeName, address, city, state, zip) VALUES(@storeID, @storeName, @address, @city, @state, @zip)";
                    insertStore.Parameters.AddWithValue("@storeID", tb_storeID.Text);
                    insertStore.Parameters.AddWithValue("@storeName", tb_storeName.Text);
                    insertStore.Parameters.AddWithValue("@address", tb_address.Text);
                    insertStore.Parameters.AddWithValue("@city", tb_city.Text);
                    insertStore.Parameters.AddWithValue("@state", tb_state.Text);
                    insertStore.Parameters.AddWithValue("@zip", tb_zip.Text);
                    try
                    {
                        connection.Open();
                        int recordsAffected = insertStore.ExecuteNonQuery();
                        //Success success = new Success();
                        this.Close();
                        //success.Show();

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
    }
}
