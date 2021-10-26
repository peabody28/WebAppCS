using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // через ViewBag можно передать данные в представление 
            ViewBag.MyProp = "Hello, World!";
            // выбор отображаемого представления ( без параметров = по умолчанию, то есть ищется на основе имени файла)
            return View();
        }

        // Методы обработки ответов формы
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            // Нужно отправить данные нового гостя no электронной почте 
            // организатору вечеринки.

            // тут я передаю обьект guest, чтоб использовать его в представлении,
            // также я мог продублировать данные в ViewBag
            if (ModelState.IsValid)
                return View("Thanks", guest);
            else
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
