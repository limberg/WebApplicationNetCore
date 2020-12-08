using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Pages
{
    public class TestModel : PageModel
    {
        IConfiguration Configuration;
        public TestModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public ContentResult OnGet()
        {
            var myKeyValue = Configuration["MyKey"];
            var defaultLogLevel = Configuration["Logging:LogLevel:Default"];

            return Content($"MyKey value:{myKeyValue} \n" + $"defaultLogLevel: {defaultLogLevel}");

        }
    }
}
