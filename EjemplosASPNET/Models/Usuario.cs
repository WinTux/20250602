using System.ComponentModel.DataAnnotations;

namespace EjemplosASPNET.Models
{
    public class Usuario
    {
        [Required]
        [MinLength(3,ErrorMessage = "El nombre de usuario debe ser de al menos 3 letras.")]
        [MaxLength(10, ErrorMessage = "El nombre de usuario debe ser de a lo mucho de 10 letras.")]
        public string nombre { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage = "La contraseña debe contar con al menos una mayúscula, una minúscula, ...")]
        public string password { get; set; }   
        [Required]
        [Range(18,35, ErrorMessage = "El usuario debe ser mayor de edad y hasta los 35 años máximo")]
        public int edad {  get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Url]
        public string pagina { get; set; }
    }
}
