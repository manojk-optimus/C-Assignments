using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying the elements of GetStringArray() function in Main() method: ");
            foreach (string value in TestStringArray.GetStringArray())
                Console.WriteLine(value);
        }
    }
}
