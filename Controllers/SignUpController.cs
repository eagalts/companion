using Companion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Companion.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(SUModel regData)
        {

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true
            };

            using (FileStream fs = new FileStream("Users.json", FileMode.Append))
            {
                //JsonSerializer.Serialize(fs, ",");
                JsonSerializer.Serialize<SUModel>(fs, regData, options);
            }

            return Content(Convert.ToString(regData));
        }
    }
}