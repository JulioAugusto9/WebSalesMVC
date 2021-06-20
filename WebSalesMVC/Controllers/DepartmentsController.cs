using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSalesMVC.Models;

namespace WebSalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> deps = new List<Department>
            {
                new Department(1, "Sales"),
                new Department(2, "Marketing"),
                new Department(3, "Research and Development")
            };
            return View(deps);
        }
    }
}
