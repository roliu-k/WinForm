
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packages_Products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProdSup = new System.Windows.Forms.DataGridView();
            this.packageRelatedTableDataStructureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageRelatedTableDataStructureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(8, 68);
            prodNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(83, 16);
            prodNameLabel.TabIndex = 23;
            prodNameLabel.Text = "Prod. Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.Location = new System.Drawing.Point(8, 133);
            supNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(86, 16);
            supNameLabel.TabIndex = 24;
            supNameLabel.Text = "Supp. Name:";
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productSupplierIdLabel.Location = new System.Drawing.Point(10, 179);
            productSupplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(225, 16);
            productSupplierIdLabel.TabIndex = 25;
            productSupplierIdLabel.Text = "ID for this product/supplier pair:";
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
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(156, 243);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(256, 36);
            this.btnDone.TabIndex = 20;
            this.btnDone.Text = "&Save";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(432, 82);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 44);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(432, 145);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 44);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "<<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "ProductId", true));
            this.prodNameComboBox.DataSource = this.productBindingSource1;
            this.prodNameComboBox.DisplayMember = "ProdName";
            this.prodNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(95, 65);
            this.prodNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(287, 24);
            this.prodNameComboBox.TabIndex = 24;
            this.prodNameComboBox.ValueMember = "ProductId";
            this.prodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodNameComboBox_SelectedIndexChanged);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // supNameComboBox
            // 
            this.supNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "SupplierId", true));
            this.supNameComboBox.DataSource = this.supplierBindingSource1;
            this.supNameComboBox.DisplayMember = "SupName";
            this.supNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameComboBox.FormattingEnabled = true;
            this.supNameComboBox.Location = new System.Drawing.Point(95, 130);
            this.supNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.supNameComboBox.Name = "supNameComboBox";
            this.supNameComboBox.Size = new System.Drawing.Size(287, 24);
            this.supNameComboBox.TabIndex = 25;
            this.supNameComboBox.ValueMember = "SupplierId";
            this.supNameComboBox.SelectedIndexChanged += new System.EventHandler(this.supNameComboBox_SelectedIndexChanged);
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataSource = typeof(TravelExpertDatabase.Supplier);
            // 
            // productSupplierIdTextBox
            // 
            this.productSupplierIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productSupplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "ProductSupplierId", true));
            this.productSupplierIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSupplierIdTextBox.Location = new System.Drawing.Point(238, 180);
            this.productSupplierIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productSupplierIdTextBox.Name = "productSupplierIdTextBox";
            this.productSupplierIdTextBox.ReadOnly = true;
            this.productSupplierIdTextBox.Size = new System.Drawing.Size(124, 15);
            this.productSupplierIdTextBox.TabIndex = 26;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblDesc);
            this.Header.Controls.Add(this.lblTitle);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1118, 75);
            this.Header.TabIndex = 27;
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(0, 51);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDesc.Size = new System.Drawing.Size(1118, 21);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Add or remove associated products from this package.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblTitle.Size = new System.Drawing.Size(1118, 51);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Package Manager - Add or Edit Package";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // body
            // 
            this.body.Controls.Add(this.label3);
            this.body.Controls.Add(this.btnCancel);
            this.body.Controls.Add(this.panel3);
            this.body.Controls.Add(this.btnAdd);
            this.body.Controls.Add(this.btnDone);
            this.body.Controls.Add(this.panel1);
            this.body.Controls.Add(this.btnDelete);
            this.body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.body.Location = new System.Drawing.Point(0, 81);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1118, 300);
            this.body.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(505, 243);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(256, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.grdProdSup);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(505, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 217);
            this.panel3.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Current products in this package:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(productSupplierIdLabel);
            this.panel1.Controls.Add(this.productSupplierIdTextBox);
            this.panel1.Controls.Add(supNameLabel);
            this.panel1.Controls.Add(this.prodNameComboBox);
            this.panel1.Controls.Add(this.supNameComboBox);
            this.panel1.Controls.Add(prodNameLabel);
            this.panel1.Location = new System.Drawing.Point(10, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 217);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select a product to add:";
            // 
            // grdProdSup
            // 
            this.grdProdSup.AllowUserToAddRows = false;
            this.grdProdSup.AllowUserToDeleteRows = false;
            this.grdProdSup.AllowUserToResizeColumns = false;
            this.grdProdSup.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdProdSup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProdSup.AutoGenerateColumns = false;
            this.grdProdSup.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdProdSup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProdSup.CausesValidation = false;
            this.grdProdSup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProdSup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProdSup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSupplierId,
            this.productIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.grdProdSup.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdProdSup.DataSource = this.packageRelatedTableDataStructureBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProdSup.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdProdSup.EnableHeadersVisualStyles = false;
            this.grdProdSup.Location = new System.Drawing.Point(12, 39);
            this.grdProdSup.Margin = new System.Windows.Forms.Padding(2);
            this.grdProdSup.MultiSelect = false;
            this.grdProdSup.Name = "grdProdSup";
            this.grdProdSup.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProdSup.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdProdSup.RowHeadersVisible = false;
            this.grdProdSup.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProdSup.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdProdSup.RowTemplate.Height = 24;
            this.grdProdSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdSup.ShowEditingIcon = false;
            this.grdProdSup.Size = new System.Drawing.Size(575, 129);
            this.grdProdSup.TabIndex = 29;
            // 
            // packageRelatedTableDataStructureBindingSource
            // 
            this.packageRelatedTableDataStructureBindingSource.DataSource = typeof(TravelExpertDatabase.PackageRelatedTableDataStructure);
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "ID";
            this.ProductSupplierId.Name = "ProductSupplierId";
            this.ProductSupplierId.ReadOnly = true;
            this.ProductSupplierId.Width = 50;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Prod. ID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Supp. ID";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "Add /\r\nRemove";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "1. Select a type of product:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "2. Choose a vendor supplying that product.";
            // 
            // frmProdSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 381);
            this.Controls.Add(this.body);
            this.Controls.Add(this.Header);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProdSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdSupplier";
            this.Load += new System.EventHandler(this.frmProdSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            this.Header.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageRelatedTableDataStructureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource packages_Products_SupplierBindingSource;
        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox1;
        private System.Windows.Forms.ComboBox productSupplierIdComboBox;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.ComboBox supNameComboBox;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private System.Windows.Forms.TextBox productSupplierIdTextBox;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProdSup;
        private System.Windows.Forms.BindingSource packageRelatedTableDataStructureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodSuppIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}