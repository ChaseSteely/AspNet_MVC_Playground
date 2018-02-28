using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Playground.Services
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public string GoogleApiKey { get ; set; }
    }
}
