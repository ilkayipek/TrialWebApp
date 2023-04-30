using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrialWebApp.Models;
using TrialWebApp.DataBase;

namespace TrialWebApp.Controllers;

public class HomeController : Controller
{
    ApplicationConnectionDb db = new ApplicationConnectionDb();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        /*
         Kategori k = new Kategori();
        k.kategoriId = 4;
        k.kategoriAd = "İçecekler";
        db.kategoriler.Add(k);
        db.SaveChanges();
         */

        ViewBag.kategori = db.kategoriler.ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        /*
          Kullanici k = new Kullanici();
        k.kullaniciAdSoyad = "ilkay ipek";
        db.kullanicilar.Add(k);
        db.SaveChanges();
         */

        ViewBag.kullanicilar = db.kullanicilar.ToList();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

