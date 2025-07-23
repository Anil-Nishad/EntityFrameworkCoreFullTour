namespace EntityFrameworkCore.Domain;

public class League : BaseDomainModel
{
    public string? Name { get; set; }

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();

    public virtual ICollection<TeamsCoachesLeague> TeamsCoachesLeagues { get; set; } = new List<TeamsCoachesLeague>();
}
