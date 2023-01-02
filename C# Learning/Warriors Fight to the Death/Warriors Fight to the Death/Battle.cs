using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Fight_to_the_Death
{
    class Battle
    {
        // StartFight
        // war1 attacks war1, war2 is damaged and health decreases
        // Get attack result
        // war1 attacks war2, war1 is damaged and health decreases
        // Get attack result
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        // Get Attack Result
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, dmg2WarB);
            Console.WriteLine("{0} has {1} Health\n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is Victorious.\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }
            else return "Fight Again";


        }
    }
}
