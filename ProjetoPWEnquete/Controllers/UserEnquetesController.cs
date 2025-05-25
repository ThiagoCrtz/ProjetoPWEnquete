using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRoles.Data;

namespace ProjetoPWEnquete.Controllers
{
    public class UserEnquetesController : Controller
    {
        private readonly AppDbContext _context;

        public UserEnquetesController(AppDbContext context)
        {
            _context = context;
        }
      

    }
}
