using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWriters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath4 = @"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data\testfile4.txt";
            FileInfo datFile = new FileInfo(textFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randomText = "Random Text";
            string randomText2 = "Second random Text";
            int myAge = 47;
            double height = 187;
            bw.Write(randomText + 
                "\n" + randomText2);
            bw.Write(myAge);
            bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
