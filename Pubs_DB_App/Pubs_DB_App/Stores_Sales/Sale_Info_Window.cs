using Pubs_DB_App.Stores_Sales;
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
    public partial class Sales : Form
    {
        string titleID;
        public Sales(string orderNO, 
            string titleID, 
            string storeID, 
            DateTime orderDate, 
            short quantity, 
            string payterms)
        {
            this.titleID = titleID;
            InitializeComponent();
            tb_orderNum.Text = orderNO;
            tb_title.Text = titleID;
            tb_store.Text = storeID;
            tb_orderDate.Text = orderDate.ToString("yyyy-mm-dd");
            tb_quantity.Text = quantity.ToString();
            tb_discount.Text = payterms;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {

        }
        private void btn_view_title_info_Click(object sender, EventArgs e)
        {
            Title_Info_Window titleWindow = new Title_Info_Window(titleID);
            this.Close();
            titleWindow.Show();
        }

        private void btn_create_sale_Click(object sender, EventArgs e)
        {
            Insert_Window_Sale newSale = new Insert_Window_Sale();
            this.Close();
            newSale.Show();
        }

        private void btn_new_sale_search_Click(Object sender, EventArgs e)
        {

        }
    }
}
