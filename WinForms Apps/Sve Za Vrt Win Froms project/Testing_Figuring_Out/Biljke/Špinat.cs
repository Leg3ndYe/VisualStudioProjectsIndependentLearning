using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Špinat : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Rajčica \n" +
                "Grah \n" +
                "Krumpir \n" +
                "Jagoda \n" +
                "Rotkvica \n" +
                "Korabica \n" +
                "Celer \n" +
                "Kupusnjače");
        }

        public string LosiSusjedi()
        {
            return string.Format("Cikla \n" +
                "Blitva");
        }
    }
}
