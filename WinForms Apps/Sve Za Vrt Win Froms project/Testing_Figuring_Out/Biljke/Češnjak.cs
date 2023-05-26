using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Cesnjak : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Jagoda \n" +
                "Krastavac \n" +
                "Malina \n" +
                "Ljiljani \n" +
                "Mrkva \n" +
                "Voćke \n" +
                "Ruža \n" +
                "Cikla \n" +
                "Rajčica \n" +
                "Tulipan");
        }

        public string LosiSusjedi()
        {
            return string.Format("Grašak \n" +
                "Kupusnjače \n" +
                "Grah");
        }
    }
}
