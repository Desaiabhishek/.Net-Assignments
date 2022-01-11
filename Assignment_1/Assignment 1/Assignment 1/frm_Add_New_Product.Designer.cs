namespace Assignment_1
{
    partial class frm_Add_New_Product
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
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_view_all_product = new System.Windows.Forms.Button();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_Product_name = new System.Windows.Forms.Label();
            this.lbl_purchase_price = new System.Windows.Forms.Label();
            this.lbl_Sales_price = new System.Windows.Forms.Label();
            this.tb_product_id = new System.Windows.Forms.TextBox();
            this.tb_Product_name = new System.Windows.Forms.TextBox();
            this.tb_sales_price = new System.Windows.Forms.TextBox();
            this.tb_purchase_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Corbel", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(252, 24);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(367, 55);
            this.lbl_Add_New_Product.TabIndex = 1;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Coral;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.Location = new System.Drawing.Point(843, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(79, 30);
            this.btn_log_out.TabIndex = 8;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(346, 528);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(174, 53);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(47, 528);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 53);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_view_all_product
            // 
            this.btn_view_all_product.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_view_all_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all_product.Location = new System.Drawing.Point(622, 528);
            this.btn_view_all_product.Name = "btn_view_all_product";
            this.btn_view_all_product.Size = new System.Drawing.Size(300, 53);
            this.btn_view_all_product.TabIndex = 7;
            this.btn_view_all_product.Text = "View All Product";
            this.btn_view_all_product.UseVisualStyleBackColor = false;
            this.btn_view_all_product.Click += new System.EventHandler(this.btn_view_all_product_Click);
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.Location = new System.Drawing.Point(125, 153);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(152, 33);
            this.lbl_product_id.TabIndex = 7;
            this.lbl_product_id.Text = "Product ID";
            // 
            // lbl_Product_name
            // 
            this.lbl_Product_name.AutoSize = true;
            this.lbl_Product_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_name.Location = new System.Drawing.Point(115, 241);
            this.lbl_Product_name.Name = "lbl_Product_name";
            this.lbl_Product_name.Size = new System.Drawing.Size(201, 33);
            this.lbl_Product_name.TabIndex = 8;
            this.lbl_Product_name.Text = "Product Name";
            // 
            // lbl_purchase_price
            // 
            this.lbl_purchase_price.AutoSize = true;
            this.lbl_purchase_price.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_purchase_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchase_price.Location = new System.Drawing.Point(125, 316);
            this.lbl_purchase_price.Name = "lbl_purchase_price";
            this.lbl_purchase_price.Size = new System.Drawing.Size(213, 33);
            this.lbl_purchase_price.TabIndex = 9;
            this.lbl_purchase_price.Text = "Purchase Price";
            // 
            // lbl_Sales_price
            // 
            this.lbl_Sales_price.AutoSize = true;
            this.lbl_Sales_price.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Sales_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_price.Location = new System.Drawing.Point(125, 399);
            this.lbl_Sales_price.Name = "lbl_Sales_price";
            this.lbl_Sales_price.Size = new System.Drawing.Size(163, 33);
            this.lbl_Sales_price.TabIndex = 10;
            this.lbl_Sales_price.Text = "Sales Price";
            // 
            // tb_product_id
            // 
            this.tb_product_id.Location = new System.Drawing.Point(505, 166);
            this.tb_product_id.MaxLength = 10;
            this.tb_product_id.Name = "tb_product_id";
            this.tb_product_id.Size = new System.Drawing.Size(284, 20);
            this.tb_product_id.TabIndex = 1;
            // 
            // tb_Product_name
            // 
            this.tb_Product_name.Location = new System.Drawing.Point(505, 254);
            this.tb_Product_name.MaxLength = 10;
            this.tb_Product_name.Name = "tb_Product_name";
            this.tb_Product_name.Size = new System.Drawing.Size(284, 20);
            this.tb_Product_name.TabIndex = 2;
            // 
            // tb_sales_price
            // 
            this.tb_sales_price.Location = new System.Drawing.Point(505, 412);
            this.tb_sales_price.MaxLength = 10;
            this.tb_sales_price.Name = "tb_sales_price";
            this.tb_sales_price.Size = new System.Drawing.Size(284, 20);
            this.tb_sales_price.TabIndex = 4;
            // 
            // tb_purchase_price
            // 
            this.tb_purchase_price.Location = new System.Drawing.Point(505, 329);
            this.tb_purchase_price.MaxLength = 10;
            this.tb_purchase_price.Name = "tb_purchase_price";
            this.tb_purchase_price.Size = new System.Drawing.Size(284, 20);
            this.tb_purchase_price.TabIndex = 3;
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.ControlBox = false;
            this.Controls.Add(this.tb_purchase_price);
            this.Controls.Add(this.tb_sales_price);
            this.Controls.Add(this.tb_Product_name);
            this.Controls.Add(this.tb_product_id);
            this.Controls.Add(this.lbl_Sales_price);
            this.Controls.Add(this.lbl_purchase_price);
            this.Controls.Add(this.lbl_Product_name);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.btn_view_all_product);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.lbl_Add_New_Product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_view_all_product;
        private System.Windows.Forms.Label lbl_product_id;
        private System.Windows.Forms.Label lbl_Product_name;
        private System.Windows.Forms.Label lbl_purchase_price;
        private System.Windows.Forms.Label lbl_Sales_price;
        private System.Windows.Forms.TextBox tb_product_id;
        private System.Windows.Forms.TextBox tb_Product_name;
        private System.Windows.Forms.TextBox tb_sales_price;
        private System.Windows.Forms.TextBox tb_purchase_price;
    }
}