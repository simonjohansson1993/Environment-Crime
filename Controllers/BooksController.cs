using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstWebApplication.Controllers {
  public class BooksController : Controller {
    public ViewResult Bocker()  {
      ViewBag.Title = "böcker: Knottens bokförlag";
      return View();
    }
    public ViewResult Amfibie() {
      ViewBag.Title = "Amfibie: Knottens bokförlag";
      return View();
    }
    public ViewResult Krokodil() {
      ViewBag.Title = "Krokodil: Knottens bokförlag";
      return View();
    }
    public ViewResult Odlan() {
      ViewBag.Title = "Odlan: Knottens bokförlag";
      return View();
    }
    public ViewResult Titta() {
      ViewBag.Title = "Titta: Knottens bokförlag";
      return View();
    }
  }
}
