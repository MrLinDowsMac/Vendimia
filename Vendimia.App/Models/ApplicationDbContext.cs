using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Vendimia.App.Models
{
    class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VendimiaDB;Integrated Security=True")
            .EnableSensitiveDataLogging(true)
            .UseLoggerFactory(loggerFactory);
            //new LoggerFactory().Create.AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true)
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalle { get; set; }
        public DbSet<Configuracion> Configuracion { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add your own configuration here
            //modelBuilder.Entity<Configuracion>().Property<decimal>(x => x.TasaFinanciamiento).
            modelBuilder.Entity<Configuracion>()
                .Property(e => e.TasaFinanciamiento).HasColumnType("decimal(6,4)");

            modelBuilder.Entity<Configuracion>()
                .Property(e => e.Enganche).HasColumnType("decimal(6,4)");

            //Seed Data
            modelBuilder.Entity<Configuracion>().HasData(
                new Configuracion { Id=1, PrimerConfiguracion = true, Enganche = 0.00M, PlazoMaximo = 0, TasaFinanciamiento = 0.00M }
            );
        }


    }
}
