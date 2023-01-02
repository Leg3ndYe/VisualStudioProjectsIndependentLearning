using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            List<int> numList = new List<int>();
            numList.Add(24);

            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1, new Animal() { Name = "Steve" });
            animalList.RemoveAt(1);
            Console.WriteLine("Num of Animals : {0}", animalList.Count);

            foreach(Animal a in animalList) { Console.WriteLine(a.Name); }

            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            string strX = "5", strY = "4";
            Animal.GetSum<string>(ref strX, ref strY);

            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());

            Arithmethic add, sub, addSub;
            add = new Arithmethic(Add);
            sub = new Arithmethic(Subract);
            addSub = add + sub;

            Console.WriteLine($"Add {6} & {10}");
            add(6, 10);
            Console.WriteLine($"Add & Subtract {10} & {4}");
            addSub(10, 4);
        }

        public struct Rectangle<T>
        {
            private T width;
            private T lenght;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }
            public T Lenght
            {
                get { return lenght; }
                set { lenght = value; }
            }
            public Rectangle(T w, T l)
            {
                width = w;
                lenght = l;
            }
            public string GetArea()
            {
                double dblW = Convert.ToDouble(Width);
                double dblL = Convert.ToDouble(Lenght);
                return string.Format($"{Width} * {Lenght} = {dblW * dblL}");
            }

        }

        public delegate void Arithmethic(double num1, double num2);
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Subract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}
