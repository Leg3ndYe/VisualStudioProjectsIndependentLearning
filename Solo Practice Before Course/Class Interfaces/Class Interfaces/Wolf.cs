
namespace Class_Interfaces
{
    internal class Wolf : Animal
    {
        public Wolf(int speed, int weight)
        {
            Speed = speed;
            Weight = weight;
        }

        public override string GetHunterInfo()
        {
            return "Wolves are hunted by: grizzly bears, polar bears, Siberian tigers, scavengers, and of course, humans.";
        }

        public override string GetInfo()
        {
            return "You chose to be a wolf." +
                 "\nYour specs are: " +
                $"\nSpeed: {Speed} km/h" +
                $"\nWeight: {Weight} kg" +
                $"\n{GetPreyInfo()}" + 
                $"\n{GetHunterInfo()}";
                
        }
        public override string GetPreyInfo()
        {
            return "Wolves like to eat: deer, elk, bison, and moose.";
        }

        public static Wolf CreateDefault()
        {
            int wolfspeed = 50;
            int wolfweight = 5;
            return new Wolf(wolfspeed, wolfweight);
        }
    }
}
