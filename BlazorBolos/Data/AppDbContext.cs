using Microsoft.EntityFrameworkCore;

namespace BlazorBolos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Bolo> Bolos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolo>().HasData(
                new Bolo
                {
                    Id = 1,
                    Nome= "Bolo1",
                    Descricao= "Bolo1 ",
                    Preco = 25.45m,
                    ImagemUrl = "bolo1.jpg",                    
                },
                new Bolo
                {
                    Id = 2,
                    Nome= "Bolo2",
                    Descricao= "Bolo2 Descricao",
                    Preco = 21.0m,
                    ImagemUrl = "bolo2.jpg",
                },
                new Bolo
                {
                    Id = 3,
                    Nome= "Bolo3",
                    Descricao= "Bolo3 descricao",
                    Preco = 19.0m,
                    ImagemUrl = "bolo3.jpg",
                },
                new Bolo
                {
                    Id = 4,
                    Nome= "Bolo4",
                    Descricao= "Bolo4 descricao",
                    Preco = 34.75m,
                    ImagemUrl = "bolo4.jpg",
                });
        }
    }
}
