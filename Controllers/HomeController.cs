using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lesson02.Models;

namespace Lesson02.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contact()
    {
        ViewBag.name = ("Berat Karasu");
        return View();
    }

    public IActionResult Lessons()
    {
        string[] lessonsList = {
            "Web Tabanlı Uygulama Geliştirme",
            "Oyun Programlama",
            "Web Tabanlı İçerik Yönetimi",
            "Grafik Ve Canlandırma",
            "Edebiyat",
            "Tarih",
            "Matematik"
        };
        ViewBag.lessons = lessonsList;
        return View();
    }

    
}
