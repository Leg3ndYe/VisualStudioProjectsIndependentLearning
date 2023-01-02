using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_Check_for_equality_of_3_ints
{
    internal class Program
    {
        /* Task: Write a C# Sharp program to compare equality of three integers and calculate how many integers have the same value.
            (1,2, 3) -> 0
            (1,3,3) -> 2
            (3,3,3) -> 3*/
        static void Main(string[] args)
        {
            char[] first = new char[3];
            char[] second = new char[3];
            char[] third = new char[3];
            string number = " ";
            Console.WriteLine("Input 3 integers in 3 diffrent int arrays");
            Input(number, first, second, third);
            
           
        }
        static void Input(string number, char[] first, char[] second, char[] third)
        {
            int loops = 1;
            Console.WriteLine("Input numbers in {0} array", loops);
            for (int j = 0; j < 3; j++)
            {
                number = Console.ReadLine();
                first[j] = Convert.ToChar(number);
            }
            loops++;
            Console.WriteLine("Input numbers in {0} array", loops);
            for (int j = 0; j < 3; j++)
            {
                number = Console.ReadLine();
                second[j] = Convert.ToChar(number);
            }
            loops++;
            Console.WriteLine("Input numbers in {0} array", loops);
            for (int j = 0; j < 3; j++)
            {
                number = Console.ReadLine();
                third[j] = Convert.ToChar(number);
            } 
            CheckForEquality(first, second, third);
        }
        static int CheckForEquality(char[] first, char[] second, char[] third)
        {
            int numberOfEquals1 = 1, numberOfEquals2 = 1, numberOfEquals3 = 1;
    
            
            if (first[0] == first[1] && first[1] == first[2])
            {
                numberOfEquals1 = 3;   
            }
            else if (first[0] == first[2] || first[0] == first[1])
            {
                numberOfEquals1++;
            }
            else if (first[1] == first[2])
            {
                numberOfEquals1++;
            }
            
            
            if (second[0] == second[1] && second[1] == second[2])
            {
                numberOfEquals2 = 3;
            }
            else if (second[0] == second[2] || second[0] == second[1])
            {
                numberOfEquals2++;
            }
            else if (first[1] == second[2])
            {
                numberOfEquals2++;
            }
            
           
            if (third[0] == third[1] && third[1] == third[2])
            {
                numberOfEquals3 = 3;
            }
            else if (third[0] == third[2] || third[0] == third[1])
            {
                numberOfEquals3++;
            }
            else if (third[1] == third[2])
            {
                numberOfEquals3++;
            }
            
            Console.WriteLine("{0} {1} {2}", numberOfEquals1, numberOfEquals2, numberOfEquals3);
            return 0;
        }
    }
}
