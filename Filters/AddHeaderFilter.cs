using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcore_filter.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace aspnetcore_filter.Filters
{
    public class AddHeaderFilter : ActionFilterAttribute
    {
        override public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
