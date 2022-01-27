using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assingment_2
{
    public partial class frm_view_all_product : Form
    {
        public frm_view_all_product()
        {
            InitializeComponent();
        }

        private void btn_add_new_product_Click(object sender, EventArgs e)
        {
            frm_add_new_product ANP = new frm_add_new_product();
            ANP.Show();
            this.Hide();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_searchs_product_Click(object sender, EventArgs e)
        {
            frm_search_product SP = new frm_search_product();
            SP.Show();
            this.Hide();
        }

        private void frm_view_all_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Management_System_DBDataSet4.tbl_Product_Details' table. You can move, or remove it, as needed.
            this.tbl_Product_DetailsTableAdapter3.Fill(this.product_Management_System_DBDataSet4.tbl_Product_Details);

            lbl_welcome.Text = "WElcome " + Globalvar.add;

        }
    }
}
