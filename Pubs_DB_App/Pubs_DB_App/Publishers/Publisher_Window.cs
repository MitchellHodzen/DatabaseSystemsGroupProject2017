using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pubs_DB_App.Stores_Sales;

namespace Pubs_DB_App.Publishers
{
    public partial class Publisher_Window : Form
    {

        public string pubID;
        Start_Window startWindow;
        public Publisher_Window(Start_Window startWindow, string pubID, string name, string city, string state, string country)
        {
            InitializeComponent();
            this.pubID = pubID;
            this.tb_pubname.Text = name;
            this.tb_city.Text = city;
            this.tb_state.Text = state;
            this.tb_country.Text = country;
            this.startWindow = startWindow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Insert_Window_Employee iwe = new Insert_Window_Employee(pubID);
            iwe.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Insert_Window_Title iwt = new Insert_Window_Title();
            iwt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Insert_Window_Job iwj = new Insert_Window_Job(pubID);
            iwj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Insert_Window_Sale iws = new Insert_Window_Sale();
            iws.Show();
        }

        private void tb_pubname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Publisher_Window_Load(object sender, EventArgs e)
        {
            tb_pubid.Text = pubID; 
        }

        private void btn_jobs_Click(object sender, EventArgs e)
        {
            View_Publisher_Jobs vpj = new View_Publisher_Jobs(pubID);
            vpj.Show();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            View_Publisher_Employees vpe = new View_Publisher_Employees(pubID);
            vpe.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_titles_Click(object sender, EventArgs e)
        {
            startWindow.Focus();
            startWindow.SetTab("tabPage2");
        }
    }
}
