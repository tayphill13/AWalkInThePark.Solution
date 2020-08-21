// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace Parks.Controllers
// {
//   [Route("api/[controller]")]
//   [ApiController]
//   public class MonumentsController : ControllerBase
//   {
//     // GET api/monuments
//     [HttpGet]
//     public ActionResult<IEnumerable<string>> Get()
//     {
//       return new string[] { "monument1", "monument2" };
//     }

//     // GET api/monuments/5
//     [HttpGet("{id}")]
//     public ActionResult<string> Get(int id)
//     {
//       return "thisMonument";
//     }

//     // POST api/monuments
//     [HttpPost]
//     public void Post([FromBody] string value)
//     {
//       Console.WriteLine(value);
//     }

//     // PUT api/monuments/5
//     [HttpPut("{id}")]
//     public void Put(int id, [FromBody] string value)
//     {
//     }

//     // DELETE api/monuments/5
//     [HttpDelete("{id}")]
//     public void Delete(int id)
//     {
//     }
//   }
// }
