using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_Avaliacao_3bi.Models;

namespace LP3_Avaliacao_3bi.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View(StoreController.stores);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}