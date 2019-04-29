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
    public class ResultFilterSample : ResultFilterAttribute
    {

        private readonly string _name;
        private readonly string _value;

        public ResultFilterSample(string name = "", string value = "")
        {
            _name = name;
            _value = value;
        }

        override public void OnResultExecuting(ResultExecutingContext context)
        {
            if (_name.Length > 0 && _value.Length > 0)
            {
                context.HttpContext.Response.Headers.Add(_name, _value);
            }
            else
            {
                context.HttpContext.Response.Headers.Add("Author", "Aykut Asil");
            }
        }
    }
}
