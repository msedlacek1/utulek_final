using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VirtualniUtulek.Eshop.Application.Abstraction;
using VirtualniUtulek.Eshop.Application.ViewModels;
using VirtualniUtulek.Eshop.Web.Models;

namespace VirtualniUtulek.Eshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IHomeService _homeService;

        public HomeController(ILogger<HomeController> logger,
                                IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            CarouselZvireViewModel viewModel = _homeService.GetIndexViewModel();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}