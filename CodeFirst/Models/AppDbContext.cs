//====
//CRUD
//====
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CNTLCPV;Initial Catalog=CodeFirstDBCore;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Company> Companiyalar { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
