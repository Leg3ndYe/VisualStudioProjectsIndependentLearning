using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    internal class Program
    {
        // ------ FUNCTIONS ------ //

        // -- END OF FUNCTIONS -- //
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Random text");
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);
            sb2.AppendLine("\nMore important text");
            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Lenght : {0}", sb2.Length);
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));
            sb2.Insert(11, "that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());
        }

    }
}
