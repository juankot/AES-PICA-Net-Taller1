using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Filters;
using mvc_app.Models;
using Newtonsoft.Json;


namespace mvc_app.Controllers
{
    public class ContactoController : Controller
    {
        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [ErroresFilter]
        public async Task<IActionResult> Contacto(ContactoViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            
                    using (var response = await httpClient.PostAsync("http://localhost:5000/api/contacto", content))
                    {
                        ContactoViewModel receivedContacto = null;
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        receivedContacto = JsonConvert.DeserializeObject<ContactoViewModel>(apiResponse);
                    }
                }
                return RedirectToAction("Gracias");
            }
            return View(model);
        }

        [ErroresFilter]
        public IActionResult Gracias()
		{
			return View();
		}

    }
}
