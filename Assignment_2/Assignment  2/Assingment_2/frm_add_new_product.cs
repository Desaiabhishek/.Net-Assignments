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
    public partial class frm_add_new_product : Form
    {
        public frm_add_new_product()
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
        void con_Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void clear()
        {
            tb_produt_name.Clear();
            tb_purchaes_price.Clear();
            tb_sales_price.Clear();

            tb_produt_name.Focus();
        }

        void Auto_Incr()
        {
            int cnt = 0;

            con_open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "Select Count([Product ID]) From tbl_Product_Details";

            cnt = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();

            if (cnt > 0)
            {
                cmd.Connection = con;
                cmd.CommandText = "Select Max ([Product ID]) From tbl_Product_Details";


                cnt = Convert.ToInt32(cmd.ExecuteScalar());
            }

            else
            {
                cnt = 0;
            }

            tb_produt_id.Text = Convert.ToString(cnt + 1);

            con_Close();
        } 

        private void btn_view_all_product_Click(object sender, EventArgs e)
        {
            frm_view_all_product VAP = new frm_view_all_product();
            VAP.Show();
            this.Hide();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con_open();

            if (tb_produt_id.Text != "" && tb_produt_name.Text != "" && tb_purchaes_price.Text != "" && tb_sales_price.Text != "")
            {

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con;

                Cmd.CommandText = "Insert Into tbl_Product_Details values(@Pid,@pname,@pprice,@sprice)";

                Cmd.Parameters.Add("Pid", SqlDbType.NChar).Value = tb_produt_id.Text;
                Cmd.Parameters.Add("pname", SqlDbType.NVarChar).Value = tb_produt_name.Text;
                Cmd.Parameters.Add("pprice",SqlDbType.Money).Value = tb_purchaes_price.Text;
                Cmd.Parameters.Add("sprice",SqlDbType.Money).Value = tb_sales_price.Text;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 
                tb_produt_id.Clear();
                Auto_Incr();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
               
            }
            clear();
            con_Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frm_add_new_product_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Welcome " + Globalvar.add;
            Auto_Incr();

        }

        private void Is_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Is_Letter(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space) ))
            {
                e.Handled = true;
            }
        }

        private void Is_Amount(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }
        
    }
}
