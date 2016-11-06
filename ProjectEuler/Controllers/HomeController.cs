using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEuler.Domain.Factories;

namespace ProjectEuler.Controllers
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

        public string Problem(int problemNumber)
        {
            _logger.LogDebug($"problemNumer: {problemNumber}");
            var problem = ProblemFactory.Create(problemNumber);
            return problem.Solve();
        }
    }
}
