using Microsoft.AspNetCore.Mvc;
using ColdConnectApp.Data;
using ColdConnectApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ColdConnectApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbrigosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AbrigosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var abrigos = await _context.Abrigos.Include(a => a.Doacoes).ToListAsync();
            return Ok(abrigos);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Abrigo abrigo)
        {
            _context.Abrigos.Add(abrigo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = abrigo.Id }, abrigo);
        }
    }
}
