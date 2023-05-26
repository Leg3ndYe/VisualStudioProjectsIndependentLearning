using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    class Mrkva : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grašak \n" +
                    "Češnjak \n" +
                    "Rajčica \n" +
                    "Radič \n" +
                    "Luk \n" +
                    "Poriluk \n" +
                    "kadulja \n" +
                    "Rotkva \n" +
                    "Blitva");
        }
        public string LosiSusjedi()
        {
            return string.Format("Kopar \n" +
                    "Anis");
        }
    }
}
