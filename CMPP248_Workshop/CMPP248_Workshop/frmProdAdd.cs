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
    public partial class frmProdAdd : Form
    {
        public frmProdAdd()
        {
            InitializeComponent();
        }
        //Adds new product to database
        private void btnSubmitProd_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent("Product Name", prodNameTextBox))
            {

                Product newProduct = new Product
                {
                    ProdName = prodNameTextBox.Text
                };
                using (travelexpertsDataContext db = new travelexpertsDataContext())
                {
                    db.Products.InsertOnSubmit(newProduct);
                    db.SubmitChanges();
                }
                DialogResult = DialogResult.OK;
                MessageBox.Show("New product added");
            }
        }
        //closes add form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProducts newprod = new frmProducts();
            newprod.Show();
        }
    }
}
