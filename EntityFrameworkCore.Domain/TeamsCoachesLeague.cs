namespace EntityFrameworkCore.Domain;

public class TeamsCoachesLeague : BaseDomainModel
{
    public int TeamId { get; set; }
    public int CoachId { get; set; }
    public int LeagueId { get; set; }

    public virtual Team Team { get; set; } = null!;
    public virtual Coach Coach { get; set; } = null!;
    public virtual League League { get; set; } = null!;
}