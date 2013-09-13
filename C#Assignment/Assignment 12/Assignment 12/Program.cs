using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle[] vhArray = new Vehicle[3]
            {
                new Vehicle("SUzuki",2000),
                new Vehicle("Hundai",2013),
                new Vehicle("Tata",1999),
            };
        
            Console.WriteLine("Unsorted Vehicles Data....");
            foreach (Vehicle vh in vhArray)
            {
                 Console.WriteLine(vh.Make + "\t\t" + vh.Year);
            }
            // Use of IComparable by sorting array with "default" sort order.
            Array.Sort(vhArray);
            Console.WriteLine("\nVehicles - Sorted by Make (Ascending - IComparable)\n");

            foreach (Vehicle vh in vhArray)
                Console.WriteLine(vh.Make + "\t\t" + vh.Year);

            Console.WriteLine("\n\nCalling Equals:\n");
            Console.WriteLine("Make[0] and Make[1]: {0} ",vhArray.Equals(vhArray[0]));
            Console.WriteLine("\n\nVehicle Collection Class Iterator using Foreach loop ");
            VehicleCollections vObj = new VehicleCollections();
            foreach (Object s in vObj)
            {
                Console.WriteLine(s);
            }
        }
    }
}
