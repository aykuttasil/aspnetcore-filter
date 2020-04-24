using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcore_filter.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace aspnetcore_filter.Filters
{
    public class IActionFilterSampleAttribute : IActionFilter
    {

        private readonly string _name;
        private readonly string _value;

        ILogger<IActionFilterSampleAttribute> _logger;

        public IActionFilterSampleAttribute(ILogger<IActionFilterSampleAttribute> logger, string name = "", string value = "")
        {
            _name = name;
            _value = value;
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("MyLog: IActionFilterSampleAttribute log");
            context.HttpContext.Response.Headers.Add(_name, _value);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
