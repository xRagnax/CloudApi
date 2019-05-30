using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChiroAPI.Data;
using ChiroAPI.Models;

namespace ChiroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeidersController : ControllerBase
    {
        private readonly LeidingContext _context;

        public LeidersController(LeidingContext context)
        {
            _context = context;
        }

        // GET: api/Leiders
        [HttpGet]
        public List<Leiding> GetLeiders(string naam, string groep, int leeftheid, int jaarleiding, int? page, string sort, int length = 2,  string dir ="asc")
        {
            IQueryable<Leiding> query = _context.Leiders;
            if (!string.IsNullOrWhiteSpace(naam))
                query = query.Where(q => q.Naam == naam);
            if (!string.IsNullOrWhiteSpace(groep))
                query = query.Where(q=> q.Groep == groep);
            if (!string.IsNullOrWhiteSpace(naam))
                query = query.Where(q => q.Leeftheid == leeftheid);
            if (!string.IsNullOrWhiteSpace(groep))
                query = query.Where(q => q.JaarLeiding == jaarleiding);

            if (page.HasValue)
                query = query.Skip(page.Value * length);
            query = query.Take(length);

            if(!string.IsNullOrWhiteSpace(sort))
                switch (sort)
                {
                    case "naam":
                        if (dir == "asc")
                            query = query.OrderBy(q => q.Naam);
                        else if (dir == "desc")
                            query = query.OrderByDescending(q => q.Naam);
                        break;
                    case "groep":
                        if (dir == "asc")
                            query = query.OrderBy(q => q.Groep);
                        else if (dir == "desc")
                            query = query.OrderByDescending(q => q.Groep);
                        break;
                    case "leeftheid":
                        if (dir == "asc")
                            query = query.OrderBy(q => q.Leeftheid);
                        else if (dir == "desc")
                            query = query.OrderByDescending(q => q.Leeftheid);
                        break;
                    case "jaarleiding":
                        if (dir == "asc")
                            query = query.OrderBy(q => q.JaarLeiding);
                        else if (dir == "desc")
                            query = query.OrderByDescending(q => q.JaarLeiding);
                        break;

                }


            return query.ToList();
        }


        // GET: api/Leiders/5
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult<Leiding> getLeiders(int id)
        {
            var deLeider = _context.Leiders.Find(id);
            if (deLeider == null)
                return NotFound();

            return deLeider;
        }
 

        // PUT: api/Leiders/5
        [HttpPut]
        public ActionResult<Leiding> PutLeiding([FromBody] Leiding leiding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

            _context.Leiders.Update(leiding);
            _context.SaveChanges();


            return NoContent();
        }

        // POST: api/Leiders
        [HttpPost]
        public ActionResult<Leiding> PostLeiding([FromBody] Leiding Leiding)
        {
            _context.Leiders.Add(Leiding);
            _context.SaveChanges();
            return Created("", Leiding);

        }

        // DELETE: api/Leiders/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLeiding([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leiding = _context.Leiders.Find(id);
            if (leiding == null)
            {
                return NotFound();
            }

            _context.Leiders.Remove(leiding);
            _context.SaveChanges();

            return NoContent();
        }

    }
}