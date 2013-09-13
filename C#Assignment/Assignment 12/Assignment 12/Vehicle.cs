using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_12
{
    class Vehicle:IComparable
    {
         private int year;
         private string make;
         public Vehicle(string Make,int Year)
         {
            make=Make;
            year=Year;
         }
         public int Year
         {
            get
            {
                return year;
            }
             set
             {
                 year=value;
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
                    make=value;
                }
          }

      // Implement IComparable CompareTo to provide default sort order.
      int IComparable.CompareTo(object obj)
      {
         Vehicle vh=(Vehicle)obj;
         return String.Compare(this.make,vh.make);
      }
      public override bool Equals(Object obj)
      {
           Vehicle vhMake = obj as Vehicle;
           bool temp1=vhMake.make == this.make;
           bool temp2 = vhMake.year == this.year;
           return temp1;      
      }
    }
}
