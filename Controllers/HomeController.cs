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
        int[] varAux = new int[4];
        ViewBag.ListaSitios=varAux;
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


    public IActionResult GuardarCantSitios(int decision){
        int[] cantSitios = new int[4];
        cantSitios = Models.Sitios.calcularCantSitios(decision);
        ViewBag.ListaSitios = cantSitios;
        return View("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
