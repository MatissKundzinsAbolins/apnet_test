using AppNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNet.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person();
            person.Name = "Matīss";
            person.Surname = "Kundziņš-Āboliņš";
            person.Email = "matisskundzins.abolins@gmail.com";
            person.Age = 22;
            person.Address = "tests";
            person.IsMale = true;

            return View(person);
        }
    }
}
