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
    //Page created by Chris Eckstadt
    public partial class frmSupplierModify : Form
    {
        public Supplier currentSupplier;
        public frmSupplierModify()
        {
            InitializeComponent();
        }
        //submits modified supplier to database
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent("Supplier Name", supplierNameTextBox)) { 
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                Supplier supplierfrmDB = db.Suppliers.Single(p => p.SupplierId.ToString() == supplierIdTextBox.Text);
                    List<Supplier> ExistingSupplier = db.Suppliers.Where(q => q.SupName == supplierNameTextBox.Text).ToList();
                    if (ExistingSupplier.Count >0 && ExistingSupplier[0].SupName != currentSupplier.SupName)
                    {
                        MessageBox.Show("Cannor modify Supplier because supplier name already exists");
                    }else if(supplierNameTextBox.Text != supplierfrmDB.SupName)
                    {
                        supplierfrmDB.SupName = supplierNameTextBox.Text;
                        db.SubmitChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Supplier Modified");
                      

             }
            }
        }
    }
        //closes modify page
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        //loads the current supplier from the supplier page
        private void frmSupplierModify_Load(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {


                supplierIdTextBox.Text = Convert.ToString(currentSupplier.SupplierId);
                supplierNameTextBox.Text = currentSupplier.SupName;

            }
        }
    }
    }
