using RestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ActiveController : ControllerBase
{
    private readonly AppDbContext _context;

    public ActiveController(AppDbContext context)
    {
        _context = context;
    }
    
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<User>> Create([FromBody] User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok();
    }
}