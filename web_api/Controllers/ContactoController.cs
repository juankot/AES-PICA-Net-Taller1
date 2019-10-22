using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webappi.Models;

namespace webappi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        [HttpPost]
        public object Post(ContactoViewModel model)
        {
            if (ModelState.IsValid)
			{
				return Ok(model);
			}
			else
			{
				return BadRequest();
			}
        }
    }
}
