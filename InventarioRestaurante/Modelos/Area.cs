using System.ComponentModel.DataAnnotations;


namespace InventarioRestaurante.Modelos
{
    public class Area
    {
        public int Id {  get; set; }
        public string? Nombre { get; set; }

        public string? Encargado { get; set; }

        //Propiedad de navegacion EF
        public virtual ICollection<Producto>? Productos { get; set; }
    }
}
