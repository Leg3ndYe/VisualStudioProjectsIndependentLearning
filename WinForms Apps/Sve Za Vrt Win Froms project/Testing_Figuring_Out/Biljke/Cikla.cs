using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Cikla : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Niski grah \n" +
                "Kopar \n" +
                "Krastavac \n" +
                "Češnjak \n" +
                "Kupusnjače \n" +
                "Korijandar \n" +
                "Kim \n" +
                "Salata \n" +
                "Tikvice \n" +
                "Luk");
        }

        public string LosiSusjedi()
        {
            return string.Format("Krumpir \n" +
                "Poriluk \n" +
                "Kukuruz \n" +
                "Špinat");
        }
    }
}
