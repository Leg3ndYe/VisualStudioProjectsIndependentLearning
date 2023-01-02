using System;

namespace Class_Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Human human = GetHuman();

            Console.Clear();
            Console.WriteLine(human.GetInfo());

            Console.ReadLine();
        }

        public static Human GetHuman()
        {
            BaseHumanInfo humanInfo = GetHumanInfo();

            Console.WriteLine("Input if you are: Employed (E) Student (S) Jobless (J)");
            char question = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (question)
            {
                case 'E':
                    return GetEmployee(humanInfo);
                case 'S':
                    return GetStudent(humanInfo);
                default:
                    return GetJobless(humanInfo);
            }
        }

        private static Human GetJobless(BaseHumanInfo humanInfo)
        {
            Console.Write("Where do you live: ");
            string residence = Console.ReadLine();
            Console.Write("Why are you jobless: ");
            string reason = Console.ReadLine();
            return new Jobless(humanInfo, residence, reason);
        }

        private static Human GetStudent(BaseHumanInfo humanInfo)
        {
            Console.Write("Student ID: ");
            int studentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade you are in: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Favorite subject: ");
            string favoriteSubject = Console.ReadLine();
            return new Student(humanInfo, studentID, grade, favoriteSubject);
        }

        private static Human GetEmployee(BaseHumanInfo humanInfo)
        {
            Console.Write("Name of the company: ");
            string nameOfCompany = Console.ReadLine();
            Console.Write("Your position in the company: ");
            string position = Console.ReadLine();
            Console.Write("Your salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            return new Employed(humanInfo, nameOfCompany, position, salary);
        }

        private static BaseHumanInfo GetHumanInfo()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            BaseHumanInfo humanInfo = new BaseHumanInfo(gender, age, surname, name);
            return humanInfo;
        }
    }
}
