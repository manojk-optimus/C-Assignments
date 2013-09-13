using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Assignment_9
{
   class Vehicle
    {
        public static string make;
        private int yearOfManufacture;
        private string model;
        public static float speed;
        public static int noOfWheels;
        public Vehicle()
        {
        }
        public Vehicle(string brandName, int yearOfManufacture, string model, float vehSpeed)
        {
            make = brandName;
            yearOfManufacture = this.yearOfManufacture;
            model = this.model;
            speed = vehSpeed;
        }

       //Checking the Exception and throwing the exception 
        public static void Accelarate()
        {   
            
          {
              try
              {
                  speed += 10;
                  if (speed > 100)
                      throw new Exception();
                 // Console.WriteLine("Speed After Accelarating: " + speed);
              }
              catch (Exception e)
              {
                  Console.WriteLine("Ohooo,Exception !!!!,This Car is OverHeated");
              }
              
            }
          
        }

        public static void DeAccelarate()
        {
            speed -= 10;
            Console.WriteLine("speed after Deccelarating: " + speed);
        }
        public static void Stop()
        {
            speed = 0;
            Console.WriteLine("Now The vehicle has Stopped");
        }
        public static bool isMoving()
        {
            if (speed != 0)
                return true;
            else
                return false;
        }
        public void displayDetail()
        {
            Console.WriteLine("Vehicle is Moving:  "+isMoving());
        }

    };
    class Bicycle : Vehicle
    {
        
        private static bool hasFrontWheelBreak;
        public static void setNoOfWheels(int wheels)
        {
         Bicycle.noOfWheels = wheels;
        }
        public Bicycle(string brandName, bool frontwheelBreak)
        {
            Bicycle.make = brandName;
            hasFrontWheelBreak = frontwheelBreak;
        }
        public static void displayDetails()
        {
            Console.WriteLine("Bicycle make : "+make+"\nHas Front Break: "+hasFrontWheelBreak+"\nNo of Wheels: "+noOfWheels);
        }

    };
    class Bike : Vehicle
    {
        
        private static bool isElectric;
        public static void setNoOfWheels(int wheels)
        {
            Bike.noOfWheels = wheels;
        }
        public Bike(string brandName, bool electric)
        {
            make = brandName;
            isElectric = electric;
        }
        public static void displayDetails()
        {
            Console.WriteLine("Bike make : "+make+"\nBike is Electric: "+isElectric+"\nNo of Wheels: "+noOfWheels);
        }
    };
    class Car : Vehicle
    {

        private static bool isElectric;
        private static string SteeringWheelPosition;
        public static void setNoOfWheels(int wheels)
        {
            Car.noOfWheels = wheels;
        }
        public Car(string brandName, bool electric,string steeringPosition)
        {
            make = brandName;
            isElectric = electric;
            SteeringWheelPosition = steeringPosition;
        }

        public static void displayDetails()
        {
            Console.WriteLine("Car make : "+make+"\nCar is Electric: "+isElectric+"\nNo of Wheels: "+noOfWheels+"\nSteeringWheelPosition : "+SteeringWheelPosition);

        }
    };
    class Truck : Vehicle
    {
        private static string SteeringWheelPosition;
        public static void setNoOfWheels(int wheels)
        {
            Truck.noOfWheels = wheels;
        }
        public Truck(string brandName,string steeringPosition)
        {
            Truck.make = brandName;
            SteeringWheelPosition = steeringPosition;
        }

        public static void displayDetails()
        {
            Console.WriteLine("Truck make : "+make+"\nNo of Wheels: "+noOfWheels+"\nSteeringWheelPosition : "+SteeringWheelPosition);

        }
    };
}
