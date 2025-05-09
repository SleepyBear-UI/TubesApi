using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KonstruksiPerangkatLunak.Models;

namespace KonstruksiPerangkatLunak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClient()
        {
            var clients = await _context.Clients
                .ToListAsync();

            return Ok(clients);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientModel client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllClient), new { id = client.Id }, client);
        }

        [HttpGet("client/{clientId}")]
        public async Task<IActionResult> GetByClients(int clientId)
        {
            var clients = await _context.Clients
                .Where(l => l.Id == clientId)
                .ToListAsync();

            return Ok(clients);
        }
    }
}
