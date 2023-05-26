using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Krumpir : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Bob \n" +
                "Kamilica \n" +
                "Dragoljub \n" +
                "Kupusnjače \n" +
                "Kim \n" +
                "Kukuruz \n" +
                "Hren \n" +
                "Paprena metvica \n" +
                "Špinat \n" +
                "Kadifica");
        }

        public string LosiSusjedi()
        {
            return string.Format("Grašak \n" +
                "Bundeva \n" +
                "Cikla \n" +
                "Celer \n" +
                "Suncokret \n" +
                "Rajčica");
        }
    }
}
