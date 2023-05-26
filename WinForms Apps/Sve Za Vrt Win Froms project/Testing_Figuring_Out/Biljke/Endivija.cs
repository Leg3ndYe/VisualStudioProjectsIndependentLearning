using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Endivija:IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Kupusnjače \n" +
                "Poriluk \n" +
                "Grah");
        }

        public string LosiSusjedi()
        {
            return string.Format("Radič");
        }
    }
}
