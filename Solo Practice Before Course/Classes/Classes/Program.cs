using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classes.Program;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char repeat = ' ';
            string textafterinput = "";
            BookList listOfBooks = new BookList();
            char choiceAfterInput = ' ';
            do
            {
                do
                {
                    Book book = InputBook();
                    Console.Write("Would you maybe like to input another book? If Yes input (Y)");
                    repeat = Convert.ToChar(Console.ReadLine().ToUpper());
                    listOfBooks.Add(book);
                } while (repeat == 'Y');
                do
                {
                    Console.WriteLine(AfterInputText(textafterinput));
                    choiceAfterInput = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    int newline = 0;
                    foreach (string s in AfterChoiceOutput(choiceAfterInput, listOfBooks))
                    {
                        newline++;
                        Console.Write("{0} ", s);
                        if (choiceAfterInput == '4')
                        {
                            if (newline == 3)
                            {
                                Console.WriteLine();
                                newline = 0;
                            }
                        }
                        else if (choiceAfterInput == '5')
                        {
                            if (newline == listOfBooks.Count)
                            {
                                Console.WriteLine();
                                newline = 0;
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you maybe like to us to output something else? If Yes input (Y)");
                    Console.WriteLine("If you would like to input another book press (I)");
                    repeat = Convert.ToChar(Console.ReadLine().ToUpper());
                    Console.Clear();

                } while (repeat == 'Y');
            } while (repeat == 'I');
        }

        public static Book InputBook()
        {
            Console.Write("Input a book name: ");
            string name = Console.ReadLine();
            Console.Write("Input the author of the book: ");
            string author = Console.ReadLine();
            Console.Write("Input the year of books release: ");
            int year = Convert.ToInt32(Console.ReadLine());
            return new Book(name, author, year);
        }

        public static string AfterInputText(string textafterinput)
        {
            textafterinput += "Would you like to see: " + Environment.NewLine;
            textafterinput += "1 Only names of the books you have entered? " + Environment.NewLine;
            textafterinput += "2 Names of authors you have entered" + Environment.NewLine;
            textafterinput += "3 Release dates of the books you have entered" + Environment.NewLine;
            textafterinput += "4 All together in rows" + Environment.NewLine;
            textafterinput += "5 All together in columns" + Environment.NewLine;
            return textafterinput;
        }
        public static IEnumerable<string> AfterChoiceOutput(char choice, BookList listOfBooks)
        {
            switch (choice)
            {
                case '1':
                    return listOfBooks.Names;
                case '2':
                    return listOfBooks.Authors;
                case '3':
                    return listOfBooks.Years;
                case '4':
                    return listOfBooks.GetRowOutputList();
                case '5':
                    return listOfBooks.GetColumnOutputList();
                default:
                    List<string> listOfErrors = new List<string>();
                    listOfErrors.Add("Error, why haven't you chosen one of the options I gave you!? Chose Again...");
                    return listOfErrors;   // Because why not!
            }
        }
    }
}
