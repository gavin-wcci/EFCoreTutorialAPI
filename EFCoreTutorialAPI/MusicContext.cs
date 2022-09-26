using EFCoreTutorialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorialAPI
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Song>().HasData(new Song() { Id = 1, Title = "More Than a Feeling" });
            model.Entity<Song>().HasData(new Song() { Id = 2, Title = "Misfit Toys" });
        }
    }
}
