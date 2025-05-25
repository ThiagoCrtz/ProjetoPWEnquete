namespace ProjetoPWEnquete.Models
{
        public class Enquete
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? descrição { get; set; }
        public DateTime ExpiresAt { get; set; }

        public string? Option1 { get; set; }
        public int? Option1Votes { get; set; }

        public string? Option2 { get; set; }
        public int? Option2Votes { get; set; }

        public string? Option3 { get; set; }
        public int? Option3Votes { get; set; }

        public string? Option4 { get; set; }
        public int? Option4Votes { get; set; }

        public string? Option5 { get; set; }
        public int? Option5Votes { get; set; }

        public string? Option6 { get; set; }
        public int? Option6Votes { get; set; }

        public string? Option7 { get; set; }
        public int? Option7Votes { get; set; }

        public string? Option8 { get; set; }
        public int? Option8Votes { get; set; }

        public string? Option9 { get; set; }
        public int? Option9Votes { get; set; }

        public string? Option10 { get; set; }
        public int? Option10Votes { get; set; }
    }
}
