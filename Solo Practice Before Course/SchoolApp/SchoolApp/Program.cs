using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectList listOfSubjects = SubjectList.InputSubjectsInList();
            int numberOfGrades = listOfSubjects.Count;
            
            GradeList listOfGrades = GradeList.InputGradesInList(numberOfGrades);

            foreach (string subject in listOfSubjects.GetSubjectList())
            {
                Console.Write( $"{subject} ");
            }
            Console.WriteLine();

            foreach (int grade in listOfGrades.GetGradeList())
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
            Console.WriteLine(GradeList.GetCalculatedGrade(listOfGrades));
        }
    }
}
