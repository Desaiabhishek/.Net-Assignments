using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Frm_View_All_Product : Form
    {
        public Frm_View_All_Product()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Management_System_DBDataSet.tbl_Product_Details' table. You can move, or remove it, as needed.
            this.tbl_Product_DetailsTableAdapter.Fill(this.product_Management_System_DBDataSet.tbl_Product_Details);

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();
            Obj.Show();
            this.Hide();

        }
    }
}
