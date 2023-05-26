using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Celer : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Niski grah \n" +
                "Krastavac \n" +
                "Kamilica \n" +
                "Kupusnjače \n" +
                "Poriluk \n" +
                "Rajčica");

        }

        public string LosiSusjedi()
        {
            return string.Format("Krumpir \n" +
                "Salata \n" +
                "Kukuruz");
        }
    }
}
