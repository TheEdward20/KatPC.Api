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
    public class KatPCUsuariosMasterController : ControllerBase
    {
        private readonly KatPCDbContext _context;

        public KatPCUsuariosMasterController(KatPCDbContext context)
        {
            _context = context;
        }

        

        // POST: api/KatPCUsuariosMaster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KatPCUsuarios>> PostKatPCUsuarios(KatPCUsuarios katPCUsuarios)
        {
            _context.KatPCuser.Add(katPCUsuarios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKatPCUsuarios", new { id = katPCUsuarios.IdUsuario }, katPCUsuarios);
        }

    }
}
