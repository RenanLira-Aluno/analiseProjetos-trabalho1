using Microsoft.EntityFrameworkCore;

namespace livraria.Models
{
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

        public DbSet<Librarian> Librarian {get;set;}
    }
}