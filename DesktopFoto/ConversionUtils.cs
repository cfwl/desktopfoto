using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopFoto
{
    static class ConversionUtils
    {
        public static int ToInt32(this string s,int deflt)
        {
            int result = deflt;
            if (!Int32.TryParse(s, out result))
                result = deflt;

            return result;
        }

        public static string ToString(this string s, string deflt)
        {
            string result = deflt;
            if (string.IsNullOrWhiteSpace(s))
                result = deflt;
            else
                result = s;

            return result;
        }
    }
}
