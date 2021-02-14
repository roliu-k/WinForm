using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    // This should allow adding a Product Supplier ID from a combination of Product ID and Supplier to the Package.
    // All IDs should already exist - if not, they are added on their respective forms.

    public partial class frmProdSupplier : Form
    {

        // Class-level variables
        public Package currentPackage;

        public frmProdSupplier()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: this should only work if the product/supplier doesn't already exist!!


            // Get ProductSupplierID from combobox
            int prodSupID = Convert.ToInt32(productSupplierIdTextBox.Text);

            // Create a PackagesProductSupplier with that ID, and the Package ID from the current package
            Packages_Products_Supplier newPackProdSup = new Packages_Products_Supplier
            {
                ProductSupplierId = prodSupID,
                PackageId = currentPackage.PackageId
            };

            // Add that PackagesProductsSupplier to the db
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                // insert through data context object from the main form
                dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPackProdSup);
                dbContext.SubmitChanges(); // submit to the database
            }

            // Re-load the datagrid view
            refreshDataGrid();
        }

        //Delete from GridView so it won't add to database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Grab data from selected cell on gridview
            int rowNum = grdProdSup.CurrentCell.RowIndex; // index of the current row
            int prodSuppID = Convert.ToInt32(grdProdSup[0, rowNum].Value); // Column for ProductSupplierID


            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                //
                Packages_Products_Supplier packProdSupForRemoval = (from match in dbContext.Packages_Products_Suppliers
                                                          where (match.ProductSupplierId == prodSuppID
                                                          && match.PackageId == currentPackage.PackageId)
                                                          select match).Single();

                dbContext.Packages_Products_Suppliers.DeleteOnSubmit(packProdSupForRemoval);
                dbContext.SubmitChanges(); // submit to the database
            }
            refreshDataGrid();
        }

        //Save changes, add to database, close window
        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmProdSupplier_Load(object sender, EventArgs e)
        {
            // Populate data grid showing products
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                refreshDataGrid();

                // display the list of selection for products and suppliers 
                prodNameComboBox.DataSource = db.Products;
                prodNameComboBox.DisplayMember = "ProdName";
                prodNameComboBox.ValueMember = "ProductId";


                supNameComboBox.DataSource = db.Suppliers;
                supNameComboBox.DisplayMember = "SupName";
                supNameComboBox.ValueMember = "SupplierId";

            }

            lblDesc.Text = $"Add or remove associated products from this package (ID#{currentPackage.PackageId}: {currentPackage.PkgName})";
            
            
        }



        private void refreshDataGrid()
        {
            // Populate data grid showing products
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                grdProdSup.DataSource = TravelExpertsQueryManager.FindProdInfoByPackage(db, currentPackage.PackageId);
            }
        }

        private void DisplayProdSupId()
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                int prodId = Convert.ToInt32(prodNameComboBox.SelectedValue);
                int supId = Convert.ToInt32(supNameComboBox.SelectedValue);

                productSupplierIdTextBox.Text = TravelExpertsQueryManager.FindProdSuppID(db,prodId, supId).ToString();

            }
        }

        private void prodNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // get the list of suppliers applicable with the selected product ID
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {

                supNameComboBox.DataSource = TravelExpertsQueryManager.GetSuppliersByProductID(db, Convert.ToInt32(prodNameComboBox.SelectedValue));

                DisplayProdSupId();
            }
        }

        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayProdSupId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
