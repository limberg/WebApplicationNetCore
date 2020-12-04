using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ExceptionsFilter
{
    public class HttpResponseException : Exception
    {
        public int Status { get; set; } = 400;
        public object Value { get; set; }
    }
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        //Subtracting this number allows other filters to run at the very end of the pipeline.
        public int Order => int.MaxValue - 10;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Exception is HttpResponseException exception)
            {
                context.Result = new ObjectResult(exception.Value)
                {
                    StatusCode = exception.Status
                };

            context.ExceptionHandled = true;
            }
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
