using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models
{
    public class ReporteProducto
    {
        [Display(Name = "Dia")]
        public string dia { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        [Display(Name = "Codigo Producto")]
        public int codigoProducto { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Total Vendido")]
        public double totalVendido { get; set; }
    }
}
