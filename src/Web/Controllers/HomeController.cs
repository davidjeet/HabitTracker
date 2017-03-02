using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Model;
using Common.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHabitRepository _repository;

        public HomeController(IHabitRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            ////IQueryable<Habit> habits = _repository.GetHabits().Where(x=>x.HabitId != null);
            await Task.Run(() => Console.WriteLine("Index page"));
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
