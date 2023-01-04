using Blazor4.Model;
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace Blazor4.Data
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions options): base(options)
        {

        }

        public SystemContext(): base()
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=localhost\\SQLEXPRESS;Database=Demo;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(conn);

            base.OnConfiguring(optionsBuilder);
        }

    }
}
