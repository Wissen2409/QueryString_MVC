using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QueryString_MVC.Models;

namespace QueryString_MVC.Controllers;

public class HomeController : Controller
{


    public IHelper _helper;
    public HomeController(IHelper helper)
    {
        _helper = helper;
    }


    public IActionResult Index()
    {
        return View();
    }
    public IActionResult QueryString(QueryStringModel model)
    {

        var result = HttpContext.Request.QueryString;

        _helper.GetQueryString();

        return View();
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
