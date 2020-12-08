using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Options
{
    public class ColorOptions
    {
        public const string Color = "Color";

        public string Foreground { get; set; }
        public string Background { get; set; }
    }
}
