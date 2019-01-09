using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BudgetControl.Class.Ext
{
    public static class ValueExtension
    {
        public static bool IsTwoDigit(this TextBox txt)
        {
            return Regex.IsMatch(txt.Text, @"^(\d*,*\d*)*(\.\d+)?$");
            //return Regex.IsMatch(txt.Text, @"^(((\d{1,3})(,\d{3})*)|(\d+))(\.\d{1}(\d{1})?)?$");
        }

        public static bool IsInteger(this TextBox txt)
        {
            return Regex.IsMatch(txt.Text, @"^(\d*,*\d*)*$");
        }

        public static string TwoDigitFormat(this string txt)
        {
            decimal d = 0;

            decimal.TryParse(txt.Replace(",", String.Empty), out d);

            return String.Format("{0:#,0.00}", d);
        }
        public static string ThreeDigitFormat(this string txt)
        {
            decimal d = 0;

            decimal.TryParse(txt.Replace(",", String.Empty), out d);

            return String.Format("{0:#,0.000}", d);
        }

        public static string ThreeDigitFormat(this object obj)
        {
            return Convert.ToDecimal(obj).ToString("#,0.000");
        }

        public static string TwoDigitFormat(this object obj)
        {
            return Convert.ToDecimal(obj).ToString("#,0.00");
        }

        public static string IntegerFormat(this string txt)
        {
            decimal d = 0;

            decimal.TryParse(txt.Replace(",", String.Empty), out d);

            return String.Format("{0:#,0}", d);
        }

        public static string IntegerFormat(this object obj)
        {
            return Convert.ToDecimal(obj).ToString("#,0");
        }

        public static bool IsNumberOrDigit(this char c)
        {
            if (char.IsNumber(c) || c == '.' || c == ',' || c == '\b') return true;
            return false;
        }

        public static int? ToInt(this object obj)
        {
            try
            {

                return Convert.ToInt32(obj);
            }
            catch
            {
                return null;
            }
        }
        public static int ToIntorDefault(this object obj)
        {
            try
            {

                return Convert.ToInt32(obj);
            }
            catch
            {
                return 0;
            }
        }
        public static decimal? ToDecimal(this object obj)
        {
            try
            {

                return Convert.ToDecimal(obj);
            }
            catch
            {
                return null;
            }
        }
        public static decimal ToDecimalorDefault(this object obj)
        {
            try
            {

                return Convert.ToDecimal(obj);
            }
            catch
            {
                return 0;
            }
        }
    }
}
