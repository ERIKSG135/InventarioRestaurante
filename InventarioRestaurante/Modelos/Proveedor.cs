using System.ComponentModel.DataAnnotations;


namespace InventarioRestaurante.Modelos
{
    public class Proveedor
    {
            public int Id { get; set; }
            public string? Nombre { get; set; }

            public string? Numero { get; set; }

            //Propiedad de navegacion EF
            public virtual ICollection<Producto>? Productos { get; set; }
        }
    }

