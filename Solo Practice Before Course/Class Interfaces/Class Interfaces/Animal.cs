
namespace Class_Interfaces
{
    abstract class Animal : IPrey, IHunt
    {
        public int Speed { get; set; }
        public int Weight { get; set; }

        public abstract string GetHunterInfo();
        public abstract string GetPreyInfo();
        public abstract string GetInfo();
    }
}
