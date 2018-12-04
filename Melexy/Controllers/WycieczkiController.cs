using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Melexy.Models;
using Melexy.VievModels;

namespace Melexy.Controllers
{
    public class WycieczkiController : Controller
    {
        // GET: Wycieczki
        public ActionResult Nowa()
        {
            
            return View();
        }


        public ActionResult WycieczkiZDnia()
        {
            List<Wycieczka> Wycieczki = new List<Wycieczka>()
            {
                new Wycieczka {start = DateTime.UtcNow , cena = 150},
                new Wycieczka {start = DateTime.UtcNow , cena = 300},
            };
            var viewModel = new WycieczkiZDnia
            {
                Wycieczki = Wycieczki
            };
            return View(viewModel);
        }
    }
}