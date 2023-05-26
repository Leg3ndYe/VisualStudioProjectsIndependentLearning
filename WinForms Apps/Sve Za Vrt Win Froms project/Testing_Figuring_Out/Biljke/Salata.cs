using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Salata : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grah \n" +
                "Kopar \n" +
                "Grašak \n" +
                "Rajčica \n" +
                "Luk \n" +
                "Rotkvica \n" +
                "Komorač \n" +
                "Radič \n" +
                "Krastavac \n" +
                "Cikla \n" +
                "Jagoda \n" +
                "Korabica \n" +
                "Poriluk");
        }

        public string LosiSusjedi()
        {
            return string.Format("Peršin \n" +
                "Celer");
        }
    }
}
