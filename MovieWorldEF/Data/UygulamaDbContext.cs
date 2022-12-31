using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldEF.Data
{
    internal class UygulamaDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set;}
        public DbSet<Genre> Genres { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=MovieWorldDb; integrated security=true");
        }

       
        
        
    }
}
