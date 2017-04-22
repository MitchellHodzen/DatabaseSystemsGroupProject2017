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
using Pubs_DB_App.Authors;

namespace Pubs_DB_App
{
    public partial class Start_Window : Form
    {
        public Start_Window()
        {
            InitializeComponent();
            this.Shown += Start_Window_Shown;
        }

        private void Start_Window_Shown(Object sender, EventArgs e)
        {
            //Displays connection window when the program is first started
            new ConnectionWindow().Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the publishers 
            string command = "SELECT pubID, pubName, city, state, country FROM PUBLISHER";
            bool addWhere = false;
            string checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_pub_pubName.Text))
            {
                checks = checks + "pubName = " + "'" + tb_pub_pubName.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_pub_city.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "city = " + "'" + tb_pub_city.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_pub_state.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "state = " + "'" + tb_pub_state.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_pub_country.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "country = " + "'" + tb_pub_country.Text + "'" + " ";
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
                    SqlCommand selectPublishersCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(selectPublishersCommand);
                    
                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_pub.DataSource = dataTable;
                    dgv_pub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void Start_Window_Load(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the titles
            string command = "select title.titleID, title, type, pubDate, authorFName, authorLName from title " +
                "join titleauthor on title.titleID = titleauthor.titleID " +
                "join author On titleauthor.authorID = author.authorID";

            bool addWhere = false;
            string checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_title_fName.Text))
            {
                checks = checks + "authorFName = " + "'" + tb_title_fName.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_title_lName.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "authorLName = " + "'" + tb_title_lName.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_title_type.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "type = " + "'" + tb_title_type.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_title_pubDate.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "pubDate = " + "'" + tb_title_pubDate.Text + "'" + " ";
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
                    SqlCommand selectTitlesCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(selectTitlesCommand);

                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_title.DataSource = dataTable;
                    dgv_title.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void btn_author_search_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the titles
            string command = "select authorID, authorFName, authorLName, city, state from author";

            bool addWhere = false;
            string checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_author_fName.Text))
            {
                checks = checks + "authorFName = " + "'" + tb_author_fName.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_author_lName.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "authorLName = " + "'" + tb_author_lName.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_author_city.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "type = " + "'" + tb_author_city.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_author_state.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "pubDate = " + "'" + tb_author_state.Text + "'" + " ";
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
                    SqlCommand selectTitlesCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(selectTitlesCommand);

                    //Displays output on grid view
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_author.DataSource = dataTable;
                    dgv_author.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stateString;
            //check if state is null before passing it as string
            if (dgv_pub.CurrentRow.Cells[3].Value.GetType() == typeof(DBNull))
            {
                stateString = "";
            }
            else
            {
                stateString = (string)dgv_pub.CurrentRow.Cells[3].Value;
            }

            Publisher_Window pubWindow = new Publisher_Window((string)dgv_pub.CurrentRow.Cells[0].Value, (string)dgv_pub.CurrentRow.Cells[1].Value,
                (string)dgv_pub.CurrentRow.Cells[2].Value, stateString, (string)dgv_pub.CurrentRow.Cells[4].Value);
            pubWindow.Show();
        }

        private void btn_selectTitle_Click(object sender, EventArgs e)
        {
            Title_Info_Window titleWindow = new Title_Info_Window((string)dgv_title.CurrentRow.Cells[0].Value);
            titleWindow.Show();
        }

        private void btn_selectAuthor_Click(object sender, EventArgs e)
        {
            Authors_Window authorWindow = new Authors_Window((string)dgv_author.CurrentRow.Cells[0].Value);
            authorWindow.Show();
        }

        private void btn_newTitle_Click(object sender, EventArgs e)
        {
            Insert_Authors_Window insertAuthor = new Insert_Authors_Window();
            insertAuthor.Show();
        }

        private void btn_addAuthor_Click(object sender, EventArgs e)
        {
            Insert_Authors_Window insertAuthor = new Insert_Authors_Window();
            insertAuthor.Show();
        }
    }
}
