
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
            System.Windows.Forms.Label productSupplierIdLabel1;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdSupplierAddEdit));
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.products_SupplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.products_SupplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnManageProds = new System.Windows.Forms.Button();
            this.btnManageSupps = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.productSupplierIdTextBox1 = new System.Windows.Forms.TextBox();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            productSupplierIdLabel1 = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingNavigator)).BeginInit();
            this.products_SupplierBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productSupplierIdLabel1
            // 
            productSupplierIdLabel1.AutoSize = true;
            productSupplierIdLabel1.Location = new System.Drawing.Point(24, 49);
            productSupplierIdLabel1.Name = "productSupplierIdLabel1";
            productSupplierIdLabel1.Size = new System.Drawing.Size(132, 17);
            productSupplierIdLabel1.TabIndex = 12;
            productSupplierIdLabel1.Text = "Product Supplier Id:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(24, 168);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(83, 17);
            prodNameLabel.TabIndex = 16;
            prodNameLabel.Text = "Prod Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(29, 222);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(78, 17);
            supNameLabel.TabIndex = 20;
            supNameLabel.Text = "Sup Name:";
            // 
            // products_SupplierBindingNavigator
            // 
            this.products_SupplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.products_SupplierBindingNavigator.BindingSource = this.products_SupplierBindingSource;
            this.products_SupplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.products_SupplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.products_SupplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.products_SupplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.products_SupplierBindingNavigatorSaveItem});
            this.products_SupplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.products_SupplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.products_SupplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.products_SupplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.products_SupplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.products_SupplierBindingNavigator.Name = "products_SupplierBindingNavigator";
            this.products_SupplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.products_SupplierBindingNavigator.Size = new System.Drawing.Size(633, 27);
            this.products_SupplierBindingNavigator.TabIndex = 0;
            this.products_SupplierBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(TravelExpertDatabase.Products_Supplier);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // products_SupplierBindingNavigatorSaveItem
            // 
            this.products_SupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.products_SupplierBindingNavigatorSaveItem.Enabled = false;
            this.products_SupplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("products_SupplierBindingNavigatorSaveItem.Image")));
            this.products_SupplierBindingNavigatorSaveItem.Name = "products_SupplierBindingNavigatorSaveItem";
            this.products_SupplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.products_SupplierBindingNavigatorSaveItem.Text = "Save Data";
            this.products_SupplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.products_SupplierBindingNavigatorSaveItem_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertDatabase.Supplier);
            // 
            // btnManageProds
            // 
            this.btnManageProds.Location = new System.Drawing.Point(447, 91);
            this.btnManageProds.Name = "btnManageProds";
            this.btnManageProds.Size = new System.Drawing.Size(153, 30);
            this.btnManageProds.TabIndex = 7;
            this.btnManageProds.Text = "Manage Products";
            this.btnManageProds.UseVisualStyleBackColor = true;
            this.btnManageProds.Click += new System.EventHandler(this.btnManageProds_Click);
            // 
            // btnManageSupps
            // 
            this.btnManageSupps.Location = new System.Drawing.Point(447, 155);
            this.btnManageSupps.Name = "btnManageSupps";
            this.btnManageSupps.Size = new System.Drawing.Size(153, 30);
            this.btnManageSupps.TabIndex = 8;
            this.btnManageSupps.Text = "Manage Suppliers";
            this.btnManageSupps.UseVisualStyleBackColor = true;
            this.btnManageSupps.Click += new System.EventHandler(this.btnManageSupps_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(501, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // productSupplierIdTextBox1
            // 
            this.productSupplierIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "ProductSupplierId", true));
            this.productSupplierIdTextBox1.Location = new System.Drawing.Point(162, 46);
            this.productSupplierIdTextBox1.Name = "productSupplierIdTextBox1";
            this.productSupplierIdTextBox1.Size = new System.Drawing.Size(121, 22);
            this.productSupplierIdTextBox1.TabIndex = 13;
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "Product.ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(113, 165);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(254, 22);
            this.prodNameTextBox.TabIndex = 17;
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "Supplier.SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(114, 219);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.Size = new System.Drawing.Size(253, 22);
            this.supNameTextBox.TabIndex = 21;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(80, 80);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(76, 17);
            productIdLabel.TabIndex = 21;
            productIdLabel.Text = "Product Id:";
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "ProductId", true));
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(162, 77);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.productIdComboBox.TabIndex = 22;
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(77, 116);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(79, 17);
            supplierIdLabel.TabIndex = 22;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "SupplierId", true));
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(162, 113);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.supplierIdComboBox.TabIndex = 23;
            // 
            // frmProdSupplierAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 327);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdComboBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdComboBox);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameTextBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(productSupplierIdLabel1);
            this.Controls.Add(this.productSupplierIdTextBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnManageSupps);
            this.Controls.Add(this.btnManageProds);
            this.Controls.Add(this.products_SupplierBindingNavigator);
            this.Name = "frmProdSupplierAddEdit";
            this.Text = "frmProdSupplierAddEdit";
            this.Load += new System.EventHandler(this.frmProdSupplierAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingNavigator)).EndInit();
            this.products_SupplierBindingNavigator.ResumeLayout(false);
            this.products_SupplierBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.BindingNavigator products_SupplierBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton products_SupplierBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnManageProds;
        private System.Windows.Forms.Button btnManageSupps;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox productSupplierIdTextBox1;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
    }
}