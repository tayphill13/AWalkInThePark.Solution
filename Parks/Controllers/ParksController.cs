using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Parks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        // GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "park1", "park2" };
        }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "thisPark";
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine(value);
        }

        // PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
