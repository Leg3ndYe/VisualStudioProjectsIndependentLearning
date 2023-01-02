using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath2 = @"D:\Programs\Microsoft Visual Studio projects\DirectoryFunctions\C#Data\testfile2.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);
            string randString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for(int i = 0; i < fileByteArray.Length; i++) 
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();
        }
    }
}
