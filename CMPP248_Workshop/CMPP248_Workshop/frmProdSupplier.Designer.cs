
namespace CMPP248_Workshop
{
    partial class frmProdSupplier
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
            System.Windows.Forms.Label prodNameLabel1;
            System.Windows.Forms.Label productIdLabel1;
            System.Windows.Forms.Label supNameLabel1;
            System.Windows.Forms.Label supplierIdLabel1;
            System.Windows.Forms.Label productSupplierIdLabel;
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packages_Products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdTextBox1 = new System.Windows.Forms.TextBox();
            this.productSupplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            prodNameLabel1 = new System.Windows.Forms.Label();
            productIdLabel1 = new System.Windows.Forms.Label();
            supNameLabel1 = new System.Windows.Forms.Label();
            supplierIdLabel1 = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertDatabase.Supplier);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // packages_Products_SupplierBindingSource
            // 
            this.packages_Products_SupplierBindingSource.DataSource = typeof(TravelExpertDatabase.Packages_Products_Supplier);
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(TravelExpertDatabase.Products_Supplier);
            // 
            // prodNameLabel1
            // 
            prodNameLabel1.AutoSize = true;
            prodNameLabel1.Location = new System.Drawing.Point(56, 158);
            prodNameLabel1.Name = "prodNameLabel1";
            prodNameLabel1.Size = new System.Drawing.Size(83, 17);
            prodNameLabel1.TabIndex = 11;
            prodNameLabel1.Text = "Prod Name:";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "Product.ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(198, 155);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.ReadOnly = true;
            this.prodNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.prodNameTextBox.TabIndex = 12;
            // 
            // productIdLabel1
            // 
            productIdLabel1.AutoSize = true;
            productIdLabel1.Location = new System.Drawing.Point(56, 186);
            productIdLabel1.Name = "productIdLabel1";
            productIdLabel1.Size = new System.Drawing.Size(76, 17);
            productIdLabel1.TabIndex = 13;
            productIdLabel1.Text = "Product Id:";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "Product.ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(198, 183);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(121, 22);
            this.productIdTextBox.TabIndex = 14;
            // 
            // supNameLabel1
            // 
            supNameLabel1.AutoSize = true;
            supNameLabel1.Location = new System.Drawing.Point(56, 248);
            supNameLabel1.Name = "supNameLabel1";
            supNameLabel1.Size = new System.Drawing.Size(78, 17);
            supNameLabel1.TabIndex = 15;
            supNameLabel1.Text = "Sup Name:";
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "Supplier.SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(198, 245);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.ReadOnly = true;
            this.supNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.supNameTextBox.TabIndex = 16;
            // 
            // supplierIdLabel1
            // 
            supplierIdLabel1.AutoSize = true;
            supplierIdLabel1.Location = new System.Drawing.Point(56, 276);
            supplierIdLabel1.Name = "supplierIdLabel1";
            supplierIdLabel1.Size = new System.Drawing.Size(79, 17);
            supplierIdLabel1.TabIndex = 17;
            supplierIdLabel1.Text = "Supplier Id:";
            // 
            // supplierIdTextBox1
            // 
            this.supplierIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "Supplier.SupplierId", true));
            this.supplierIdTextBox1.Location = new System.Drawing.Point(198, 273);
            this.supplierIdTextBox1.Name = "supplierIdTextBox1";
            this.supplierIdTextBox1.ReadOnly = true;
            this.supplierIdTextBox1.Size = new System.Drawing.Size(121, 22);
            this.supplierIdTextBox1.TabIndex = 18;
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Location = new System.Drawing.Point(56, 96);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(132, 17);
            productSupplierIdLabel.TabIndex = 18;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // productSupplierIdComboBox
            // 
            this.productSupplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "ProductSupplierId", true));
            this.productSupplierIdComboBox.FormattingEnabled = true;
            this.productSupplierIdComboBox.Location = new System.Drawing.Point(198, 96);
            this.productSupplierIdComboBox.Name = "productSupplierIdComboBox";
            this.productSupplierIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.productSupplierIdComboBox.TabIndex = 19;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(911, 380);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(91, 40);
            this.btnDone.TabIndex = 20;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(457, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 210);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(347, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 34);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(347, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "<<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmProdSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 537);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(productSupplierIdLabel);
            this.Controls.Add(this.productSupplierIdComboBox);
            this.Controls.Add(supNameLabel1);
            this.Controls.Add(this.supNameTextBox);
            this.Controls.Add(supplierIdLabel1);
            this.Controls.Add(this.supplierIdTextBox1);
            this.Controls.Add(prodNameLabel1);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(productIdLabel1);
            this.Controls.Add(this.productIdTextBox);
            this.Name = "frmProdSupplier";
            this.Text = "frmProdSupplier";
            this.Load += new System.EventHandler(this.frmProdSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource packages_Products_SupplierBindingSource;
        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox1;
        private System.Windows.Forms.ComboBox productSupplierIdComboBox;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}