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
    public partial class frmSupplierAdd : Form
    {
        public frmSupplierAdd()
        {
            InitializeComponent();
        }
        //submits new supplier to database
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent("Supplier Name", supplierAddTextBoc))
            {

                Supplier newSupplier = new Supplier
                {
                    SupName = supplierAddTextBoc.Text
                };
                using (travelexpertsDataContext db = new travelexpertsDataContext())
                {
                    db.Suppliers.InsertOnSubmit(newSupplier);
                    db.SubmitChanges();
                }
                DialogResult = DialogResult.OK;
                MessageBox.Show("New Supplier added");

            }
        }
        //closes application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuppliers newsup = new frmSuppliers();
            newsup.Show();
        }
    }
}

