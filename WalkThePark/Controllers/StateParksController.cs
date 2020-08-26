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
  public class StateParksController : ControllerBase
  {
    private WalkTheParkContext _db;
    public StateParksController(WalkTheParkContext db)
    {
      _db = db;
    }

    // GET api/stateparks
    [HttpGet ("StateParkPages")]
    public ActionResult GetAll([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
      var pagedData = _db.StateParks
          .OrderBy(thing => thing.StateParkId)
          .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
          .Take(validUrlQuery.PageSize);
      return Ok(pagedData);
    }

    // GET api/nationalparks/5
    [HttpGet]
    public ActionResult<IEnumerable<StatePark>> Get(string name, string state, string county)
    {
      var query = _db.StateParks.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }
      if (county != null)
      {
        query = query.Where(entry => entry.County == county);
      }

      return query.ToList();
    }

    // POST api/stateparks
    [HttpPost]
    public void Post([FromBody] StatePark statePark)
    {
      _db.StateParks.Add(statePark);
      _db.SaveChanges();
    }

    // GET api/stateparks/5
    [HttpGet("{id}")]
    public ActionResult<StatePark> GetAction(int id)
    {
      return _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
    }

      // PUT api/stateparks/5
      [HttpPut("{id}")]
    public void Put(int id, [FromBody] StatePark statePark)
    {
      statePark.StateParkId = id;
      _db.Entry(statePark).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/stateparks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateParkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
      _db.StateParks.Remove(stateParkToDelete);
      _db.SaveChanges();
    }
  }
}
