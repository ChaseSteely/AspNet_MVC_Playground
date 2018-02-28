using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Playground.Services
{
    public interface IApplicationConfiguration
    {
        string GoogleApiKey { get; set; }
    }
}
