using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstWebApplication.Controllers {
  public class CitizenController : Controller {
    public ViewResult Contact() {
      ViewBag.Title = "Contact: Crime Report";
      return View();
    }
    public ViewResult Faq() {
      ViewBag.Title = "Faq: Crime Report";
      return View();
    }
    public ViewResult Services() {
      ViewBag.Title = "Services: Crime Report";
      return View();
    }
    public ViewResult Thanks() {
      ViewBag.Title = "Thanks: Crime Report";
      return View();
    }
    public ViewResult Validate() {
      ViewBag.Title = "Validate: Crime Report";
      return View();
    }
  }
}
