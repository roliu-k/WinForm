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
        public frmProducts()
        {
            InitializeComponent();

            productBindingSource.DataSource = new travelexpertsDataContext().Products;
        }
    }

}
