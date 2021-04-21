using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelViewControllerProject.Models;

namespace ModelViewControllerProject.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
                
                return View("Thanks", guest);
            else
                // Wykryto błąd sprawdzania wiarygodności
                return View();
        }


    }
}