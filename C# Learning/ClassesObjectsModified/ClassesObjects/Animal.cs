﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();
        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }
        public Animal(): this ("No Name", "No Sound") { }
        public Animal(string name) : this(name, "No Sound") { }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if(value.Any(char.IsDigit))
                {
                    this.name = "No Name";
                    Console.WriteLine("Name can't contain numbers");
                }
                else
                {
                    name = value;   
                }
            }
        }
        public string Sound
        {
            get { return sound; }
            set 
            { 
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height/weight;
                if ((calc >= .18) &&(calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
