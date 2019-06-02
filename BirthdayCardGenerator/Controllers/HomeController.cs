using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CardGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult FormFill()
        {
            return View();
        }
       [HttpPost]
        public ActionResult FormFill(Models.CardInfo cardInfo)
        {
            if (ModelState.IsValid)
            {
                return View("YourCard" , cardInfo);
            }
            else
            {
                return View();
            }
           

        }
    }
}