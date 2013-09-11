using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class TestSwitch
    {
        public static void read()
        {
            string str=Console.ReadLine();
            switch (str)
            {
                case "VB":
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }
    }
}
