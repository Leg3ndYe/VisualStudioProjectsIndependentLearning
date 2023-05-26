using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Rajčica : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Bosiljak \n" +
                "Cikla \n" +
                "Celer \n" +
                "Grah \n" +
                "Dragoljub \n" +
                "Mrkva \n" +
                "Poriluk \n" +
                "Peršin \n" +
                "Salata \n" +
                "Češnjak \n" +
                "Špinat \n" +
                "Grah \n" +
                "Radič \n" +
                "Šparoge \n" +
                "Tikvice");
        }

        public string LosiSusjedi()
        {
            return string.Format("Krumpir \n" +
                "Komorač \n" +
                "Grašak \n" +
                "Krastavci \n" +
                "Patlidžan \n" +
                "Kupus \n" +
                "Kelj");
        }
    }
}
