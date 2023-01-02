using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numList2 = new List<int>() { 1, 2, 3, 2, 3 };
            Console.WriteLine("Sum : {0}", numList2.Aggregate((x,y) => x + y));

            Console.WriteLine("Average : {0}", numList2.AsQueryable().Average());

            Console.WriteLine("All > 3 : {0}", numList2.All(x => x > 3));

            Console.WriteLine("Any > 3 : {0}", numList2.Any(x => x > 3));

            Console.WriteLine("Distinct : {0}", string.Join(",", numList2.Distinct()));

            var numList3 = new List<int>() { 3 };

            Console.WriteLine("Except : {0}", string.Join(",", numList2.Except(numList3)));

            Console.WriteLine("Intersect : {0}", string.Join(",", numList2.Intersect(numList3)));
        }
    }
}
