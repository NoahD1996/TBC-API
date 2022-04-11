#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarkov_Ballistics_Calculator.Models;

namespace Tarkov_Ballistics_Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BulletController : ControllerBase
    {
        private readonly BulletContext _context;

        public BulletController(BulletContext context)
        {
            _context = context;
        }

        // GET: api/Bullet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bullet>>> GetBullets()
        {
            return await _context.Bullets.ToListAsync();
        }

        // GET: api/Bullet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bullet>> GetBullet(long id)
        {
            var bullet = await _context.Bullets.FindAsync(id);

            if (bullet == null)
            {
                return NotFound();
            }

            return bullet;
        }

        // PUT: api/Bullet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBullet(long id, Bullet bullet)
        {
            if (id != bullet.Id)
            {
                return BadRequest();
            }

            _context.Entry(bullet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BulletExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bullet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bullet>> PostBullet(Bullet bullet)
        {
            _context.Bullets.Add(bullet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBullet", new { id = bullet.Id }, bullet);
        }

        // DELETE: api/Bullet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBullet(long id)
        {
            var bullet = await _context.Bullets.FindAsync(id);
            if (bullet == null)
            {
                return NotFound();
            }

            _context.Bullets.Remove(bullet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BulletExists(long id)
        {
            return _context.Bullets.Any(e => e.Id == id);
        }
    }
}
