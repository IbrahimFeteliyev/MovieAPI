using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MovieDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieVideo> MovieVideos { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

    }
}
