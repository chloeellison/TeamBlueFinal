using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FCARform.Models;

namespace FCARform.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<CLO> CLOs {get; set;}
    public DbSet<Dean> Deans {get; set;}
    public DbSet<Professor> Professors {get; set;}
    public DbSet<Administrator> Administrators {get; set;}
}
