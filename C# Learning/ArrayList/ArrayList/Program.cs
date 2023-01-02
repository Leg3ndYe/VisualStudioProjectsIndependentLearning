using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code

            ArrayList aList = new ArrayList();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count : {0}", aList.Count);
            Console.WriteLine("Capacity : {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();

            aList.Insert(1, "Turkey");

            aList2.RemoveAt(0);
            aList2.RemoveRange(0, 2);

            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));

            foreach (object o in aList) Console.WriteLine(o);

            string[] myArray = (string[])aList.ToArray(typeof(string));

            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            #endregion
        }
    }
}
