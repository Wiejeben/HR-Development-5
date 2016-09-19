using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class NameConversion
    {
        public static string SnakeToPascal(string value)
        {
            var textInfo = new CultureInfo("en-US").TextInfo;

            return textInfo.ToTitleCase(value).Replace("_", string.Empty);
        }

        public static string PascalToSnake(string value)
        {
            return string.Concat(value.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
