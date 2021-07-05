using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models
{
    public class ReporteCliente
    {
        [Display(Name = "Dia")]
        public string dia { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        [Display(Name = "Nombres")]
        public string nombres { get; set; }
        
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Total")]
        public double total { get; set; }
    }
}
