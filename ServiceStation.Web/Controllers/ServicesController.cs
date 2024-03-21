using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;
using System.Xml.Serialization;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            PageTitle = "Service Details";
            var service = new VehicleService
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Coast = 23.99m,
                IsDeleted = true
            };

           // ViewBag.Service = service;
            return View(service);

        }
         
    }
}
