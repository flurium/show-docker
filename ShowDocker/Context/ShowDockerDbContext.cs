using Microsoft.EntityFrameworkCore;
using ShowDocker.Models;

namespace ShowDocker.Context
{
    public class ShowDockerDbContext : DbContext
    {
        public DbSet<TopG> TopGs { get; set; }
    }
}