using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginFacebookGoogle.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Display(Name = "Codigo")]
        
        //[Range(0, 8, ErrorMessage = "Maximo 8 numeros")]
        
        
        public string id { get; set; }
        
        [EmailAddress]
        [Required(ErrorMessage = "Ingresar Correo Electronico")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }


        [Required(ErrorMessage =" Ingresar numero telefonico")]        
        [Display(Name = "Numero")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[9]{1}[0-9]{8}", ErrorMessage = "Primer digito 9 y Maximo 9 numeros")]      
        
        public string PhoneNumber { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Ingresar Nombre")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-z-A-ZáéíóúÁÉÍÓÚ/s Ü]+", ErrorMessage ="Solamente Letras")]
        public string Nombre { get; set; }


        [Display(Name = "Numero DNI")]
        [RegularExpression("^[0-9]{8}", ErrorMessage = "Maximo solo 8 numeros")]
        [Required(ErrorMessage = "Ingresar Numero DNI")]
        public int ID_Registro{ get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Ingresar direccion")]
        public string Direccion { get; set; }
        
        
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "¿Recordar este explorador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }
}
