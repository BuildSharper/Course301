using BuildSharper.Course301.App1.Models;
using BuildSharper.Course301.App1.Services;
using BuildSharper.Course301.App1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuildSharper.Course301.App1.Controllers
{
    public class HomeController : Controller
    {
        private IDrinkService DrinkService;

        public HomeController()
        {
            DrinkService = new DrinkService();
        }

        public IActionResult Index()
        {
            var drinks = DrinkService.GetDrinks();

            return View(drinks);
        }

        public IActionResult Drink(Guid id)
        {
            var drink = DrinkService.GetDrink(id);

            return View(drink);
        }
    }
}