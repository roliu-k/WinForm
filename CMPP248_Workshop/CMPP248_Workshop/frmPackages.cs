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
    /*
     * Displays packages in read-only context,
     * with buttons allowing the user to proceed
     * to add new packages or modify the selected.
     * 
     * The initial bulk of this form was done by the whole
     * group in a live session, creating a functioning
     * details-view layout that allowed the user to 
     * direct to the proper add or modify form.
     * While much of that original code has been modifed,
     * it was integral to getting this page running.
     * 
     * Updated design and inclusion of datagrids led by Eric.
     */

    public partial class frmPackages : Form
    {
        Package currentPackage;
        int selectedPackageId;

        public frmPackages()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate data into data views
            RefreshView();
        }


        //Adds new Packages to Database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModify secondForm = new frmAddModify();
            secondForm.isAdd = true;

            //
            //
            // Because we give the user the option to add products to the new package before saving it,
            // We need to do a preliminary insert into the database in order to get a valid PackageID
            // for the PackageProductsSuppliers table.
            // We don't use the current highest PackageID + 1, in order to avoid concurrency issues.
            Package newPackage = new Package
            {
                PkgName = "DEFAULT",
                PkgStartDate = DateTime.Now,
                PkgEndDate = DateTime.Now,
                PkgDesc = "DEFAULT",
                PkgBasePrice = 0,
                PkgAgencyCommission = 0
            };
            // submit changes to database
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                db.Packages.InsertOnSubmit(newPackage); // insert the new package through data context object
                db.SubmitChanges(); //submit to database
            }
            secondForm.currentPackage = newPackage; // Now that the newpackage has been added to the database, the Object has an Id (magic!)
            //
            //

            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                secondForm.Close();
                RefreshView();
            }
        }

        //Allows modifications to Packages
        private void btnModify_Click(object sender, EventArgs e)
        {

            //Package currentPackage;
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                currentPackage = (from p in dbContext.Packages // LINQ query that returns one record
                                  where p.PackageId == selectedPackageId // use ID of selected row in Packages
                                  select p).Single(); // method Single runs the LINQ query, only when receiving one value


                frmAddModify secondForm = new frmAddModify();
                secondForm.isAdd = false; // Modify mode
                secondForm.currentPackage = currentPackage;
                DialogResult result = secondForm.ShowDialog(); // display second form modal
                if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
                {
                    RefreshView();
                }
            }
        }

        public void RefreshView()
        {

            // Populate data in Packages gridview [Eric - changed from details view to gridview, to allow easier browsing]
            grdPackages.DataSource = new travelexpertsDataContext().Packages;

            // Populate data in Product Info gridview
            RefreshProductGrid();
        }

        private void RefreshProductGrid()
        {
            // Grab ID of the row currently selected in the Packages Datagrid. [Eric]
            selectedPackageId = Convert.ToInt32(grdPackages.CurrentRow.Cells[0].Value);

            // Set title for the products data using that current id
            lblSelectedProdsTitle.Text = $"Products for Selected Package (ID #{selectedPackageId})";

            // Populate data in Product Info gridview
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                // Use an in-depth query to grab the info needed for the product info data grid
                dataGridView1.DataSource = TravelExpertsQueryManager.FindProdInfoByPackage(db, selectedPackageId);
            }
        }

        private void grdPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshProductGrid();
        }
    }
}