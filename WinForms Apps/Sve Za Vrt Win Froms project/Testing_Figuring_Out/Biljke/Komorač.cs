using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Komorač : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Endivija \n" +
                "Grašak \n" +
                "Matovilac \n" +
                "Krastavac \n" +
                "Salata \n" +
                "Kadulja \n" +
                "Radič");
        }

        public string LosiSusjedi()
        {
            return string.Format("Kopar \n" +
                "Grah \n" +
                "Kim \n" +
                "Rajčica");
        }
    }
}
