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
    public class NationalParksController : ControllerBase
    {
        private WalkTheParkContext _db;
        public NationalParksController(WalkTheParkContext db)
        {
            _db = db;
        }

        // GET api/nationalparks
        [HttpGet ("pages")]
        public async Task<IActionResult> GetAll([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.NationalParks
                .OrderBy(thing => thing.NationalParkId)
                .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
        }
    
        // GET api/nationalparks/
        [HttpGet]
        public ActionResult<IEnumerable<NationalPark>> Get(string name, string state, int accessPrice)
        {
            var query = _db.NationalParks.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (state != null)
            {
                query = query.Where(entry => entry.State == state);
            }
            if (accessPrice != null)
            {
                query = query.Where(entry => entry.AccessPrice == accessPrice);
            }

            return query.ToList();
        }

        // POST api/nationalparks
        [HttpPost]
        public void Post([FromBody] NationalPark nationalPark)
        {
            _db.NationalParks.Add(nationalPark);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<NationalPark> GetAction(int id)
        {
            return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
        }

        // PUT api/nationalparks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NationalPark nationalPark)
        {
            nationalPark.NationalParkId = id;
            _db.Entry(nationalPark).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/nationalparks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var nationalParkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
            _db.NationalParks.Remove(nationalParkToDelete);
            _db.SaveChanges();
        }
    }
}
