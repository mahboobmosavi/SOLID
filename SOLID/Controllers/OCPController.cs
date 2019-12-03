using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOLID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OCPController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetDailyPlannings()
        {
            //aaaa
            //
            return new string[] { "value1", "value2" };
        }
    }
}