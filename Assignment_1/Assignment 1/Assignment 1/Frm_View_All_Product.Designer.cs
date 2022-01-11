namespace Assignment_1
{
    partial class Frm_View_All_Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_View_All_Product = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_add_new_product = new System.Windows.Forms.Button();
            this.dgv_view_all_product = new System.Windows.Forms.DataGridView();
            this.product_Management_System_DBDataSet = new Assignment_1.Product_Management_System_DBDataSet();
            this.tblProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Product_DetailsTableAdapter = new Assignment_1.Product_Management_System_DBDataSetTableAdapters.tbl_Product_DetailsTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_all_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Product
            // 
            this.lbl_View_All_Product.AutoSize = true;
            this.lbl_View_All_Product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_View_All_Product.Font = new System.Drawing.Font("Corbel", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Product.Location = new System.Drawing.Point(260, 24);
            this.lbl_View_All_Product.Name = "lbl_View_All_Product";
            this.lbl_View_All_Product.Size = new System.Drawing.Size(344, 55);
            this.lbl_View_All_Product.TabIndex = 2;
            this.lbl_View_All_Product.Text = "View All Product";
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Coral;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.Location = new System.Drawing.Point(843, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(79, 30);
            this.btn_log_out.TabIndex = 2;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_add_new_product
            // 
            this.btn_add_new_product.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_add_new_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_product.Location = new System.Drawing.Point(286, 546);
            this.btn_add_new_product.Name = "btn_add_new_product";
            this.btn_add_new_product.Size = new System.Drawing.Size(300, 53);
            this.btn_add_new_product.TabIndex = 1;
            this.btn_add_new_product.Text = "Add New Product";
            this.btn_add_new_product.UseVisualStyleBackColor = false;
            // 
            // dgv_view_all_product
            // 
            this.dgv_view_all_product.AllowUserToAddRows = false;
            this.dgv_view_all_product.AllowUserToDeleteRows = false;
            this.dgv_view_all_product.AutoGenerateColumns = false;
            this.dgv_view_all_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_view_all_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_view_all_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_all_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.purchaesPriceDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn});
            this.dgv_view_all_product.DataSource = this.tblProductDetailsBindingSource;
            this.dgv_view_all_product.Location = new System.Drawing.Point(12, 96);
            this.dgv_view_all_product.Name = "dgv_view_all_product";
            this.dgv_view_all_product.ReadOnly = true;
            this.dgv_view_all_product.Size = new System.Drawing.Size(910, 444);
            this.dgv_view_all_product.TabIndex = 3;
            // 
            // product_Management_System_DBDataSet
            // 
            this.product_Management_System_DBDataSet.DataSetName = "Product_Management_System_DBDataSet";
            this.product_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductDetailsBindingSource
            // 
            this.tblProductDetailsBindingSource.DataMember = "tbl_Product_Details";
            this.tblProductDetailsBindingSource.DataSource = this.product_Management_System_DBDataSet;
            // 
            // tbl_Product_DetailsTableAdapter
            // 
            this.tbl_Product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaesPriceDataGridViewTextBoxColumn
            // 
            this.purchaesPriceDataGridViewTextBoxColumn.DataPropertyName = "Purchaes Price";
            this.purchaesPriceDataGridViewTextBoxColumn.HeaderText = "Purchaes Price";
            this.purchaesPriceDataGridViewTextBoxColumn.Name = "purchaesPriceDataGridViewTextBoxColumn";
            this.purchaesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "Sales Price";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "Sales Price";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_View_All_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgv_view_all_product);
            this.Controls.Add(this.btn_add_new_product);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.lbl_View_All_Product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_All_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Product";
            this.Load += new System.EventHandler(this.Frm_View_All_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_all_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Product;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_add_new_product;
        private System.Windows.Forms.DataGridView dgv_view_all_product;
        private Product_Management_System_DBDataSet product_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource tblProductDetailsBindingSource;
        private Product_Management_System_DBDataSetTableAdapters.tbl_Product_DetailsTableAdapter tbl_Product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
    }
}