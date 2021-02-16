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
     * presentation.
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
                        Products_Suppliers.ProductSupplierId,
                        Packages.PackageId,
                        Packages.PkgName,
                        Products.ProductId,
                        Products.ProdName,
                        Suppliers.SupplierId,
                        Supplier = Suppliers.SupName
                    };


                return ProdInfo.ToList();  
        }

        /// <summary>
        /// Gets data for all packages which contain a particular Product/Supplier pair. Added by Eric.
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
                    .Select(pps => pps.PackageId).ToList(); // grab the package IDs from those matches and return them as a list

                // Use that list of package IDs to get package data for them all
                List<Package> packages = dbContext.Packages.Where(pkg => packageIDs.Contains(pkg.PackageId)).ToList();

                // Return this lsit
                return packages;
            }
        }

        /// <summary>
        /// Get the ID for a particular Product_Supplier entry using the corresponding product id and supplier id.
        /// </summary>
        /// <param name="db"></param>
        /// <param name="ProductID">Int ID for the given product</param>
        /// <param name="SupplierID">Int ID for a paired supplier to that product.</param>
        /// <returns>ProductSupplier ID.</returns>
        public static int FindProdSuppID(travelexpertsDataContext db, int ProductID, int SupplierID)
        {
            int ProdSuppID =
                (from prodsupp in db.Products_Suppliers
                 join Products in db.Products
                 on prodsupp.ProductId equals Products.ProductId
                 join suppliers in db.Suppliers
                 on prodsupp.SupplierId equals suppliers.SupplierId
                 where (Products.ProductId == ProductID
                 && suppliers.SupplierId == SupplierID)
                 select prodsupp.ProductSupplierId).SingleOrDefault();

            return ProdSuppID;
        }

        /// <summary>
        /// Get a subset of suppliers with associations to one given product in the ProductSuppliers table.
        /// </summary>
        /// <param name="db">DB context</param>
        /// <param name="productID">Int with ID for given product.</param>
        /// <returns>List of Supplier objects.</returns>
        public static List<Supplier> GetSuppliersByProductID(travelexpertsDataContext db, int productID)
        {
            List<Supplier> filteredSuppliers = 
                (from prodsupp in db.Products_Suppliers
                join Products in db.Products
                on prodsupp.ProductId equals Products.ProductId
                join Suppliers in db.Suppliers
                on prodsupp.SupplierId equals Suppliers.SupplierId
                where Products.ProductId == productID
                select Suppliers).ToList();

            return filteredSuppliers;
        }


        /// <summary>
        /// Determine whether the combination of package ID and ProductSupplier ID exists
        /// </summary>
        /// <param name="packageID">Package ID</param>
        /// <param name="prodSuppID">Product Supplier ID</param>
        /// <returns>returns false if not found</returns>
        public static bool ExistPackagesProductsSupplier(int packageID, int prodSuppID)
        {
            using(travelexpertsDataContext db = new travelexpertsDataContext())
            {
                var package = db.Packages_Products_Suppliers.SingleOrDefault(p =>
                                               p.PackageId == packageID &&
                                               p.ProductSupplierId == prodSuppID);
                if (package == null)
                    return false;
                else
                    return true;
            }
        }
    }
}
