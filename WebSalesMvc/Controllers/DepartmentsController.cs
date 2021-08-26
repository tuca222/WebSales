using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMvc.Models;

namespace WebSalesMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDepartments = new List<Department>();
            listDepartments.Add(new Department { Id = 1, Name = "Apple" });
            listDepartments.Add(new Department { Id = 2, Name = "Samsung" });

            return View(listDepartments);
        }
    }
}
