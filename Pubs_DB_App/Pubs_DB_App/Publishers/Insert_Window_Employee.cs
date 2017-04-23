using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pubs_DB_App.Publishers
{
    public partial class Insert_Window_Employee : Form
    {
        bool person_verified;
        int min_job_val, max_job_val;
        public Insert_Window_Employee(string pub_id)
        {
            InitializeComponent();
            tb_pubID.Text = pub_id;
            tb_pubID.ReadOnly = true;
            person_verified = false;
            min_job_val = 0; max_job_val = 0;
            
            //Populates job combobox
            String command = "SELECT jobID FROM JOB WHERE pubID = '" + pub_id + "' ";
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
                    combo_job.Items.Add("");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        combo_job.Items.Add(row[0]);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void Insert_Window_Employee_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (verifySubmission())
            {
                string command = "INSERT INTO EMPLOYMENT (SSN, jobID, job_lvl, positionStartDate, empID, pubID) VALUES (" +
                    tb_SSN.Text + ", " + combo_job.Text + ", " + tb_joblvl.Text + ", '" + tb_hireDateY.Text + "-"
                    + combo_hireDateM.Text + "-" + combo_hireDateD.Text + "', 1234, '" + tb_pubID.Text + "')";

                MessageBox.Show(command);

                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //Open the database
                        connection.Open();
                        //Creates SQL command using the command string generated earlier
                        SqlCommand insertEmploymentCommand = new SqlCommand(command, connection);
                        //Executes command
                        insertEmploymentCommand.ExecuteNonQuery();
                        //Display success message
                        MessageBox.Show("Employment was successfully created.", "Employee Hired",
                        MessageBoxButtons.OK);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }

            }
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_SSN.Text) || tb_SSN.Text.Length != 9)
            {
                MessageBox.Show("Input 9 Digit SSN", "Invalid SSN",
                    MessageBoxButtons.OK);
            }
            else
            {
                //construct query to search for SSN
                string command = "SELECT * FROM PERSON WHERE SSN = " + tb_SSN.Text;
                //
                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //open the db
                        connection.Open();
                        //create SQL command
                        using (SqlCommand searchSSNCommand = new SqlCommand(command, connection))
                        {
                            using (SqlDataReader reader = searchSSNCommand.ExecuteReader())
                            {
                                //if ssn returned a value
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    //set name boxes
                                    tb_fName.Text = (string)reader["personFName"];
                                    tb_fName.ReadOnly = true;
                                    tb_lName.Text = (string)reader["personLName"];
                                    tb_lName.ReadOnly = true;

                                    if(reader["personMInit"].GetType() == typeof(DBNull))
                                    {
                                        tb_middle.Text = "";
                                    }
                                    else
                                    {
                                        tb_middle.Text = (string)reader["personMInit"];
                                    }
                                    tb_middle.ReadOnly = true;

                                    tb_SSN.ReadOnly = true;
                                    btn_employee.Enabled = false;
                                    person_verified = true;
                                }
                                else
                                {
                                    DialogResult dialogResult = MessageBox.Show("No user with that SSN Found. Insert a new user?", "SSN Not Found", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        //ensure correct fields were used
                                        if (!string.IsNullOrWhiteSpace(tb_fName.Text) && !string.IsNullOrWhiteSpace(tb_lName.Text))
                                        {
                                            //insert person into DB
                                            if (insertPerson())
                                            {
                                                tb_fName.ReadOnly = true;
                                                tb_lName.ReadOnly = true;
                                                tb_middle.ReadOnly = true;
                                                tb_SSN.ReadOnly = true;
                                                btn_employee.Enabled = false;

                                                person_verified = true;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Specify values for all fields with an *.", "Missing Required Fields.",
                                                MessageBoxButtons.OK);
                                        }
                                    }
                                    else if (dialogResult == DialogResult.No)
                                    {
                                        
                                    }
                                }
                            }
                        }
                        
                    }
                    finally
                    {
                        if(connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private bool insertPerson()
        {
            bool success = false;

            //construct command string
            string command;
            if (!string.IsNullOrWhiteSpace(tb_middle.Text))
            {
                command = "INSERT INTO PERSON (SSN, personFName, personLName, personMInit) VALUES ("
                + tb_SSN.Text + ", '" + tb_fName.Text + "', '" + tb_lName.Text + "', '" + tb_middle.Text + "')";
            }
            else
            {
                command = "INSERT INTO PERSON (SSN, personFName, personLName) VALUES ("
                + tb_SSN.Text + ", '" + tb_fName.Text + "', '" + tb_lName.Text + "')";
            }

            //insert command into DB
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand insertPersonCommand = new SqlCommand(command, connection);
                    //Executes command
                    insertPersonCommand.ExecuteNonQuery();
                    //Display success message
                    MessageBox.Show("Person added to the database successfully.", "Person Created",
                    MessageBoxButtons.OK);

                    success = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

            return success;
        }

        private void tb_joblvl_TextChanged(object sender, EventArgs e)
        {
            //prevent non-number entry
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_joblvl.Text, "[^0-9]"))
            {
                MessageBox.Show("Only Numerals Allowed.");
                tb_joblvl.Text = tb_joblvl.Text.Remove(tb_joblvl.Text.Length - 1);
            }
        }

        private void combo_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(combo_job.Text))
            {
                string command = "SELECT min_lvl, max_lvl FROM JOB WHERE jobID = " + combo_job.Text;
                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //open the db
                        connection.Open();
                        //create SQL command
                        using (SqlCommand checklvlsCommand = new SqlCommand(command, connection))
                        {
                            using (SqlDataReader reader = checklvlsCommand.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    //set name boxes
                                    min_job_val = Convert.ToInt32(reader["min_lvl"]);
                                    max_job_val = Convert.ToInt32(reader["max_lvl"]);
                                }
                            }
                        }

                    }
                    finally
                    {
                        if (connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private bool verifySubmission()
        {
            if (!person_verified)
            {
                MessageBox.Show("Please verify employee details first", "Error",
                    MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(combo_job.Text) || string.IsNullOrWhiteSpace(tb_joblvl.Text)
                || string.IsNullOrWhiteSpace(combo_hireDateD.Text) || string.IsNullOrWhiteSpace(combo_hireDateM.Text)
                || string.IsNullOrWhiteSpace(tb_hireDateY.Text))
            {
                MessageBox.Show("Specify values for all required fields.", "Error",
                    MessageBoxButtons.OK);
                return false;
            }
            if (Int32.Parse(tb_joblvl.Text) > max_job_val || Int32.Parse(tb_joblvl.Text) < min_job_val)
            {
                MessageBox.Show("Job Level out of range for that job. Min lvl = " + min_job_val + ". Max lvl = " + max_job_val, "Error",
                    MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
