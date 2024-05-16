using System.ComponentModel.DataAnnotations;

namespace InventarioRestaurante.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100, ErrorMessage = "Maximo de caracteres 100")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe agregar una cantidad")]
        public string? Cantidad { get; set;}
        [Required(ErrorMessage = "Debe seleccionar Area")]

        //propiedad de navegacion EF
        public int AreaId { get; set;}
        virtual public Area? Area { get; set; }

        public int ProveedorId { get; set; }
        virtual public Proveedor? Proveedor { get; set; }

       
    }
}
