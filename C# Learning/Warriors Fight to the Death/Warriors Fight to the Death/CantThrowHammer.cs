using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Fight_to_the_Death
{
    class CantThrowHammer : IThrowsHammer
    {
        public string throwsHammer()
        {
            return "Fails at throwing hammer";
        }
    }
}
