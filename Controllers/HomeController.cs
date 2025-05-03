using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_practice.Models;

namespace mvc_practice.Controllers;

public class HomeController : Controller
{
  
    public IActionResult Index()
    {
        ViewData["Title"] = "Home page";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
