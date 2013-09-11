using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student("manoj", "kumar", 23, 10902446, "Male");
            Student.RandomStudentEnrollmentNoGenerator();
            Student.PrintStudentDetails();
            Console.Write("\nEnter the choice....:");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                Student.printStudentDetails(choice); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter only Number..");
            }
               
        }
    }
}
