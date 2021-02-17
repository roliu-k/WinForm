
namespace CMPP248_Workshop
{
    partial class frmPackages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.grdPackages = new System.Windows.Forms.DataGridView();
            this.packageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgBasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgAgencyCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.pnlSubBody = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageRelatedTableDataStructureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectedProdsTitle = new System.Windows.Forms.Label();
            this.leftbuff = new System.Windows.Forms.Panel();
            this.rightbuff = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainRightBuff = new System.Windows.Forms.Panel();
            this.mainLeftBuff = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.pnlSubBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageRelatedTableDataStructureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(68, 477);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Add New Package...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(410, 477);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(256, 36);
            this.btnModify.TabIndex = 16;
            this.btnModify.Text = "&Modify Selected Package...";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grdPackages
            // 
            this.grdPackages.AllowUserToAddRows = false;
            this.grdPackages.AllowUserToDeleteRows = false;
            this.grdPackages.AllowUserToResizeColumns = false;
            this.grdPackages.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdPackages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grdPackages.AutoGenerateColumns = false;
            this.grdPackages.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPackages.CausesValidation = false;
            this.grdPackages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageIdDataGridViewTextBoxColumn,
            this.pkgNameDataGridViewTextBoxColumn,
            this.pkgStartDateDataGridViewTextBoxColumn,
            this.pkgEndDateDataGridViewTextBoxColumn,
            this.pkgBasePriceDataGridViewTextBoxColumn,
            this.pkgAgencyCommissionDataGridViewTextBoxColumn,
            this.pkgDescDataGridViewTextBoxColumn});
            this.grdPackages.DataSource = this.packageBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPackages.DefaultCellStyle = dataGridViewCellStyle23;
            this.grdPackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdPackages.EnableHeadersVisualStyles = false;
            this.grdPackages.Location = new System.Drawing.Point(0, 23);
            this.grdPackages.Margin = new System.Windows.Forms.Padding(15);
            this.grdPackages.MultiSelect = false;
            this.grdPackages.Name = "grdPackages";
            this.grdPackages.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackages.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.grdPackages.RowHeadersVisible = false;
            this.grdPackages.RowHeadersWidth = 51;
            this.grdPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPackages.Size = new System.Drawing.Size(1045, 224);
            this.grdPackages.TabIndex = 20;
            this.grdPackages.TabStop = false;
            this.grdPackages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPackages_CellClick);
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            this.packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.packageIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
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
            this.pkgStartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pkgStartDateDataGridViewTextBoxColumn.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle18.Format = "MMM d, yyyy";
            this.pkgStartDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.pkgStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pkgStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgStartDateDataGridViewTextBoxColumn.Name = "pkgStartDateDataGridViewTextBoxColumn";
            this.pkgStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgStartDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // pkgEndDateDataGridViewTextBoxColumn
            // 
            this.pkgEndDateDataGridViewTextBoxColumn.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle19.Format = "MMM d, yyyy";
            this.pkgEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.pkgEndDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pkgEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgEndDateDataGridViewTextBoxColumn.Name = "pkgEndDateDataGridViewTextBoxColumn";
            this.pkgEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgEndDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // pkgBasePriceDataGridViewTextBoxColumn
            // 
            this.pkgBasePriceDataGridViewTextBoxColumn.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.pkgBasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.pkgBasePriceDataGridViewTextBoxColumn.HeaderText = "Base Price";
            this.pkgBasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgBasePriceDataGridViewTextBoxColumn.Name = "pkgBasePriceDataGridViewTextBoxColumn";
            this.pkgBasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgBasePriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn
            // 
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = null;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.HeaderText = "Commission";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.Width = 115;
            // 
            // pkgDescDataGridViewTextBoxColumn
            // 
            this.pkgDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pkgDescDataGridViewTextBoxColumn.DataPropertyName = "PkgDesc";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pkgDescDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.pkgDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pkgDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgDescDataGridViewTextBoxColumn.Name = "pkgDescDataGridViewTextBoxColumn";
            this.pkgDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertDatabase.Package);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1079, 75);
            this.Header.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 51);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(389, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select any package to view its product details beneath.";
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
            this.Title.Size = new System.Drawing.Size(1079, 51);
            this.Title.TabIndex = 19;
            this.Title.Text = "Package Manager - View Packages";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // body
            // 
            this.body.Controls.Add(this.pnlSubBody);
            this.body.Controls.Add(this.grdPackages);
            this.body.Controls.Add(this.label2);
            this.body.Dock = System.Windows.Forms.DockStyle.Top;
            this.body.Location = new System.Drawing.Point(17, 75);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1045, 377);
            this.body.TabIndex = 20;
            // 
            // pnlSubBody
            // 
            this.pnlSubBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSubBody.Controls.Add(this.dataGridView1);
            this.pnlSubBody.Controls.Add(this.lblSelectedProdsTitle);
            this.pnlSubBody.Controls.Add(this.leftbuff);
            this.pnlSubBody.Controls.Add(this.rightbuff);
            this.pnlSubBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubBody.Location = new System.Drawing.Point(0, 247);
            this.pnlSubBody.Name = "pnlSubBody";
            this.pnlSubBody.Size = new System.Drawing.Size(1045, 130);
            this.pnlSubBody.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.packageRelatedTableDataStructureBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(200, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(641, 96);
            this.dataGridView1.TabIndex = 23;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier Id";
            this.supplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageRelatedTableDataStructureBindingSource
            // 
            this.packageRelatedTableDataStructureBindingSource.DataSource = typeof(TravelExpertDatabase.PackageRelatedTableDataStructure);
            // 
            // lblSelectedProdsTitle
            // 
            this.lblSelectedProdsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectedProdsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProdsTitle.Location = new System.Drawing.Point(200, 0);
            this.lblSelectedProdsTitle.Name = "lblSelectedProdsTitle";
            this.lblSelectedProdsTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblSelectedProdsTitle.Size = new System.Drawing.Size(641, 28);
            this.lblSelectedProdsTitle.TabIndex = 22;
            this.lblSelectedProdsTitle.Text = "Selected Package Products:";
            // 
            // leftbuff
            // 
            this.leftbuff.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftbuff.Location = new System.Drawing.Point(841, 0);
            this.leftbuff.Name = "leftbuff";
            this.leftbuff.Size = new System.Drawing.Size(200, 126);
            this.leftbuff.TabIndex = 25;
            // 
            // rightbuff
            // 
            this.rightbuff.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightbuff.Location = new System.Drawing.Point(0, 0);
            this.rightbuff.Name = "rightbuff";
            this.rightbuff.Size = new System.Drawing.Size(200, 126);
            this.rightbuff.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current Package Details:";
            // 
            // mainRightBuff
            // 
            this.mainRightBuff.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainRightBuff.Location = new System.Drawing.Point(1062, 75);
            this.mainRightBuff.Name = "mainRightBuff";
            this.mainRightBuff.Size = new System.Drawing.Size(17, 468);
            this.mainRightBuff.TabIndex = 26;
            // 
            // mainLeftBuff
            // 
            this.mainLeftBuff.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainLeftBuff.Location = new System.Drawing.Point(0, 75);
            this.mainLeftBuff.Name = "mainLeftBuff";
            this.mainLeftBuff.Size = new System.Drawing.Size(17, 468);
            this.mainLeftBuff.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(743, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.body);
            this.Controls.Add(this.mainLeftBuff);
            this.Controls.Add(this.mainRightBuff);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Manager - View Packages";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.pnlSubBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageRelatedTableDataStructureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.DataGridView packageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView grdPackages;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedProdsTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource packageRelatedTableDataStructureBindingSource;
        private System.Windows.Forms.Panel pnlSubBody;
        private System.Windows.Forms.Panel leftbuff;
        private System.Windows.Forms.Panel rightbuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel mainRightBuff;
        private System.Windows.Forms.Panel mainLeftBuff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

