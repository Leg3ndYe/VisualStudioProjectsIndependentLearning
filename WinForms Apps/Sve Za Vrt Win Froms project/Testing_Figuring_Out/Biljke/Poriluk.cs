using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Poriluk : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Endivija \n" +
                "Mrkva \n" +
                "Celer \n" +
                "Rajčica \n" +
                "Korabica \n" +
                "Salata \n" +
                "Kamilica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Crveni luk \n" +
                "Grah \n" +
                "Cikla \n" +
                "Bob \n" +
                "Pastrnjak \n" +
                "Luk kozjak");
        }
    }
}
