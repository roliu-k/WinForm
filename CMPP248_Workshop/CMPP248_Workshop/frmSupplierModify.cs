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
            if (Validator.IsPresent(supplierNameTextBox)) { 
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                Supplier supplierfrmDB = db.Suppliers.Single(p => p.SupplierId.ToString() == supplierIdTextBox.Text);
                    if (supplierfrmDB != null)
                    {
                        supplierfrmDB.SupName = supplierNameTextBox.Text;
                        db.SubmitChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Supplier Modified");
                        frmSuppliers newsupp = new frmSuppliers();
                        newsupp.Show();
                    }
                }
            }
    }
        //closes modify page
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuppliers newsupp = new frmSuppliers();
            newsupp.Show();
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
