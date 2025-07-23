using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;

namespace EntityFrameworkCore.Data;

public class FootballLeageDbContext : DbContext
//From The Entity Framework Core documentation, DbContext is the primary class responsible for interacting with the database.
{
    public FootballLeageDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Combine(path, "FootballLeage_EfCore.db");
    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coaches { get; set; }
    public DbSet<League> Leagues { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Audit> Audits { get; set; }
    public DbSet<TeamsCoachesLeague> TeamsCoachesLeagues { get; set; }
    public DbSet<TeamsAndLeaguesView> TeamsAndLeaguesView { get; set; }
    public string DbPath { get; private set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Using SQL Server
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeage_EfCore; Encrypt=False");
         
        optionsBuilder.UseSqlite($"Data Source={DbPath}")
        //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking) // Use NoTracking for better performance in read-only scenarios
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging() // EnableSensitiveDataLogging is useful for debugging but should be disabled in production
        .EnableDetailedErrors(); // EnableDetailedErrors provides more detailed error messages, which can be helpful during development.
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply global filter to all entities that inherit from BaseEntity
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(BaseDomainModel).IsAssignableFrom(entityType.ClrType))
            {
                var parameter = Expression.Parameter(entityType.ClrType, "e");
                var isDeletedProp = Expression.Property(parameter, nameof(BaseDomainModel.IsDeleted));
                var filter = Expression.Lambda(
                    Expression.Equal(isDeletedProp, Expression.Constant(false)), parameter);

                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(filter);
            }
        }
        /*
         * If you're applying a filter to a specific entity, like Team:
        modelBuilder.Entity<Team>()
            .HasQueryFilter(team => !team.IsDeleted);
        */

        modelBuilder.Entity<TeamsAndLeaguesView>().HasNoKey().ToView("vw_TeamsAndLeagues");
        modelBuilder.HasDbFunction(typeof(FootballLeageDbContext)
            .GetMethod(nameof(GetLatestMatchRecords), new[] { typeof(int) }))
            .HasName("fn_GetLatestMatchRecords");

        // Relationships for TeamsCoachesLeague
        modelBuilder.Entity<TeamsCoachesLeague>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<TeamsCoachesLeague>()
            .HasOne(x => x.Team)
            .WithMany(t => t.TeamsCoachesLeagues)
            .HasForeignKey(x => x.TeamId);

        modelBuilder.Entity<TeamsCoachesLeague>()
            .HasOne(x => x.Coach)
            .WithMany(c => c.TeamsCoachesLeagues)
            .HasForeignKey(x => x.CoachId);

        modelBuilder.Entity<TeamsCoachesLeague>()
            .HasOne(x => x.League)
            .WithMany(l => l.TeamsCoachesLeagues)
            .HasForeignKey(x => x.LeagueId);

        // Relationships for Team-Coach
        modelBuilder.Entity<Coach>()
            .HasOne(c => c.Team)
            .WithMany(t => t.Coaches)
            .HasForeignKey(c => c.TeamId);

        // Relationships for Team-League
        modelBuilder.Entity<Team>()
            .HasOne(t => t.League)
            .WithMany(l => l.Teams)
            .HasForeignKey(t => t.LeagueId);

        // Relationships for Match-Team
        modelBuilder.Entity<Match>()
            .HasOne(m => m.HomeTeam)
            .WithMany(t => t.MatchHomeTeams)
            .HasForeignKey(m => m.HomeTeamId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Match>()
            .HasOne(m => m.AwayTeam)
            .WithMany(t => t.MatchAwayTeams)
            .HasForeignKey(m => m.AwayTeamId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed data
        var teamNames = new[]
        {
                "Manchester United", "Real Madrid", "Barcelona", "Chelsea", "Liverpool",
                "Bayern Munich", "Juventus", "Paris Saint-Germain", "Arsenal", "Manchester City",
                "AC Milan", "Inter Milan", "Borussia Dortmund", "Tottenham Hotspur", "Ajax",
                "Atletico Madrid", "Napoli", "Roma", "Porto", "Benfica",
                "Sevilla", "Leicester City", "Everton", "Lazio", "Valencia",
                "Monaco", "RB Leipzig", "Villarreal", "Wolverhampton", "Fiorentina",
                "Shakhtar Donetsk", "Zenit", "Galatasaray", "Celtic", "Rangers",
                "PSV Eindhoven", "Olympiacos", "Besiktas", "Sporting CP", "Dynamo Kyiv",
                "Club Brugge", "Anderlecht", "Marseille", "Lille", "Bayer Leverkusen",
                "Schalke 04", "Hertha Berlin", "Werder Bremen", "Southampton", "Crystal Palace",
                "Burnley", "Watford", "Brighton", "Newcastle United", "West Ham United",
                "Aston Villa", "Leeds United", "Bologna", "Sampdoria", "Torino",
                "Udinese", "Cagliari", "Genoa", "Espanyol", "Real Sociedad",
                "Real Betis", "Alaves", "Eibar", "Getafe", "Leganes",
                "Mallorca", "Granada", "Osasuna", "Valladolid", "Levante",
                "Elche", "Cadiz", "Huesca", "Spezia", "Verona",
                "Parma", "Benevento", "Crotone", "Salernitana", "Empoli",
                "Sassuolo", "Reims", "Nantes", "Strasbourg", "Angers",
                "Metz", "Brest", "Lorient", "Saint-Etienne", "Toulouse"
            };

        var coachNames = new[]
        {
                "Pep Guardiola", "Jurgen Klopp", "Carlo Ancelotti", "Diego Simeone", "Thomas Tuchel",
                "Antonio Conte", "Zinedine Zidane", "Mauricio Pochettino", "Luis Enrique", "Erik ten Hag",
                "Unai Emery", "Massimiliano Allegri", "Julian Nagelsmann", "Simone Inzaghi", "Luciano Spalletti",
                "Graham Potter", "Brendan Rodgers", "David Moyes", "Steven Gerrard", "Frank Lampard",
                "Xavi Hernandez", "Mikel Arteta", "Marco Rose", "Ralph Hasenhuttl", "Oliver Glasner",
                "Nuno Espirito Santo", "Paulo Fonseca", "Leonardo Jardim", "Jesse Marsch", "Rudi Garcia",
                "Peter Bosz", "Vincenzo Italiano", "Ivan Juric", "Roberto De Zerbi", "Andriy Shevchenko",
                "Patrick Vieira", "Gerardo Seoane", "Roger Schmidt", "Mark van Bommel", "Philippe Clement",
                "Sergio Conceicao", "Jorge Jesus", "Fatih Terim", "Steven Cooper", "Sean Dyche",
                "Roy Hodgson", "Eddie Howe", "Steve Bruce", "Scott Parker", "Daniel Farke"
            };

        var leagueNames = new[]
        {
                "Premier League", "La Liga", "Serie A", "Bundesliga", "Ligue 1",
                "Eredivisie", "Primeira Liga", "Russian Premier League", "Turkish Super Lig", "Scottish Premiership"
            };
        var baseDate = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

        // Teams
        var teams = new List<Team>();
        for (int i = 0; i < teamNames.Length; i++)
        {
            teams.Add(new Team
            {
                Id = i + 1,
                Name = teamNames[i],
                LeagueId = ((i % leagueNames.Length) + 1),
        CreatedDate = baseDate.AddDays(-i) // ✅ static value
            });
        }
        modelBuilder.Entity<Team>().HasData(teams);

        // Coaches
        var coaches = new List<Coach>();
        for (int i = 0; i < coachNames.Length; i++)
        {
            coaches.Add(new Coach
            {
                Id = i + 1,
                Name = coachNames[i],
                TeamId = ((i % teamNames.Length) + 1),
        CreatedDate = baseDate.AddDays(-i) // ✅ static value
            });
        }
        modelBuilder.Entity<Coach>().HasData(coaches);

        // Leagues
        var leagues = new List<League>();
        for (int i = 0; i < leagueNames.Length; i++)
        {
            leagues.Add(new League
            {
                Id = i + 1,
                Name = leagueNames[i],
        CreatedDate = baseDate.AddDays(-i) // ✅ static value
            });
        }
        modelBuilder.Entity<League>().HasData(leagues);

        // Matches
        var matches = new List<Match>();
        for (int i = 1; i <= 50; i++)
        {
            matches.Add(new Match
            {
                Id = i,
                HomeTeamId = (i % teamNames.Length) + 1,
                AwayTeamId = ((i + 1) % teamNames.Length) + 1,
        Date = baseDate.AddDays(-i), // ✅ static value
                TicketPrice = 20 + i,
        CreatedDate = baseDate.AddDays(-i) // ✅ static value
            });
        }
        modelBuilder.Entity<Match>().HasData(matches);

        // Audits
        var audits = new List<Audit>();
        for (int i = 1; i <= 100; i++)
        {
            audits.Add(new Audit
            {
                Id = i,
                Action = "Insert",
                TableName = "Team",
        DateTime = baseDate.AddDays(-i), // ✅ static value
                KeyValues = $"{{Id:{i}}}",
                OldValues = null,
                NewValues = null
            });
        }
        modelBuilder.Entity<Audit>().HasData(audits);

        // Teams-Coaches-League
        var tcl = new List<TeamsCoachesLeague>();
        for (int i = 1; i <= 100; i++)
        {
            tcl.Add(new TeamsCoachesLeague
            {
                Id = i,
                TeamId = (i % teamNames.Length) + 1,
                CoachId = (i % coachNames.Length) + 1,
                LeagueId = (i % leagueNames.Length) + 1
            });
        }
        modelBuilder.Entity<TeamsCoachesLeague>().HasData(tcl);
    }

    // This method is used to configure the models globally
    // Pre-convention model configuration
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>()
            .HavePrecision(16, 2);
    }

    // Manipulate Entries Before Saving Changes
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // Custom logic before saving changes can be added here
        var entries = ChangeTracker.Entries<BaseDomainModel>().Where(e => e.State == EntityState.Modified
        || e.State == EntityState.Added);
        foreach (var entry in entries)
        {
            entry.Entity.Version = Guid.NewGuid(); // Update the version for concurrency checks
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTime.UtcNow;
                entry.Entity.CreatedBy = "System"; // You can replace this with the actual user context if available
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.ModifiedDate = DateTime.UtcNow;
                entry.Entity.ModifiedBy = "System"; // You can replace this with the actual user context if available
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
    public DateTime GetLatestMatchRecords(int teamId) => throw new NotImplementedException();
}
