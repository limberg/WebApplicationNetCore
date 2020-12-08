using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.WebApplication.Options;

namespace WebApplication.Pages
{
    public class AddMyDependencyInjectionModel : PageModel
    {
        private readonly IMyDependency _myDependency;

        public AddMyDependencyInjectionModel(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }

        public void OnGet()
        {
            _myDependency.WriteMessage("AddMyDependencyInjectionModel.OnGet");
        }
    }
}
