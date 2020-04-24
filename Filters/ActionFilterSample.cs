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
    public class ActionFilterSampleAttribute : ActionFilterAttribute
    {

        private readonly string _name;
        private readonly string _value;

        public ActionFilterSampleAttribute(string name = "", string value = "")
        {
            _name = name;
            _value = value;
        }

        override public void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Test-ActionFilterAttribute", "yeah");
        }

        override public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
