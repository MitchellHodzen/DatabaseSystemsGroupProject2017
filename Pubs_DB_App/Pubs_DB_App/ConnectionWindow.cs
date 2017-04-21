using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubs_DB_App
{
    public partial class ConnectionWindow : Form
    {
        //Use 
        public static string ConnectionString = null;
        public ConnectionWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retrieveInput_Click(object sender, EventArgs e)
        {
            string serverName = serverNameInput.Text;
            ConnectionString = "Server = " + serverName + ";" + "database = Group1Pubs;" + "Trusted_Connection = yes;";
            this.Close();
        }
    }
}
