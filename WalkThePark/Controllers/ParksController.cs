using Microsoft.EntityFrameworkCore;
using WalkThePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WalkThePark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private WalkTheParkContext _db;
        public ParksController(WalkTheParkContext db)
        {
            _db = db;
        }

        // GET api/parks
        [HttpGet ("pages")]
        public async Task<IActionResult> GetAll([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.Parks
                .OrderBy(thing => thing.ParkId)
                .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
        }
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "park1", "park2" };
        // }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Park>> Get(string name, string state, string parkType, int accessPrice)
        {
            var query = _db.Parks.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (state != null)
            {
                query = query.Where(entry => entry.State == state);
            }
            if (parkType != null)
            {
                query = query.Where(entry => entry.ParkType == parkType);
            }
            if (accessPrice != null)
            {
                query = query.Where(entry => entry.AccessPrice == accessPrice);
            }

            return Queryable.ToList();
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine(value);
        }

        // PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
