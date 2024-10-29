using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CareMiApi4.Data;
using CareMiApi4.Models;
using Microsoft.AspNetCore.Authorization;

namespace CareMiApi4.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExamesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExamesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Exames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exame>>> GetExames()
        {
            return await _context.Exames.ToListAsync();
        }

        // GET: api/Exames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exame>> GetExame(int id)
        {
            var exame = await _context.Exames.FindAsync(id);

            if (exame == null)
            {
                return NotFound();
            }

            return exame;
        }

        // PUT: api/Exames/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExame(int id, Exame exame)
        {
            if (id != exame.CdExame)
            {
                return BadRequest();
            }

            _context.Entry(exame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExameExists(id))
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

        // POST: api/Exames
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Exame>> PostExame(Exame exame)
        {
            _context.Exames.Add(exame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExame", new { id = exame.CdExame }, exame);
        }

        // DELETE: api/Exames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExame(int id)
        {
            var exame = await _context.Exames.FindAsync(id);
            if (exame == null)
            {
                return NotFound();
            }

            _context.Exames.Remove(exame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExameExists(int id)
        {
            return _context.Exames.Any(e => e.CdExame == id);
        }
    }
}
