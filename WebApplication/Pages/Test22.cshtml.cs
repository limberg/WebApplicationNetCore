using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Pages
{
    public class Test22Model : PageModel
    {
        private IConfiguration Configuration;

        public Test22Model(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public ContentResult OnGet()
        {
            var positionsOptions = new PositionOptions();
            Configuration.GetSection(PositionOptions.Position).Bind(positionsOptions);

            return Content($"Title: {positionsOptions.Title} \n" + $"Name: {positionsOptions.Name}");
        }
    }

    
}
