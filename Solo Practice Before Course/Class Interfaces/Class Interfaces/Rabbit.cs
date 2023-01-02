
namespace Class_Interfaces
{
    internal class Rabbit : Animal
    {
        public Rabbit (int speed, int weight)
        {
            Speed = speed;
            Weight = weight;
        }

        public override string GetHunterInfo()
        {
            return "Rabbits are hunted by: large hawks and owls, domestic dogs, coyotes, foxes, and bobcats";
        }

        public override string GetInfo()
        {
            return "You chose to be a rabbit." +
                 "\nYour specs are: " +
                $"\nSpeed: {Speed} km/h" +
                $"\nWeight: {Weight} kg" +
                $"\n{GetPreyInfo()}" +
                $"\n{GetHunterInfo()}";
        }
        public override string GetPreyInfo()
        {
            return "Rabbits like to eat: things like grass, seeds, fruits and vegetables.";
        }
        public static Rabbit CreateDefault()
        {
            int rabbitspeed = 30;
            int rabbitweight = 2;
            return new Rabbit(rabbitspeed, rabbitweight);
        }
    }
    
    
}
