using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using My_Portfolio.Models;
using MyPortfolio.Models;

namespace My_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1 , Title = "نام پروژه" , Image = "01.jpg" , Description = "اولین نمونه کار من "
            },
            new Portfolio
            {
                Id = 2 , Title = "نام پروژه" , Image = "02.jpg" , Description = "دومین نمونه کار من "
            },
            new Portfolio
            {
                Id = 3 , Title = "نام پروژه" , Image = "03.jpg" , Description = "سومین نمونه کار من "
            },
            new Portfolio
            {
                Id = 4 , Title = "نام پروژه" , Image = "04.jpg" , Description = "چهارمین نمونه کار من "
            },
            new Portfolio
            {
                Id = 5 , Title = "نام پروژه" , Image = "01.jpg" , Description = "پنجمین نمونه کار من "
            },
            new Portfolio
            {
                Id = 6 , Title = "نام پروژه" , Image = "02.jpg" , Description = "ششمین نمونه کار من "
            },
        };
        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی آیدین سلماسی خوش آمدید";
            ViewBag.headingText = "  این سایت به جهت مشاهده نمونه کار های من و معرفی من به مشتریان و کسانی که میخواهند از خدمات سایت بهره مند شوند طراحی و پیاده سازی شده است ";
            // return View();
            return View(_portfolios);
            //return View("Index");
            //return View("Index", _portfolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "Aidin2salmasi@gmail.com",
                Mobile = "09013630210",
                Github = "github.com/AidinSalmasi"
            };
            return View(contact);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

