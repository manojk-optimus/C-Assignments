using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5
{
    class TestStringArray
    {
        static String[] myStringArray;
        public static string[] GetStringArray()
        {
            myStringArray = new String[] { "FirstElement", "SecondElement" };
            return myStringArray;
        }
        
    }
}
