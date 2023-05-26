using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Paprika : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Korabica \n" +
                "Dinje \n" +
                "Salata \n" +
                "Rotkvica \n" +
                "Kukuruz \n" +
                "Šparoga \n" +
                "Vlasac \n" +
                "Matovilac");
        }

        public string LosiSusjedi()
        {
            return string.Format("Bob \n" +
                "Grah");
        }
    }
}
