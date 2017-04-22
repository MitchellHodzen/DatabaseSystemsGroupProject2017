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
    public partial class Authors_Window : Form
    {
        public string authorID;
        public Authors_Window(string authorID)
        {
            InitializeComponent();
            this.authorID = authorID;
            label2.Text = authorID;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "select * from Author " +
                "Where AuthorID = " + "'" + authorID + "'";

            string command2 = "Select title.titleid, title from title join TITLEAUTHOR on title.titleID = TITLEAUTHOR.titleID join author on TITLEAUTHOR.authorID = author.authorID Where author.authorID = " + "'" + authorID + "'";

            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand authorInfoCommand = new SqlCommand(command, connection);
                    SqlCommand authorInfoCommand2 = new SqlCommand(command2, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(authorInfoCommand);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(authorInfoCommand2);

                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    DataTable dataTable2 = new DataTable();
                    adapter.Fill(dataTable);
                    adapter2.Fill(dataTable2);
                    dgv.DataSource = dataTable;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv2.DataSource = dataTable2;
                    dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Title_Info_Window titleWindow = new Title_Info_Window((string)dgv2.CurrentRow.Cells[0].Value);
            titleWindow.Show();
        }
    }
}

