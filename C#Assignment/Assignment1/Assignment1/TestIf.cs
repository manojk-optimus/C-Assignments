using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class TestIf
    {
        public static void read()
        {
            string tempStr = Console.ReadLine();
            if (tempStr == "C#")
                Console.WriteLine("Good choice, C# is a fine language");
            else if (tempStr == "VB")
                Console.WriteLine("VB .NET: OOP, multithreading and more!"); 
            else
                Console.WriteLine("Well...good luck with that!");
        }
    }
}
