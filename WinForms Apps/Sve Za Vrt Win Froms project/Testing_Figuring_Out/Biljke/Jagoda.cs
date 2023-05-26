using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Jagoda : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grah \n" +
                "Češnjak \n" +
                "Salata \n" +
                "Poriluk \n" +
                "Rotkvica \n" +
                "Vlasac \n" +
                "Špinat \n" +
                "Luk");
        }

        public string LosiSusjedi()
        {
            return string.Format("Kupusnjače");
        }
    }
}
