using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
        
    }
    public DbSet<User> Users { get; set; }
}