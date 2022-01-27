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
    public partial class frm_login : Form
    {
        public frm_login()
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
            tb_username.Clear();
            tb_password.Clear();

            tb_username.Focus();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            con_open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "Select Count(*) From tbl_Login_Table Where Username = @Uname And Password = @Pswd";

            cmd.Parameters.Add("Uname",SqlDbType.NVarChar).Value = tb_username.Text;
            cmd.Parameters.Add("Pswd",SqlDbType.NVarChar).Value = tb_password.Text;

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                MessageBox.Show("Welcome", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globalvar.add = tb_username.Text;

                frm_add_new_product ANP = new frm_add_new_product();
                ANP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Falid", "Incurrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbl_note.Text = ("Enter Currect Username && Password");
                lbl_note.Visible = true;

                clear();
            }
            con_close();
        }
    }
}
