using System.ComponentModel.DataAnnotations;

namespace ProjetoPWEnquete.ViewsModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
        public string Email { get; set; }
        public string Cpf { get; set; }


        [Required(ErrorMessage = "Senha é obrigatório")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassowrd", ErrorMessage = "Senha não são iguais")]
        public string Password { get; set; }



        [Required(ErrorMessage = "Confirmar Senha é obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]    
        public string ConfirmPassowrd { get; set; }
    }
}
