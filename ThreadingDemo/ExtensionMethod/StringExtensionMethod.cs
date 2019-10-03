using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtensionMethod
    {
        public static string Greet(this string obj)
        {
            return $"Good Morning {obj}";
        }
    }
}
