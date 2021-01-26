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

        private void frmAddModify_Load(object sender, EventArgs e)
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
        

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
              
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

        // add a validation to make sure end date does not occur before start date
        private void pkgEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //DateTime 
            if (pkgEndDateDateTimePicker.Value != null)
            {
                //if()
                pkgEndDateDateTimePicker.Enabled = true;
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Short;
                tmpDate = pkgEndDateDateTimePicker.Value;
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

        private void btnEditAddProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
