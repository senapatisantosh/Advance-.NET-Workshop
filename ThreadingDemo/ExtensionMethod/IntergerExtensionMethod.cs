using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class IntergerExtensionMethod
    {
        public static int Square(this int obj)
        {
            return obj * obj;
        }
    }
}
