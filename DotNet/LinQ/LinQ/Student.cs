using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinQ
{
    public class Student
    {
        public int    ID     { get; set; }
        public string Name   { get; set; }
        public string Gender { get; set; }
                
        public static List<Student> GetAllStudents()
        {
            List<Student> StudentList = new List<Student>();

            Student s1 = new Student { ID = 1, Name = "Sarfaraz", Gender = "Male"};
            Student s2 = new Student { ID = 2, Name = "Saira", Gender = "Female" };
            Student s3 = new Student { ID = 3, Name = "Sonam", Gender = "Female" };
            Student s4 = new Student { ID = 4, Name = "Sofia", Gender = "Female" };

            StudentList.Add(s1);
            StudentList.Add(s2);
            StudentList.Add(s3);
            StudentList.Add(s4);

            return StudentList;
        }
    }
}