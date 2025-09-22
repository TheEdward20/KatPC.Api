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
    public class KatPCDataMasterController : ControllerBase
    {
        private readonly KatPCDbContext _context;

        public KatPCDataMasterController(KatPCDbContext context)
        {
            _context = context;
        }

        // GET: api/KatPCDataMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KatPCDatos>>> GetKatPCs()
        {
            return await _context.KatPCs.ToListAsync();
        }

        // GET: api/KatPCDataMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KatPCDatos>> GetKatPCData(int id)
        {
            var katPCData = await _context.KatPCs.FindAsync(id);

            if (katPCData == null)
            {
                return NotFound();
            }

            return katPCData;
        }

        // PUT: api/KatPCDataMaster/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKatPCData(int id, KatPCDatos katPCData)
        {
            if (id != katPCData.IdEquipo)
            {
                return BadRequest();
            }

            _context.Entry(katPCData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KatPCDataExists(id))
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

        // POST: api/KatPCDataMaster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KatPCDatos>> PostKatPCData(KatPCDatos katPCData)
        {
            _context.KatPCs.Add(katPCData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKatPCData", new { id = katPCData.IdEquipo }, katPCData);
        }

        // DELETE: api/KatPCDataMaster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKatPCData(int id)
        {
            var katPCData = await _context.KatPCs.FindAsync(id);
            if (katPCData == null)
            {
                return NotFound();
            }

            _context.KatPCs.Remove(katPCData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KatPCDataExists(int id)
        {
            return _context.KatPCs.Any(e => e.IdEquipo == id);
        }
    }
}
