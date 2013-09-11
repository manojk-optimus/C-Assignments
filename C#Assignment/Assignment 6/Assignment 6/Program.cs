using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal obj = new Animal();
            obj.setAnimalName("Tommy");
            Dog obj1 = new Dog();
            obj1.getAnimalName();
            obj1.setDogName("Child- Tommy");
            
        }
    }
}
