using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_Avaliacao_3bi.Models;
using LP3_Avaliacao_3bi.ViewModels;

namespace LP3_Avaliacao_3bi.Controllers;

public class AdmController : Controller
{
    public IActionResult Index()
    {
        return View(StoreController.stores);
    }

    public IActionResult Show(int id)
    {
        foreach(var store in StoreController.stores)
        {
            if(store.Id  == id)
            {
                return View(store);
            }
        }
        return View();
    }

    public IActionResult Delete(int id)
    {
        foreach(var store in StoreController.stores)
        {
            if(store.Id  == id)
            {
                StoreController.stores.Remove(store);
                ViewBag.Store = store.Store;
                ViewBag.Name = store.Name;
                return View();
            }
        }
        return View();
    }

    public IActionResult Register() 
    {
        return View();
    }

    public IActionResult RegisterData([FromForm] int id, [FromForm] string floor, [FromForm] string name, [FromForm] string description, [FromForm] string store, [FromForm] string email) 
    {        
        foreach(var reg in StoreController.stores)
        {
            if(name.Equals(reg.Name))
            {
                ViewBag.Name = reg.Name;
                return View("RegisterExistentError");
            }
        }

        if(id < 0)
            return View("RegisterNegativeError");
        else
        {
            ShoppingViewModel shop = new ShoppingViewModel(id, floor, name, description, store, email);
            StoreController.stores.Add(shop);
            return View();
        }
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}