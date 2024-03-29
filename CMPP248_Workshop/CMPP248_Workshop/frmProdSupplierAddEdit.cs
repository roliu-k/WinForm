﻿using System;
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
    // Foundation by Holly.
    // Fleshed-out functionality and layout by Eric.

    public partial class frmProdSupplierAddEdit : Form
    {
        // Class - level variables
        int selectedProdID; // keeps track of the product_supplier ID in the row selected of the products_suppliers datagrid
        bool addMode = false; // bool that keeps track of whether the user is adding or updating a product_supplier
        travelexpertsDataContext rootDB; //need one context that persists for data binding

        public frmProdSupplierAddEdit()
        {
            InitializeComponent();
        }

        // Initial form setup
        private void frmProdSupplierAddEdit_Load(object sender, EventArgs e)
        {
            // On load, populate data for all data displays
            rootDB = new travelexpertsDataContext(); // create a new context

            //get product_supplier data for top datagrid
            products_SupplierBindingSource.DataSource = TravelExpertsQueryManager.GetProductsSuppliersExtended(rootDB);

            selectedProdID = Convert.ToInt32(grdProductSuppliers.Rows[0].Cells[0].Value); // set selectedProdID as ID of top row
            lblSelectedProdsTitle.Text = $"Modify details for selected product (ID #{selectedProdID})"; // Set display for that ID

            supplierIdComboBox.DataSource = rootDB.Suppliers; // get supplier data for suppliers details dropbox
            productIdComboBox.DataSource = rootDB.Products;  // get product data for products details dropbox
            RefreshPackagesByProdSuppGrid(); // get package data for selected product_supplier row (in this case, top one)
            SetDataGridToFirstEntry(); // Selects the first row of the main datagrid

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
   

        // Fires every time a cell is clicked in the product_suppliers datagrid
        private void grdProductSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Put form in modify mode
            addMode = false;
            btnAddProdSupp.Enabled = true; //enable add button if disabled

           // Grab ID of the row currently selected in the Prod_Supp datagrid
           selectedProdID = Convert.ToInt32(grdProductSuppliers.SelectedRows[0].Cells[0].Value);

            // Set title for the products details below using that current id
            lblSelectedProdsTitle.Text = $"Modify details for selected product (ID #{selectedProdID})";

            // re-bind data 
            RefreshPackagesByProdSuppGrid(); // for associated packages datagrid
            RefreshProdSupId(); //for product_supplier ID


        }
        /// <summary>
        /// Refreshes data for the associated packages datagrid, based on current selected row in prod_supp grid
        /// </summary>
        private void RefreshPackagesByProdSuppGrid()
        {
            //// Grab ID of the row currently selected in the Prod_Supp datagrid
            selectedProdID = Convert.ToInt32(grdProductSuppliers.SelectedRows[0].Cells[0].Value);

            // Set title for the products data using that current id
            lblAssociatesPackages.Text = $"Associated Packages for selected product (ID #{selectedProdID})";

            // Use a query to get only packages associated with the prod_supp id, and bind it to the grid
            grdPackagesforProdSupp.DataSource = TravelExpertsQueryManager.GetPackagesByProdSuppID(selectedProdID);
        }

        // Modifies the ProductSupplier associated with the selected row of the datagrid using the user inputs [Eric]
        private void btnModifyProdSupp_Click(object sender, EventArgs e)
        {
            // Get user inputs
            int newProdId = Convert.ToInt32(productIdComboBox.SelectedValue);
            int newSupID = Convert.ToInt32(supplierIdComboBox.SelectedValue);

            // The user may not have selected a value for the supplierIDComboBox yet, if so, they want the visible (top) one 
            if (newSupID == 0) {
                supplierIdComboBox.SelectedIndex = 0;
                newSupID = Convert.ToInt32(supplierIdComboBox.SelectedValue);  
            }

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
                    Products_Supplier matchingProps = Validator.prodSupComboAlreadyExists(db, newProdId, newSupID, prodSupID);

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
                        DialogResult result = MessageBox.Show($"That product/supplier combination already exists (ID #{matchingProps.ProductSupplierId} - {matchingProps.Product.ProdName} - {matchingProps.Supplier.SupName}). Would you like to change any associated packages to have the selected product?", 
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
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                                }                    
                            }
                            MessageBox.Show($"Any associated packages successfully transffered to ID# {matchingProps.ProductSupplierId} - {matchingProps.Product.ProdName} - {matchingProps.Supplier.SupName})");
                        }
                    }
                    // Reload data
                    checkboxFilterProducts_CheckedChanged(sender, e);//this updates the main datagrid based on whether the filter is on
                    RefreshPackagesByProdSuppGrid();
                    RefreshProdSupId();

                } // end modify   

                else // if in add mode
                {
                    // Validate to ensure the combo is new
                    Products_Supplier match = Validator.prodSupComboAlreadyExists(db, newProdId, newSupID);
                    if (match == null) //if new
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

                        // Reload main data
                        checkboxFilterProducts_CheckedChanged(sender, e); //updates main datagrid based on status of filter checkbox

                        // Go to the new entry in the gridview
                        checkboxFilterProducts.Checked = false; // uncheck filter so new product can be seen
                        int lastIndex = grdProductSuppliers.Rows.Count - 1; // get last row of the grid
                        grdProductSuppliers.Rows[lastIndex].Selected = true; // select it
                        grdProductSuppliers.FirstDisplayedScrollingRowIndex = lastIndex; // go down to it
                        grdProductSuppliers_CellClick(sender, new DataGridViewCellEventArgs(1, lastIndex));

                        // Reload related data
                        RefreshPackagesByProdSuppGrid();
                        productIdComboBox_SelectedIndexChanged(sender, e);
                        RefreshProdSupId();
                    }
                    else // if the combo already exists
                    {
                        // Alert the user
                        MessageBox.Show($"That product/supplier combination already exists (ID #{match.ProductSupplierId}).");
                    }
                }
            }

        }

        // Sets up the form for adding a new ProductSupplier [Eric]
        private void btnAddProdSupp_Click(object sender, EventArgs e)
        {
            // put form in add mode
            addMode = true;

            // Set up display for add mode
            lblAssociatesPackages.Text = "";
            lblSelectedProdsTitle.Text = $"*Add details for new product.*";

            btnAddProdSupp.Enabled = false; // disable button until leaving add mode to make things clearer for user

            // Put combo boxes in default state
            productIdComboBox.SelectedIndex = 0;
            supplierIdComboBox.SelectedIndex = 0;

            // clear associated packages
            grdPackagesforProdSupp.DataSource = null;
        }

        // Whenever the user selects a product from the dropdown, update the suppliers dropdown with appropriate data [Eric]
        private void productIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                // If the user has selected the option to filter suppliers
                if (checkBoxFilterSuppliers.Checked == true)
                {
                    // Get the list of suppliers applicable with the selected product ID
                    supplierIdComboBox.DataSource = TravelExpertsQueryManager.GetSuppliersByProductID(db, Convert.ToInt32(productIdComboBox.SelectedValue));

                    // Make top option of suppliers dropdown selected
                    supplierIdComboBox.SelectedIndex = 0;
                }
                else
                {
                    supplierIdComboBox.DataSource = db.Suppliers; // get supplier data for suppliers details dropbox

                    // Make top option of suppliers dropdown selected
                    supplierIdComboBox.SelectedIndex = 0;
                }
            }
        }

        // Updates the display of the prodsuppID
        private void RefreshProdSupId()
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

        // Checking off the top filter button will toggle filtering all products in the product_supplier datagrid (either all of them, or just those with packages)
        private void checkboxFilterProducts_CheckedChanged(object sender, EventArgs e)
        {
            // Update the persisting db image (used as a data source)
            rootDB = new travelexpertsDataContext();
            
            // If the user checks off the option to filter
            if (checkboxFilterProducts.Checked == true)
            {
                // Query PPS to find all ProductSuppliers associated to packages
                List<int> prodSupIDsWithPackages = rootDB.Packages_Products_Suppliers.Select(pps =>
                    pps.ProductSupplierId) // just need ids
                    .ToList();

                // Filter the datagrid to only show those entries
                products_SupplierBindingSource.DataSource = TravelExpertsQueryManager.GetProductsSuppliersExtended(rootDB, prodSupIDsWithPackages);
            }
            else
            {
                products_SupplierBindingSource.DataSource = TravelExpertsQueryManager.GetProductsSuppliersExtended(rootDB);
            }
        }

        // Major headaches getting the first row to select... it won't seem to do so unless we go to another row first. So, this code makes that happen [Eric]
        private void SetDataGridToFirstEntry()
        {
            // Both the default form load, and trying to initially select the top row, resist firing the events we want. So, first, select an arbitrary row
            // In theory, this will crash if there are less than 2 product_suppliers in the database (shouldn't happen, but we'll throw in a try block)
            try
            {
                grdProductSuppliers.CurrentCell = grdProductSuppliers.Rows[2].Cells[2];
                grdProductSuppliers_CellClick(this.grdProductSuppliers, new DataGridViewCellEventArgs(2, 2));
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured retrieving product_supplier data. Please check to ensure you are connected to the database - " + ex.Message, ex.GetType().ToString());
            }

            // Then, select the top row as desired
            grdProductSuppliers.CurrentCell = grdProductSuppliers.Rows[0].Cells[0];
            grdProductSuppliers_CellClick(this.grdProductSuppliers, new DataGridViewCellEventArgs(0, 0));
        }
    }
}
