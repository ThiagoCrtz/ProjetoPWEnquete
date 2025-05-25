using ProjetoPWEnquete.Models;

public class Voto
{
    public int Id { get; set; }

    public int EnqueteId { get; set; }
    public Enquete Enquete { get; set; }

    public string UserId { get; set; } // Identifica o usuário (pode ser string se usar Identity)

    public int OpcaoEscolhida { get; set; } // Pode ser número de 1 a 10 (ou nome da opção)
}
