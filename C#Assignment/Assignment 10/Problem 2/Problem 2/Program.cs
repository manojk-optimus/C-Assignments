using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Problem_2
{
   protected  class Student
    {

        protected internal int _age;//This variable is only accessible in same Assembly
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
namespace University
{
    
    class univPeople
    {
       
          Student[] students = new Student[3];    
        /*This requires the Assembly reference because Student class belongs to 
          Problem_2 namespace.This can work if we use like 
          Problem_2.Student[] students=new Problem_2.Student[3];   */
           
            WorkingStaff[] staffMembers;   //assembly Reference is absent with the WorkingStaff class.
           
             //Const logic for this class which fills in both the array of student and staff
            public univPeople
            {
                Student Ankit = new Student();
                // Here also require the Assembly reference becaused Student class belongs to Problem_2
                // The above code can work if we use like ---
                // Problem_2.Student Ankit = new Problem_2.Student();
                Ankit.fullName="Ankit Mathur";    //Ankit object is not available/created in the above statement
                Ankit._age = 25;      
                students0=Ankit;
            }   
    };
}
