using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace gbacomp
{
    public static class Extensions
    {
        public static bool TryParseHex(string str, out int result)
        {
            return int.TryParse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
        }
    }
}
