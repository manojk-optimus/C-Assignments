using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle obj = new Vehicle();
            Vehicle obj1 = new Vehicle("Honda", 2000, "FR@005", 200);
            Vehicle.Accelarate();
            Vehicle.DeAccelarate();
            Vehicle.isMoving();
            obj.displayDetail();
            Console.WriteLine("\n\n Details About Bicycle........\n\n");
            Bicycle byObj = new Bicycle("Titan",true);
            Bicycle.setNoOfWheels(2);
            Bicycle.Accelarate();
            Bicycle.DeAccelarate();
            Bicycle.displayDetails();
            Bicycle.isMoving();

            Console.WriteLine("\n\nDetails Of Bike......\n\n");
            Bike bkObj = new Bike("Bajaj",true);
            Bike.Accelarate();
            Bike.DeAccelarate();
            Bike.setNoOfWheels(2);
            Bike.isMoving();
            Bike.displayDetails();

            Console.WriteLine("\n\nDetails Of Car......\n\n");
            Car cObj = new Car("Hundai", false, "Left");
            Car.Accelarate();
            Car.DeAccelarate();
            Car.setNoOfWheels(4);
            Car.isMoving();
            Car.displayDetails();

            Console.WriteLine("\n\nDetails Of Truck....");
            Truck tObj = new Truck("Tata", "Right");
            Truck.Accelarate();
            Truck.DeAccelarate();
            Truck.isMoving();
            Truck.setNoOfWheels(10);
            Truck.displayDetails();





        }
    }
}
