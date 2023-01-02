namespace Class_Inheritance
{
    class Employed : Human
    {
        public string NameOfCompany { get; }
        public string Position { get; }
        public double Salary { get; }

        public Employed(BaseHumanInfo baseHumanInfo, string nameOfCompany, string position, double salary) : base(baseHumanInfo)
        {
            NameOfCompany = nameOfCompany;
            Position = position;
            Salary = salary;
        }

        public override string GetInfo()
        {
            string humanInfo = base.GetInfo();
            return humanInfo +
                $"\nCompany: {NameOfCompany}" +
                $"\nPosition: {Position}" +
                $"\nSalary: {Salary}";
        }
    }
}
