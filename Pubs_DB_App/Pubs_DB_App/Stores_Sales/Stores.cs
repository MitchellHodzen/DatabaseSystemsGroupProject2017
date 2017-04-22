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

namespace Pubs_DB_App.Publishers
{
    public partial class Stores : Form
    {
        public string storeID;
        public Stores(string storeID)
        {
            InitializeComponent();
            this.storeID = storeID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_sales_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the publishers 
            String command = "SELECT * FROM SALES";
            bool addWhere = false;
            String checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_storeName.Text))
            {
                checks = checks + "storeName = " + "'" + tb_storeName.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_storeID.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "storeID = " + "'" + tb_storeID.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_address.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "address = " + "'" + tb_address.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_city.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "city = " + "'" + tb_city.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_state.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "state = " + "'" + tb_state.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_zip.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "zip = " + "'" + tb_zip.Text + "'" + " ";
                addWhere = true;
            }
            //Combine the statements together
            if (addWhere == true)
            {
                command = command + " WHERE " + checks;
            }

            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand selectStoresCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(selectStoresCommand);

                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dvg_results.DataSource = dataTable;
                    dvg_results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
        private void btn_addStore_Click(object sender, EventArgs e)
        {
            Insert_Window_Store addStoreWindow = new Insert_Window_Store();
            addStoreWindow.Show();
        }
    }

}
