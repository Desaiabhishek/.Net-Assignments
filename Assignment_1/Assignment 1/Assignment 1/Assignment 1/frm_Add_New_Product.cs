using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment_1
{
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-14155jj\SQLEXPRESS;Initial Catalog=Product_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void Clear_Control()
        {
            
            tb_Product_name.Clear();
            tb_purchase_price.Clear();
            tb_sales_price.Clear();

            tb_Product_name.Focus();

        }

        void Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count([Product ID]) From tbl_Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max([Product ID]) From tbl_Product_Details";

               Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Cnt = 0;
            }

            tb_product_id.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_product_id.Text != "" && tb_Product_name.Text != "" && tb_purchase_price.Text != "" && tb_sales_price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into  tbl_Product_Details Values (@Pid,@PName,@PPrice,@SPrice)";

                Cmd.Parameters.Add("Pid", SqlDbType.Int).Value = tb_product_id.Text;
                Cmd.Parameters.Add("PName", SqlDbType.VarChar).Value = tb_Product_name.Text;
                Cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_purchase_price.Text;
                Cmd.Parameters.Add("SPrice", SqlDbType.Money).Value = tb_sales_price.Text;

                Cmd.ExecuteNonQuery();
                
                MessageBox.Show("Record Save Successfully", "Record Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("1st Fill All Fileds", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            Clear_Control();
            tb_product_id.Clear();
            Auto_Incr();

            Con.Close();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();
            Obj.Show();
            this.Hide();
        }

        private void btn_view_all_product_Click(object sender, EventArgs e)
        {
            Frm_View_All_Product ANP = new Frm_View_All_Product();
            ANP.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }

    }
}
