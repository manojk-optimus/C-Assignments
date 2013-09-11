using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    class Student
    {
        private static string studentFirstName;
        private static string studentLastName;
        private static int studentAge;
        private static long studentId;
        private static string studentGender;
        private static long enrollMentId;
        public Student()
        { }
        public Student(string surName,string primaryName,int stuAge,long stuId,string stuGender)
        {
            studentFirstName=surName;
            studentLastName=primaryName;
            studentAge=stuAge;
            studentId = stuId;
            studentGender = stuGender;           
        }
        public static void RandomStudentEnrollmentNoGenerator()
        {
            var r = new Random();
           enrollMentId = r.Next(1, 100);   //Generates random no between 1 to 100
            Console.WriteLine("Student Enrollment Number is Generated as: "+ enrollMentId);
        }
        public static void PrintStudentDetails()
        {
            Console.WriteLine("FirstName: " + studentFirstName + "\nLast Name: " + studentLastName + "\nAge: " + studentAge + "\nStudent ID: " + studentId + "\nGender: " + studentGender+"\nEnrollment ID: "+enrollMentId);
        }
        public static void printStudentDetails(int choice)
        {
            switch (choice)
            {
                case (int)studentAttributes.studentAge:
                    Console.WriteLine("Student Age: " + Student.studentAge);
                    break;
                default:
                    Console.WriteLine("Hello!!!Enter proper Value to find the Student Age,Enter 3");
                    break;
            }
                       
        }
        enum studentAttributes
        {
            studentFirstName=1,
            studentLastName,
            studentAge,
            studentId,
            studentgender,
            enrollMentId,
        };
    }
}
