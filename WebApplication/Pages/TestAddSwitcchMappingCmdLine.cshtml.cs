using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Pages
{
    public class TestAddSwitcchMappingCmdLineModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public TestAddSwitcchMappingCmdLineModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ContentResult OnGet()
        {
            return Content($"Key1: '{_configuration["key1"]}'\n" +
                           $"Key2: '{_configuration["key2"]}'\n");
        }
    }
}
