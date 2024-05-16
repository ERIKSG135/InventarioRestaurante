using Microsoft.EntityFrameworkCore;

namespace InventarioRestaurante.Modelos
{
    public class InventarioDBContext: DbContext
    {
        public InventarioDBContext(DbContextOptions<InventarioDBContext> options):base(options) 
        {
        }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Area> Areas {  get; set; } 

        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
