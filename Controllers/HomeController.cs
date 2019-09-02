using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebItemOfListDemo.Models;

namespace WebItemOfListDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<WebItemOfListDemo.Models.Item>();
            model.Add(new Item()
            {
                Guid = Guid.NewGuid().ToString(),
                a = "a1",
                b = "b1",
                c = "c1",
                d = "d1",
                istrue = true
            });
            model.Add(new Item()
            {
                Guid = Guid.NewGuid().ToString(),
                a = "a2",
                b = "b2",
                c = "c2",
                d = "d2",
                istrue = false
            });
            return View(model);
        }
        [HttpPost]
        public IActionResult someaction(Item s)
        {
            return Json(s);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
