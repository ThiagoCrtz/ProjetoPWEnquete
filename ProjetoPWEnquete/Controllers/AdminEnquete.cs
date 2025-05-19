using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjetoPWEnquete.Models;
using ProjetoPWEnquete.ViewsModels;
using System.Collections.Generic;
using UserRoles.Data;
namespace ProjetoPWEnquete.Controllers
{
    public class AdminEnquete : Controller
    {
        private readonly AppDbContext _context;

        public AdminEnquete(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CriarEnquete( )
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarEnquete(AddEnqueteModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

  

            var enquete = new Enquete
            {
                Question = model.Title,
                descrição = model.Description,
                ExpiresAt = model.ExpirationDate,
                Option1 = model.Option1,
                Option2 = model.Option2,
                Option3 = model.Option3,
                Option4 = model.Option4,
                Option5 = model.Option5,
                Option6 = model.Option6,
                Option7 = model.Option7,
                Option8 = model.Option8,
                Option9 = model.Option9,
                Option10 = model.Option10
            };


            _context.Enquetes.Add(enquete);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

    }
}
