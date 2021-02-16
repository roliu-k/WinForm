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
    public partial class frmProductsModify : Form
    {

        public Product currentProduct;
        public string OldName;
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
                    List<Product> ExistingProdut = db.Products.Where(q => q.ProdName == prodNameTextBox.Text).ToList();
                    if(ExistingProdut.Count > 0 && ExistingProdut[0].ProdName != currentProduct.ProdName)
                    {
                        MessageBox.Show("Cannot modify product because product already exists");
                    }
                    else if(prodNameTextBox.Text != productFromDB.ProdName)
                    {
                        
                            productFromDB.ProdName = prodNameTextBox.Text;
                            db.SubmitChanges();
                            DialogResult = DialogResult.OK;
                            MessageBox.Show("Proudct modified");
                        
                        
                    }
                  
                }

            }
        }
        //closes modify form
            private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        //loads the current product from the product page
        private void frmProductsModify_Load(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {

                OldName = currentProduct.ProdName;
                productIdTextBox.Text = Convert.ToString(currentProduct.ProductId);
                prodNameTextBox.Text = currentProduct.ProdName;

            }
        }
    }
 }

