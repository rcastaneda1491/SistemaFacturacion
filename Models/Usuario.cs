using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Id")]
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "El campo usuario es obligatorio")]
        [Display(Name = "Usuario")]
        public string user { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "El campo email es obligatorio")]
        [Display(Name = "Correo")]
        public string email { get; set; }

        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [Display(Name = "Contraseña")]
        public string password { get; set; }
    }
}
