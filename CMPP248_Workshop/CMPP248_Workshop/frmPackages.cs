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
            secondForm.currentPackage = null; // no current product when inserting
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