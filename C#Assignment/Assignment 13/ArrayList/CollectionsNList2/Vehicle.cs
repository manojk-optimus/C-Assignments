using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsNList2
{
    public class Vehicle
    {
            private int year;
            private string make;
            public Vehicle()
            {
            }
            public Vehicle(string Make, int Year)
            {
                make = Make;
                year = Year;
            }
            public int Year
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
            public string Make
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
    }
    public class Cars : Vehicle
    {
         private string stearingPosition;
         private int year;
         private string make;
         public Cars()
         {
         }
         public Cars(string Make, int Year,string StrPosition)
            {
                make = Make;
                year = Year;
                stearingPosition = StrPosition;
            }
            public int Year
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
            public string Make
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
            public string StearingPosition
            {
                get
                {
                    return stearingPosition;
                }
                set
                {
                    stearingPosition = value;
                }
            }
 
    }
}

