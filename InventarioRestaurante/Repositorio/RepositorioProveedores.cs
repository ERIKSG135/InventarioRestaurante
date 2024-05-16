using InventarioRestaurante.Modelos;
using Microsoft.EntityFrameworkCore;

namespace InventarioRestaurante.Repositorio
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly InventarioDBContext _context;

        public RepositorioProveedores(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<Proveedor> Add(Proveedor proveedor)
        {
            await _context.Proveedores.AddAsync(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }

        public async Task Delete(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor?> Get(int id)
        {
            return await _context.Proveedores.FindAsync(id);
        }

        public async Task<List<Proveedor>> GetAll()
        {
            return await _context.Proveedores.Include(r => r.Productos).ToListAsync();
        }

        public async Task Update(int id, Proveedor proveedor)
        {
            var proveedoractual = await _context.Areas.FindAsync(id);
            if (proveedoractual != null)
            {
                proveedoractual.Nombre = proveedor.Nombre;
                proveedoractual.Encargado = proveedor.Numero;
                await _context.SaveChangesAsync();
            }
        }
    }
}
