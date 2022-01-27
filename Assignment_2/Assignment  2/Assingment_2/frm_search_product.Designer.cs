namespace Assingment_2
{
    partial class frm_search_product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_search_product = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.tb_purchaes_price = new System.Windows.Forms.TextBox();
            this.tb_sales_price = new System.Windows.Forms.TextBox();
            this.tb_produt_name = new System.Windows.Forms.TextBox();
            this.tb_produt_id = new System.Windows.Forms.TextBox();
            this.lbl_sales_price = new System.Windows.Forms.Label();
            this.lbl_purchaes_price = new System.Windows.Forms.Label();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.btn_add_new_product = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_search_product
            // 
            this.lbl_search_product.AutoSize = true;
            this.lbl_search_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_search_product.Font = new System.Drawing.Font("Bodoni MT", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_product.Location = new System.Drawing.Point(278, 33);
            this.lbl_search_product.Name = "lbl_search_product";
            this.lbl_search_product.Size = new System.Drawing.Size(303, 53);
            this.lbl_search_product.TabIndex = 3;
            this.lbl_search_product.Text = "Search Product";
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Tomato;
            this.btn_log_out.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.Location = new System.Drawing.Point(798, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(124, 28);
            this.btn_log_out.TabIndex = 5;
            this.btn_log_out.Tag = "5";
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // tb_purchaes_price
            // 
            this.tb_purchaes_price.Location = new System.Drawing.Point(499, 333);
            this.tb_purchaes_price.MaxLength = 10;
            this.tb_purchaes_price.Name = "tb_purchaes_price";
            this.tb_purchaes_price.Size = new System.Drawing.Size(271, 20);
            this.tb_purchaes_price.TabIndex = 4;
            this.tb_purchaes_price.Tag = "";
            this.tb_purchaes_price.Visible = false;
            // 
            // tb_sales_price
            // 
            this.tb_sales_price.Location = new System.Drawing.Point(499, 430);
            this.tb_sales_price.MaxLength = 7;
            this.tb_sales_price.Name = "tb_sales_price";
            this.tb_sales_price.Size = new System.Drawing.Size(271, 20);
            this.tb_sales_price.TabIndex = 5;
            this.tb_sales_price.Tag = "";
            this.tb_sales_price.Visible = false;
            // 
            // tb_produt_name
            // 
            this.tb_produt_name.Location = new System.Drawing.Point(499, 243);
            this.tb_produt_name.MaxLength = 25;
            this.tb_produt_name.Name = "tb_produt_name";
            this.tb_produt_name.Size = new System.Drawing.Size(271, 20);
            this.tb_produt_name.TabIndex = 3;
            this.tb_produt_name.Tag = "";
            this.tb_produt_name.Visible = false;
            // 
            // tb_produt_id
            // 
            this.tb_produt_id.Location = new System.Drawing.Point(499, 148);
            this.tb_produt_id.MaxLength = 4;
            this.tb_produt_id.Name = "tb_produt_id";
            this.tb_produt_id.Size = new System.Drawing.Size(271, 20);
            this.tb_produt_id.TabIndex = 1;
            this.tb_produt_id.Tag = "1";
            this.tb_produt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Numeric);
            // 
            // lbl_sales_price
            // 
            this.lbl_sales_price.AutoSize = true;
            this.lbl_sales_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sales_price.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales_price.Location = new System.Drawing.Point(132, 419);
            this.lbl_sales_price.Name = "lbl_sales_price";
            this.lbl_sales_price.Size = new System.Drawing.Size(163, 33);
            this.lbl_sales_price.TabIndex = 23;
            this.lbl_sales_price.Text = "Sales Price";
            // 
            // lbl_purchaes_price
            // 
            this.lbl_purchaes_price.AutoSize = true;
            this.lbl_purchaes_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_purchaes_price.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchaes_price.Location = new System.Drawing.Point(132, 322);
            this.lbl_purchaes_price.Name = "lbl_purchaes_price";
            this.lbl_purchaes_price.Size = new System.Drawing.Size(213, 33);
            this.lbl_purchaes_price.TabIndex = 22;
            this.lbl_purchaes_price.Text = "Purchaes Price";
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_product_name.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(132, 232);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(201, 33);
            this.lbl_product_name.TabIndex = 21;
            this.lbl_product_name.Text = "Product Name";
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_product_id.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.Location = new System.Drawing.Point(132, 140);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(151, 33);
            this.lbl_product_id.TabIndex = 20;
            this.lbl_product_id.Text = "Product ID";
            // 
            // btn_add_new_product
            // 
            this.btn_add_new_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_new_product.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_product.Location = new System.Drawing.Point(488, 520);
            this.btn_add_new_product.Name = "btn_add_new_product";
            this.btn_add_new_product.Size = new System.Drawing.Size(282, 57);
            this.btn_add_new_product.TabIndex = 4;
            this.btn_add_new_product.Tag = "4";
            this.btn_add_new_product.Text = "Add New Product";
            this.btn_add_new_product.UseVisualStyleBackColor = false;
            this.btn_add_new_product.Click += new System.EventHandler(this.btn_add_new_product_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_refresh.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(119, 520);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(227, 57);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Tag = "3";
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(634, 171);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(37, 16);
            this.lbl_error.TabIndex = 30;
            this.lbl_error.Text = "Error";
            this.lbl_error.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(778, 139);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 34);
            this.btn_search.TabIndex = 2;
            this.btn_search.Tag = "2";
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Azure;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(12, 18);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(62, 15);
            this.lbl_welcome.TabIndex = 31;
            this.lbl_welcome.Text = "Welcome ";
            // 
            // frm_search_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_add_new_product);
            this.Controls.Add(this.tb_purchaes_price);
            this.Controls.Add(this.tb_sales_price);
            this.Controls.Add(this.tb_produt_name);
            this.Controls.Add(this.tb_produt_id);
            this.Controls.Add(this.lbl_sales_price);
            this.Controls.Add(this.lbl_purchaes_price);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.lbl_search_product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_search_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Product";
            this.Load += new System.EventHandler(this.frm_search_product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_search_product;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.TextBox tb_purchaes_price;
        private System.Windows.Forms.TextBox tb_sales_price;
        private System.Windows.Forms.TextBox tb_produt_name;
        private System.Windows.Forms.TextBox tb_produt_id;
        private System.Windows.Forms.Label lbl_sales_price;
        private System.Windows.Forms.Label lbl_purchaes_price;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Label lbl_product_id;
        private System.Windows.Forms.Button btn_add_new_product;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_welcome;
    }
}