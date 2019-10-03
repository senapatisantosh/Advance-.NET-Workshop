using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{
    class OfTypeDemo
    {
        public static void OfTypeExample()
        {
            List<object> list = new List<object>();
            list.Add(1);
            list.Add("wdqweqwe");
            list.Add(6.5);
            list.Add(5.5f);
            list.Add(new { Name = "santosh"});
            foreach (var item in list.OfType<object>())
            {
                if(item.GetType().ToString().Contains("__Ano"))
                {
                    foreach (var item2 in item.GetType().GetProperties())
                    {
                        Console.WriteLine(item2.GetValue(item));
                    }
                }
            }
        }
    }
}
