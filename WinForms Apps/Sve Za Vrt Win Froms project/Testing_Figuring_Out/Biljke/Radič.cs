using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Figuring_Out.Biljke
{
    internal class Radič : IDobriLosiSusjedi
    {
        public string DobriSusjedi()
        {
            return string.Format("Salata \n" +
                "Grah \n" +
                "Mrkva \n" +
                "Grah \n" +
                "Rajčica");
        }

        public string LosiSusjedi()
        {
            return string.Format(" ");
        }
    }
}
