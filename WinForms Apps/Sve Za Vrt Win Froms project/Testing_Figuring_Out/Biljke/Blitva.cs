using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Blitva : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Grah \n" +
                "Kupusnjače \n" +
                "Mrkva \n" +
                "Rotkvica \n" +
                "Brokula \n" +
                "Kukuruz");
        }

        public string LosiSusjedi()
        {
            return string.Format("Cikla \n" +
                "Špinat");
        }
    }
}
