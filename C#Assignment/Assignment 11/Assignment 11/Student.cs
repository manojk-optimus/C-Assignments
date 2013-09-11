using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_11
{
    public class Student
    {
        protected internal static int _age;
        public static int _rollNo;
        public static string studentName;
        public static bool isPresent; 
        public Student()
        {
        }
        public Student(int stuAge, int stuRollNo, string stuName)
        {
            _age = stuAge;
            _rollNo = stuRollNo;
            studentName = stuName;
        }
        public static bool StudentAttendence(bool attendence)
        {
            isPresent = attendence;
            return isPresent;
        }
    }
    public class SchoolStudents : Student
    {
        public static bool markPresent(bool att)
        {
            if (att == false)
                att = true;
            //Console.WriteLine("\n\nSchool Student is marked as present:");
            return att;
        }
        public static void getStudentDetails()
        {
            Console.WriteLine("\n\nSchool Student Details......\n\n");
            Console.WriteLine("Student Age: "+SchoolStudents._age);
            Console.WriteLine("Student RollNo: " +SchoolStudents._rollNo);
            Console.WriteLine("Student Name: " + SchoolStudents.studentName);
            
        }
        
    }
    public class CollegeStudent : Student
    {
        public static bool markAbsent(bool att)
        {
            if (att == true)
                att = false;
           // Console.WriteLine("college Student is marked as Absent:");
            return att;
        }
        public static void getStudentDetails()
        {
            Console.WriteLine("\n\nCollege Student Details......\n\n");
            Console.WriteLine("Student Age: " + CollegeStudent._age);
            Console.WriteLine("Student RollNo: " + CollegeStudent._rollNo);
            Console.WriteLine("Student Name: " + CollegeStudent.studentName);
        }
       

    }
}
