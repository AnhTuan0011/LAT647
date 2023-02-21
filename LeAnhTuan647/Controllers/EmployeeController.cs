using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LeAnhTuan647.Models;

namespace LeAnhTuan647.Controllers;

    public class EmployeeController : Controller 
    {
        public IActionResult Index()
    {
        return View();
    }
    }