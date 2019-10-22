using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models
{
    public class ContactoViewModel
    {
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Este campo debe tener entre 3 y 50 caracteres.")]
        public string Nombres { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Este campo debe tener entre 3 y 50 caracteres.")]
        public string Apellidos { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(100)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido.")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Este campo debe tener entre 3 y 15 caracteres.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Comentario { get; set; }
    }
}