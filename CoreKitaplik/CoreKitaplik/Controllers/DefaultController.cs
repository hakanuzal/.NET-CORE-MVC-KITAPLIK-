using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreKitaplik.Controllers;
using CoreKitaplik.Models;

namespace CoreKitaplik.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){ ID = 1 , Name = "Şeker Portakalı", Author = "Jose Mauro"},
                new Kitaplar(){ ID = 2 , Name = "Olasılıksız", Author = "Adam Fawer"},
                new Kitaplar(){ ID = 3 , Name = "Sefiller", Author = "Victor Hugo"},
                new Kitaplar(){ ID = 4 , Name = "Yeraltından Notlar", Author = "Dostoyevski"},
                new Kitaplar(){ ID = 5 , Name = "Gazap Üzümleri", Author = "Jhon Steinbeck"}
            };
            return View(ktp);
        }
    }
}
