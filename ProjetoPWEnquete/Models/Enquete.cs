using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoPWEnquete.Models
{
    public class Enquete
    {
        public int Id { get; set; }

        [Required]
        public string Question { get; set; }

        public string descrição { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime ExpiresAt { get; set; }

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
    }
}
