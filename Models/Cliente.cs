using System.ComponentModel.DataAnnotations;

namespace SistemaFacturacion.Models
{
    public class Cliente
    {
        [Key]
        public int codigoCliente { get; set; }

        [Required(ErrorMessage = "El campo nombres es obligatorio")]
        [Display(Name = "Nombres")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "El campo apellidos es obligatorio")]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }
        
        [Required(ErrorMessage = "El campo NIT es obligatorio")]
        [Display(Name = "Nit")]
        public string nit { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "El campo activo es obligatorio")]
        [Display(Name = "Activo")]
        public string activo { get; set; }
    }
}
