using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
