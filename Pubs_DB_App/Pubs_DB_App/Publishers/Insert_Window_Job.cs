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
    
    public partial class Insert_Window_Job : Form
    {
        public Insert_Window_Job(string pub_id)
        {
            InitializeComponent();
            tb_pubID.Text = pub_id;
            tb_pubID.ReadOnly = true;
        }

        private void Insert_Window_Job_Load(object sender, EventArgs e)
        {

        }

        private void tb_submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_pubID.Text) && !string.IsNullOrWhiteSpace(tb_description.Text)
                && !string.IsNullOrWhiteSpace(tb_maxLvl.Text) && !string.IsNullOrWhiteSpace(tb_minLvl.Text))
            {
                string command = "INSERT INTO JOB (pubID, jobDesc, min_lvl, max_lvl) VALUES ('" 
                    + tb_pubID.Text + "', '" + tb_description.Text + "', " + tb_minLvl.Text
                    + " , " + tb_maxLvl.Text + ")";

                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //Open the database
                        connection.Open();
                        //Creates SQL command using the command string generated earlier
                        SqlCommand insertJobCommand = new SqlCommand(command, connection);
                        //Executes command
                        insertJobCommand.ExecuteNonQuery();
                        //Display success message
                        MessageBox.Show("Job was submitted to the database successfully.", "Job Created",
                        MessageBoxButtons.OK);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("You must input text for all required fields.", "MISSING FEILDS ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
