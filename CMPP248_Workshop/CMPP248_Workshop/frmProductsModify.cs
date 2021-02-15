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
    public partial class frmProductsModify : Form
    {

        public Product currentProduct;
        public frmProductsModify()
        {
            InitializeComponent();
        }
        //submits modified product to database
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent("Product Name",prodNameTextBox)) {
                using (travelexpertsDataContext db = new travelexpertsDataContext())
                {
                    Product productFromDB = db.Products.Single(p => p.ProductId.ToString() == productIdTextBox.Text);
                    if (productFromDB != null)
                    {
                        productFromDB.ProdName = prodNameTextBox.Text;
                        db.SubmitChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Proudct modified");
                        frmProducts newprod = new frmProducts();
                        newprod.Show();
                    }
                }

            }
        }
        //closes modify form
            private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProducts newprod = new frmProducts();
            newprod.Show();
        }
        //loads the current product from the product page
        private void frmProductsModify_Load(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {


                productIdTextBox.Text = Convert.ToString(currentProduct.ProductId);
                prodNameTextBox.Text = currentProduct.ProdName;

            }
        }
    }
 }

