using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sObj = new Student(23,0139,"Manoj");
            bool attendence = Student.StudentAttendence(false);
            SchoolStudents.markPresent(attendence);
            CollegeStudent.markAbsent(attendence);
            SchoolStudents.getStudentDetails();
            Console.WriteLine("Presenet: " + SchoolStudents.markPresent(attendence));
            CollegeStudent.getStudentDetails();
            Console.WriteLine("Presenet: " + CollegeStudent.markAbsent(attendence));
        }
    }
}
