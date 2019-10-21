using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetWonderAdoption.Controllers
{
    public class AdoptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}