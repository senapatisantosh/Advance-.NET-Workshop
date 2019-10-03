using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDEMO
{
    class CustomGenerics
    {
        internal static void Swapnumber<TOBj1>(ref TOBj1 t1, ref TOBj1 t2)
        {
            TOBj1 temp = t1;
            t1 = t2;
            t2 = temp;
        }
        internal static void print<T>(T tObj) where T : new ()
        {

            foreach (var item in typeof(T).GetProperties())
            {
                Console.WriteLine(item.Name+": "+item.GetValue(tObj));
            }
        }
    }
}
