using Microsoft.EntityFrameworkCore;
using ShowDocker.Models;

namespace ShowDocker.Context
{
  public class ShowDockerDbContext : DbContext
  {
    public ShowDockerDbContext(DbContextOptions options) : base(options)
    {
      Database.EnsureCreated();
    }

    public DbSet<TopG> TopGs { get; set; }
  }
}