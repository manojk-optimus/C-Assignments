using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_6
{
    class Animal
    {
        private string animalName;
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void setAnimalName(string name)
        {
            animalName = name;
            Console.WriteLine(animalName);
        }
        
        private string getAnimalName()
        {
            return animalName;

        }
       
    };
    class Dog : Animal
    {
        private string dogName;
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public void setDogName(String str)
        {
            dogName=str;
            Console.WriteLine("Animal Name Is Private in Animal Class and cannot directly accessed in the derived class!!  "+dogName);
        }
        public string getAnimalName()
        {
            return "Animal Name is not Directly available in child class";
        }

    };
}
