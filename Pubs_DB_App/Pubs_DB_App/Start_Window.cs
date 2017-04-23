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
            string command = "select Distinct title.titleID, pubID, title,type, pubDate from title " +
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
            if (!string.IsNullOrWhiteSpace(tb_title_titleID.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "title.titleID = " + "'" + tb_title_titleID.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(combo.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "pubID = " + "'" + combo.Text + "'" + " ";
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
                checks = checks + "city = " + "'" + tb_author_city.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_author_state.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "state = " + "'" + tb_author_state.Text + "'" + " ";
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

            Publisher_Window pubWindow = new Publisher_Window(this, (string)dgv_pub.CurrentRow.Cells[0].Value, (string)dgv_pub.CurrentRow.Cells[1].Value,
                (string)dgv_pub.CurrentRow.Cells[2].Value, stateString, (string)dgv_pub.CurrentRow.Cells[4].Value);
            pubWindow.Show();
        }

        public void SetTab(string tab)
        {
            tabControl1.SelectTab(tab);
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
            Insert_Window_Title insertTitle = new Insert_Window_Title(null);
            insertTitle.Show();
        }

        private void btn_addAuthor_Click(object sender, EventArgs e)
        {
            Insert_Authors_Window insertAuthor = new Insert_Authors_Window();
            insertAuthor.Show();
        }

        //Store Tab Functions
        private void btn_store_search_Click(object sender, EventArgs e)
        {
            //Begin building the SQL command to view the publishers 
            String command = "SELECT * FROM STORE";
            bool addWhere = false;
            String checks = "";
            //Construct the where statement based on user input
            if (!string.IsNullOrWhiteSpace(tb_store_name.Text))
            {
                checks = checks + "storeName = " + "'" + tb_store_name.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_store_id.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "storeID = " + "'" + tb_store_id.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_store_address.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "address = " + "'" + tb_store_address.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_pub_city.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "city = " + "'" + tb_store_city.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_store_state.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "state = " + "'" + tb_store_state.Text + "'" + " ";
                addWhere = true;
            }
            if (!string.IsNullOrWhiteSpace(tb_store_zip.Text))
            {
                if (addWhere == true)
                {
                    checks = checks + " AND ";
                }
                checks = checks + "zip = " + "'" + tb_store_zip.Text + "'" + " ";
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
                    dgv_store.DataSource = dataTable;
                    dgv_store.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
        private void btn_selectStore_Click(object sender, EventArgs e)
        {
            Stores storeWindow = new Stores((string)dgv_store.CurrentRow.Cells[0].Value, (string)dgv_store.CurrentRow.Cells[1].Value,
                (string)dgv_store.CurrentRow.Cells[2].Value, (string)dgv_store.CurrentRow.Cells[3].Value,
                (string)dgv_store.CurrentRow.Cells[4].Value, (string)dgv_store.CurrentRow.Cells[5].Value);
            storeWindow.Show();
        }
        private void btn_addStore_Click(object sender, EventArgs e)
        {
            Insert_Window_Store addStoreWindow = new Insert_Window_Store();
            addStoreWindow.Show();
        }

        private void tb_store_city_TextChanged(object sender, EventArgs e)
        {

        }

        public void setPubCombo()
        {
            //Populates pubID and authorID combobox
            String command = "Select pubID FROM Publisher";
            //Connets to the database using the connection string from the connection page
            using (SqlConnection connection = new SqlConnection(ConnectionWindow.ConnectionString))
            {
                try
                {
                    //Open the database
                    connection.Open();
                    //Creates SQL command using the command string generated earlier
                    SqlCommand getpubIDCommand = new SqlCommand(command, connection);
                    //Executes command and recieves output
                    SqlDataAdapter adapter = new SqlDataAdapter(getpubIDCommand);
                    //Fills comboboxes
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    combo.Items.Add("");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        combo.Items.Add(row[0]);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        Boolean i = false;
        private void combo_MouseClick(object sender, MouseEventArgs e)
        {
             if(i == false)
            {
                setPubCombo();
                i = true;
            }
            
        }
        public void SetTitlesPublisher(string pubID)
        {
            if (i == false)
            {
                setPubCombo();
                i = true;
            }
            combo.SelectedIndex = combo.FindStringExact(pubID);
        }
    }
}
