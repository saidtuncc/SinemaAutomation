using Microsoft.EntityFrameworkCore;

namespace SinemaSistemiv1.Data
{
    public class SinemaSistemiContext : DbContext
    {
        public SinemaSistemiContext()
        {
        }

        public SinemaSistemiContext(DbContextOptions<SinemaSistemiContext> options)
            : base(options)
        {
        }

        public DbSet<Filmler> Filmler { get; set; }
        public DbSet<Koltuklar> Koltuklar { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Salonlar> Salonlar { get; set; }
        public DbSet<SatisRaporlari> SatisRaporlari { get; set; }
        public DbSet<Seanslar> Seanslar { get; set; }
        public DbSet<Biletler> Biletler { get; set; }
        public DbSet<HalkGunu> HalkGunu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;",
                    new MySqlServerVersion(new Version(8, 0, 21)));
            }
        }
    }
}
