using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstWebApplication.Controllers {
  public class InvestigatorController : Controller {
    public ViewResult CrimeInvestigator() {
      return View();
    }
    public ViewResult StartInvestigator() {
      ViewBag.Title = "Contact: Crime Report";
      return View();
    }
    
    
  }
}
