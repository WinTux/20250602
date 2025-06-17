using EjemplosASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemplosASPNET.Conexion
{
    public class ProductoDbContext : DbContext
    {
        public virtual DbSet<Producto> Productos { get; set; }
        public ProductoDbContext(DbContextOptions<ProductoDbContext> options) : base(options) { }
    }
}
