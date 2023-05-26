using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Brokula : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Luk \n" +
                "Poriluk \n" +
                "Celer \n" +
                "Ružmarin \n" +
                "Kopar \n" +
                "Kadulja \n" +
                "Kamilica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Luk \n" +
                "Češnjak");
        }
    }
}
