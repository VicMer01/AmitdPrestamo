using AmitdPres.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AmitdPrestamo.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<TipoAmortizacion> TiposAmortizacion { get; set; }
        public DbSet<TipoPrestamo> TiposPrestamo { get; set; }
        public DbSet<GastosLegales> GastosLegales { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Garantia> Garantias { get; set; }
        public DbSet<TipoGarantia> TiposGarantia { get; set; }
        public DbSet<Documentos> Documentos { get; set; }
    }
}
