using GlobalGames.Data;
using GlobalGames.Data.Entities;
using GlobalGames.Helpers;
using GlobalGames.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GlobalGames.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISubscriberRepository _subscriberRepository;
        private readonly IBudgetRepository _budgetRepository;
        private readonly IUserHelper _userHelper;

        public HomeController(ISubscriberRepository subscriberRepository,
            IBudgetRepository budgetRepository,
            IUserHelper userHelper)
        {

            _subscriberRepository = subscriberRepository;
            _budgetRepository = budgetRepository;
            _userHelper = userHelper;
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

        [HttpPost]
        public async Task<IActionResult> Subscribe(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                //TODO: Modificar para o user que tiver logado
                subscriber.User = await _userHelper.GetUserByEmailAsync("tarik@gmail.com");
                await _subscriberRepository.AddAsync(subscriber);
                return RedirectToAction(nameof(Index));
            }

            return View(subscriber);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBudget(int id, Budget budget)
        {
            if (ModelState.IsValid)
            {
                budget.User = await _userHelper.GetUserByEmailAsync("tarik@gmail.com");
                await _budgetRepository.AddAsync(budget);
                return RedirectToAction(nameof(Index));
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
