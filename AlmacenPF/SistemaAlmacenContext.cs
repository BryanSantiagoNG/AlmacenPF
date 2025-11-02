using Microsoft.EntityFrameworkCore;

namespace AlmacenPF.Models
{
    public class SistemaAlmacenContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Distribuidor> Distribuidores { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=SistemaAlmacen;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Claves primarias
            modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
            modelBuilder.Entity<Proveedor>().HasKey(p => p.IdProveedor);
            modelBuilder.Entity<Distribuidor>().HasKey(d => d.IdDistribuidor);
            modelBuilder.Entity<Articulo>().HasKey(a => a.IdArticulo);
            modelBuilder.Entity<Pedido>().HasKey(p => p.IdPedido);
            modelBuilder.Entity<DetallePedido>().HasKey(d => d.IdDetallePedido);
            modelBuilder.Entity<Factura>().HasKey(f => f.IdFactura);
            modelBuilder.Entity<DetalleFactura>().HasKey(d => d.IdDetalleFactura);
        }
    }
}
