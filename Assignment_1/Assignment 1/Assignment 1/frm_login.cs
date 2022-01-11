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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "Admin" && tb_password.Text == "a123" || tb_username.Text == "A" && tb_password.Text == "a")
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Product ANP = new frm_Add_New_Product();
                ANP.Show();
                this.Hide();

            }
            else
            {
                lbl_note.Visible = true;
                lbl_note.Text = "Enter Correct Username && Password";

                MessageBox.Show("Incorrect Username & Password ", "Incorrect Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_username.Clear();
            tb_password.Clear();
            tb_username.Focus();
        }
    }
}
