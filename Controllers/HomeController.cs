using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstWebApplication.controllers {
  public class HomeController : Controller {
    public ViewResult Index() {
      ViewBag.Title = "Home";
      return View();
    }
    public ViewResult Login() {
      ViewBag.Title = "login";
      return View();
    }
    
  }
}
