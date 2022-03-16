using CM.Domain;
using Microsoft.EntityFrameworkCore;

namespace CM.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }  
    }
}
