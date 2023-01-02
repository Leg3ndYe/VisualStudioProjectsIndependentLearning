
namespace Class_Interfaces
{
    internal class Fox : Animal
    {
        public Fox(int speed, int weight)
        {
            Speed = speed;
            Weight = weight;
        }

        public override string GetHunterInfo()
        {
            return "Foxes are hunted by: eagles and coyotes.";
        }

        public override string GetInfo()
        {
            return "You chose to be a fox." +
                 "\nYour specs are: " +
                $"\nSpeed: {Speed} km/h" + 
                $"\nWeight: {Weight} kg" +
                $"\n{GetPreyInfo()}" +
                $"\n{GetHunterInfo()}";
        }
        public override string GetPreyInfo()
        {
            return "Foxes like to hunt: rabbits, rodents, birds, frogs and earthworms";
        }
        public static Fox CreateDefault()
        {
            int foxspeed = 50;
            int foxweight = 4;
            return new Fox(foxspeed, foxweight);
        }
    }
}
