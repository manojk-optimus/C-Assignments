using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Assignment14
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle<string,int> obj = new Vehicle<string,int>("Bajaj",2005);
            obj.Print();
            List<Vehicle<string, int>> myVehicleList = new List<Vehicle<string, int>>()
            {
                new Vehicle<string,int>("Mahindra",2007),
                new Vehicle<string,int>("Odi",2009),
                new Vehicle<string,int>("Hummer",2005)
            };
             myVehicleList.Add(obj);
            // myVehicleList.Add(new Object());
            //comparing the object with the same object
            Console.WriteLine("\n\nmyVehicleList.Equals(myVehicleList):   {0}", myVehicleList.Equals(myVehicleList));

            //comparing Vehicle object with the List object
            Console.WriteLine("\nobj.Equals(myVehicleList):   {0}", obj.Equals(myVehicleList));

            //adding the Cars objects with the lists
            Console.WriteLine("\nAdding the Cars to the list..");
            myVehicleList.Add(new Cars("Tata",2012,"Right"));
            myVehicleList.Add(new Cars("GeneralMotors", 2013, "Left"));
            myVehicleList.Add(new Cars("Tata", 2012, "Left"));

            //adding the Trucks to the Lists

            Console.WriteLine("\nAdding the Trucks to the list..");
            myVehicleList.Add(new Truck("Tata", 2011, "Right",10));
            myVehicleList.Add(new Truck("AshokLeyland", 2013, "Left",12));
            myVehicleList.Add(new Truck("Mahindra", 2012, "Left",8));
            Console.WriteLine(myVehicleList[9].GetType());
            //Cars car = (Cars)myVehicleList[6];
            //if (car != null)
            //{
            //    Console.WriteLine(car);
            //}
            //Console.ReadKey();

            Console.WriteLine("\n\nDisplaying the Lists elements in Unsorted order.....\n\n");
            for (int i = 0;i<10; i++)
            {
                Console.WriteLine(myVehicleList[i].Make + "  :  " + myVehicleList[i].Year);
            }
            myVehicleList.Sort();
            Console.WriteLine("\n\nDisplaying the Lists elements in Sorted order.....\n\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myVehicleList[i].Make + "  :  " + myVehicleList[i].Year);
            }
        }
    }
}
