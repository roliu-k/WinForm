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
     * The initial bulk of this form was done as
     * a group in a live session, creating a functioning
     * details-view layout that allowed the user to 
     * direct to the proper add or modify form. 
     * Additional individual fixes are noted, but all work
     * otherwise was distributed equally.
     */

    public partial class frmPackages : Form
    {
        //travelexpertsDataContext db = new travelexpertsDataContext();
        Package currentPackage;

        public frmPackages()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            packageBindingSource.DataSource = new travelexpertsDataContext().Packages;

            // Add data to Packages gridview [Eric - changed from details view to gridview, to allow easier browsing]
            grdPackages.DataSource = new travelexpertsDataContext().Packages;
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
            // Grab ID of the row currently selected in the Packages Datagrid. [Eric]
            int selectedId = Convert.ToInt32(grdPackages.CurrentRow.Cells[0].Value);

            //Package currentPackage;
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                currentPackage = (from p in dbContext.Packages // LINQ query that returns one record
                                  where p.PackageId == selectedId // use ID of selected row in Packages
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
            packageBindingSource.Clear();
            packageBindingSource.DataSource = new travelexpertsDataContext().Packages;
        }
    }
}