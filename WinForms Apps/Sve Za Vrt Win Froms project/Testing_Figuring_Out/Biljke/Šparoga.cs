using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Šparoga : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Krastavac \n" +
                "Salata \n" +
                "Peršin \n" +
                "Rajčica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Luk \n" +
                "Češnjak");
        }
    }
}
