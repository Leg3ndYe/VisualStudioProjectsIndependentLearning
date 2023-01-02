using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOne = new List<int>(new int[] {1, 3, 4});
            var listTwo = new List<int>(new int[] {4, 6, 8});
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach (var item in sumList) { Console.WriteLine(item); }
        }
    }
}
