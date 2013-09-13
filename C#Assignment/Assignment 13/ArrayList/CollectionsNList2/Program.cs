using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionsNList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAdding the Vehicles to the Arraylist");
            ArrayList listOfVehicles = new ArrayList()
            {
                new Vehicle("Suzuki",1999),
                new Vehicle("Tata",1995),
                new Vehicle("Honda",2005),
                new Vehicle("Sunny",1990)
            };
            Console.WriteLine("\n\nDisplay the Vehicles Available in ArrayList:\n\n");
            for (int i = 0;i<4; i++)
            {
                Console.WriteLine(((Vehicle)listOfVehicles[i]).Make.ToString() + "    :    " + ((Vehicle)listOfVehicles[i]).Year.ToString());
            }
            Console.WriteLine("\n\nNow Adding the derived Object to the ArrayList:");
            listOfVehicles.Add(new Cars("Maruti",2013,"Left"));
            listOfVehicles.Add(new Cars("Hundai", 2012, "Right"));
            listOfVehicles.Add(new Cars("ceverlet", 2014, "Left"));
            listOfVehicles.Add(new Cars("BMW", 2011, "Right"));
            Console.WriteLine("\n\nDisplay the Cars Available in ArrayList:\n\n");
            Console.WriteLine("Car" + "     " + "   Year   " + "    Stearing Side    \n");
            for (int i = 4; i < 8; i++)
            {
                Console.WriteLine(((Cars)listOfVehicles[i]).Make.ToString() + "    :    " + ((Cars)listOfVehicles[i]).Year.ToString() + "    :    " + ((Cars)listOfVehicles[i]).StearingPosition.ToString());
            }
        }
    }
}
