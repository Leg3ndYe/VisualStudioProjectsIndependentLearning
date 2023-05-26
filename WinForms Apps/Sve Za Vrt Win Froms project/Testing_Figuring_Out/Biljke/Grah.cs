using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Grah : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Jagoda \n" +
                "Krastavac \n" +
                "Krumpir \n" +
                "Kupusnjače \n" +
                "Salata \n" +
                "Cikla \n" +
                "Celer \n" +
                "Rajčica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Grašak \n" +
                "Komorač \n" +
                "Ćešnjak \n" +
                "Poriluk \n" +
                "Luk");
        }
    }
}
