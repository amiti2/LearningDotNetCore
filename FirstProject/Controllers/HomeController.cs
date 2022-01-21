using Microsoft.AspNetCore.Mvc;
using System;
namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning":"Good Evening";
            return View("MyView2",viewModel);
        }

        public RedirectResult Index2()
        {
            return Redirect("http://google.com");
        }
    }
}