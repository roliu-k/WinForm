using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    //Create a new ProductSupplier ID through a product Id and supplier Id

    public partial class frmProdSupplierAddEdit : Form
    {

        int selectedProdID;

        public frmProdSupplierAddEdit()
        {
            InitializeComponent();
        }
        private void frmProdSupplierAddEdit_Load(object sender, EventArgs e)
        {
            travelexpertsDataContext dbContext = new travelexpertsDataContext();
            products_SupplierBindingSource.DataSource = dbContext.Products_Suppliers;
            supplierIdComboBox.DataSource = dbContext.Suppliers;
            productIdComboBox.DataSource = dbContext.Products;
            RefreshPackagesByProdSuppGrid();




        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void products_SupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

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

        private void grdProductSuppliers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((grdProductSuppliers.Rows[e.RowIndex].DataBoundItem != null) &&
            (grdProductSuppliers.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(
                              grdProductSuppliers.Rows[e.RowIndex].DataBoundItem,
                              grdProductSuppliers.Columns[e.ColumnIndex].DataPropertyName
                            );
            }
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

        private void grdProductSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshPackagesByProdSuppGrid();

            // Grab ID of the row currently selected in the Packages Datagrid. [Eric]
            selectedProdID = Convert.ToInt32(grdProductSuppliers.CurrentRow.Cells[0].Value);

            // Set title for the products data using that current id
            lblSelectedProdsTitle.Text = $"Details for selected product (ID #{selectedProdID})";

        }

        private void RefreshPackagesByProdSuppGrid()
        {
            // Grab ID of the row currently selected in the Packages Datagrid. [Eric]
            selectedProdID = Convert.ToInt32(grdProductSuppliers.CurrentRow.Cells[0].Value);

            // Set title for the products data using that current id
            lblAssociatesPackages.Text = $"Associated Packages for selected product (ID #{selectedProdID})";

             grdPackagesforProdSupp.DataSource = TravelExpertsQueryManager.GetPackagesByProdSuppID(selectedProdID);
        }
    }
}
