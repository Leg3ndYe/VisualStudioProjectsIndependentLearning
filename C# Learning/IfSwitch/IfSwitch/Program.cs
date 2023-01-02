using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchWhile
{
    internal class Program
    {
        // If, Else If, Else, Switch
        static void Main(string[] args)
        {
            int age = 17;
            if ((age >= 5) && (age <= 7)) 
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");
            }
            if((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }
            Console.WriteLine("!true = " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another School");
                    break;
            }
            string name2 = "Derek";
            string name3 = "Derek";
            if(name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }

        }
    }
}
