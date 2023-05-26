using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Korabica : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grah \n" +
                "Grašak \n" +
                "Krumpir \n" +
                "Salata \n" +
                "Poriluk \n" +
                "Rotkvica \n" +
                "Špinat \n" +
                "Rajčica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Rajčica \n" +
                "Rikola");
        }
    }
}
