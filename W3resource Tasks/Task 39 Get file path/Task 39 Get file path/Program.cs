using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_39_Get_file_path
{
    internal class Program
    {
        /* Task: Write a C# Sharp program to get the file name (including extension) from a given path.*/
        static void Main(string[] args)
        {
            string filePath = "c:/csharp/ex/test.cpp";
            Console.WriteLine(GetDotFile(filePath));
        }
        public static string GetDotFile(string filePath)
        {
            return filePath.Split('/').Last();
        }

    }
}
