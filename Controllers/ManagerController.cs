using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstWebApplication.Controllers {
  public class ManagerController : Controller {
    public ViewResult CrimeManager() {
      return View();
    }
    public ViewResult StartManager() {
      
      return View();
    }
  }
}
