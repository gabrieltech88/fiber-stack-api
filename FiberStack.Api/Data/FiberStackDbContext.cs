using Microsoft.EntityFrameworkCore;
using FiberStack.Api.Data.Models;

namespace FiberStack.Api.Data;

public class FiberStackDbContext : DbContext
{
    public DbSet<Olt> Olts{ get; set; }
    public DbSet<Acesso> Acesso { get; set; }
    public FiberStackDbContext(DbContextOptions<FiberStackDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}