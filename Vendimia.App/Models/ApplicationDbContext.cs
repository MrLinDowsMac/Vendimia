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
        public DbSet<VentaDetalle> VentaDetalle {get; set; }
        
        
    }
}
