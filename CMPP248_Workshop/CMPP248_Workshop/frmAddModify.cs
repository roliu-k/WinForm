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
        private DateTime? tmpDate;

        public frmAddModify()
        {
            InitializeComponent();
        }
        //If Modify Button was clicked on Form1
        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if(!isAdd)   // modify
            {
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

                // dispaly current package information
                packageBindingSource.Add(currentPackage);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {//add validation at some point
                if (Validator.IsPresent(pkgNameTextBox) &&
                    Validator.IsPresent(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgAgencyCommissionTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgAgencyCommissionTextBox))
                // TODO: Add special validation for agency commision

                {
                    Package newPackage = new Package //create new package using the text box values
                    {
                        PkgName = pkgNameTextBox.Text,
                        PkgStartDate = pkgStartDateDateTimePicker.Value,
                        PkgEndDate = pkgEndDateDateTimePicker.Value,
                        PkgDesc = pkgDescTextBox.Text,
                        PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text),
                        PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text)
                    };

                    // validate package end date that must be later than start date
                    if (IsValidEndDate())
                    {
                        using (travelexpertsDataContext db = new travelexpertsDataContext())
                        {
                            db.Packages.InsertOnSubmit(newPackage); // insert the new package through data context object
                            db.SubmitChanges(); //submit to database
                        }
                        DialogResult = DialogResult.OK;
                    }
                    else
                        DialogResult = DialogResult.Cancel;
                }
            }
            else // modify code
            {

                // TODO: ADD VALIDATION

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
                            packageFromDB.PkgStartDate = pkgStartDateDateTimePicker.Value;
                            packageFromDB.PkgEndDate = pkgEndDateDateTimePicker.Value;
                            packageFromDB.PkgDesc = pkgDescTextBox.Text;
                            packageFromDB.PkgBasePrice = Decimal.Parse(pkgBasePriceTextBox.Text, System.Globalization.NumberStyles.Currency);
                            packageFromDB.PkgAgencyCommission = Decimal.Parse(pkgAgencyCommissionTextBox.Text, System.Globalization.NumberStyles.Currency);
                            // submit changes 
                            db.SubmitChanges();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            
        }

        private void pkgEndDateDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                pkgEndDateDateTimePicker.CustomFormat = " ";
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                tmpDate = null;
            }
        }

        private void pkgStartDateDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                pkgStartDateDateTimePicker.CustomFormat = " ";
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                tmpDate = null;
            }
        }

        
        private void pkgEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime? endDate = pkgEndDateDateTimePicker.Value;

            if (endDate != null)
            {
                pkgEndDateDateTimePicker.Enabled = true;
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Short;
                tmpDate = endDate;
            }
        }

        private void pkgStartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (pkgStartDateDateTimePicker.Value != null)
            {
                pkgStartDateDateTimePicker.Enabled = true;
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Short;
                tmpDate = pkgStartDateDateTimePicker.Value;
            }
        }

        // add a validation to make sure end date does not occur before start date
        private bool IsValidEndDate()
        {
            bool valid = false;

            DateTime? startDate = pkgStartDateDateTimePicker.Value;
            DateTime? endDate = pkgEndDateDateTimePicker.Value;

            if (endDate != null)
            {
                if (endDate > startDate) 
                {
                    pkgEndDateDateTimePicker.Enabled = true;
                    pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Short;
                    tmpDate = endDate;
                    valid = true;
                }
                else
                    MessageBox.Show("The package end date should be later than package start date", "Input Error");
            }

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
    }
}
