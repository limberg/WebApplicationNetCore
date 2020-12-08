using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Pages
{
    public class Index2Model : PageModel
    {

        private IConfigurationRoot ConfigRoot;
        public Index2Model(IConfiguration configRoot)
        {
            ConfigRoot = (IConfigurationRoot)configRoot;
        }
        public ContentResult OnGet()
        {
            string str = "";
            foreach(var provider in ConfigRoot.Providers.ToList())
            {
                str += provider.ToString() + "\n";
            }

            return Content(str);
        }
    }
}
