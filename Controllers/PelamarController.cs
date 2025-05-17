using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TubesApi.Models;

namespace TubesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PelamarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PelamarController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPelamar()
        {
            var pelamars = await _context.Pelamars
                .ToListAsync();
            return Ok(pelamars);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PelamarModel pelamar)
        {
            _context.Pelamars.Add(pelamar);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllPelamar), new { id = pelamar.Id }, pelamar);
        }

        [HttpGet("pelamar/{pelamarId}")]
        public async Task<IActionResult> GetById(int pelamarId)
        {
            var pelamars = await _context.Pelamars
                .Where(l => l.Id == pelamarId)
                .ToListAsync();

            return Ok(pelamars);
        }
    }
}
