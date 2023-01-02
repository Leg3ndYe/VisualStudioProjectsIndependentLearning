using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Fight_to_the_Death
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paladin thor = new Paladin("Thor", 100, 26, 10, 40);
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 60);
            Battle.StartFight(thor, loki);
        }
    }
}
