using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models
{
    public class ReporteFactura
    {
        [Display(Name = "Dia")]
        public string dia { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        [Display(Name = "Facturas Emitidas")]
        public int facturasEmitidas { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Total")]
        public double Total { get; set; }

        [Display(Name = "Cantidad Productos")]
        public int cantidadProductos { get; set; }
    }
}
