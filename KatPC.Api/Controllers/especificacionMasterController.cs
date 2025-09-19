using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KatPC.Api.Model;
using Microsoft.AspNetCore.Cors;

namespace KatPC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("allowCors")]
    public class especificacionMasterController : ControllerBase
    {
        private readonly KatPCDbContext _context;

        public especificacionMasterController(KatPCDbContext context)
        {
            _context = context;
        }

        // GET: api/especificacionMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<especifiDATA>>> Getespecificaciones()
        {
            return await _context.especifiDATA.ToListAsync();
        }

        // GET: api/especificacionMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<especifiDATA>> Getespecificacion(int id)
        {
            var especificacion = await _context.especifiDATA.FindAsync(id);

            if (especificacion == null)
            {
                return NotFound();
            }

            return especificacion;
        }

        // PUT: api/especificacionMaster/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putespecificacion(int id, especifiDATA especificacion)
        {
            if (id != especificacion.id)
            {
                return BadRequest();
            }

            _context.Entry(especificacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!especificacionExists(id))
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

        // POST: api/especificacionMaster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<especifiDATA>> Postespecificacion(especifiDATA especificacion)
        {
            _context.especifiDATA.Add(especificacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getespecificacion", new { id = especificacion.id }, especificacion);
        }

        // DELETE: api/especificacionMaster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteespecificacion(int id)
        {
            var especificacion = await _context.especifiDATA.FindAsync(id);
            if (especificacion == null)
            {
                return NotFound();
            }

            _context.especifiDATA.Remove(especificacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool especificacionExists(int id)
        {
            return _context.especifiDATA.Any(e => e.id == id);
        }
    }
}
