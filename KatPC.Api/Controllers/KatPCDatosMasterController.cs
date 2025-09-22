using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KatPC.Api.Model;

namespace KatPC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KatPCDatosMasterController : ControllerBase
    {
        private readonly KatPCDbContext _context;

        public KatPCDatosMasterController(KatPCDbContext context)
        {
            _context = context;
        }

        // GET: api/KatPCDatosMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KatPCDatos>>> GetKatPCs()
        {
            return await _context.KatPCs.ToListAsync();
        }

        // GET: api/KatPCDatosMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KatPCDatos>> GetKatPCDatos(int id)
        {
            var katPCDatos = await _context.KatPCs.FindAsync(id);

            if (katPCDatos == null)
            {
                return NotFound();
            }

            return katPCDatos;
        }

        // PUT: api/KatPCDatosMaster/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKatPCDatos(int id, KatPCDatos katPCDatos)
        {
            if (id != katPCDatos.IdEquipo)
            {
                return BadRequest();
            }

            _context.Entry(katPCDatos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KatPCDatosExists(id))
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

        // POST: api/KatPCDatosMaster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KatPCDatos>> PostKatPCDatos(KatPCDatos katPCDatos)
        {
            _context.KatPCs.Add(katPCDatos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKatPCDatos", new { id = katPCDatos.IdEquipo }, katPCDatos);
        }

        // DELETE: api/KatPCDatosMaster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKatPCDatos(int id)
        {
            var katPCDatos = await _context.KatPCs.FindAsync(id);
            if (katPCDatos == null)
            {
                return NotFound();
            }

            _context.KatPCs.Remove(katPCDatos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KatPCDatosExists(int id)
        {
            return _context.KatPCs.Any(e => e.IdEquipo == id);
        }
    }
}
