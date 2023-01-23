using Assessment5b.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assessment5b.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(HomeIndexModel model)
        {
            
            return View();
        }

        public IActionResult SubmitAge(SubmitAgeModel model)
        {
            var viewModel = new SubmitAgeModel();
            viewModel.Age= model.Age;

            if (model.Age >=426 || model.Age >=889)
            {
                viewModel.Age= model.Age;
                viewModel.CanFly =true;
            }

            return View(viewModel);
        }

        public IActionResult ShipSelection(SpaceshipSelectionModel model)
        {
            var viewModel = new SpaceshipSelectionModel();
            viewModel.Age= model.Age;

            if (model.Age >=426 || model.Age >=889)
            {
                viewModel.Age= model.Age;
                viewModel.CanFly =true;
            }

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Sorry(HomeIndexModel model)
        {
            var viewModel = new HomeIndexModel();
            viewModel.Age= model.Age;

            if (model.Age <= 426)
            {
                TempData["Age"] = "Sorry, you're too young";
            }            
            return View(viewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}