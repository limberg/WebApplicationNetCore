using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WebApplication.Pages
{
    public class ConfigPatternOptionsModel : PageModel
    {
        private readonly PositionOptions _options;

        public ConfigPatternOptionsModel(IOptions<PositionOptions> options)
        {
            _options = options.Value;
        }
        public ContentResult OnGet()
        {
            return Content($"Title:{_options.Title} \n Name: {_options.Name}");

        }
    }
}
