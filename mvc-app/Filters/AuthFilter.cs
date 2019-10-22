using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using mvc_app.Models;

namespace mvc_app.Filters
{
	public class AuthFilter : ActionFilterAttribute, IActionFilter
	{
		public override void OnActionExecuted(ActionExecutedContext context)
		{

		}

		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var autenticado = context.HttpContext.Session.GetString("Autenticado");

			if (string.IsNullOrEmpty(autenticado))
			{
				context.Result = new RedirectToRouteResult(
					new RouteValueDictionary(new { controller = "Login", action = "AuthError" })
				);
			}
		}
	}
}