using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Assignment_10
{
    class Student
    {

        protected int _age;
        int _rollNo;
    }
    class CollegeStudent
    {
        public static void Main()
        {
            CollegeStudent stu = new CollegeStudent();
           // stu._age = 10;       //This wont work because  _age is protected member of student class and it is only accessible in same class or in next Derived class

        }
    }
}
