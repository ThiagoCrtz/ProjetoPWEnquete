using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ProjetoPWEnquete.Models
{
    public class User : IdentityUser
    {
        public string FullName ;

        public string Cpf { get; set; }
    }
}
