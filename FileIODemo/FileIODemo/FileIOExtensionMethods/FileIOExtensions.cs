using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo.FileIOExtensionMethods
{
    internal static class FileIOExtensions
    {
        public static T GetContentWithLineno<T>(this IEnumerable<T> genericCollection, int lineNO) where T:class
        {
            T temp = null;
            try
            {
                temp = genericCollection.ElementAt<T>(lineNO);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index Out Of Range Exception : Enter INdex less than {genericCollection.Count<T>()}");
            }
            return temp;
        }
    }
}
