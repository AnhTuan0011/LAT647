
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BAITHUCHANH0703.Models;

namespace BaiThucHanh0703.Controllers
{
    public class PersonController : Controller
    {
         public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Person std)
        {
            string  kq = std.NamePerson + "-" + std.Age +"-" + std.Address ;
            ViewBag.messhi=kq;
            return View();
        }
    }
}