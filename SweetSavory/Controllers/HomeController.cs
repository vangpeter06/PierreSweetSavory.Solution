using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SweetSavory.Models;

namespace SweetSavory.Controllers
{
    public class HomeController : Controller
    {
      private readonly SweetSavoryContext _db;

      public HomeController(SweetSavoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.TreatList = new List<Treat>(_db.Treats.OrderBy(treat => treat.Name));
        ViewBag.FlavorList = new List<Flavor>(_db.Flavors.OrderBy(flavor => flavor.Name));
        return View();
      }

    }
}