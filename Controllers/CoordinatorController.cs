using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstWebApplication.Controllers {
  public class CoordinatorController : Controller {
    public ViewResult CrimeCoordinator() {
      return View();
    }
    public ViewResult ReportCrime() {
      ViewBag.Title = "Contact: Crime Report";
      return View();
    }
    public ViewResult StartCoordinator() {
      ViewBag.Title = "Contact: Crime Report";
      return View();
    }
    public ViewResult Thanks() {
      ViewBag.Title = "Contact: Crime Report";
      return View();
    }
    public ViewResult Validate() {
      ViewBag.Title = "Contact: Crime Report";
      return View();
    }
  }
}
