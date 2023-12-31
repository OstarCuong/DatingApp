using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControlerBase
    {
        public readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUers()
        {
            return await _context.Users.ToListAsync();

        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUers(int id)
        {
        
            return await _context.Users.FindAsync(id);
        }
        
    }
}