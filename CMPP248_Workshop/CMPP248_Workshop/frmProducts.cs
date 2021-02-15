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
        Product currentProduct;
        int selectProductId;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProdAdd newprod = new frmProdAdd();
            newprod.Show();
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                currentProduct = (from p in db.Products
                                  where p.ProductId == selectProductId
                                  select p).Single();

                frmProductsModify frmprodmodify = new frmProductsModify();

                frmprodmodify.currentProduct = currentProduct;
                DialogResult result = frmprodmodify.ShowDialog();
                this.Close();
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshProductGrid();
        }
        public void RefreshView()
        {

            // Populate data in Packages gridview [Eric - changed from details view to gridview, to allow easier browsing]
            productBindingSource.DataSource = new travelexpertsDataContext().Products;

            // Populate data in Product Info gridview
            RefreshProductGrid();
        }
        private void RefreshProductGrid()
        {
            // Grab ID of the row currently selected in the Packages Datagrid. [Eric]
            selectProductId = Convert.ToInt32(productDataGridView.CurrentRow.Cells[0].Value);



        }
    }
 }


