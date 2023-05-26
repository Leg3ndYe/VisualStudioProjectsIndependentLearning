using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Tikvice : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Kukuruz \n" +
                "Dragoljub \n" +
                "Grah \n" +
                "Luk \n" +
                "Cikla");
        }

        public string LosiSusjedi()
        {
            return string.Format(" ");
        }
    }
}
