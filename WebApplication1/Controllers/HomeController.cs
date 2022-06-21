using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IPeople _personRep;
        public HomeController (IPeople personRep)
        {
            _personRep = personRep;
        }
        public ViewResult Index()
        {
            var homePeople = new HomeViewModel
            {
                bdNow = _personRep.getBdNow,
                bdSoon=_personRep.getBdSoon
            };
            return View(homePeople);
        }
 
    }
}
