using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Grašak : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Kopar \n" +
                "Komorač \n" +
                "Krastavac \n" +
                "Kupusnjače \n" +
                "Salata \n" +
                "Kukuruz \n" +
                "Mrkva \n" +
                "Rotkvica \n" +
                "Tikvice \n" +
                "Rikola");
        }

        public string LosiSusjedi()
        {
            return string.Format("Krumpir \n" +
                "Ćešnjak \n" +
                "Poriluk \n" +
                "Rajčica \n" +
                "Luk");
        }
    }
}
