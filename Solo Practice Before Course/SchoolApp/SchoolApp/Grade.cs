using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Grade
    {
        public int SubjectGrade { get; set; }
        public Grade(int subjectGrade)
        {
            SubjectGrade = subjectGrade;
        }
        public static Grade InputGrade()
        {
            int subjectGrade = 0;
            Console.Write("Input subject grade: ");
            subjectGrade = Convert.ToInt32(Console.ReadLine());
            return new Grade(subjectGrade);
        }
    }
}
