using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Fight_to_the_Death
{
    class Paladin : Warrior
    {
        int throwChance = 0;
        CanThrowHammer paladinType = new CanThrowHammer();
        Random rnd = new Random();
        public Paladin(string name = "Warrior", double health = 0, double attkMax = 0, double blockMax = 0, int throwChance = 0) 
            : base(name, health, attkMax, blockMax)
        {
            this.throwChance = throwChance;
        }
        public override double Attack()
        {
            int rndThrowHammer = rnd.Next(1, 100);
            if(rndThrowHammer < this.throwChance)
            {
                Console.WriteLine($"{Name} {paladinType.throwsHammer()}");
                return base.Attack()+20;
            }
            else
            {
                return base.Attack();
            }
        }
    }
}
