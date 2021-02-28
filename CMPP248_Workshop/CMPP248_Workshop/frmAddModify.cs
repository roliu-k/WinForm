using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    /* This form is to Create/Modify Packages in the Package Database. 
    Groundwork done by the full team in live sessions any unattributed blocks can be assumed to be a team effort.
    Validation by Ronnie.
    Layout, cancel management, refactoring by Eric.
     */

    public partial class frmAddModify : Form
    {
        // Class-level variables
        public bool isAdd; // Mode for the form (add or modify)
        public Package currentPackage; // Package being modified, passed by parent form
        List<Packages_Products_Supplier> ppsSnapshot = new List<Packages_Products_Supplier>(); // snapshot of associated lines in Packages_Products_Suppliers
                                                                                               // in case they are modified, then the user cancels
        public bool didAddProducts = false; // toggle to see if products have been added (causing differences from the ppsSnapshot)
        private DateTime? tmpStartDate; // temp variable for startdate input
        private DateTime? tmpEndDate; // temp vairable for endate input

        public frmAddModify()
        {
            InitializeComponent();
        }

        //If Modify Button was clicked on Form1
        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if(!isAdd)   // Set up for Modify mode - use the Package passed from the last form to populate fields
            {

                // Update the title and description of the page
                lblTitle.Text = "Package Manager - Edit Package";
                lblDesc.Text = $"Edit any details and modify product list for the current package (ID #{currentPackage.PackageId}).";

                using (travelexpertsDataContext db = new travelexpertsDataContext())
                {
                    // Grab current package ID used to create this modify page
                    int packageId = currentPackage.PackageId; 
                    // Use an in-depth query to grab the info needed for the product info data grid
                    dataGridView1.DataSource = TravelExpertsQueryManager.FindProdInfoByPackage(db, currentPackage.PackageId);
                }

                // Set up a snapshot of current associated package_product_suppliers entries
                ppsSnapshot = TravelExpertsQueryManager.GetPackagesProductsSuppliersByPackageID(currentPackage.PackageId);

                // handle nullable datetime
                if (currentPackage.PkgStartDate == null)
                    EmptyDateTimePicker(pkgStartDateDateTimePicker);

                if (currentPackage.PkgEndDate == null)
                    EmptyDateTimePicker(pkgEndDateDateTimePicker);

                // Display current package information in details view
                packageBindingSource.Add(currentPackage);
            }

            else // Set up for Add mode
            {
                // Update the title and description of the page
                lblTitle.Text = "Package Manager - Add A New Package";
                lblDesc.Text = "Add details and products for a new package.";
                EmptyDateTimePicker(pkgStartDateDateTimePicker);
                EmptyDateTimePicker(pkgEndDateDateTimePicker);
            }

        }

        // Checks to ensure valid fields and then updates the current package entry in the database.
        // Note: we insert a new Package with default properties when entering this form in add mode.
        // As such, the save button functions the same in either mode. See Load and Cancel code for differences.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // VALIDATION [Ronnie]
            if (Validator.IsPresent("Name", pkgNameTextBox) &&
                Validator.IsPresent("Description", pkgDescTextBox) &&
                Validator.IsPresent("Base Price", pkgBasePriceTextBox) &&
                Validator.IsValidEndDate(pkgStartDateDateTimePicker, pkgEndDateDateTimePicker, ref tmpEndDate) &&
                Validator.IsDecimal("Base Price", pkgBasePriceTextBox) &&
                (pkgAgencyCommissionTextBox.Text == "" ||
                    (Validator.IsDecimal("Agency Commission", pkgAgencyCommissionTextBox) &&
                    Validator.IsNonNegativeDecimal("Agency Commission", pkgAgencyCommissionTextBox) &&
                    Validator.IsLEBasePrice(pkgBasePriceTextBox, pkgAgencyCommissionTextBox)
                )) &&
                Validator.IsNonNegativeDecimal("Base Price", pkgBasePriceTextBox)

                )
            {
                try
                {
                    using (travelexpertsDataContext db = new travelexpertsDataContext())
                    {
                        // get the product with Code from the current text box
                        Package packageFromDB = db.Packages.Single(p => p.PackageId == currentPackage.PackageId);

                        //MessageBox.Show("Testing concurrency: update or delete current record from SSMS and click OK");

                        if (packageFromDB != null)
                        {
                            // make changes by copying values from text boxes
                            packageFromDB.PkgName = pkgNameTextBox.Text;
                            packageFromDB.PkgStartDate = tmpStartDate;
                            packageFromDB.PkgEndDate = tmpEndDate;
                            packageFromDB.PkgDesc = pkgDescTextBox.Text;
                            packageFromDB.PkgBasePrice = Decimal.Parse(pkgBasePriceTextBox.Text, System.Globalization.NumberStyles.Currency);
                            
                            //AgencyCommission can be null, so we check for that first
                            if (pkgAgencyCommissionTextBox.Text == "")
                            {
                                packageFromDB.PkgAgencyCommission = null;
                            }
                            // If not null, we have to parse it out of the formatted textbox
                            else
                            {
                                packageFromDB.PkgAgencyCommission = Decimal.Parse(pkgAgencyCommissionTextBox.Text, System.Globalization.NumberStyles.Currency);

                            }           

                            // submit changes 
                            db.SubmitChanges();
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            
        }

        /*
         * The following event listeners handle the DateTimePickers and their ability to accept null value [Ronnie]
         */
        private void pkgEndDateDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                EmptyDateTimePicker(pkgEndDateDateTimePicker);
                tmpEndDate = null;
            }
        }

        private void pkgStartDateDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                EmptyDateTimePicker(pkgStartDateDateTimePicker);
                tmpStartDate = null;
            }
        }

        
        private void pkgEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime? endDate = pkgEndDateDateTimePicker.Value;

            if (endDate != null)
            {
                pkgEndDateDateTimePicker.Enabled = true;
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Short;
                tmpEndDate = endDate;
            }
        }

        private void pkgStartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (pkgStartDateDateTimePicker.Value != null)
            {
                pkgStartDateDateTimePicker.Enabled = true;
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Short;
                tmpStartDate = pkgStartDateDateTimePicker.Value;
            }
        }

        private void EmptyDateTimePicker(DateTimePicker dt)
        {
            dt.CustomFormat = " ";
            dt.Format = DateTimePickerFormat.Custom;
        }

        //To add Products to a Package - calls form ProdSuppliers
        private void btnEditAddProducts_Click(object sender, EventArgs e)
        {
            frmProdSupplier prodsForm = new frmProdSupplier();
            prodsForm.currentPackage = currentPackage;
            DialogResult result = prodsForm.ShowDialog(); // display second form modal
            
            if (result == DialogResult.OK) // new row got inserted
            {
                // Toggle a switch noting that products were updated - checked in the event of cancel
                didAddProducts = true;

                // Show the updated list of products associated with this package
                using (travelexpertsDataContext db = new travelexpertsDataContext())
                {
                    dataGridView1.DataSource = TravelExpertsQueryManager.FindProdInfoByPackage(db, currentPackage.PackageId);
                }
            }
        }

        // Go back to last page without saving changes. This may involve some cleaning up, depending on the mode and if products were added [Eric]
        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                // First, we have to check to see if any products were added to the package before cancelling
                if (didAddProducts) // this will be true if so - no need to spend time querying the db
                {
                    // Get the current PPS entries in the database corresponsind to this package
                    List<Packages_Products_Supplier> ppsCurrent =
                        TravelExpertsQueryManager.GetPackagesProductsSuppliersByPackageID(currentPackage.PackageId);

                    // Next, we have to get the PPS entries to re-add (if they were deleted) and/or remove (if new ones were added)
                    // This is not a super efficient process, but packages shouldn't have enough products for it to make much difference
                    // First, get the ones to re-add
                    List<Packages_Products_Supplier> ppsToAdd = ppsSnapshot // Creating a list of Package_Product_Suppliers where...
                        .Where(ppsSnap => !ppsCurrent // ...for each snapshot entry, it is NOT the case that...
                        .Any(ppsCurr => ppsCurr.ProductSupplierId == ppsSnap.ProductSupplierId)) // ...any current entry has that snapshot entry's ProductSupplierID
                        .ToList();

                    // Next, the ones to remove
                    List<Packages_Products_Supplier> ppsToDelete = ppsCurrent // Creating a list of Package_Product_Suppliers where...
                       .Where(ppsCurr => !ppsSnapshot // ...for each current entry, it is NOT the case that...
                       .Any(ppsSnap => ppsCurr.ProductSupplierId == ppsSnap.ProductSupplierId)) // ...any snapshot entry has that current entry's ProductSupplierID
                       .ToList();

                    // Add the needed entries back
                    foreach(Packages_Products_Supplier ppsA in ppsToAdd)
                    {
                        // LINQ to SQL doesn't let you re-add old entity objects, so we need to create copies to add back in place
                        Packages_Products_Supplier clone = new Packages_Products_Supplier
                        {
                            PackageId = ppsA.PackageId,
                            ProductSupplierId = ppsA.ProductSupplierId
                        };

                        dbContext.Packages_Products_Suppliers.InsertOnSubmit(clone);
                    }

                    // Delete the entries to undo
                    foreach (Packages_Products_Supplier ppsD in ppsToDelete)
                    {
                        // Deleting only works on entities from the current context, so need to grab them
                        // I'm sure this could be done in the ones-to-remove LINQ query above, but I couldn't manage it
                        Packages_Products_Supplier deleteTarget = dbContext.Packages_Products_Suppliers // Search in the table...
                            .Single(pps => // ...for the one entry, with...
                            pps.ProductSupplierId == ppsD.ProductSupplierId //...the matching ProductSupplierID...
                            && pps.PackageId == ppsD.PackageId); //... and the matching PackageID 

                        dbContext.Packages_Products_Suppliers.DeleteOnSubmit(deleteTarget);
                    }

                    // Save changes. Phew!
                    dbContext.SubmitChanges();

                }

                // One more step if in Add mode. 
                // A package was inserted into the database initially (to get the add products half to work). 
                // So, if cancelling, we want to delete it this created package.
                if (isAdd)
                {
                    // Delete package
                    Package packToDelete = dbContext.Packages
                    .Single(p => p.PackageId == currentPackage.PackageId);

                    dbContext.Packages.DeleteOnSubmit(packToDelete);
                    dbContext.SubmitChanges(); // submit to the database
                }
            }

            // Exit the form
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Ensures data isn't partway saved in the event the user clicks 'X' to exit the program partway 
        // (or the application ends in other unexpected ways) [Eric]
        private void frmAddModify_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Checks to see if a normal close route happened
            if (!(new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")))
                btnCancel_Click(sender, e);
        }
    }
}
