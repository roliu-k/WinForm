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
    // This form is to Create/Modify Packages in the Package Database. 

    public partial class frmAddModify : Form
    {
        // Class-level variables
        public bool isAdd;
        public Package currentPackage;
        private DateTime? tmpStartDate;
        private DateTime? tmpEndDate;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {//add validation at some point
                if (Validator.IsPresent("Name", pkgNameTextBox) &&
                    Validator.IsPresent("Description", pkgDescTextBox) &&
                    Validator.IsPresent("Base Price", pkgBasePriceTextBox) &&
                    IsValidEndDate() &&
                    Validator.IsDecimal("Base Price", pkgBasePriceTextBox) &&
                    Validator.IsDecimal("Agency Commission", pkgAgencyCommissionTextBox) &&
                    Validator.IsNonNegativeDecimal("Base Price", pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal("Agency Commission", pkgAgencyCommissionTextBox) &&
                    Validator.IsLEBasePrice(pkgBasePriceTextBox, pkgAgencyCommissionTextBox) 
                    )
                {
                    Package newPackage = new Package //create new package using the text box values
                    {
                        PkgName = pkgNameTextBox.Text,
                        PkgStartDate = tmpStartDate,
                        PkgEndDate = tmpEndDate,
                        PkgDesc = pkgDescTextBox.Text,
                        PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text),
                        PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text)
                    };

                    // submit changes to database
                    using (travelexpertsDataContext db = new travelexpertsDataContext())
                    {
                        db.Packages.InsertOnSubmit(newPackage); // insert the new package through data context object
                        db.SubmitChanges(); //submit to database
                    }
                    DialogResult = DialogResult.OK;

                }
            }
            else // modify code
            {

                // VALIDATION
                if (Validator.IsPresent("Name", pkgNameTextBox) &&
                    Validator.IsPresent("Description", pkgDescTextBox) &&
                    Validator.IsPresent("Base Price", pkgBasePriceTextBox) &&
                    IsValidEndDate() &&
                    Validator.IsDecimal("Base Price", pkgBasePriceTextBox) &&
                    Validator.IsDecimal("Agency Commission", pkgAgencyCommissionTextBox) &&
                    Validator.IsNonNegativeDecimal("Base Price", pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal("Agency Commission", pkgAgencyCommissionTextBox) &&
                    Validator.IsLEBasePrice(pkgBasePriceTextBox, pkgAgencyCommissionTextBox)
                    )
                {
                    try
                    {
                        using (travelexpertsDataContext db = new travelexpertsDataContext())
                        {
                            // get the product with Code from the current text box
                            Package packageFromDB = db.Packages.Single(p => p.PackageId.ToString() == packageIdTextBox.Text);

                            //MessageBox.Show("Testing concurrency: update or delete current record from SSMS and click OK");

                            if (packageFromDB != null)
                            {
                                // make changes by copying values from text boxes
                                packageFromDB.PkgName = pkgNameTextBox.Text;
                                packageFromDB.PkgStartDate = tmpStartDate;
                                packageFromDB.PkgEndDate = tmpEndDate;
                                packageFromDB.PkgDesc = pkgDescTextBox.Text;
                                packageFromDB.PkgBasePrice = Decimal.Parse(pkgBasePriceTextBox.Text, System.Globalization.NumberStyles.Currency);
                                packageFromDB.PkgAgencyCommission = Decimal.Parse(pkgAgencyCommissionTextBox.Text, System.Globalization.NumberStyles.Currency);
                                // submit changes 
                                db.SubmitChanges();
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            
        }

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

        // add a validation to make sure end date does not occur before start date
        private bool IsValidEndDate()
        {
            bool valid = false;
            DateTime? startDate = null;
            DateTime? endDate = null;

            if (pkgStartDateDateTimePicker.Text != " ")
            {
                startDate = pkgStartDateDateTimePicker.Value;
            }
            if (pkgEndDateDateTimePicker.Text != " ")
            {
                endDate = pkgEndDateDateTimePicker.Value;
            }

            if (endDate != null)
            {
                if (endDate > startDate || startDate == null) 
                {
                    pkgEndDateDateTimePicker.Enabled = true;
                    pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Short;
                    tmpEndDate = endDate;
                    valid = true;
                }
                else
                    MessageBox.Show("The package end date should be later than package start date", "Input Error");
            }

            // when both fields are empty, return true
            if (endDate == null && startDate == null)
                valid = true;

            return valid;
        }

        //To add Products to a Package - calls form ProdSuppliers
        private void btnEditAddProducts_Click(object sender, EventArgs e)
        {
            frmProdSupplier prodsForm = new frmProdSupplier();
            prodsForm.currentPackage = currentPackage;
            DialogResult result = prodsForm.ShowDialog(); // display second form modal
            
            if (result == DialogResult.OK) // new row got inserted
            {
                MessageBox.Show("Updated associated products");

                // Show the updated list of products associated with this package
                using (travelexpertsDataContext db = new travelexpertsDataContext())
                {
                    dataGridView1.DataSource =
                        from Packages in db.Packages
                        join Packages_Products_Suppliers in db.Packages_Products_Suppliers
                        on Packages.PackageId equals Packages_Products_Suppliers.PackageId
                        join Products_Suppliers in db.Products_Suppliers
                        on Packages_Products_Suppliers.ProductSupplierId equals Products_Suppliers.ProductSupplierId
                        join Products in db.Products
                        on Products_Suppliers.ProductId equals Products.ProductId
                        join Suppliers in db.Suppliers
                        on Products_Suppliers.SupplierId equals Suppliers.SupplierId
                        where Packages.PackageId == currentPackage.PackageId
                        orderby Packages.PackageId
                        select new
                        {
                            Packages.PackageId,
                            Packages.PkgName,
                            Products.ProductId,
                            Products.ProdName,
                            Suppliers.SupplierId,
                            Supplier = Suppliers.SupName
                        };
                }
            }
        }

        // Go back to last page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // If in Add mode, we had to insert into the database already. So, if cancelling, we delete this.
            if (isAdd)
            {
                using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
                {



                    // Delete package
                    Package packToDelete = dbContext.Packages
                        .Single(p => p.PackageId == currentPackage.PackageId);

                    dbContext.Packages.DeleteOnSubmit(packToDelete);
                    dbContext.SubmitChanges(); // submit to the database

                }
            }

            DialogResult = DialogResult.Cancel;
        }
    }
}
