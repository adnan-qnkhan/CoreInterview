using CoreInterview.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreInterview.Models
{
    public class mStudent
    {
        public int ID { get; set; }

        public int StudentID { get; set; }

        public string Name { get; set; }

        public Course subject { get; set; }
    }

    public enum Course
    {
         CSharp = 1,
         Javascript= 2,
         Python = 3
    }

    public class Student : IStudent
    {
        public string AddStudents()
        {
            return "Get Student Records";
        }

        public string GetStudent()
        {
            return "Add Students";
        }
    }
}
