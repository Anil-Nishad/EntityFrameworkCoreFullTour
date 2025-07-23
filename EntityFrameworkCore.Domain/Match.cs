namespace EntityFrameworkCore.Domain;

public class Match : BaseDomainModel
{
    public int HomeTeamId { get; set; }

    public int AwayTeamId { get; set; }

    public DateTime Date { get; set; }

    public decimal TicketPrice { get; set; }

    public virtual Team HomeTeam { get; set; } = null!;

    public virtual Team AwayTeam { get; set; } = null!;
}

