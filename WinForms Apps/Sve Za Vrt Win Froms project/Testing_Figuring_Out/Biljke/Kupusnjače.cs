using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Kupusnjače : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grah \n" +
                "Kopar \n" +
                "Endivija \n" +
                "Grašak \n" +
                "Kamilica \n" +
                "Krumpir \n" +
                "Salata \n" +
                "Korijandar \n" +
                "Kim \n" +
                "Poriluk \n" +
                "Blitva \n" +
                "Paprena metvica \n" +
                "Cikla \n" +
                "Celer \n" +
                "Špinat \n" +
                "Rajčica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Jagoda \n" +
                "Gorušica \n" +
                "Češnjak \n" +
                "Luk");
        }
    }
}
