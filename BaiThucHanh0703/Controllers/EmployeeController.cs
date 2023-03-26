using Microsoft.AspNetCore.Mvc;
using BAITHUCHANH0703.Models;

namespace BaiThucHanh0703.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(string FullName)
        {
            string strReturn = "Hello " + FullName;
            //gui du lieu ve view
            ViewBag.thongbao = strReturn;
            return View();
            //tra ve danh sach cac sinh vien trong Database
        }
         public IActionResult About()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Employee std)
        {
            string  kq = std.StudentCode + "-" + std.FullName +"-" + std.Address ;
            ViewBag.mess=kq;
            return View();
        }

       
    }

}