using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Rukola : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Salata \n" +
                "Grah \n" +
                "Mrkva \n" +
                "Celer \n" +
                "Krastavci \n" +
                "Krumpir \n" +
                "Špinat");
        }

        public string LosiSusjedi()
        {
            return string.Format("Kupus \n" +
                "Kelj \n" +
                "Cvjetača \n" +
                "Brokula \n" +
                "Repa \n" +
                "Rotkvica");
        }
    }
}
