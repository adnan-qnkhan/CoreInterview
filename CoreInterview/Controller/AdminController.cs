using CoreInterview.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreInterview.Models
{
  
    public class AdminController : Controller
    {
        //private readonly IStudent student;
        public AdminController()
        {
           // student = _student;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
