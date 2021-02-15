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
    // This should allow adding/modifying Suppliers in the Supplier database.

    public partial class frmSuppliers : Form
    {

        Supplier currentSupplier;
        int selectSupplierId;
        public bool isAdd;
        //travelexpertsDataContext = new travelexpertsDataContext

        public frmSuppliers()
        {
            InitializeComponent();
            supplierBindingSource.DataSource = new travelexpertsDataContext().Suppliers;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplierAdd newsupp = new frmSupplierAdd();
            newsupp.Show();
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                currentSupplier = (from p in db.Suppliers
                                   where p.SupplierId == selectSupplierId
                                   select p).Single();

                frmSupplierModify frmprodmodify = new frmSupplierModify();

                frmprodmodify.currentSupplier = currentSupplier;
                DialogResult result = frmprodmodify.ShowDialog();
                this.Close();
            }
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void supplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshSupplierGrid();
        }
        private void RefreshSupplierGrid()
        {
            // Grab ID of the row currently selected in the Packages Datagrid. [Eric]
            selectSupplierId = Convert.ToInt32(supplierDataGridView.CurrentRow.Cells[0].Value);



        }
        public void RefreshView()
        {

            // Populate data in Packages gridview [Eric - changed from details view to gridview, to allow easier browsing]
            supplierBindingSource.DataSource = new travelexpertsDataContext().Suppliers;

            // Populate data in Product Info gridview
            RefreshSupplierGrid();
        }
    }
}

