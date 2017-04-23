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
    public partial class View_Publisher_Employees : Form
    {

        public string pubID;
        public View_Publisher_Employees(string pubID)
        {
            InitializeComponent();
            this.pubID = pubID;
            //Populates job combobox
            String command = "SELECT jobID FROM JOB WHERE pubID = '" + pubID + "' ";
            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand getJobsCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(getJobsCommand);

                    //Fills combobox
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    JobList.Items.Add("");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        JobList.Items.Add(row[0]);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void JobList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Publisher_Employees_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the publishers 
            String command = "SELECT JOB.pubID, JOB.jobID, personFName, personMInit, personLName, PERSON.SSN, job_lvl, positionStartDate, JOB.jobDesc " + 
                             " FROM PERSON" +
                             " JOIN EMPLOYMENT ON PERSON.SSN = EMPLOYMENT.SSN" + 
                             " JOIN JOB ON EMPLOYMENT.jobID = JOB.jobID AND EMPLOYMENT.pubID = JOB.pubID" +
                             " WHERE JOB.pubID = '" + pubID + "'" + " ";
            String checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_fName.Text))
            {
                checks = checks + "AND personFName = " + "'" + tb_fName.Text + "' ";
            }
            if (!string.IsNullOrWhiteSpace(tb_middle.Text))
            {
                checks = checks + "AND personMInit = " + "'" + tb_middle.Text + "' ";
            }
            if (!string.IsNullOrWhiteSpace(tb_LName.Text))
            {
                checks = checks + "AND personLName = " + "'" + tb_LName.Text + "' ";
            }
            if (!string.IsNullOrWhiteSpace(tb_SSN.Text))
            {
                checks = checks + "AND SSN = " + "'" + tb_SSN.Text + "' ";
            }
            if (!string.IsNullOrWhiteSpace(JobList.Text))
            {
                
                checks = checks + "AND JOB.jobID = " + "'" + JobList.Text + "' ";
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
                    SqlCommand viewEmployeesCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(viewEmployeesCommand);

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
    }
}
