using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFacturacion.Models
{
    public class FacturaProducto
    {

        [Required(ErrorMessage = "El campo cantidad es obligatorio")]
        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }

        [Required(ErrorMessage = "El campo precio unitario es obligatorio")]
        [Display(Name = "Precio Unitario")]
        public double precioUnitario { get; set; }
        

        [Required(ErrorMessage = "El campo numero factura es obligatorio")]
        [Display(Name = "No. Factura")]
        [Key, Column(Order = 0)]
        [ForeignKey("numeroFactura")]
        public int? numeroFactura { get; set; }
        
        public virtual Factura Factura { get; set; }


        [Required(ErrorMessage = "El campo codigo producto es obligatorio")]    
        [Display(Name = "Codigo Producto")]
        [Key, Column(Order = 1)]
        [ForeignKey("codigoProducto")]
        public int? codigoProducto { get; set; }
        
        public virtual Producto Productos { get; set; }
    }
}
