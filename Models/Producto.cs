using System.ComponentModel.DataAnnotations;


namespace SistemaFacturacion.Models
{
    public class Producto
    {
        [Key]
        public int codigoProducto { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo descripcion es obligatorio")]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "El campo precio es obligatorio")]
        [Display(Name = "Precio")]
        public double precio { get; set; }

        [Required(ErrorMessage = "El campo costo es obligatorio")]
        [Display(Name = "Costo")]
        public double costo{ get; set; }

        [Required(ErrorMessage = "El campo existencia es obligatorio")]
        [Display(Name = "Existencia")]
        public int existencia { get; set; }

        [Required(ErrorMessage = "El campo activo es obligatorio")]
        [Display(Name = "Activo")]
        public string activo { get; set; }

    }
}
