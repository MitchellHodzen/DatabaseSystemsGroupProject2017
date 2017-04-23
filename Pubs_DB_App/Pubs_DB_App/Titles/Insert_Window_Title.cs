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

namespace Pubs_DB_App
{
    public partial class Insert_Window_Title : Form
    {
        public Insert_Window_Title(string pubID)
        {
            InitializeComponent();
            //Populates pubID and authorID combobox
            String command = "Select pubID FROM Publisher";
            String command2 = "Select authorID from Author";
            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand getpubIDCommand = new SqlCommand(command, connection);
                    SqlCommand getauthorIDCommand = new SqlCommand(command2, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(getpubIDCommand);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(getauthorIDCommand);
                    //Fills comboboxes
                    DataTable dataTable = new DataTable();
                    DataTable dataTable2 = new DataTable();
                    adapter.Fill(dataTable);
                    adapter2.Fill(dataTable2);
                    combo.Items.Add("");
                    combo2.Items.Add("");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        combo.Items.Add(row[0]);
                    }
                    foreach(DataRow row in dataTable2.Rows)
                    {
                        combo2.Items.Add(row[0]);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            if (!string.IsNullOrWhiteSpace(pubID))
            {
                combo.SelectedIndex = combo.FindStringExact(pubID);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(combo.Text) && !string.IsNullOrWhiteSpace(tb_titleID.Text)
               && !string.IsNullOrWhiteSpace(tb_title.Text))
            {
                string command = "INSERT INTO TITLE " +
                    "VALUES (" + "'" + tb_titleID.Text + "', '" + combo.Text + "', '" + tb_title.Text + "'";
                string checks = "";
                //Construct the where statement based on user input
                if (!string.IsNullOrWhiteSpace(tb_type.Text))
                {
                    checks = checks + ", '" + tb_type.Text + "'";
                }
                else
                {
                    checks = checks + ", null ";
                }
                checks = checks + ", null ";
                if (!string.IsNullOrWhiteSpace(tb_price.Text))
                {
                    checks = checks + ", '" + tb_price.Text + "'";
                }
                else
                {
                    checks = checks + ", null ";
                }
                
                if (!string.IsNullOrWhiteSpace(tb_advance.Text))
                {

                    checks = checks + ", '" + tb_advance.Text + "'";

                }
                else
                {
                    checks = checks + ", null ";
                }
                if (!string.IsNullOrWhiteSpace(tb_royalty.Text))
                {
                    checks = checks + ", '" + tb_royalty.Text + "'";

                }else
                {
                    checks = checks + ", null ";
                }
                if (!string.IsNullOrWhiteSpace(tb_pubDate.Text))
                {
                    checks = checks + ", '" + tb_pubDate.Text + "'";

                }else
                {
                    checks = checks + ", null ";
                }
                if (!string.IsNullOrWhiteSpace(tb_notes.Text))
                {
                    checks = checks + ", '" + tb_notes.Text + "'";

                }else
                {
                    checks = checks + ", null ";
                }

                command = command + checks + ")";

                String command2 = "Insert Into TITLEAUTHOR (titleID, authorID)" +
                    "VALUES('" + tb_titleID.Text + "' , '" + combo2.Text + "')";
                //Connets to the database using the connection string from the connection page
                using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
                {
                    try
                    {
                        //Open the database
                        connection.Open();
                        //Creates SQL command using the command string generated earlier
                        SqlCommand insertTitleCommand = new SqlCommand(command, connection);
                        SqlCommand insertTitleAuthor = new SqlCommand(command2, connection);
                        //Executes command
                        insertTitleCommand.ExecuteNonQuery();
                        insertTitleAuthor.ExecuteNonQuery();
                        //Display success message
                        MessageBox.Show("Title was submitted to the Database!", "Title Created",
                        MessageBoxButtons.OK);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }
            }


        }
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Window_Title_Load(object sender, EventArgs e)
        {

        }
    }
}
