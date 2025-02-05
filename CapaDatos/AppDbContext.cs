using Microsoft.EntityFrameworkCore;
using CapaPresentacion.Modelos;

namespace CapaDatos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto1> Producto1 { get; set; } 

        public AppDbContext() { }

        // Configuración de la cadena de conexión
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=HP1\\MSSQLSERVER01;Initial Catalog=app;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
   }
}
