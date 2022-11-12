using CoreInterview.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreInterview.Models
{
    public class StudentController 
    {
        private readonly IStudent student;
        StudentController(IStudent _student)
        {
            student = _student;
        }
    }
}
