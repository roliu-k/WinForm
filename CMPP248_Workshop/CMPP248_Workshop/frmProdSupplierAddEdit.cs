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
    //Create a new ProductSupplier ID through a product Id and supplier Id

    public partial class frmProdSupplierAddEdit : Form
    {
        public frmProdSupplierAddEdit()
        {
            InitializeComponent();
        }
        private void frmProdSupplierAddEdit_Load(object sender, EventArgs e)
        {
            travelexpertsDataContext dbContext = new travelexpertsDataContext();
            products_SupplierBindingSource.DataSource = new travelexpertsDataContext().Products_Suppliers;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void products_SupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (true)//replace with validation
            {
                Products_Supplier newProdSup = new Products_Supplier
                {
                    ProductSupplierId = Convert.ToInt32(productSupplierIdTextBox1.Text),
                    ProductId = Convert.ToInt32(productIdComboBox.Text),
                    SupplierId = Convert.ToInt32(supplierIdComboBox.Text)
                };
                DialogResult = DialogResult.OK;
            }
        }

        //Opens Products Form
        private void btnManageProds_Click(object sender, EventArgs e)
        {
            frmProducts frmProds = new frmProducts();
            frmProds.Show();
        }

        //Opens Suppliers Form
        private void btnManageSupps_Click(object sender, EventArgs e)
        {
            frmSuppliers frmSupps = new frmSuppliers();
            frmSupps.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
