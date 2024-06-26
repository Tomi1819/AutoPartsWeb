﻿namespace AutoPartsWeb.Attributes
{
    using AutoPartsWeb.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Security.Claims;

    public class NotADealerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IDealerService? dealerService = context.HttpContext.RequestServices.GetService<IDealerService>();

            if (dealerService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if ( dealerService != null &&
                dealerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
        }
    }
}
