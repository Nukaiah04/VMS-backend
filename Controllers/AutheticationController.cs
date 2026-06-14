using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Data;
using VMS.Models;

namespace VMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutheticationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AutheticationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Authetication
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Authetication>>> GetAll()
        {
            return await _context.Authetication.ToListAsync();
        }

        // GET: api/Authetication/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Authetication>> GetById(int id)
        {
            var auth = await _context.Authetication.FindAsync(id);
            if (auth == null) return NotFound();
            return auth;
        }

        // POST: api/Authetication/register
        [HttpPost("register")]
        public async Task<ActionResult<Authetication>> Register(Authetication auth)
        {
            var exists = await _context.Authetication
                .AnyAsync(a => a.Email == auth.Email);
            if (exists)
                return BadRequest("Email already registered.");

            auth.Created = DateTime.Now;
            auth.Status = "Active";

            _context.Authetication.Add(auth);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = auth.AutheticationId }, auth);
        }

        // POST: api/Authetication/login
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] Authetication loginRequest)
        {
            var user = await _context.Authetication
                .FirstOrDefaultAsync(a =>
                    a.Email == loginRequest.Email &&
                    a.Password == loginRequest.Password);

            if (user == null)
                return Unauthorized("Invalid email or password.");

            return Ok(new { message = "Login successful", role = user.Role, userName = user.UserName });
        }

        // PUT: api/Authetication/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Authetication auth)
        {
            if (id != auth.AutheticationId) return BadRequest();

            _context.Entry(auth).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var exists = await _context.Authetication.AnyAsync(a => a.AutheticationId == id);
                if (!exists) return NotFound();
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Authetication/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var auth = await _context.Authetication.FindAsync(id);
            if (auth == null) return NotFound();

            _context.Authetication.Remove(auth);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}