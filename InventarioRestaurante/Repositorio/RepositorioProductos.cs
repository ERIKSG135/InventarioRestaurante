using InventarioRestaurante.Modelos;
using Microsoft.EntityFrameworkCore;

namespace InventarioRestaurante.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly InventarioDBContext _context;

        public RepositorioProductos(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<Producto> Add(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task Delete(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Producto?> Get(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.Include(p => p.Proveedor).Include(v => v.Area).ToListAsync();
        }

        public async Task<List<Proveedor>> GetProveedores()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task<List<Area>> GetAreas()
        {
            return await _context.Areas.ToListAsync();
        }

        public async Task Update(int id, Producto producto)
        {
            var productoactual = await _context.Productos.FindAsync(id);
            if (productoactual != null)
            {
                productoactual.Nombre = producto.Nombre;
                productoactual.Cantidad = producto.Cantidad;

                await _context.SaveChangesAsync();
            }
        }
    }
}