using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertDatabase
{
    /*
     * 
     * Provides the structure for the data used in the 
     * datagrid for product info related to a package.
     * Note this class is used for cosmetic purposes only,
     * as an initial datasource so that the datagrid can
     * be easily formatted in design view.
     * The actual getting of this data is done directly
     * through a LINQ query (TravelExpertsQueryManager.FindProdInfoByPackage)
     * 
     */

    class PackageRelatedTableData
    {
        public int PackageId { get; set; }
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
    }
}
