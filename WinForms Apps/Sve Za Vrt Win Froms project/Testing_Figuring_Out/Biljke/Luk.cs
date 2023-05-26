using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Luk : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Kopar \n" +
                "Jagoda \n" +
                "Krastavac \n" +
                "Salata \n" +
                "Mrkva \n" +
                "Cikla \n" +
                "Radič");
        }

        public string LosiSusjedi()
        {
            return string.Format("Grah \n" +
                "Grašak \n" +
                "Kupusnjače");
        }
    }
}
