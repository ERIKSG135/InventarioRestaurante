using InventarioRestaurante.Modelos;

namespace InventarioRestaurante.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int id);
        Task<List<Proveedor>> GetProveedores();
        Task<List<Area>> GetAreas();
        Task<Producto> Add(Producto producto);
        Task Update(int id, Producto producto);
        Task Delete(int id);
    }
}
