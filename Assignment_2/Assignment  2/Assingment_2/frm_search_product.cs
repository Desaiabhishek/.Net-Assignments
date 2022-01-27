using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assingment_2
{
    public partial class frm_search_product : Form
    {
        public frm_search_product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-14155jj\SQLEXPRESS;Initial Catalog=Product_Management_System_DB;Integrated Security=True");

        void con_open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        void con_close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        void clear()
        {
            tb_produt_id.Clear();
            tb_produt_name.Clear();
            tb_purchaes_price.Clear();
            tb_sales_price.Clear();

            tb_produt_id.Focus();
        }



        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_add_new_product_Click(object sender, EventArgs e)
        {
            frm_add_new_product ANP = new frm_add_new_product();
            ANP.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con_open();

            if (tb_produt_id.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Select * From tbl_Product_Details Where [Product ID] = @Pid";

                cmd.Parameters.Add("Pid", SqlDbType.Int).Value = tb_produt_id.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_produt_name.Text = Dr.GetString(Dr.GetOrdinal("Product Name"));
                    tb_purchaes_price.Text = (Dr["Purchaes Price"].ToString());
                    tb_sales_price.Text = (Dr["Sales Price"].ToString());


                    tb_produt_name.Visible = true;
                    tb_purchaes_price.Visible = true;
                    tb_sales_price.Visible = true;
            
                }
                else
                {
                    MessageBox.Show("Invalid Product ID", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_produt_id.Clear();
                    tb_produt_id.Focus();

                }
                lbl_error.Visible = false;
            }

            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "1st Fill Product ID";
                tb_produt_id.Focus();
            }

            con_close();
        }

        private void frm_search_product_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Welcome " + Globalvar.add;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
            tb_produt_name.Visible = false;
            tb_purchaes_price.Visible = false;
            tb_sales_price.Visible = false;
        }

        private void Is_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
