using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Istravel.Models;

namespace Istravel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Contacto()
    {
        return View();
    }
    public IActionResult Cultura()
    {
        return View();
    }
        public IActionResult Restaurantes()
    {
        return View();
    }
        public IActionResult Sitios()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
