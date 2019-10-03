using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    /// <summary>
    /// ArrayLIst
    /// Author: Santosh
    /// Date: 29-08-2019
    /// </summary>
    class Program
    {
        // ArrayList Demo
        static void Main(string[] args)
        {
            #region ArraYLIST DEMO
            //ArrayList arrayListObj = new ArrayList();
            //arrayListObj.Add("Message1");
            //arrayListObj.Add(1);
            //arrayListObj.Add("3");
            //arrayListObj.Add("4");
            //arrayListObj.Add("5");
            //arrayListObj.Add("5");
            //arrayListObj.Add("3234");
            //arrayListObj.Add("Mess2342age1");
            //arrayListObj.Add("Mess234234age1");
            //arrayListObj.Add("Mes4234234sage1");
            //arrayListObj.Add("Mes23423423sage1");
            //arrayListObj.Add("Mess23423age1");
            //foreach (var item in arrayListObj)
            //{
            //    Console.WriteLine($"Content : {item}");
            //}
            //ArrayList newArrayListObj = new ArrayList();
            //newArrayListObj.Add("Messasdasdasage1");
            //newArrayListObj.Add("Mdasdasdessage2");
            //newArrayListObj.Add("asdasda3");
            //newArrayListObj.Add("sdasd4");
            //newArrayListObj.Add("asdasd5");
            //newArrayListObj.Add("adadsdas5");
            //newArrayListObj.Add("3asdasd234");
            //Stack stack = new Stack();
            //stack.Push("asdfnshdfsdf");
            //stack.Push("asdfnshdsdfsdfsdfsdf");
            //stack.Push("asdfnshdfsdf");
            //arrayListObj.AddRange(newArrayListObj);
            //arrayListObj.AddRange(stack);
            //Console.WriteLine("====================");



            //arrayListObj[0] = "Santosh";
            //foreach (var item in arrayListObj)
            //{
            //    Console.WriteLine($"Content : {item}");
            //}
            #endregion

            #region GENERIC TYPE SAFE

            //List<int> arrayList = new List<int>();
            //arrayList.Add(1);
            //arrayList.Add("23");
            //arrayList.Add(323);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region DICTIONARY

            //Dictionary<int, string> dicObj = new Dictionary<int, string>();
            //dicObj.Add(1,"Santosh");
            //dicObj.Add(2, "Senapati");
            //foreach (var item in dicObj)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //var nameValue = ConfigurationManager.AppSettings.GetValues("name");

            #endregion

            #region HAsh Table

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "vdhsdfsd");
            //hashtable.Add(2, "vdhsdfsdfsdfsdfsd");
            //Dictionary<int, string> dicObj = new Dictionary<int, string>();
            //dicObj.Add(1, "sdfsdf");
            //dicObj.Add(2, "vdhsdsdfsdfsdfsd");

            Console.WriteLine(hashtable.ContainsKey(1));

            #endregion



            Console.ReadKey();
        }
    }
}
