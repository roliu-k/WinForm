using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertDatabase
{

    /*
     * 
     * Helper functions to abstract complex queries out of
     * presentation. Functions done as a team during live session,
     * abstraction done by Eric.
     * 
     */

    public static class TravelExpertsQueryManager
    {
        /// <summary>
        /// Gets related product data pertaining to a specific Package from the database.
        /// Created as a team, with special mention to Ronnie and Eric for a little extra solving.
        /// </summary>
        /// <param name="db">A context from the database</param>
        /// <param name="id">The int ID of the package this data pertains to.</param>
        /// <returns>The data query containing all needed info.</returns>
        public static object FindProdInfoByPackage(travelexpertsDataContext db, int id) // object is probably not a great return type, but couldn't figure out better option [Eric]
        {
                var ProdInfo =
                    from Packages in db.Packages
                    join Packages_Products_Suppliers in db.Packages_Products_Suppliers
                    on Packages.PackageId equals Packages_Products_Suppliers.PackageId
                    join Products_Suppliers in db.Products_Suppliers
                    on Packages_Products_Suppliers.ProductSupplierId equals Products_Suppliers.ProductSupplierId
                    join Products in db.Products
                    on Products_Suppliers.ProductId equals Products.ProductId
                    join Suppliers in db.Suppliers
                    on Products_Suppliers.SupplierId equals Suppliers.SupplierId
                    where Packages.PackageId == id
                    orderby Packages.PackageId
                    select new
                    {
                        Packages.PackageId,
                        Packages.PkgName,
                        Products.ProductId,
                        Products.ProdName,
                        Suppliers.SupplierId,
                        Supplier = Suppliers.SupName
                    };
            System.Diagnostics.Debug.WriteLine(ProdInfo.GetType().ToString());

                return ProdInfo;  
        }

        /// <summary>
        /// Gets data for all packages which contain a particular Product/Supplier pair.
        /// </summary>
        /// <param name="prodSuppID">The ID of the Product_Supplier pair being queried.</param>
        /// <returns>A list of Packages using this product/supplier.</returns>
        public static List<Package> GetPackagesByProdSuppID(int prodSuppID)
        {
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                // Want to return a list of all the IDs of packages using this prod_supp
                List<int> packageIDs = dbContext.Packages_Products_Suppliers // Query bridge table
                    .Where(pps => pps.ProductSupplierId == prodSuppID) // Look for entries that have the provided prodsuppID
                    .Select(pps => pps.PackageId).ToList(); // grab only the package IDs from those matches and return them as a list

                // Use that list of package IDs to get package data for them all
                List<Package> packages = dbContext.Packages.Where(pkg => packageIDs.Contains(pkg.PackageId)).ToList();

                // Return this lsit
                return packages;
            }
        }
    }
}
