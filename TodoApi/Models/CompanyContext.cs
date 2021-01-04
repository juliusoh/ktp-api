using Microsoft.EntityFrameworkCore;

namespace CompanyApi.Models
{
    public class CompanyContext : DbContext

    {
         public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public CompanyContext() {
          
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=roflrofl;database=knowthepro");



        }

        public DbSet<CompanyItem> Companies { get; set; }
    }
}