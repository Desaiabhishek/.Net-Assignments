namespace Assingment_2
{
    partial class frm_add_new_product
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
            this.lbl_add_new_product = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_view_all_product = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_purchaes_price = new System.Windows.Forms.Label();
            this.lbl_sales_price = new System.Windows.Forms.Label();
            this.tb_produt_id = new System.Windows.Forms.TextBox();
            this.tb_produt_name = new System.Windows.Forms.TextBox();
            this.tb_sales_price = new System.Windows.Forms.TextBox();
            this.tb_purchaes_price = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_add_new_product
            // 
            this.lbl_add_new_product.AutoSize = true;
            this.lbl_add_new_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_add_new_product.Font = new System.Drawing.Font("Bell MT", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_new_product.Location = new System.Drawing.Point(261, 33);
            this.lbl_add_new_product.Name = "lbl_add_new_product";
            this.lbl_add_new_product.Size = new System.Drawing.Size(374, 52);
            this.lbl_add_new_product.TabIndex = 1;
            this.lbl_add_new_product.Text = "Add New Product";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Bisque;
            this.btn_save.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(349, 527);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(201, 57);
            this.btn_save.TabIndex = 6;
            this.btn_save.Tag = "6";
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_view_all_product
            // 
            this.btn_view_all_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_view_all_product.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all_product.Location = new System.Drawing.Point(628, 527);
            this.btn_view_all_product.Name = "btn_view_all_product";
            this.btn_view_all_product.Size = new System.Drawing.Size(294, 57);
            this.btn_view_all_product.TabIndex = 7;
            this.btn_view_all_product.Tag = "7";
            this.btn_view_all_product.Text = "View All Product";
            this.btn_view_all_product.UseVisualStyleBackColor = false;
            this.btn_view_all_product.Click += new System.EventHandler(this.btn_view_all_product_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_refresh.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(21, 527);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(227, 57);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Tag = "5";
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Tomato;
            this.btn_log_out.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.Location = new System.Drawing.Point(798, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(124, 28);
            this.btn_log_out.TabIndex = 8;
            this.btn_log_out.Tag = "8";
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_product_id.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.Location = new System.Drawing.Point(98, 133);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(151, 33);
            this.lbl_product_id.TabIndex = 12;
            this.lbl_product_id.Text = "Product ID";
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_product_name.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(98, 225);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(201, 33);
            this.lbl_product_name.TabIndex = 13;
            this.lbl_product_name.Text = "Product Name";
            // 
            // lbl_purchaes_price
            // 
            this.lbl_purchaes_price.AutoSize = true;
            this.lbl_purchaes_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_purchaes_price.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchaes_price.Location = new System.Drawing.Point(98, 315);
            this.lbl_purchaes_price.Name = "lbl_purchaes_price";
            this.lbl_purchaes_price.Size = new System.Drawing.Size(213, 33);
            this.lbl_purchaes_price.TabIndex = 14;
            this.lbl_purchaes_price.Text = "Purchaes Price";
            // 
            // lbl_sales_price
            // 
            this.lbl_sales_price.AutoSize = true;
            this.lbl_sales_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sales_price.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales_price.Location = new System.Drawing.Point(98, 412);
            this.lbl_sales_price.Name = "lbl_sales_price";
            this.lbl_sales_price.Size = new System.Drawing.Size(163, 33);
            this.lbl_sales_price.TabIndex = 15;
            this.lbl_sales_price.Text = "Sales Price";
            // 
            // tb_produt_id
            // 
            this.tb_produt_id.Location = new System.Drawing.Point(514, 146);
            this.tb_produt_id.MaxLength = 4;
            this.tb_produt_id.Name = "tb_produt_id";
            this.tb_produt_id.Size = new System.Drawing.Size(271, 20);
            this.tb_produt_id.TabIndex = 1;
            this.tb_produt_id.Tag = "1";
            this.tb_produt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Numeric);
            // 
            // tb_produt_name
            // 
            this.tb_produt_name.Location = new System.Drawing.Point(514, 238);
            this.tb_produt_name.MaxLength = 25;
            this.tb_produt_name.Name = "tb_produt_name";
            this.tb_produt_name.Size = new System.Drawing.Size(271, 20);
            this.tb_produt_name.TabIndex = 2;
            this.tb_produt_name.Tag = "2";
            this.tb_produt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Letter);
            // 
            // tb_sales_price
            // 
            this.tb_sales_price.Location = new System.Drawing.Point(514, 425);
            this.tb_sales_price.MaxLength = 7;
            this.tb_sales_price.Name = "tb_sales_price";
            this.tb_sales_price.Size = new System.Drawing.Size(271, 20);
            this.tb_sales_price.TabIndex = 4;
            this.tb_sales_price.Tag = "4";
            this.tb_sales_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Amount);
            // 
            // tb_purchaes_price
            // 
            this.tb_purchaes_price.Location = new System.Drawing.Point(514, 328);
            this.tb_purchaes_price.MaxLength = 10;
            this.tb_purchaes_price.Name = "tb_purchaes_price";
            this.tb_purchaes_price.Size = new System.Drawing.Size(271, 20);
            this.tb_purchaes_price.TabIndex = 3;
            this.tb_purchaes_price.Tag = "3";
            this.tb_purchaes_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Amount);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Azure;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(12, 20);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(62, 15);
            this.lbl_welcome.TabIndex = 16;
            this.lbl_welcome.Text = "Welcome ";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // frm_add_new_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.tb_purchaes_price);
            this.Controls.Add(this.tb_sales_price);
            this.Controls.Add(this.tb_produt_name);
            this.Controls.Add(this.tb_produt_id);
            this.Controls.Add(this.lbl_sales_price);
            this.Controls.Add(this.lbl_purchaes_price);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_view_all_product);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_add_new_product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_new_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frm_add_new_product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_add_new_product;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_view_all_product;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_product_id;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Label lbl_purchaes_price;
        private System.Windows.Forms.Label lbl_sales_price;
        private System.Windows.Forms.TextBox tb_produt_id;
        private System.Windows.Forms.TextBox tb_produt_name;
        private System.Windows.Forms.TextBox tb_sales_price;
        private System.Windows.Forms.TextBox tb_purchaes_price;
        private System.Windows.Forms.Label lbl_welcome;
    }
}