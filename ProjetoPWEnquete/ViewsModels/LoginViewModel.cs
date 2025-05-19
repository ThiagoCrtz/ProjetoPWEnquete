using System.ComponentModel.DataAnnotations;

namespace ProjetoPWEnquete.ViewsModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        public string password{ get; set; }

        [Display(Name ="Lembrar da conta")]
        public bool RememberMe{ get; set; }
    }
}
