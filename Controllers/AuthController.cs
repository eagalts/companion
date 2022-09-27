//using AspNetCore;
using Companion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http.Json;
using System.Security.Cryptography;

using System.Text.Json;
using System.Text.Json.Serialization;

using System.IO;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
//using Newtonsoft.Json;

namespace Companion.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string err)
        {
            return View();
        }


        public IActionResult Check(Class authData)
        {
            /*
            using (FileStream fs = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                //SUModel aData = JsonSerializer.Deserialize<SUModel>(fs);
                return Content($"Name: {aData?.login}  Age: {aData?.password}");
            }*/

            List<SUModel> sData = JsonConvert.DeserializeObject<List<SUModel>>(System.IO.File.ReadAllText("Users.json")+']');
            //return Content(sData[0].login);

            foreach(var el in sData)
            {
                if (authData.login == el.login)
                {
                    if (authData.password == el.password)
                    {
                        return Content("Логин +\nПароль +");
                    }
                    else
                    {
                        return Content("Логин +\nНеверно указан пароль");
                        break;
                    }
                }
            }

            return Content("Неверно указан логин");
            /*

            //string authData = $"Login: {login}   Password: {password}";
            if (authData.login == "admin")
                if (authData.password == "admin")
                    return Redirect("home/privacy");
                else
                    return Content("Неверный логин или пароль.");
            else
                return Content("Неверный логин или пароль.");
            
            return Content("\n");

            */

            //return Content("\n");
        }


    }
}
