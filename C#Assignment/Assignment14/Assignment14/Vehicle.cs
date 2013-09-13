using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment14
{
    class Vehicle<MyType1,MyType2>:IComparable,IEquatable<Vehicle<MyType1,MyType2>>
    {
        public MyType1 make;
        public MyType2 year;
        public Vehicle()
        {
        }
        public Vehicle(MyType1 x, MyType2 y)
        {
            make = x;
            year = y;
        }
        //Implementing the CompareTo() method
        public int CompareTo(object obj)
        {
            if (obj == null) 
                return 1;
            else return 0;
            
        }
        //Implementing the Equals() method
        public bool Equals(Vehicle<MyType1,MyType2> other)
        {
            if (other == null) 
                return false;
            else 
                return (this.make.Equals(other.make));
        }
        public MyType2 Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public MyType1 Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("Make={0},  Year={1}", make,year);
        }
    }
    class Cars : Vehicle<string,int>
    {
        //private string make;
        //private int year;
        private string stearingPposition;
        public Cars(string strMake, int intYear,string strPosition)
        {
            make = strMake;
            year = intYear;
            stearingPposition = strPosition;
        }
        public void DisplayCars()
        {
            Console.WriteLine("Make={0},  year={1},StearingPosition={2}", make, year, stearingPposition);
        }       
    }
    class Truck : Vehicle<string, int>
    {
        //private string make;
        //private int year;
        private string stearingPposition;
        private int noOfTyres;
        public Truck()
        {
        }
        public Truck(string strMake, int intYear, string strPosition,int tyres)
        {
            make = strMake;
            year = intYear;
            stearingPposition = strPosition;
            noOfTyres = tyres;
        }
        public void DisplayCars()
        {
            Console.WriteLine("Make={0},  year={1},StearingPosition={2},noOfTyres={3}", make, year, stearingPposition,noOfTyres);
        }
    }
}

      
