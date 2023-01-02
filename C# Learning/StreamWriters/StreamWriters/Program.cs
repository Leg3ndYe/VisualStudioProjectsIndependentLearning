using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath3 = @"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data\testfile3.txt";
            StreamWriter sw = new StreamWriter(textFilePath3);
            sw.Write("This is a random ");
            sw.WriteLine("sentence.");
            sw.WriteLine("This is nother sentence.");
            sw.Close();

            StreamReader sr = new StreamReader(textFilePath3);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String : {0}", sr.ReadLine());

            Console.WriteLine("Everything Else : {0}", sr.ReadToEnd());
        }
    }
}
