namespace Class_Inheritance
{
    public class BaseHumanInfo
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Gender { get; }

        public BaseHumanInfo(string gender, int age, string surname, string name)
        {
            Gender = gender;
            Age = age;
            Surname = surname;
            Name = name;
        }
    }
}
