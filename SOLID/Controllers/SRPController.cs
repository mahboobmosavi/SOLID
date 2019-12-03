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
    public class SRPController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetDailyPlannings()
        {
            //aaaa
            //
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetDailyPlanningById(int id)
        {
            return "value";
        }

        // POST api/values 
        [HttpPost]
        public void InsertDailyPlanning([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void EditDailyPlanning([FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteDailyPlanningById(int id)
        {
        }
    }
}