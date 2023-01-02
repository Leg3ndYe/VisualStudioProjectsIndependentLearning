using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class GradeList : List<Grade>
    {
        public IEnumerable<int> SubjectGrade => this.Select(x => x.SubjectGrade);
        public GradeList()
        {
        }
        public IEnumerable<int> GetGradeList()
        {
            List<int> gradeOutputList = new List<int>();
            gradeOutputList.AddRange(SubjectGrade);
            return gradeOutputList;
        }
        public static GradeList InputGradesInList(int numberOfGrades)
        {
            int loops = 0;
            GradeList listOfGrades = new GradeList();
            do
            {
                Grade grade = Grade.InputGrade();
                listOfGrades.Add(grade);
                loops++;

            } while (loops != numberOfGrades);
            return listOfGrades;
        }
        public static string GetCalculatedGrade(GradeList listOfGrades)
        {
            float gradesSumedUp = 0;
            float amountOfGrades = listOfGrades.Count;
            foreach (int grade in listOfGrades.GetGradeList())
            {
                gradesSumedUp += grade;
            }
            float result = gradesSumedUp / amountOfGrades;
            int finalGrade = Convert.ToInt32(gradesSumedUp) / Convert.ToInt32(amountOfGrades);
            return $"Your decimal grade is: {result.ToString("0.00")}" +
                   $"\nYour final grade is: {finalGrade}";
        }
    }
}
