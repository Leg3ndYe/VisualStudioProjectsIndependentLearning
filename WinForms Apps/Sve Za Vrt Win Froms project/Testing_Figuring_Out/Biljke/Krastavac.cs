using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Krastavac : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grah \n" +
                "Kopar \n" +
                "Grašak \n" +
                "Komorač \n" +
                "Kupusnjače \n" +
                "Salata \n" +
                "Koijandar \n" +
                "Kim \n" +
                "Poriluk \n" +
                "Celer \n" +
                "Luk \n" +
                "Peršin \n" +
                "Grašak");
        }

        public string LosiSusjedi()
        {
            return string.Format("Rotkvica \n" +
                "Rajčica");
        }
    }
}
