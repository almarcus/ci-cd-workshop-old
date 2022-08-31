using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers;

public class HomeController : Controller
{
    private HomeViewModel homeModel = new HomeViewModel();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        homeModel.WelcomeMessage = "Welcome, Aaron!";
        return View(homeModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
