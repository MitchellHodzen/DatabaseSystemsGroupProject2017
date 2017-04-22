using Pubs_DB_App.Authors;
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
    public partial class Title_Info_Window : Form
    {

        public String titleID;
        public Title_Info_Window(String titleID)
        {
            InitializeComponent();
            this.titleID = titleID;
            label2.Text = titleID;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tb_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string command = "select title.titleID, pubID, title, type, price, advance, royalty, notes, " +
                 "pubdate from title join titleauthor on title.titleID = titleauthor.titleID " +
                 "join author On titleauthor.authorID = author.authorID " +
                 "Where title.titleID = " + "'" + titleID + "'";

            string command2 = "select author.authorID, authorfname, authorlname from author " +
                "Join TITLEAUTHOR on author.authorID = TITLEAUTHOR.authorID " +
                "Join title on TITLEAUTHOR.titleID = title.titleID " +
                "Where title.titleID = " + "'" + titleID + "'";

            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand titleInfoCommand = new SqlCommand(command, connection);
                    SqlCommand titleInfoCommand2 = new SqlCommand(command2, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(titleInfoCommand);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(titleInfoCommand2);

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

        private void Title_Info_Window_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authors_Window authorWindow = new Authors_Window((string)dgv2.CurrentRow.Cells[0].Value);
            authorWindow.Show();
        }

        private void tb_addtitle_Click(object sender, EventArgs e)
        {
            Insert_Window_Title insertTitle = new Insert_Window_Title();
            insertTitle.Show();
        }
    }
}
