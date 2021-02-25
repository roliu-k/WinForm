using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPP248_Workshop
{
    /*
     * Start page for the form.
     * Initial design and structure by Holly.
     * Layout fixes by Eric.
     */

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnManagePkg_Click(object sender, EventArgs e)
        {
            frmPackages frmPkg = new frmPackages();
            frmPkg.Show();
        }

        private void btnManageProdSupp_Click(object sender, EventArgs e)
        {
            frmProdSupplierAddEdit frmProdSup = new frmProdSupplierAddEdit();
            frmProdSup.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
