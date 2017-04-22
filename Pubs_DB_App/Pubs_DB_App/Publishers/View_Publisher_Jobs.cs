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

namespace Pubs_DB_App.Publishers
{
    public partial class View_Publisher_Jobs : Form
    {
        public string pubID;
        public View_Publisher_Jobs(string pubID)
        {
            InitializeComponent();
            this.pubID = pubID;
        }

        private void View_Publisher_Jobs_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the publishers 
            String command = "SELECT * FROM JOB WHERE pubID = '" + pubID + "'" + " ";
            String checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_jobID.Text))
            {
                checks = checks + "AND jobID = " + "'" + tb_jobID.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_minLvl.Text))
            {
                checks = checks + "AND min_lvl = " + "'" + tb_minLvl.Text + "'" + " ";
            }
            if (!string.IsNullOrWhiteSpace(tb_maxLvl.Text))
            {
                checks = checks + "AND max_lvl = " + "'" + tb_maxLvl.Text + "'" + " ";
            }

            //Combine the statements together
            command = command + checks;

            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand viewJobsCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(viewJobsCommand);

                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
