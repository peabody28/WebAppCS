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

        // ASP.NET парсит URL и выбирает контроллер для обработки запроса - этот метод обрабатывает /, /Home, /Home/Index
        public IActionResult Index()
        {
            // выбор отображаемого представления ( без параметров = по умолчанию, то есть ищется на основе имени файла)
            return View();
        }

        // Метод отрисовки формы (GET-запрос)
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        // Обработка отправки формы (POST-запрос)
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            // В модели RsvpForm есть атрибуты блокирующие неверный ввод
            // В следующем условии я проверяю валидна ли модель, отправленная пользователем
            if (ModelState.IsValid)
            {
                // запись нового посетителя в базу
                // some code
                // Отрисовка результата голосования (представление Thanks)
                return View("Thanks", guest);
            }
            else
                return View();  // отрислвываю форму + указываю на ошибки
        }
    }
}
