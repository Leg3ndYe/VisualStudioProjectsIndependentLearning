using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Rotkvica : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Blitva \n" +
                "Mrkva \n" +
                "Grašak \n" +
                "Dragoljub \n" +
                "Grah \n" +
                "Kupusnjače \n" +
                "Salata \n" +
                "Špinat \n" +
                "Rajčica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Krastavac");
        }
    }
}
