using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyoboiCalendarApi
{
    public static class StringExtensions
    {
        public static string ToKebabCase(this string str)
        {
            var separater = "-";
            //return str;
            var list = str.Select((x, i)
                => i > 0 && char.IsUpper(x)
                    ? separater + x.ToString()
                    : x.ToString());
            return string.Concat(list).Replace('_', '-').ToLower();
        }
    }
}
