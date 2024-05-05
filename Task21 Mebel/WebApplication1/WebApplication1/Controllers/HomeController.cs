using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About() 
        { 
            return View(); 
        }

        public IActionResult Design() 
        {
            Furniture furniture1 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-5.png" };
            Furniture furniture2 = new Furniture() { Id = 2, Name = "Divan", Price = 550.00, ImgSrc = "images/img-1.png" };
            Furniture furniture3 = new Furniture() { Id = 3, Name = "Masa", Price = 120.10, ImgSrc = "images/img-3.png" };
            Furniture furniture4 = new Furniture() { Id = 4, Name = "Kreslo", Price = 250.40, ImgSrc = "images/img-6.png" };
            List<Furniture> list = new List<Furniture>();
            list.Add(furniture1);
            list.Add(furniture2);
            list.Add(furniture3);
            list.Add(furniture4);
            ViewBag.FurnitureList = list;
            Furniture furniture5 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-1.png" };
            Furniture furniture6 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-2.png" };
            Furniture furniture7 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-3.png" };
            Furniture furniture8 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-4.png" };
            Furniture furniture9 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-5.png" };
            Furniture furniture10 = new Furniture() { Id = 1, Name = "Stul", Price = 25.70, ImgSrc = "images/img-6.png" };
            List<Furniture> list1 = new List<Furniture>();
            list1.Add(furniture5);
            list1.Add(furniture6);
            list1.Add(furniture7);
            list1.Add(furniture8);
            list1.Add(furniture9);
            list1.Add(furniture10);
            ViewBag.FurnitureList1 = list1;
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
