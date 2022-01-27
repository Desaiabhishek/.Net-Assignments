namespace Assingment_2
{
    partial class frm_view_all_product
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
            this.components = new System.ComponentModel.Container();
            this.lbl_view_all_product = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.tblallproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Management_System_DBDataSet = new Assingment_2.Product_Management_System_DBDataSet();
            this.btn_add_new_product = new System.Windows.Forms.Button();
            this.btn_searchs_product = new System.Windows.Forms.Button();
            this.tbl_all_productTableAdapter = new Assingment_2.Product_Management_System_DBDataSetTableAdapters.tbl_all_productTableAdapter();
            this.product_Management_System_DBDataSet1 = new Assingment_2.Product_Management_System_DBDataSet1();
            this.tblProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Product_DetailsTableAdapter = new Assingment_2.Product_Management_System_DBDataSet1TableAdapters.tbl_Product_DetailsTableAdapter();
            this.product_Management_System_DBDataSet2 = new Assingment_2.Product_Management_System_DBDataSet2();
            this.tblProductDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Product_DetailsTableAdapter1 = new Assingment_2.Product_Management_System_DBDataSet2TableAdapters.tbl_Product_DetailsTableAdapter();
            this.dgv_product_details = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.product_Management_System_DBDataSet4 = new Assingment_2.Product_Management_System_DBDataSet4();
            this.tblProductDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.product_Management_System_DBDataSet3 = new Assingment_2.Product_Management_System_DBDataSet3();
            this.tbl_Product_DetailsTableAdapter2 = new Assingment_2.Product_Management_System_DBDataSet3TableAdapters.tbl_Product_DetailsTableAdapter();
            this.tbl_Product_DetailsTableAdapter3 = new Assingment_2.Product_Management_System_DBDataSet4TableAdapters.tbl_Product_DetailsTableAdapter();
            this.lbl_welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblallproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_view_all_product
            // 
            this.lbl_view_all_product.AutoSize = true;
            this.lbl_view_all_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_view_all_product.Font = new System.Drawing.Font("Bodoni MT", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_all_product.Location = new System.Drawing.Point(264, 26);
            this.lbl_view_all_product.Name = "lbl_view_all_product";
            this.lbl_view_all_product.Size = new System.Drawing.Size(337, 53);
            this.lbl_view_all_product.TabIndex = 2;
            this.lbl_view_all_product.Text = "View All Product";
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Tomato;
            this.btn_log_out.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.Location = new System.Drawing.Point(798, 16);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(124, 28);
            this.btn_log_out.TabIndex = 3;
            this.btn_log_out.Tag = "3";
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // tblallproductBindingSource
            // 
            this.tblallproductBindingSource.DataMember = "tbl_all_product";
            this.tblallproductBindingSource.DataSource = this.product_Management_System_DBDataSet;
            // 
            // product_Management_System_DBDataSet
            // 
            this.product_Management_System_DBDataSet.DataSetName = "Product_Management_System_DBDataSet";
            this.product_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_add_new_product
            // 
            this.btn_add_new_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_new_product.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_product.Location = new System.Drawing.Point(520, 528);
            this.btn_add_new_product.Name = "btn_add_new_product";
            this.btn_add_new_product.Size = new System.Drawing.Size(282, 57);
            this.btn_add_new_product.TabIndex = 2;
            this.btn_add_new_product.Tag = "2";
            this.btn_add_new_product.Text = "Add New Product";
            this.btn_add_new_product.UseVisualStyleBackColor = false;
            this.btn_add_new_product.Click += new System.EventHandler(this.btn_add_new_product_Click);
            // 
            // btn_searchs_product
            // 
            this.btn_searchs_product.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_searchs_product.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchs_product.Location = new System.Drawing.Point(99, 528);
            this.btn_searchs_product.Name = "btn_searchs_product";
            this.btn_searchs_product.Size = new System.Drawing.Size(278, 57);
            this.btn_searchs_product.TabIndex = 1;
            this.btn_searchs_product.Tag = "1";
            this.btn_searchs_product.Text = "Search Product";
            this.btn_searchs_product.UseVisualStyleBackColor = false;
            this.btn_searchs_product.Click += new System.EventHandler(this.btn_searchs_product_Click);
            // 
            // tbl_all_productTableAdapter
            // 
            this.tbl_all_productTableAdapter.ClearBeforeFill = true;
            // 
            // product_Management_System_DBDataSet1
            // 
            this.product_Management_System_DBDataSet1.DataSetName = "Product_Management_System_DBDataSet1";
            this.product_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductDetailsBindingSource
            // 
            this.tblProductDetailsBindingSource.DataMember = "tbl_Product_Details";
            this.tblProductDetailsBindingSource.DataSource = this.product_Management_System_DBDataSet1;
            // 
            // tbl_Product_DetailsTableAdapter
            // 
            this.tbl_Product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // product_Management_System_DBDataSet2
            // 
            this.product_Management_System_DBDataSet2.DataSetName = "Product_Management_System_DBDataSet2";
            this.product_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductDetailsBindingSource1
            // 
            this.tblProductDetailsBindingSource1.DataMember = "tbl_Product_Details";
            this.tblProductDetailsBindingSource1.DataSource = this.product_Management_System_DBDataSet2;
            // 
            // tbl_Product_DetailsTableAdapter1
            // 
            this.tbl_Product_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_product_details
            // 
            this.dgv_product_details.AllowUserToAddRows = false;
            this.dgv_product_details.AllowUserToDeleteRows = false;
            this.dgv_product_details.AutoGenerateColumns = false;
            this.dgv_product_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.purchaesPriceDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn});
            this.dgv_product_details.DataSource = this.tblProductDetailsBindingSource3;
            this.dgv_product_details.Location = new System.Drawing.Point(12, 134);
            this.dgv_product_details.Name = "dgv_product_details";
            this.dgv_product_details.Size = new System.Drawing.Size(892, 365);
            this.dgv_product_details.TabIndex = 4;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // purchaesPriceDataGridViewTextBoxColumn
            // 
            this.purchaesPriceDataGridViewTextBoxColumn.DataPropertyName = "Purchaes Price";
            this.purchaesPriceDataGridViewTextBoxColumn.HeaderText = "Purchaes Price";
            this.purchaesPriceDataGridViewTextBoxColumn.Name = "purchaesPriceDataGridViewTextBoxColumn";
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "Sales Price";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "Sales Price";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            // 
            // tblProductDetailsBindingSource3
            // 
            this.tblProductDetailsBindingSource3.DataMember = "tbl_Product_Details";
            this.tblProductDetailsBindingSource3.DataSource = this.product_Management_System_DBDataSet4;
            // 
            // product_Management_System_DBDataSet4
            // 
            this.product_Management_System_DBDataSet4.DataSetName = "Product_Management_System_DBDataSet4";
            this.product_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductDetailsBindingSource2
            // 
            this.tblProductDetailsBindingSource2.DataMember = "tbl_Product_Details";
            this.tblProductDetailsBindingSource2.DataSource = this.product_Management_System_DBDataSet3;
            // 
            // product_Management_System_DBDataSet3
            // 
            this.product_Management_System_DBDataSet3.DataSetName = "Product_Management_System_DBDataSet3";
            this.product_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Product_DetailsTableAdapter2
            // 
            this.tbl_Product_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_Product_DetailsTableAdapter3
            // 
            this.tbl_Product_DetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Azure;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(12, 22);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(62, 15);
            this.lbl_welcome.TabIndex = 17;
            this.lbl_welcome.Text = "Welcome ";
            // 
            // frm_view_all_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.dgv_product_details);
            this.Controls.Add(this.btn_searchs_product);
            this.Controls.Add(this.btn_add_new_product);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.lbl_view_all_product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_view_all_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Products";
            this.Load += new System.EventHandler(this.frm_view_all_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblallproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_view_all_product;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_add_new_product;
        private System.Windows.Forms.Button btn_searchs_product;
        private Product_Management_System_DBDataSet product_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource tblallproductBindingSource;
        private Product_Management_System_DBDataSetTableAdapters.tbl_all_productTableAdapter tbl_all_productTableAdapter;
        private Product_Management_System_DBDataSet1 product_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource tblProductDetailsBindingSource;
        private Product_Management_System_DBDataSet1TableAdapters.tbl_Product_DetailsTableAdapter tbl_Product_DetailsTableAdapter;
        private Product_Management_System_DBDataSet2 product_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource tblProductDetailsBindingSource1;
        private Product_Management_System_DBDataSet2TableAdapters.tbl_Product_DetailsTableAdapter tbl_Product_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_product_details;
        private Product_Management_System_DBDataSet3 product_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource tblProductDetailsBindingSource2;
        private Product_Management_System_DBDataSet3TableAdapters.tbl_Product_DetailsTableAdapter tbl_Product_DetailsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private Product_Management_System_DBDataSet4 product_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource tblProductDetailsBindingSource3;
        private Product_Management_System_DBDataSet4TableAdapters.tbl_Product_DetailsTableAdapter tbl_Product_DetailsTableAdapter3;
        private System.Windows.Forms.Label lbl_welcome;
    }
}