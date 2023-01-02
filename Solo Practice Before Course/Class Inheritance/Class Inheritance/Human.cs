using System.Xml.Linq;

namespace Class_Inheritance
{
    abstract class Human
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Gender { get; }

        public Human(BaseHumanInfo baseHumanInfo)
        {
            Gender = baseHumanInfo.Gender;
            Age = baseHumanInfo.Age;
            Surname = baseHumanInfo.Surname;
            Name = baseHumanInfo.Name;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}" +
                $"\nSurname: {Surname}" +
                $"\nAge: {Age}" +
                $"\nGender: {Gender}";
        }
    }
}
