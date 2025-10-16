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
        // LOGIN: solo validar usuario existente
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] KatPCUsuarios loginUser)
        {
            var user = await _context.KatPCuser
                .FirstOrDefaultAsync(u => u.Nombre == loginUser.Nombre && u.Passwor == loginUser.Passwor);

            if (user == null)
                return Unauthorized("Usuario o contraseña incorrectos");

            // Devuelve solo info necesaria para Angular
            return Ok(new { message = "Login exitoso", userId = user.IdUsuario, nombre = user.Nombre });
        }

    }

}
