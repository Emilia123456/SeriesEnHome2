using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SeriesEnHome2.Models;

namespace SeriesEnHome2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaSeries=BD.ListarSeries();
        return View();
    }

    public Serie MostrarMasInfo(int IdSerie){
        return  BD.GetSerie(IdSerie);
    }
    public List<Actor> MostrarActores(int IdSerie){
        return  BD.ListarActores(IdSerie);
    }
    public List<Temporada> MostrarTemporadas(int IdSerie){
        return  BD.ListarTemporadas(IdSerie);
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
