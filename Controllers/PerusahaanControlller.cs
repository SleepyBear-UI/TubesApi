using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TubesApi.Models;

namespace TubesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerusahaanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PerusahaanController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClient()
        {
            var perusahaans = await _context.Perusahaans
                .ToListAsync();

            return Ok(perusahaans);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PerusahaanModel perusahaan)
        {
            _context.Perusahaans.Add(perusahaan);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllClient), new { id = perusahaan.Id }, perusahaan);
        }

        [HttpGet("perusahaan/{perusahaanId}")]
        public async Task<IActionResult> GetByClients(int perusahaanId)
        {
            var perusahaans = await _context.Perusahaans
                .Where(l => l.Id == perusahaanId)
                .ToListAsync();

            return Ok(perusahaans);
        }
    }
}
