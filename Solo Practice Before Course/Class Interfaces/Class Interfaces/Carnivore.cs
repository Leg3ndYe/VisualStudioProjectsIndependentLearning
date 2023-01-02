using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Interfaces
{
    internal class Carnivore : IHunt, IPrey
    {
        public string GetHunterInfo()
        {
            return "I Hunt";
        }

        public string GetPreyInfo()
        {
            return "I am a Prey";
        }
    }
}
