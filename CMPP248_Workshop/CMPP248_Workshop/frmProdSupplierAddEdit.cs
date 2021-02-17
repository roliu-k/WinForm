using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    //Create a new ProductSupplier ID through a product Id and supplier Id

    public partial class frmProdSupplierAddEdit : Form
    {
        // Class - level variables
        int selectedProdID; // keeps track of the product_supplier ID in the row selected of the products_suppliers datagrid
        bool addMode = false; // bool that keeps track of whether the user is adding or updating a product_supplier

        public frmProdSupplierAddEdit()
        {
            InitializeComponent();
        }
        private void frmProdSupplierAddEdit_Load(object sender, EventArgs e)
        {
            // On load, populate data for all data displays
            travelexpertsDataContext dbContext = new travelexpertsDataContext(); // create a new context
            products_SupplierBindingSource.DataSource = dbContext.Products_Suppliers; //get product_supplier data for top datagrid

            selectedProdID = Convert.ToInt32(grdProductSuppliers.Rows[0].Cells[0].Value); // set selectedProdID as ID of top row
            lblSelectedProdsTitle.Text = $"Modify details for selected product (ID #{selectedProdID})"; // Set display for that ID

            supplierIdComboBox.DataSource = dbContext.Suppliers; // get supplier data for suppliers details dropbox
            productIdComboBox.DataSource = dbContext.Products;  // get product data for products details dropbox
            RefreshPackagesByProdSuppGrid(); // get package data for selected product_supplier row (in this case, top one)



        }

        //Opens Products Form
        private void btnManageProds_Click(object sender, EventArgs e)
        {
            frmProducts frmProds = new frmProducts();
            frmProds.Show();
        }

        //Opens Suppliers Form
        private void btnManageSupps_Click(object sender, EventArgs e)
        {
            frmSuppliers frmSupps = new frmSuppliers();
            frmSupps.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Whenever a cell is being formatted (during data bind), this will trigger,
        // looking for cells where the DataProperty name includes a "." and running a custom function.
        //  The result is the ability to display specific properties of a nested entity using dot notation.
        // (ex. getting "Product.ProdName" from a Product_Supplier entity).
        // Code with thanks from Antonio Bello on http://www.developer-corner.com/blog/2007/07/19/datagridview-how-to-bind-nested-objects/
        // Clarifying comments by [Eric]
        private void grdProductSuppliers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check to see if the currently formatted cell has a DataPropertyName with a dot in it.
            // By default they will not, but this can be changed in the design mode of the datagrid.
            if ((grdProductSuppliers.Rows[e.RowIndex].DataBoundItem != null) &&
            (grdProductSuppliers.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                // instead of just giving it the value (which the datagrid won't accept, run a function to grab the notated property)
                e.Value = BindProperty(
                              grdProductSuppliers.Rows[e.RowIndex].DataBoundItem, //this is the actual property bound (going to be a nested entity)
                              grdProductSuppliers.Columns[e.ColumnIndex].DataPropertyName // this is going to be the dot notation in the form of Entity.Property
                            );
            }
        }

        // The function associated with the CellFormatting event above, which actuall gets the associated property to display
        // Thanks again to Antonio Bello on http://www.developer-corner.com/blog/2007/07/19/datagridview-how-to-bind-nested-objects/
        private string BindProperty(object property, string propertyName)
        {
            string retValue = ""; // initialize value to return

            // check if DataPropertyName is indeed in dot notation form
            if (propertyName.Contains(".")) 
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf(".")); // get the property name defined in the dot notation
                arrayProperties = property.GetType().GetProperties(); // get all properties in the entity 

                // Iterate through all properties of the entity, looking for the one named in the DataPropertyName
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName) 
                    {
                        // With a match, set the return value to provide to the cell as that property
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else // In case the method is passed a DataPropertyName without dot notation. Thanks to the if clause in the event handler, it shouldn't
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

        // Fires every time a cell is clicked in the product_suppliers datagrid
        private void grdProductSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Put form in modify mode
            addMode = false;
            btnAddProdSupp.Enabled = true; //enable add button if disabled

           // Grab ID of the row currently selected in the Prod_Supp datagrid
           selectedProdID = Convert.ToInt32(grdProductSuppliers.CurrentRow.Cells[0].Value);

            // Set title for the products details below using that current id
            lblSelectedProdsTitle.Text = $"Modify details for selected product (ID #{selectedProdID})";

            // re-bind data 
            RefreshPackagesByProdSuppGrid(); // for associated packages datagrid
            DisplayProdSupId(); //for product_supplier ID


        }
        /// <summary>
        /// Refreshes data for the associated packages datagrid, based on current selected row in prod_supp grid
        /// </summary>
        private void RefreshPackagesByProdSuppGrid()
        {
            //// Grab ID of the row currently selected in the Prod_Supp datagrid
            //selectedProdID = Convert.ToInt32(grdProductSuppliers.CurrentRow.Cells[0].Value);

            // Set title for the products data using that current id
            lblAssociatesPackages.Text = $"Associated Packages for selected product (ID #{selectedProdID})";

            // Use a query to get only packages associated with the prod_supp id, and bind it to the grid
            grdPackagesforProdSupp.DataSource = TravelExpertsQueryManager.GetPackagesByProdSuppID(selectedProdID);
        }

        private void btnModifyProdSupp_Click(object sender, EventArgs e)
        {
            // Get user inputs
            int newProdId = Convert.ToInt32(productIdComboBox.SelectedValue);
            int newSupID = Convert.ToInt32(supplierIdComboBox.SelectedValue);
            // grab data from dropdown selectedvalues & hidden id field (productSupplierIdTextBox)
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                if (addMode == false) // if modifying
                {

                    // Get current product supplier ID
                    int prodSupID = Convert.ToInt32(productSupplierIdTextBox.Text);

                    // Grab the current entry from the database
                    Products_Supplier prodSup = db.Products_Suppliers
                        .Single(ps => ps.ProductSupplierId == prodSupID);

                    // Validate by ensuring this unique combination isn't in the database
                    var matchingProps = db.Products_Suppliers // search the Products_Suppliers table for entries...
                        .Where(ps => ps.ProductId == newProdId) // ...matching the new product id...
                        .Where(ps => ps.SupplierId == newSupID)// ... and matching the new supplier id...
                        .Where(ps => ps.ProductSupplierId != prodSupID) //... but with a different prodsupplierID
                        .FirstOrDefault(); // We can stop at the first, though there won't be more than one

                    // If no match was found, we're good
                    if(matchingProps == null)
                    {
                        // Update with inputted values
                        prodSup.ProductId = newProdId;
                        prodSup.SupplierId = newSupID;
                        db.SubmitChanges();

                    }
                    else // there is a match for the product/supplier combo
                    {
                        //Give the user the option to change to this combination anyway (this will move all associated packages to the matching Product_Supplier)
                        DialogResult result = MessageBox.Show($"That product/supplier combination already exists (ID #{matchingProps.ProductSupplierId}). Would you like to change to this combination for all associated packages?", 
                            "Existing Product/Supplier", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes )
                        {
                            // Get all Package_Product_Suppliers entries that refer to the current ProdSup ID (these will need to be modified)
                            List<Packages_Products_Supplier> ppsWithCurrentProdSupID = db.Packages_Products_Suppliers.Where(pps => pps.ProductSupplierId == prodSupID).ToList();

                            // Go through each, updating the ProdSupID to the existing combination
                            foreach(Packages_Products_Supplier pps in ppsWithCurrentProdSupID)
                            {
                                // We can't directly update ProdSupID in an existing entry as it is part of the entry's Primary key. 
                                //Instead, we have to delete it and create a new one.
                                int currentPackageId = pps.PackageId; // to keep track of the package ID
                                db.Packages_Products_Suppliers.DeleteOnSubmit(pps);
                                db.SubmitChanges(); // have to submit changes here otherwise we can't create a new one

                                try
                                {
                                    using (travelexpertsDataContext db2 = new travelexpertsDataContext())
                                    {
                                        // Now, create a new PPS using the PPS and the new ProdSupID
                                        Packages_Products_Supplier newPps = new Packages_Products_Supplier
                                        {
                                            PackageId = currentPackageId, // the same package id
                                            ProductSupplierId = matchingProps.ProductSupplierId // the prod_sup id that matches what the user wants to change it to
                                        };
                                        db2.Packages_Products_Suppliers.InsertOnSubmit(newPps);
                                        db2.SubmitChanges();
                                    }
                                }
                                catch { }                    
                            }
                        }
                    }
                    // Reload data
                    travelexpertsDataContext dbContext = new travelexpertsDataContext(); // create a new context
                    products_SupplierBindingSource.DataSource = dbContext.Products_Suppliers; //get product_supplier data for top datagrid
                    RefreshPackagesByProdSuppGrid();
                } // end modify   

                else // if in add mode
                {
                    // create a new Product_Supplier with the data
                    Products_Supplier newProdSup = new Products_Supplier
                    {
                        ProductId = newProdId,
                        SupplierId = newSupID
                    };

                    // insert into db and save
                    db.Products_Suppliers.InsertOnSubmit(newProdSup);
                    db.SubmitChanges();

                    // Re-enable Add new button
                    btnAddProdSupp.Enabled = true;
                }
            }

        }

        private void btnAddProdSupp_Click(object sender, EventArgs e)
        {
            // put form in add mode
            addMode = true;

            // Set up display for add mode
            lblAssociatesPackages.Text = "";
            lblSelectedProdsTitle.Text = $"Add details for new product.";

            btnAddProdSupp.Enabled = false; // disable button until leaving add mode to make things clearer for user


            // Put combo boxes in default state
            productIdComboBox.SelectedIndex = 0;
            supplierIdComboBox.SelectedIndex = 0;

            // clear associated packages
            grdPackagesforProdSupp.DataSource = null;
        }

        private void productIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                // If the user has selected the option to filter suppliers
                if (checkBoxFilterSuppliers.Checked == true)
                {
                    // Get the list of suppliers applicable with the selected product ID
                    supplierIdComboBox.DataSource = TravelExpertsQueryManager.GetSuppliersByProductID(db, Convert.ToInt32(productIdComboBox.SelectedValue));

                    DisplayProdSupId();
                }
                else
                {
                    supplierIdComboBox.DataSource = db.Suppliers; // get supplier data for suppliers details dropbox
                }
            }
        }

        // Updates the display of the prodsuppID
        private void DisplayProdSupId()
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                int prodId = Convert.ToInt32(productIdComboBox.SelectedValue); // grabs id from product dropdown
                int supId = Convert.ToInt32(supplierIdComboBox.SelectedValue); // grabs id from supplier dropdown

                productSupplierIdTextBox.Text = TravelExpertsQueryManager.FindProdSuppID(db, prodId, supId).ToString(); // uses that data to grab the corresponding prodsup id

            }
        }

        // Toggling the checkbox that filters supplier names automatically updates the combobox (by firing the index change event of the product combobox)
        private void checkBoxFilterSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            productIdComboBox_SelectedIndexChanged(sender, e);
        }
    }
}
