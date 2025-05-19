using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjetoPWEnquete.ViewsModels
{
    public class AddEnqueteModel : IValidatableObject
    {
        [Required(ErrorMessage = "O título da enquete é obrigatório.")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A descrição da enquete é obrigatória.")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A data de expiração é obrigatória.")]
        [Display(Name = "Data de expiração")]
        public DateTime ExpirationDate { get; set; }

        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? Option4 { get; set; }
        public string? Option5 { get; set; }
        public string? Option6 { get; set; }
        public string? Option7 { get; set; }
        public string? Option8 { get; set; }
        public string? Option9 { get; set; }
        public string? Option10 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var options = new List<string?> {
                Option1, Option2, Option3, Option4, Option5,
                Option6, Option7, Option8, Option9, Option10
            };

            // Conta as opções não nulas e não vazias
            int countFilled = options.Count(o => !string.IsNullOrWhiteSpace(o));

            if (countFilled < 2)
            {
                yield return new ValidationResult(
                    "Você deve preencher pelo menos duas opções.",
                    new[] { "Option1", "Option2" });
            }
        }
    }
}
