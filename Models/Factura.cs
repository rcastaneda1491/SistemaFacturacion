using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFacturacion.Models
{
    public class Factura
    {
        [Key]
        [Display(Name = "No. Factura")]
        public int numeroFactura { get; set; }

        
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "El campo total factura es obligatorio")]
        [Display(Name = "Total")]
        public double totalFactura { get; set; }

        [Required(ErrorMessage = "El campo anulada es obligatorio")]
        [Display(Name = "Anulada")]
        public string anulada { get; set; }

        [Required(ErrorMessage = "El campo codigo cliente es obligatorio")]
        [Display(Name = "Codigo Cliente")]
        public int? codigoCliente { get; set; }
        [ForeignKey("codigoCliente")]

        public virtual Cliente Cliente { get; set; }
    }
}
