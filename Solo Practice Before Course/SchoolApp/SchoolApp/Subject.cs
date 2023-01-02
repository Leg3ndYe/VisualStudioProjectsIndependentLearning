using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Subject
    { 
        public string SubjectName { get; }
        public Subject (string subjectName)
        {
            SubjectName = subjectName;
        }
        public static Subject InputSubject()
        {
            string subjectName = "";
            Console.Write("Input subject name: ");
            subjectName = Console.ReadLine();
            return new Subject(subjectName);
        }
    }
}
