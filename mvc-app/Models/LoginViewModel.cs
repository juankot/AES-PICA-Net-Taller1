using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string User { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Password { get; set; }
    }
}