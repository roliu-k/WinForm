
namespace CMPP248_Workshop
{
    partial class frmProdSupplierAddEdit
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
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnManageProds = new System.Windows.Forms.Button();
            this.btnManageSupps = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.packagesProductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.mainLeftBuff = new System.Windows.Forms.Panel();
            this.mainRightBuff = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grdProductSuppliers = new System.Windows.Forms.DataGridView();
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSubBody = new System.Windows.Forms.Panel();
            this.checkBoxFilterSuppliers = new System.Windows.Forms.CheckBox();
            this.btnAddProdSupp = new System.Windows.Forms.Button();
            this.btnModifyProdSupp = new System.Windows.Forms.Button();
            this.lblSelectedProdsTitle = new System.Windows.Forms.Label();
            this.leftbuff = new System.Windows.Forms.Panel();
            this.rightbuff = new System.Windows.Forms.Panel();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdPackagesforProdSupp = new System.Windows.Forms.DataGridView();
            this.packageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgBasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgAgencyCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAssociatesPackages = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.checkboxFilterProducts = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            supplierIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductSuppliers)).BeginInit();
            this.pnlSubBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackagesforProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIdLabel.Location = new System.Drawing.Point(80, 97);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(101, 16);
            supplierIdLabel.TabIndex = 5;
            supplierIdLabel.Text = "Supplier Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIdLabel.Location = new System.Drawing.Point(80, 35);
            productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(92, 16);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "Product Type:";
            // 
            // btnManageProds
            // 
            this.btnManageProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProds.Location = new System.Drawing.Point(69, 658);
            this.btnManageProds.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageProds.Name = "btnManageProds";
            this.btnManageProds.Size = new System.Drawing.Size(230, 38);
            this.btnManageProds.TabIndex = 7;
            this.btnManageProds.Text = "Manage Products...";
            this.btnManageProds.UseVisualStyleBackColor = true;
            this.btnManageProds.Click += new System.EventHandler(this.btnManageProds_Click);
            // 
            // btnManageSupps
            // 
            this.btnManageSupps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSupps.Location = new System.Drawing.Point(349, 658);
            this.btnManageSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageSupps.Name = "btnManageSupps";
            this.btnManageSupps.Size = new System.Drawing.Size(230, 38);
            this.btnManageSupps.TabIndex = 8;
            this.btnManageSupps.Text = "Manage Suppliers...";
            this.btnManageSupps.UseVisualStyleBackColor = true;
            this.btnManageSupps.Click += new System.EventHandler(this.btnManageSupps_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(636, 658);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // packagesProductsSuppliersBindingSource
            // 
            this.packagesProductsSuppliersBindingSource.DataMember = "Packages_Products_Suppliers";
            this.packagesProductsSuppliersBindingSource.DataSource = this.products_SupplierBindingSource;
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(TravelExpertDatabase.Products_Supplier);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(900, 75);
            this.Header.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 51);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(900, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Each row represents a product provided by a particular supplier.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.Title.Size = new System.Drawing.Size(900, 51);
            this.Title.TabIndex = 19;
            this.Title.Text = "Product Manager - View Products";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainLeftBuff
            // 
            this.mainLeftBuff.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainLeftBuff.Location = new System.Drawing.Point(0, 75);
            this.mainLeftBuff.Name = "mainLeftBuff";
            this.mainLeftBuff.Size = new System.Drawing.Size(17, 662);
            this.mainLeftBuff.TabIndex = 28;
            // 
            // mainRightBuff
            // 
            this.mainRightBuff.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainRightBuff.Location = new System.Drawing.Point(883, 75);
            this.mainRightBuff.Name = "mainRightBuff";
            this.mainRightBuff.Size = new System.Drawing.Size(17, 662);
            this.mainRightBuff.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current Products:";
            // 
            // grdProductSuppliers
            // 
            this.grdProductSuppliers.AllowUserToAddRows = false;
            this.grdProductSuppliers.AllowUserToDeleteRows = false;
            this.grdProductSuppliers.AllowUserToResizeColumns = false;
            this.grdProductSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdProductSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductSuppliers.AutoGenerateColumns = false;
            this.grdProductSuppliers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdProductSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductSuppliers.CausesValidation = false;
            this.grdProductSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProductSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSupplierId,
            this.Product,
            this.supplierIdDataGridViewTextBoxColumn,
            this.Supplier});
            this.grdProductSuppliers.DataSource = this.products_SupplierBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdProductSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdProductSuppliers.EnableHeadersVisualStyles = false;
            this.grdProductSuppliers.Location = new System.Drawing.Point(0, 23);
            this.grdProductSuppliers.Margin = new System.Windows.Forms.Padding(15);
            this.grdProductSuppliers.MultiSelect = false;
            this.grdProductSuppliers.Name = "grdProductSuppliers";
            this.grdProductSuppliers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdProductSuppliers.RowHeadersVisible = false;
            this.grdProductSuppliers.RowHeadersWidth = 51;
            this.grdProductSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductSuppliers.Size = new System.Drawing.Size(866, 262);
            this.grdProductSuppliers.TabIndex = 20;
            this.grdProductSuppliers.TabStop = false;
            this.grdProductSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductSuppliers_CellClick);
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "Product/Supplier ID";
            this.ProductSupplierId.MinimumWidth = 6;
            this.ProductSupplierId.Name = "ProductSupplierId";
            this.ProductSupplierId.ReadOnly = true;
            this.ProductSupplierId.Width = 170;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Product.DataPropertyName = "ProdName";
            this.Product.HeaderText = "Product Name";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 230;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier Name";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // pnlSubBody
            // 
            this.pnlSubBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSubBody.Controls.Add(this.checkBoxFilterSuppliers);
            this.pnlSubBody.Controls.Add(this.btnAddProdSupp);
            this.pnlSubBody.Controls.Add(this.btnModifyProdSupp);
            this.pnlSubBody.Controls.Add(this.lblSelectedProdsTitle);
            this.pnlSubBody.Controls.Add(this.leftbuff);
            this.pnlSubBody.Controls.Add(this.rightbuff);
            this.pnlSubBody.Controls.Add(productIdLabel);
            this.pnlSubBody.Controls.Add(this.productIdComboBox);
            this.pnlSubBody.Controls.Add(this.productSupplierIdTextBox);
            this.pnlSubBody.Controls.Add(supplierIdLabel);
            this.pnlSubBody.Controls.Add(this.supplierIdComboBox);
            this.pnlSubBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubBody.Location = new System.Drawing.Point(0, 403);
            this.pnlSubBody.Name = "pnlSubBody";
            this.pnlSubBody.Size = new System.Drawing.Size(866, 138);
            this.pnlSubBody.TabIndex = 24;
            // 
            // checkBoxFilterSuppliers
            // 
            this.checkBoxFilterSuppliers.AutoSize = true;
            this.checkBoxFilterSuppliers.Checked = true;
            this.checkBoxFilterSuppliers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilterSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilterSuppliers.Location = new System.Drawing.Point(83, 66);
            this.checkBoxFilterSuppliers.Name = "checkBoxFilterSuppliers";
            this.checkBoxFilterSuppliers.Size = new System.Drawing.Size(378, 19);
            this.checkBoxFilterSuppliers.TabIndex = 32;
            this.checkBoxFilterSuppliers.Text = "Only show suppliers who currently offer the selected product type.";
            this.checkBoxFilterSuppliers.UseVisualStyleBackColor = true;
            this.checkBoxFilterSuppliers.CheckedChanged += new System.EventHandler(this.checkBoxFilterSuppliers_CheckedChanged);
            // 
            // btnAddProdSupp
            // 
            this.btnAddProdSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdSupp.Location = new System.Drawing.Point(617, 30);
            this.btnAddProdSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProdSupp.Name = "btnAddProdSupp";
            this.btnAddProdSupp.Size = new System.Drawing.Size(189, 38);
            this.btnAddProdSupp.TabIndex = 31;
            this.btnAddProdSupp.Text = "&Add New";
            this.btnAddProdSupp.UseVisualStyleBackColor = true;
            this.btnAddProdSupp.Click += new System.EventHandler(this.btnAddProdSupp_Click);
            // 
            // btnModifyProdSupp
            // 
            this.btnModifyProdSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProdSupp.Location = new System.Drawing.Point(617, 78);
            this.btnModifyProdSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyProdSupp.Name = "btnModifyProdSupp";
            this.btnModifyProdSupp.Size = new System.Drawing.Size(189, 38);
            this.btnModifyProdSupp.TabIndex = 30;
            this.btnModifyProdSupp.Text = "&Save";
            this.btnModifyProdSupp.UseVisualStyleBackColor = true;
            this.btnModifyProdSupp.Click += new System.EventHandler(this.btnModifyProdSupp_Click);
            // 
            // lblSelectedProdsTitle
            // 
            this.lblSelectedProdsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectedProdsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProdsTitle.Location = new System.Drawing.Point(29, 0);
            this.lblSelectedProdsTitle.Name = "lblSelectedProdsTitle";
            this.lblSelectedProdsTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblSelectedProdsTitle.Size = new System.Drawing.Size(804, 28);
            this.lblSelectedProdsTitle.TabIndex = 26;
            this.lblSelectedProdsTitle.Text = "Manage Selected Product:";
            this.lblSelectedProdsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leftbuff
            // 
            this.leftbuff.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftbuff.Location = new System.Drawing.Point(833, 0);
            this.leftbuff.Name = "leftbuff";
            this.leftbuff.Size = new System.Drawing.Size(29, 134);
            this.leftbuff.TabIndex = 25;
            // 
            // rightbuff
            // 
            this.rightbuff.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightbuff.Location = new System.Drawing.Point(0, 0);
            this.rightbuff.Name = "rightbuff";
            this.rightbuff.Size = new System.Drawing.Size(29, 134);
            this.rightbuff.TabIndex = 24;
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "ProductId", true));
            this.productIdComboBox.DataSource = this.productBindingSource;
            this.productIdComboBox.DisplayMember = "ProdName";
            this.productIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(181, 34);
            this.productIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(241, 24);
            this.productIdComboBox.TabIndex = 2;
            this.productIdComboBox.ValueMember = "ProductId";
            this.productIdComboBox.SelectedIndexChanged += new System.EventHandler(this.productIdComboBox_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // productSupplierIdTextBox
            // 
            this.productSupplierIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productSupplierIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productSupplierIdTextBox.Location = new System.Drawing.Point(34, 15);
            this.productSupplierIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productSupplierIdTextBox.Name = "productSupplierIdTextBox";
            this.productSupplierIdTextBox.Size = new System.Drawing.Size(118, 13);
            this.productSupplierIdTextBox.TabIndex = 4;
            this.productSupplierIdTextBox.Visible = false;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupName";
            this.supplierIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(181, 96);
            this.supplierIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(241, 24);
            this.supplierIdComboBox.TabIndex = 6;
            this.supplierIdComboBox.ValueMember = "SupplierId";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertDatabase.Supplier);
            // 
            // grdPackagesforProdSupp
            // 
            this.grdPackagesforProdSupp.AllowUserToAddRows = false;
            this.grdPackagesforProdSupp.AllowUserToDeleteRows = false;
            this.grdPackagesforProdSupp.AllowUserToResizeColumns = false;
            this.grdPackagesforProdSupp.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdPackagesforProdSupp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdPackagesforProdSupp.AutoGenerateColumns = false;
            this.grdPackagesforProdSupp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdPackagesforProdSupp.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.grdPackagesforProdSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPackagesforProdSupp.CausesValidation = false;
            this.grdPackagesforProdSupp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackagesforProdSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPackagesforProdSupp.ColumnHeadersHeight = 29;
            this.grdPackagesforProdSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageIdDataGridViewTextBoxColumn,
            this.pkgNameDataGridViewTextBoxColumn,
            this.pkgStartDateDataGridViewTextBoxColumn,
            this.pkgEndDateDataGridViewTextBoxColumn,
            this.pkgBasePriceDataGridViewTextBoxColumn,
            this.pkgAgencyCommissionDataGridViewTextBoxColumn,
            this.pkgDescDataGridViewTextBoxColumn});
            this.grdPackagesforProdSupp.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdPackagesforProdSupp.DataSource = this.packageBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPackagesforProdSupp.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdPackagesforProdSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdPackagesforProdSupp.EnableHeadersVisualStyles = false;
            this.grdPackagesforProdSupp.Location = new System.Drawing.Point(0, 313);
            this.grdPackagesforProdSupp.Margin = new System.Windows.Forms.Padding(2);
            this.grdPackagesforProdSupp.MultiSelect = false;
            this.grdPackagesforProdSupp.Name = "grdPackagesforProdSupp";
            this.grdPackagesforProdSupp.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackagesforProdSupp.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdPackagesforProdSupp.RowHeadersVisible = false;
            this.grdPackagesforProdSupp.RowHeadersWidth = 51;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackagesforProdSupp.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grdPackagesforProdSupp.RowTemplate.Height = 24;
            this.grdPackagesforProdSupp.ShowEditingIcon = false;
            this.grdPackagesforProdSupp.Size = new System.Drawing.Size(866, 90);
            this.grdPackagesforProdSupp.TabIndex = 27;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            this.packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.packageIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            this.packageIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // pkgNameDataGridViewTextBoxColumn
            // 
            this.pkgNameDataGridViewTextBoxColumn.DataPropertyName = "PkgName";
            this.pkgNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pkgNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgNameDataGridViewTextBoxColumn.Name = "pkgNameDataGridViewTextBoxColumn";
            this.pkgNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pkgStartDateDataGridViewTextBoxColumn
            // 
            this.pkgStartDateDataGridViewTextBoxColumn.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle7.Format = "MMM d, yyyy";
            this.pkgStartDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.pkgStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pkgStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgStartDateDataGridViewTextBoxColumn.Name = "pkgStartDateDataGridViewTextBoxColumn";
            this.pkgStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgEndDateDataGridViewTextBoxColumn
            // 
            this.pkgEndDateDataGridViewTextBoxColumn.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle8.Format = "MMM d, yyyy";
            this.pkgEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.pkgEndDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pkgEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgEndDateDataGridViewTextBoxColumn.Name = "pkgEndDateDataGridViewTextBoxColumn";
            this.pkgEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgBasePriceDataGridViewTextBoxColumn
            // 
            this.pkgBasePriceDataGridViewTextBoxColumn.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle9.Format = "C2";
            this.pkgBasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.pkgBasePriceDataGridViewTextBoxColumn.HeaderText = "Base Price";
            this.pkgBasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgBasePriceDataGridViewTextBoxColumn.Name = "pkgBasePriceDataGridViewTextBoxColumn";
            this.pkgBasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgBasePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn
            // 
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle10.Format = "C2";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.HeaderText = "Commission";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgDescDataGridViewTextBoxColumn
            // 
            this.pkgDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pkgDescDataGridViewTextBoxColumn.DataPropertyName = "PkgDesc";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pkgDescDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.pkgDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pkgDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgDescDataGridViewTextBoxColumn.Name = "pkgDescDataGridViewTextBoxColumn";
            this.pkgDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertDatabase.Package);
            // 
            // lblAssociatesPackages
            // 
            this.lblAssociatesPackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssociatesPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociatesPackages.Location = new System.Drawing.Point(0, 285);
            this.lblAssociatesPackages.Name = "lblAssociatesPackages";
            this.lblAssociatesPackages.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblAssociatesPackages.Size = new System.Drawing.Size(866, 28);
            this.lblAssociatesPackages.TabIndex = 28;
            this.lblAssociatesPackages.Text = "Associated Packages:";
            this.lblAssociatesPackages.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // body
            // 
            this.body.Controls.Add(this.checkboxFilterProducts);
            this.body.Controls.Add(this.pnlSubBody);
            this.body.Controls.Add(this.grdPackagesforProdSupp);
            this.body.Controls.Add(this.lblAssociatesPackages);
            this.body.Controls.Add(this.grdProductSuppliers);
            this.body.Controls.Add(this.label2);
            this.body.Dock = System.Windows.Forms.DockStyle.Top;
            this.body.Location = new System.Drawing.Point(17, 75);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(866, 541);
            this.body.TabIndex = 21;
            // 
            // checkboxFilterProducts
            // 
            this.checkboxFilterProducts.AutoSize = true;
            this.checkboxFilterProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxFilterProducts.Location = new System.Drawing.Point(133, 0);
            this.checkboxFilterProducts.Name = "checkboxFilterProducts";
            this.checkboxFilterProducts.Size = new System.Drawing.Size(253, 19);
            this.checkboxFilterProducts.TabIndex = 29;
            this.checkboxFilterProducts.Text = "Only show products currently in packages.";
            this.checkboxFilterProducts.UseVisualStyleBackColor = true;
            this.checkboxFilterProducts.CheckedChanged += new System.EventHandler(this.checkboxFilterProducts_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 616);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(866, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Other Actions:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // frmProdSupplierAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.body);
            this.Controls.Add(this.mainRightBuff);
            this.Controls.Add(this.mainLeftBuff);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnManageSupps);
            this.Controls.Add(this.btnManageProds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProdSupplierAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.frmProdSupplierAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductSuppliers)).EndInit();
            this.pnlSubBody.ResumeLayout(false);
            this.pnlSubBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackagesforProdSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnManageProds;
        private System.Windows.Forms.Button btnManageSupps;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource packagesProductsSuppliersBindingSource;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel mainLeftBuff;
        private System.Windows.Forms.Panel mainRightBuff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdProductSuppliers;
        private System.Windows.Forms.Panel pnlSubBody;
        private System.Windows.Forms.Panel leftbuff;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSelectedProdsTitle;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.TextBox productSupplierIdTextBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.DataGridView grdPackagesforProdSupp;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.Panel rightbuff;
        private System.Windows.Forms.Label lblAssociatesPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModifyProdSupp;
        private System.Windows.Forms.Button btnAddProdSupp;
        private System.Windows.Forms.CheckBox checkBoxFilterSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxFilterProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
    }
}