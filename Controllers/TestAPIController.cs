using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FakeCtrip.API.Controllers
{
    [Route("api/[controller]")]
    public class TestAPIController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value2", "value3" };
        }
    }
}

