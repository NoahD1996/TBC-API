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
    public class ArmorController : ControllerBase
    {
        private readonly ArmorContext _context;

        public ArmorController(ArmorContext context)
        {
            _context = context;
        }

        // GET: api/Armor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armor>>> GetArmor()
        {
            return await _context.Armor.ToListAsync();
        }

        // GET: api/Armor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Armor>> GetArmor(long id)
        {
            var armor = await _context.Armor.FindAsync(id);

            if (armor == null)
            {
                return NotFound();
            }

            return armor;
        }

        // PUT: api/Armor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmor(long id, Armor armor)
        {
            if (id != armor.Id)
            {
                return BadRequest();
            }

            _context.Entry(armor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmorExists(id))
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

        // POST: api/Armor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Armor>> PostArmor(Armor armor)
        {
            _context.Armor.Add(armor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArmor", new { id = armor.Id }, armor);
        }

        // DELETE: api/Armor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArmor(long id)
        {
            var armor = await _context.Armor.FindAsync(id);
            if (armor == null)
            {
                return NotFound();
            }

            _context.Armor.Remove(armor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmorExists(long id)
        {
            return _context.Armor.Any(e => e.Id == id);
        }
    }
}
