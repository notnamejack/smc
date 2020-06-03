using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SMC.Views.Job
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Сustomers()
        {
            return View();
        }
        public IActionResult Rating()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }
        public IActionResult Technic()
        {
            return View();
        }
    }
}