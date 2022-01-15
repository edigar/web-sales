using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models;

namespace WebSales.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departmentList = new List<Department>();
            departmentList.Add(new Department { Id = 1, Name = "Eletronics" });
            departmentList.Add(new Department { Id = 1, Name = "Fashion" });

            return View(departmentList);
        }
    }
}
