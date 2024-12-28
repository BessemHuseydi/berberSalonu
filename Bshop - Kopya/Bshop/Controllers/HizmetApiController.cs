using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bshop.Models;
using Bshop.Data;

namespace Bshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HizmetApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HizmetApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/HizmetApi
        [HttpGet]
        public ActionResult<List<Hizmet>> Get()
        {
            return _context.Hizmets.Include(h => h.CalisanHizmetleri).ToList();
        }

        // GET: api/HizmetApi/5
        [HttpGet("{id}")]
        public ActionResult<Hizmet> Get(int id)
        {
            var hizmet = _context.Hizmets.Include(h => h.CalisanHizmetleri)
                                           .FirstOrDefault(h => h.Id == id);
            if (hizmet == null)
            {
                return NotFound();
            }

            return hizmet;
        }

        // POST: api/HizmetApi
        [HttpPost]
        public ActionResult<Hizmet> Post([FromBody] Hizmet hizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Hizmets.Add(hizmet);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = hizmet.Id }, hizmet);
        }

        // PUT: api/HizmetApi/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Hizmet hizmet)
        {
            if (id != hizmet.Id)
            {
                return BadRequest();
            }

            var existingHizmet = _context.Hizmets.Find(id);
            if (existingHizmet == null)
            {
                return NotFound();
            }

            existingHizmet.Name = hizmet.Name;
            existingHizmet.Description = hizmet.Description;
            existingHizmet.DurationMinutes = hizmet.DurationMinutes;
            existingHizmet.Price = hizmet.Price;
            existingHizmet.PhotoUrl = hizmet.PhotoUrl;

            _context.Hizmets.Update(existingHizmet);
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/HizmetApi/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var hizmet = _context.Hizmets.Include(h => h.CalisanHizmetleri)
                                           .FirstOrDefault(h => h.Id == id);

            if (hizmet == null)
            {
                return NotFound();
            }

            if (hizmet.CalisanHizmetleri != null && hizmet.CalisanHizmetleri.Any())
            {
                return BadRequest("Hizmet, ilişkili çalışanlar tarafından kullanılmaktadır.");
            }

            _context.Hizmets.Remove(hizmet);
            _context.SaveChanges();

            return Ok();
        }
    }
}
