using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_4
{
    class TestString
    {
        public static void stringTest()
        {

            string str = Console.ReadLine();
            Console.WriteLine("Original text is : " + str);
            string strModified = String.Empty;

            // count total words 
            System.Text.RegularExpressions.MatchCollection wordColl = System.Text.RegularExpressions.Regex.Matches(str, @"[\S]+");
            Console.WriteLine("No Of Words:  " + wordColl.Count.ToString());


            //counting total no of characters including white spaces 

            System.Text.RegularExpressions.MatchCollection charColl = System.Text.RegularExpressions.Regex.Matches(str, @".");
            Console.WriteLine("Total characters :  " + charColl.Count.ToString());

            // Remove the characters after the give index

            strModified = str.Remove(3);
            Console.WriteLine("String After deleting from index 3:  " + strModified);

            strModified = str;
            // Remove 5 characters after the give index

            strModified = str.Remove(1, 1);
            Console.WriteLine("String will be deleted after index 3:  " + strModified);


            //string in upper case

            Console.WriteLine("Original String In Upper Case: " + str.ToUpper());

            // string in lower case

            Console.WriteLine("Original String in Lower Case: " + str.ToLower());

            //copy a string into another string

            strModified = String.Copy(str);
            Console.WriteLine("original String is copied to a new variable: " + strModified);

            //Concatenate various strings

            strModified = String.Concat(str, "This Is concatenated");
            Console.WriteLine("String After Concat() operation:  " + strModified);


            // String Equals() method

            bool b = String.Equals(str, "Hello");

            Console.WriteLine("Both Strings are same : " + b);
            //String  Intern()

            Console.WriteLine("String Intern() method : " + String.Intern(str));
            // String Format()

            strModified = String.Format("{0} - is the original string", str);
            Console.WriteLine(str);
        }


    }
}
