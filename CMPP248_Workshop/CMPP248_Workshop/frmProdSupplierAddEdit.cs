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
            supplierIdComboBox.DataSource = dbContext.Suppliers; // get supplier data for suppliers details dropbox
            productIdComboBox.DataSource = dbContext.Products;  // get product data for products details dropbox
            RefreshPackagesByProdSuppGrid(); // get package data for selected product_supplier row (in this case, top one)

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void products_SupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

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
            // Grab ID of the row currently selected in the Prod_Supp datagrid
            selectedProdID = Convert.ToInt32(grdProductSuppliers.CurrentRow.Cells[0].Value);

            // Set title for the products details below using that current id
            lblSelectedProdsTitle.Text = $"Details for selected product (ID #{selectedProdID})";

            // re-bind data for associated packages datagrid
            RefreshPackagesByProdSuppGrid(); 


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
            if(addMode == false) // if modifying
            {
                // grab data from dropdowns & hidden id field (productSupplierIdTextBox)

                // update entry in Product_Suppliers with the current ID using that data

                
            }
            else // if in add mode
            {
                // grab dropdown data

                // create a new Product_Supplier with that data

                // insert into db and save
            }

            // reload data

            travelexpertsDataContext dbContext = new travelexpertsDataContext(); // create a new context
            products_SupplierBindingSource.DataSource = dbContext.Products_Suppliers; //get product_supplier data for top datagrid
            RefreshPackagesByProdSuppGrid();

        }
    }
}
