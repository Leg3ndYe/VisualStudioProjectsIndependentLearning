using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class SubjectList : List<Subject>
    {
        public IEnumerable<string> SubjectName => this.Select(x => x.SubjectName);  
        public SubjectList()
        {
            
        }
        public IEnumerable<string> GetSubjectList()
        {
            List<string> subjectOutputList = new List<string>();
            subjectOutputList.AddRange(SubjectName);
            return subjectOutputList;
        }
        public static SubjectList InputSubjectsInList()
        {
            char choice = ' ';
            SubjectList listOfSubjects = new SubjectList();
            do
            {
                Subject subject = Subject.InputSubject();
                listOfSubjects.Add(subject);
                Console.Write("Would you like to add another subject? ");
                choice = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (choice == 'Y');
            Console.Clear();
            return listOfSubjects;
        }

    }
}
