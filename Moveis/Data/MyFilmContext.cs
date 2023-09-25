using Microsoft.EntityFrameworkCore;
using Moveis.Data.Entity;

namespace Moveis.Data
{
    public class MyFilmContext:DbContext
    {
        public MyFilmContext(DbContextOptions<MyFilmContext> options) : base(options) 
        {
            
        }
        public DbSet<Film> Films { get; set; }  
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }

    }
}
