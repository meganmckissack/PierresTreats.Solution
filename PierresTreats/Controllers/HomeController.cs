using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierresTreatsContext _db;
    
      public HomeController(PierresTreatsContext db)
      {
        _db = db;
      }
      
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Treat> treatList = _db.Treats.ToList();
        ViewBag.Treats = treatList;

        List<Flavor> flavorList = _db.Flavors.ToList();
        ViewBag.Flavors = flavorList;
        return View();
      }
    }
}


