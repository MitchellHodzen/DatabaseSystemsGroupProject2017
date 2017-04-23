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

namespace Pubs_DB_App.Authors
{
    public partial class Insert_Authors_Window : Form
    {
        public Insert_Authors_Window()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_fName.Text) && !string.IsNullOrWhiteSpace(tb_lName.Text)
             && !string.IsNullOrWhiteSpace(tb_authorID.Text) && !string.IsNullOrWhiteSpace(tb_phoneNum.Text))
            {
                string command = "INSERT INTO AUTHOR " +
                    "VALUES (" + "'" + tb_authorID.Text + "', '" + tb_fName.Text + "', '" + tb_lName.Text + "', '" + tb_phoneNum.Text + "'";
                string checks = "";
                //Construct the where statement based on user input
                if (!string.IsNullOrWhiteSpace(tb_address.Text))
                {
                    checks = checks + ", '" + tb_address.Text + "'";
                }
                else
                {
                    checks = checks + ", null ";
                }
                if (!string.IsNullOrWhiteSpace(tb_city.Text))
                {
                    checks = checks + ", '" + tb_city.Text + "'";
                }
                else
                {
                    checks = checks + ", null ";
                }
                
                if (!string.IsNullOrWhiteSpace(tb_state.Text))
                {

                    checks = checks + ", '" + tb_state.Text + "'";

                }
                else
                {
                    checks = checks + ", null ";
                }
                if (!string.IsNullOrWhiteSpace(tb_zip.Text))
                {
                    checks = checks + ", '" + tb_zip.Text + "'";

                }
                else
                {
                    checks = checks + ", null ";
                }
                if (contract.Checked)
                {
                    checks = checks + ", 1";

                }
                else
                {
                    checks = checks + ", 0 ";
                }
               

                command = command + checks + ")";
                //Connets to the database using the connection string from the connection page
                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //Open the database
                        connection.Open();
                        //Creates SQL command using the command string generated earlier
                        SqlCommand insertAuthorCommand = new SqlCommand(command, connection);
                        //Executes command
                        insertAuthorCommand.ExecuteNonQuery();
                        //Display success message
                        MessageBox.Show("Author was submitted to the database successfully.", "Author Created",
                        MessageBoxButtons.OK);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }
            }
        }
    }
}
