using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dogs = {"K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin",
            "Benji", "Charlie B. Barkin", "Lassie", "Snoopy"};

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces) { Console.WriteLine(i); }
        }
    }
}
