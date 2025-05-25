using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoPWEnquete.ViewsModels;
using UserRoles.Data;

namespace ProjetoPWEnquete.Controllers
{
    public class EnqueteController : Controller
    {
        private readonly AppDbContext _context;

        public EnqueteController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult ListarEnquetes()
        {
            var enquetes = _context.Enquetes.ToList();
            return View(enquetes);
        }
        [Authorize(Roles = "User, Admin")]

        public async Task<IActionResult> DetalhesEnqueteAsync(int id)
        {
            var enquete = await _context.Enquetes.FindAsync(id);
            var votos = _context.Votos
                .Where(v => v.EnqueteId == id)
                .GroupBy(v => v.OpcaoEscolhida)
                .Select(g => new { Opcao = g.Key, Count = g.Count() })
                .ToList();

            return View(enquete); ;
        }
        [HttpPost]
        public async Task<IActionResult> Votar([FromBody] Voto voto)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var jaVotou = await _context.Votos
                .AnyAsync(v => v.EnqueteId == voto.EnqueteId && v.UserId == userId);

            if (jaVotou)
            {
                return Content("Você já votou nesta enquete.");
            }

            var novoVoto = new Voto
            {
                EnqueteId = voto.EnqueteId,
                UserId = userId,
                OpcaoEscolhida = voto.OpcaoEscolhida
            };

            _context.Votos.Add(novoVoto);
            await _context.SaveChangesAsync();

            return Content("Voto registrado com sucesso!");
        }

  
        public async Task<IActionResult> Grafico(int enqueteId)
        {
            var enquete = await _context.Enquetes.FindAsync(enqueteId);
            if (enquete == null) return NotFound();

            // Conta os votos por opção (1 a 10)
            var votos = await _context.Votos
                .Where(v => v.EnqueteId == enqueteId)
                .GroupBy(v => v.OpcaoEscolhida)
                .Select(g => new { Opcao = g.Key, Quantidade = g.Count() })
                .ToListAsync();

            // Prepara labels e valores
            var labels = new List<string>();
            var valores = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                var opcaoTexto = (string?)enquete.GetType().GetProperty($"Option{i}")?.GetValue(enquete);
                if (!string.IsNullOrEmpty(opcaoTexto))
                {
                    labels.Add(opcaoTexto);
                    var voto = votos.FirstOrDefault(v => v.Opcao == i);
                    valores.Add(voto?.Quantidade ?? 0);
                }
            }

            var vm = new ResultadoGraficoViewModel
            {
                Labels = labels.ToArray(),
                Votos = valores.ToArray(),
                TituloEnquete = enquete.Question
            };

            return View(vm);
        }


    }
}
