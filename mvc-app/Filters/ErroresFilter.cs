using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using mvc_app.Models;

namespace mvc_app.Filters
{
	public class ErroresFilter : ExceptionFilterAttribute
	{
		public override void OnException(ExceptionContext context)
		{

			context.Result = new RedirectToRouteResult(
					new RouteValueDictionary(new { controller = "Inicio", action = "Error" })
				);
		}
	}
}