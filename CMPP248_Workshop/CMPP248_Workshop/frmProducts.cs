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
    //This should allow adding/modifying products in the product database.

    public partial class frmProducts : Form
    {
        public bool isAdd;
        public frmProducts()
        {
            InitializeComponent();

            productBindingSource.DataSource = new travelexpertsDataContext().Products;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Product newProduct = new Product
                {
                    ProdName = productIdTextBox.Text
                };
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }

}
