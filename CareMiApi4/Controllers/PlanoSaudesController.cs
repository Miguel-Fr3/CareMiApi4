using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CareMiApi4.Data;
using CareMiApi4.Models;

namespace CareMiApi4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoSaudesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlanoSaudesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PlanoSaudes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanoSaude>>> GetPlanosSaude()
        {
            return await _context.PlanosSaude.ToListAsync();
        }

        // GET: api/PlanoSaudes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanoSaude>> GetPlanoSaude(int id)
        {
            var planoSaude = await _context.PlanosSaude.FindAsync(id);

            if (planoSaude == null)
            {
                return NotFound();
            }

            return planoSaude;
        }

        // PUT: api/PlanoSaudes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanoSaude(int id, PlanoSaude planoSaude)
        {
            if (id != planoSaude.CdPlanoSaude)
            {
                return BadRequest();
            }

            _context.Entry(planoSaude).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanoSaudeExists(id))
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

        // POST: api/PlanoSaudes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlanoSaude>> PostPlanoSaude(PlanoSaude planoSaude)
        {
            _context.PlanosSaude.Add(planoSaude);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanoSaude", new { id = planoSaude.CdPlanoSaude }, planoSaude);
        }

        // DELETE: api/PlanoSaudes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanoSaude(int id)
        {
            var planoSaude = await _context.PlanosSaude.FindAsync(id);
            if (planoSaude == null)
            {
                return NotFound();
            }

            _context.PlanosSaude.Remove(planoSaude);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanoSaudeExists(int id)
        {
            return _context.PlanosSaude.Any(e => e.CdPlanoSaude == id);
        }
    }
}