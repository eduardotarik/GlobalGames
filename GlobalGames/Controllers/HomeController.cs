using GlobalGames.Data;
using GlobalGames.Data.Entities;
using GlobalGames.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GlobalGames.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISubscriberRepository _subscriberRepository;
        private readonly IBudgetRepository _budgetRepository;

        public HomeController(ISubscriberRepository subscriberRepository,
            IBudgetRepository budgetRepository)
        {

            _subscriberRepository = subscriberRepository;
            _budgetRepository = budgetRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Newsletter()
        {
            return PartialView("_Newsletter");
        }

        public async Task<IActionResult> Subscribe(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var subscriber = new Subscriber { Email = email };
                await _subscriberRepository.AddAsync(subscriber);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateBudget(Budget budget)
        {
            if (ModelState.IsValid)
            {
                await _budgetRepository.AddAsync(budget);

                return RedirectToAction("Index");
            }

            return View(budget);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
