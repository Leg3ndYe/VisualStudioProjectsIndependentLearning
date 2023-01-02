using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime awesomeDate = new System.DateTime(2006, 02, 03);
            Console.WriteLine("Day of the Week : {0}", awesomeDate.DayOfWeek);

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            TimeSpan lunchtime = new TimeSpan(12, 30, 0);
            lunchtime = lunchtime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}", lunchtime.ToString());

        }
    }
}
