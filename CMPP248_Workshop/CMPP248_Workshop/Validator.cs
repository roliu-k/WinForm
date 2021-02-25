using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    public static class Validator
    {
        public static bool IsPresent(string attrName, TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(attrName + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsCorrectLength(string attrName, TextBox textBox, int maxLen)
        {
            if ((textBox.Text).Length > maxLen)
            {
                MessageBox.Show(attrName + " can be at most " + maxLen.ToString() + " long", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsDecimal(string attrName, TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, NumberStyles.Currency, null, out number) )
            {
                return true;
            }
            else
            {
                MessageBox.Show(attrName + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(string attrName, TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(attrName + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsNonNegativeDecimal(string attrName, TextBox textBox)
        {
            decimal number = Decimal.Parse(textBox.Text, NumberStyles.Currency);

            if (number < 0)
            {
                MessageBox.Show(attrName + " must be positive or zero" , "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsNonNegativeInt(string attrName, TextBox textBox)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(attrName + " must be positive or zero", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsLEBasePrice(TextBox txtBasePrice, TextBox txtAgencyCommission)
        {
            decimal commission = Decimal.Parse(txtAgencyCommission.Text, NumberStyles.Currency);
            decimal basePrice = Decimal.Parse(txtBasePrice.Text, NumberStyles.Currency);
            if (commission > basePrice)
            {
                MessageBox.Show(txtAgencyCommission.Tag + " cannot be greater than the " + txtBasePrice.Tag, "Entry Error");
                txtAgencyCommission.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validates whether or not a given product and supplier combination already exists in the database. [Eric]
        /// </summary>
        /// <param name="db">Database context</param>
        /// <param name="prodId">Int product ID to check</param>
        /// <param name="supId">Int supplier ID to check</param>
        /// <param name="prodSupId">Optional - An existing productsupplier entry to disregard (if modifying an exisiting one, in case it's left unchanged).</param>
        /// <returns></returns>
        public static Products_Supplier prodSupComboAlreadyExists(travelexpertsDataContext db, int prodId, int supId, int prodSupId = -1)
        {
            var matchingProps = db.Products_Suppliers // search the Products_Suppliers table for entries...
                   .Where(ps => ps.ProductId == prodId) // ...matching the new product id...
                   .Where(ps => ps.SupplierId == supId)// ... and matching the new supplier id...
                   .Where(ps => ps.ProductSupplierId != prodSupId) //... but with a different prodsupplierID
                   .FirstOrDefault(); // We can stop at the first, though there won't be more than one

            // If no match was found, we're good
            return matchingProps;
        }

        // add a validation to make sure end date does not occur before start date [Ronnie]
        public static bool IsValidEndDate(DateTimePicker pkgStartDateDateTimePicker, DateTimePicker pkgEndDateDateTimePicker, ref DateTime? tmpEndDate)
        {
            bool valid = false;
            DateTime? startDate = null;
            DateTime? endDate = null;

            if (pkgStartDateDateTimePicker.Text != " ")
            {
                startDate = pkgStartDateDateTimePicker.Value;
            }
            if (pkgEndDateDateTimePicker.Text != " ")
            {
                endDate = pkgEndDateDateTimePicker.Value;
            }

            if (endDate != null)
            {
                if (endDate > startDate || startDate == null)
                {
                    pkgEndDateDateTimePicker.Enabled = true;
                    pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Short;
                    tmpEndDate = endDate;
                    valid = true;
                }
                else
                    MessageBox.Show("The package end date should be later than package start date", "Input Error");
            }

            // when both fields are empty, return true
            if (endDate == null && startDate == null)
                valid = true;

            return valid;
        }
    }
}
