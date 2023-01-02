using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo lukasDir = new DirectoryInfo(@"D:\Programs\Microsoft Visual Studio projects");
            
            Console.WriteLine(lukasDir.FullName);
            Console.WriteLine(lukasDir.Name);
            Console.WriteLine(lukasDir.Parent);
            Console.WriteLine(lukasDir.Attributes);
            Console.WriteLine(lukasDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data");
            dataDir.Create();

            //Directory.Delete(@"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data");

            string[] customers =
            {
               "Bob Smith",
               "Sally Smith",
               "Robert Smith"
            };
            string textFilePath = @"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);

            foreach(string cust in File.ReadAllLines(textFilePath)) 
            {
                Console.WriteLine($"Customer : {cust}");
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data");

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches : {0}", txtFiles.Length);

            foreach(FileInfo file in txtFiles) 
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }
           
        }
    }
}
