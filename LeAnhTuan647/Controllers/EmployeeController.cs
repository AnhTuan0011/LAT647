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

        [HttpPost]
        public IActionResult Index(string FullName)
        {       
            string strReturn = "Hello" + FullName;
            // gui du lieu ve view
            ViewBag.abc    = strReturn;
            return View();
            // tra ve danh sach cac sinh vien trong Database
        }

        public IActionResult Creat()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
    }
    
    
