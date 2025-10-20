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
    public class KatPCServiciosMasterController : ControllerBase
    {
        private readonly KatPCDbContext _context;

        public KatPCServiciosMasterController(KatPCDbContext context)
        {
            _context = context;
        }

        // GET: api/KatPCServiciosMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KatPCServicios>>> GetKatPCServices()
        {
            return await _context.KatPCServices.ToListAsync();
        }

        // GET: api/KatPCServiciosMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KatPCServicios>> GetKatPCServicios(int id)
        {
            var katPCServicios = await _context.KatPCServices.FindAsync(id);

            if (katPCServicios == null)
            {
                return NotFound();
            }

            return katPCServicios;
        }

        // PUT: api/KatPCServiciosMaster/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKatPCServicios(int id, KatPCServicios katPCServicios)
        {
            if (id != katPCServicios.IdServicio)
            {
                return BadRequest();
            }

            _context.Entry(katPCServicios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KatPCServiciosExists(id))
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

        // POST: api/KatPCServiciosMaster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KatPCServicios>> PostKatPCServicios(KatPCServicios katPCServicios)
        {
            _context.KatPCServices.Add(katPCServicios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKatPCServicios", new { id = katPCServicios.IdServicio }, katPCServicios);
        }

        // DELETE: api/KatPCServiciosMaster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKatPCServicios(int id)
        {
            var katPCServicios = await _context.KatPCServices.FindAsync(id);
            if (katPCServicios == null)
            {
                return NotFound();
            }

            _context.KatPCServices.Remove(katPCServicios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KatPCServiciosExists(int id)
        {
            return _context.KatPCServices.Any(e => e.IdServicio == id);
        }
    }
}
