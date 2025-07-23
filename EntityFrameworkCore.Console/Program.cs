// See https://aka.ms/new-console-template for more information
using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

//(localdb)\ProjectModels
Console.WriteLine("Hello, World!");
/*
 Console.WriteLine("Get-Migration -Context FootballLeageDbContext");
Console.WriteLine("Add-Migration UpdatedBaseModelClass -Context FootballLeageDbContext");
Console.WriteLine("Remove-Migration -Context FootballLeageDbContext");
Console.WriteLine("Update-Database -Context FootballLeageDbContext");
Console.WriteLine("Update-Database -Context FootballLeageDbContext -Migration 2323213_MoreTablesAdded");
Console.WriteLine("Script-Migration -Context FootballLeageDbContext");
Console.WriteLine("Script-Migration -Context FootballLeageDbContext -Indempotent");
Console.WriteLine("Script-Migration Initial AddedMoreEntities -Context FootballLeageDbContext -Indempotent");
*/

#region
void PrintRedSkull()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Set background to red and foreground to white
        //Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        //Console.Clear(); // Apply background color to entire window

        // Write DANGER text
        Console.WriteLine(@"
            ██████╗  █████╗ ███╗   ██╗ ██████╗  ██████╗ ███████╗██████╗ 
            ██╔══██╗██╔══██╗████╗  ██║██╔════╝ ██╔═══██╗██╔════╝██╔══██╗
            ██████╔╝███████║██╔██╗ ██║██║  ███╗██║   ██║█████╗  ██████╔╝
            ██╔═══╝ ██╔══██║██║╚██╗██║██║   ██║██║   ██║██╔══╝  ██╔══██╗
            ██║     ██║  ██║██║ ╚████║╚██████╔╝╚██████╔╝███████╗██║  ██║
            ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝  ╚═════╝ ╚══════╝╚═╝  ╚═╝
            ");
        // Write Skull and Bones ASCII art
        Console.WriteLine(@"
               ______
            .-'      '-.
           /            \
          |              |
          |,  .-.  .-.  ,|
          | )(_o/  \o_)( |
          |/     /\     \|
          (_     ^^     _)
           \__|IIIIII|__/
            | \IIIIII/ |
            \          /
             `--------`
            .----.  .----.
           (      \/      )
            \.         ./ 
              `-.____.-'
        ");
    Console.WriteLine(@"
             _____                        _             
            |  __ \                      | |            
            | |  | | __ _ _ __ ___   __ _| | _____ _ __ 
            | |  | |/ _` | '_ ` _ \ / _` | |/ / _ \ '__|
            | |__| | (_| | | | | | | (_| |   <  __/ |   
            |_____/ \__,_|_| |_| |_|\__,_|_|\_\___|_|   
            ");
    Console.ResetColor();
}
//PrintRedSkull();
#endregion

using var db = new FootballLeageDbContext();

#region DB Details
Console.WriteLine("...*********************...");
Console.WriteLine("Welcome to the Football League Database!");
Console.WriteLine($"Database Path: {db.DbPath}");
Console.WriteLine(db.DbPath);
Console.WriteLine("...*********************...");
#endregion

Console.WriteLine("Hello, Anil!");

#region Raw SQl
//Querying a Keyless Entity
//await GetRecordsFromView();
async Task GetRecordsFromView()
{
    var details = await db.TeamsAndLeaguesView.ToListAsync();
    foreach (var team in details)
    {
        Console.WriteLine($"Team Name : {team.Name} --  League Name : {team.leagueName}");
    }
}

//FromSQlRaw();
void FromSQlRaw()
{
    Console.WriteLine("Enter Team Name: ");
    var teamName = Console.ReadLine();
    var teamNameParam = new SqliteParameter("teamName", teamName);
    var team = db.Teams.FromSqlRaw($"SELECT * from TEAMS WHERE NAME = @teamName", teamNameParam);
    foreach (var t in team)
    {
        Console.WriteLine($"Team Name: {t.Name} and Team ID : {t.Id}");
    }
}

//FromSQl();
void FromSQl()
{
    Console.WriteLine("Enter Team Name: ");
    var teamName = Console.ReadLine();
    var team = db.Teams.FromSql($"SELECT * from TEAMS WHERE NAME = {teamName}");
    foreach (var t in team)
    {
        Console.WriteLine($"Team Name: {t.Name} and Team ID : {t.Id}");
    }
}

//FromSqlInterpolated();
void FromSqlInterpolated()
{
    Console.WriteLine("Enter Team Name: ");
    var teamName = Console.ReadLine();
    var team = db.Teams.FromSqlInterpolated($"SELECT * from TEAMS WHERE NAME = {teamName}");
    foreach (var t in team)
    {
        Console.WriteLine($"Team Name: {t.Name} and Team ID : {t.Id}");
    }
}

//await MixWithLinq();
async Task MixWithLinq()
{
    var team = await db.Teams.FromSql($"SELECT * from TEAMS")
        .Where(q => q.Id == 10)
        .OrderBy(q => q.CreatedDate)
        .Include("League")
        .ToListAsync();
    foreach (var t in team)
    {
        Console.WriteLine($"Team Name: {t.Name} and Team ID : {t.Id}");
    }
}

// Executing Stored Procedures
//ExecuteSP();
void ExecuteSP()
{
    var leagueId = 1;
    var league = db.Leagues
        .FromSqlInterpolated($"Exec dbo.StoredProcedureToGetLeagueNameHere {leagueId}");
    var deleteLeague = db.Database
        .ExecuteSqlInterpolatedAsync($"Exec dbo.DeleteLeague {leagueId}");
}

// Non-querying statement
//await NonQueryingSatement();
async Task NonQueryingSatement()
{
    var someNewTeamName = "new team name here";
    await db.Database.ExecuteSqlInterpolatedAsync($"Update Teams set name = {someNewTeamName} where Id = 100");
}

// Query Scaler or Non-Entity Type
//QueryScalerType();
void QueryScalerType()
{
    var LeagueIds = db.Database.SqlQuery<int>($"Select ID From leagues").ToList();
}

// Execute User-Defined Query
//ExeFunction();
void ExeFunction()
{
    var earliestRecords = db.GetLatestMatchRecords(1);
}

#endregion

var coachesPerTeam = await db.Teams
    .Include(t => t.Coaches)
    .Select(t => new
    {
        Team = t.Name,
        CoachCount = t.Coaches.Count
    })
    .ToListAsync();
foreach(var c in coachesPerTeam)
{
    Console.WriteLine($"ID: {c.Team} , Name: {c.CoachCount}");
}

#region Golobal Query Filters


//await GloablQueryFilters();

async Task GloablQueryFilters()
{
    // This will automatically exclude IsDeleted = true rows

    var activeCoach = db.Coaches.ToList();
    foreach (var c in activeCoach)
    {
        Console.WriteLine($"ID: {c.Id} , Name: {c.Name}");
    }

    // If you want to bypass the filter:
    var allCoach = db.Coaches.IgnoreQueryFilters().ToList();
    foreach (var c in allCoach)
    {
        Console.WriteLine($"ID: {c.Id} , Name: {c.Name}");
    }
    //var coach = await db.Coaches.FindAsync(53);
    //coach.IsDeleted = true;
    //await db.SaveChangesAsync();
    //var coaches = await db.Coaches.Where(q => !q.IsDeleted).ToListAsync();
    //foreach (var c in coaches)
    //{
    //    Console.WriteLine($"ID: {c.Id} , Name: {c.Name}");
    //}
}


#endregion

#region Read Queries
// Select All Teams
//Console.WriteLine("Select All Teams");

//GetAllTeams();

//await GetAllTeamsAsync();

////selecting a single team
//await GetOneTeam();

//select all record that meets the condition
//await GetFilteredTeams();

//await GetAllTeamsQuerySyntax();

//Aggregate Functions
//await AggregateFunctions();

//Grouping and Aggregating
//GroupedAndAggregate();

//Ordering
//Order();

//Skip and Take -- Great topic to learn about pagination
//await SkipAndTake();

//Select and Projections - more precise queries
//await SelectAndProjections();

/*
No Traking - EF Core tracks objects that are returned by quereis.This is useful when you want to update or delete the objects later.
This is less useful when you are only reading data and not modifying it.
And in disconnected scenarios, like web applications, you might not need tracking.
*/
//await NoTrackingExample();

// Iqueryables vs ListTypes
//await IQueryableVsListTypes();
#endregion

#region Insert Queries
//InsertSimpleCoach();
//InsertLoopCoaches();
//InsertBatchCoaches();
#endregion

#region Update Queries
//UpdateCoach();
//UpdateCoachWithNoTraking();
//ExecuteUpadate();
#endregion

#region Delete Query Method
//DeleteCoach();
//ExecuteDelete();
#endregion

#region Delete Method
async void DeleteCoach()
{
Console.WriteLine("Delete Coach Example");
Console.WriteLine("Enter the Id of the coach to delete:");
var coachId = Convert.ToInt32(Console.ReadLine());
var coach = await db.Coaches.FindAsync(coachId);
if (coach == null)
{
    Console.WriteLine($"No coach found with Id: {coachId}");
    return;
}
    
db.Coaches.Remove(coach);
// When tracing is disbaled, you need to explicitly set the state of the entity to Deleted
//db.Entry(coach).State = EntityState.Deleted; // Explicitly set the state to Deleted
await db.SaveChangesAsync();
    
Console.WriteLine($"Coach with Id: {coachId} has been deleted.");
}
async void ExecuteDelete()
{
Console.WriteLine("Execute Delete Example");
Console.WriteLine("Enter the Id of the coach to delete:");
var coachName = Console.ReadLine();
var coach = await db.Coaches.Where(c => c.Name == coachName).ExecuteDeleteAsync();
}
#endregion

#region Update Query Methods
async void UpdateCoach()
{
    Console.WriteLine("Update Coach Example");
    Console.WriteLine("Enter the Id of the coach to update:");
    var coachId = Convert.ToInt32(Console.ReadLine());
    var coach = await db.Coaches.FindAsync(coachId);
    if (coach == null)
    {
        Console.WriteLine($"No coach found with Id: {coachId}");
        return;
    }
    
    Console.WriteLine($"Current Name: {coach.Name}");
    Console.WriteLine("Enter the new name for the coach:");
    var newName = Console.ReadLine() ?? string.Empty;
    
    coach.Name = newName;
    coach.ModifiedBy = "Admin";
    coach.ModifiedDate = DateTime.Now;
    await db.SaveChangesAsync();
    
    Console.WriteLine($"Coach updated. New Name: {coach.Name} and Updated by: {coach.ModifiedBy}");

}
async void UpdateCoachWithNoTraking()
{     
    Console.WriteLine("Update Coach with No Tracking Example");
    Console.WriteLine("Enter the Id of the coach to update:");
    var coachId = Convert.ToInt32(Console.ReadLine());
    var coach = await db.Coaches.AsNoTracking().FirstOrDefaultAsync(c => c.Id == coachId);
    if (coach == null)
    {
        Console.WriteLine($"No coach found with Id: {coachId}");
        return;
    }
    
    Console.WriteLine($"Current Name: {coach.Name}");
    Console.WriteLine("Enter the new name for the coach:");
    var newName = Console.ReadLine() ?? string.Empty;
    
    // Create a new instance to update
    coach.Name = newName;
    coach.ModifiedBy = "Admin";
    coach.ModifiedDate = DateTime.Now;
    
    db.Coaches.Update(coach); // Explicitly update the entity
   // db.Entry(coach).State = EntityState.Modified; // Set the state to Modified
    await db.SaveChangesAsync();
    
    Console.WriteLine($"Coach updated. New Name: {coach.Name} and Updated by: {coach.ModifiedBy}");
}
async void ExecuteUpadate()
{
    Console.WriteLine("Execute Update Example");
    Console.WriteLine("Enter the Name of the coach to update:");
   // var coachId = Convert.ToInt32(Console.ReadLine());
    var coachName = Console.ReadLine();
    Console.WriteLine("Enter the Updated Name of the coach:");
    var updatedName = Console.ReadLine();
    var coach = await db.Coaches.Where(c => c.Name == coachName)
        .ExecuteUpdateAsync(set => set.SetProperty(prop => prop.Name, updatedName)
                                      .SetProperty(prop => prop.ModifiedDate, DateTime.Now)
                                      .SetProperty(prop => prop.ModifiedBy, "Admin")

        );
}
#endregion

#region Insert Query Methods
// Inseting Data
#region Simple Insert Example
async void InsertSimpleCoach()
{
    //var newCoach = new Coach
    //{
    //    Name = "John Doe",
    //    CreatedDate = DateTime.Now
    //};
    //await db.Coaches.AddAsync(newCoach);
    //await db.SaveChangesAsync();

    Console.WriteLine("Insert Simple Coach Example");
    Console.WriteLine("Enter the name of the coach to insert:");
    var coachName = Console.ReadLine() ?? string.Empty;
    var newCoach = new Coach
    {
        Name = coachName,
        CreatedDate = DateTime.Now
    };
    await db.Coaches.AddAsync(newCoach);
    await db.SaveChangesAsync();
    Console.WriteLine($"Coach '{newCoach.Name}' inserted with Id: {newCoach.Id}");
}

#endregion

#region Loop Insert Example
async void InsertLoopCoaches()
{
    /*
    var newCoach1 = new Coach
    {
        Name = "Theodore Whitmore",
        CreatedDate = DateTime.Now
    };
    var newCoach2 = new Coach
    {
        Name = "Teddy Sheringham",
        CreatedDate = DateTime.Now
    };
    List<Coach> coaches = new List<Coach> { newCoach1, newCoach2 };
    foreach (var coach in coaches)
    {
        await db.Coaches.AddAsync(coach);
    }
    Console.WriteLine(db.ChangeTracker.DebugView.LongView);
    await db.SaveChangesAsync();
    Console.WriteLine(db.ChangeTracker.DebugView.LongView);
    foreach (var coach in coaches)
    {
        Console.WriteLine($"Coach '{coach.Name}' inserted with Id: {coach.Id}");
    }
    */
    Console.WriteLine("Insert Loop Coaches Example");
    Console.WriteLine("Enter the number of coaches to insert:");
    var numberOfCoaches = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < numberOfCoaches; i++)
    {
        Console.WriteLine($"Enter name for Coach {i + 1}:");
        var coachName = Console.ReadLine() ?? string.Empty;
        var newCoach = new Coach
        {
            Name = coachName,
            CreatedDate = DateTime.Now
        };
        await db.Coaches.AddAsync(newCoach);
        Console.WriteLine($"Coach '{newCoach.Name}' inserted with Id: {newCoach.Id}");
    }
    await db.SaveChangesAsync();
    
}
#endregion

#region Batch Insert Example
async void InsertBatchCoaches()
{
    //await db.Coaches.AddRangeAsync(
    //new Coach { Name = "Theodore Whitmore", CreatedDate = DateTime.Now, ModifiedBy = "Anil K" },
    //new Coach { Name = "Teddy Sheringham", CreatedDate = DateTime.Now },
    //new Coach { Name = "John Doe", CreatedDate = DateTime.Now }
    //);
    //await db.SaveChangesAsync();

    Console.WriteLine("Insert Batch Coaches Example");
    Console.WriteLine("Enter the number of coaches to insert:");
    var numberOfCoaches = Convert.ToInt32(Console.ReadLine());
    List<Coach> coaches = new List<Coach>();
    for (int i = 0; i < numberOfCoaches; i++)
    {
        Console.WriteLine($"Enter name for Coach {i + 1}:");
        var coachName = Console.ReadLine() ?? string.Empty;
        var newCoach = new Coach
        {
            Name = coachName,
            CreatedDate = DateTime.Now
        };
        coaches.Add(newCoach);
    }
    await db.Coaches.AddRangeAsync(coaches);
    await db.SaveChangesAsync();
    foreach (var coach in coaches)
    {
        Console.WriteLine($"Coach '{coach.Name}' inserted with Id: {coach.Id}");
    }
}
#endregion

//async Task InsertTeam()
//{
//    Console.WriteLine("Insert Team Example");
//    Console.WriteLine("Enter the name of the team to insert:");
//    var teamName = Console.ReadLine() ?? string.Empty;
//    var newTeam = new Team
//    {
//        Name = teamName,
//        CreatedDate = DateTime.Now
//    };
//    db.Teams.Add(newTeam);
//    await db.SaveChangesAsync();
//    Console.WriteLine($"Team '{newTeam.Name}' inserted with Id: {newTeam.Id}");
//}

#endregion

#region Read Query Methods
async Task IQueryableVsListTypes()
{
    Console.WriteLine("IQueryable vs List<T> Example");
    Console.WriteLine("Enter '1' for Team with Id 1 or '2' for teams thatcontain 'F.C.' in their name:");
    var option = Convert.ToInt32(Console.ReadLine());
    List<Team> teamsAsList = new List<Team>();

    // After executing to ToListAsync, the records are loaded into memory. Any operation is then done in memory
    teamsAsList = await db.Teams.ToListAsync();
    if(option == 1)
    {
        teamsAsList = teamsAsList.Where(t => t.Id == 1).ToList();
    }
    else if (option == 2)
    {
        teamsAsList = teamsAsList.Where(t => t.Name.Contains("F.C.")).ToList();        
    }
    foreach (var team in teamsAsList)
    {
        Console.WriteLine(team.Name);
    }

    // Records stay as IQueryable until the ToListAsync is executed, then the final query is performed.
    var teamsAsQueryable = db.Teams.AsQueryable();
    //IQueryable<Team> teamsQuery;
    if (option == 1)
    {
        teamsAsQueryable = db.Teams.Where(t => t.Id == 1);
    }
    else if (option == 2)
    {
        teamsAsQueryable = db.Teams.Where(t => t.Name.Contains("F.C."));
    }
    // Actual Query Execution
    teamsAsList = await teamsAsQueryable.ToListAsync();
    foreach (var team in teamsAsList)
    {
        Console.WriteLine(team.Name);
    }

    //// IQueryable: Query is built and executed in the database
    //IQueryable<Team> query = db.Teams.Where(t => t.Name.Contains("F"));

    //// List<T>: Data is loaded into memory, then filtered
    //List<Team> teams =await db.Teams.ToListAsync();
    //var filteredTeams = teams.Where(t => t.Name.Contains("F"));

}
async Task NoTrackingExample()
{
    var teams = await db.Teams
        .AsNoTracking() // This tells EF Core not to track the entities
        //.AsTracking() // This tells EF Core to track the entities
        .Where(t => t.Id > 0)
        .OrderBy(t => t.Id)
        .ToListAsync();
}
async Task SelectAndProjections()
{
    var teamsusingSelectSingleColumn = await db.Teams
    .Where(t => t.Id > 0)
    .Select(t => t.Name /* or t.Id */)
    .ToListAsync();

    foreach (var teamName in teamsusingSelectSingleColumn)
    {
        Console.WriteLine($"Team Name: {teamName}");
    }

    //using new we create an anonymous type
    //This is useful when we want to select multiple columns or create a custom object
    var teamsUsingMulitpleColoumnSelect = await db.Teams
        .Where(t => t.Id > 0)
        .Select(t => new { t.Id, t.Name, t.CreatedDate })
        .ToListAsync();

    foreach (var team in teamsUsingMulitpleColoumnSelect)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}, CreatedDate: {team.CreatedDate}");
    }


    // Select with Custom Anonymous Type
    var teamsUsingCustomAnonymousType = await db.Teams
        .Where(t => t.Id > 0)
        .Select(t => new TeamInfo { Id = t.Id, Name = t.Name, CreatedDate = t.CreatedDate })
        .ToListAsync();
    foreach (var team in teamsUsingCustomAnonymousType)
    {
        Console.WriteLine(team);
        //Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}, CreatedDate: {team.CreatedDate}");
    }
}
async Task SkipAndTake()
{
    Console.WriteLine("Skip and Take Example");
    var recordCount = 6;
    var page = 0;
    var next = true;
    while (next)
    {
        var SkipAndTakeTeams = await db.Teams
            .Where(t => t.Id > 0)
            .OrderBy(t => t.Id)
            .Skip(page * recordCount)
            .Take(recordCount)
            .ToListAsync();
        if (SkipAndTakeTeams.Count == 0)
        {
            next = false;
        }
        else
        {
            foreach (var team in SkipAndTakeTeams)
            {
                Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}, CreatedDate: {team.CreatedDate}");
            }
            page++;
        }
        //next = Convert.ToBoolean(Console.ReadLine());
        // Replace this line:
        //next = Convert.ToBoolean(Console.ReadLine() ?? "false");
        Console.WriteLine("Do you want to see the next page? (true/false)");
        // With this:
        var input = Console.ReadLine();
        next = string.Equals(input, "true", StringComparison.OrdinalIgnoreCase);
        if (!next)
        {
            Console.WriteLine("Exiting pagination...");
            break;
        }
    }

    Console.WriteLine("...*********************...");
}
async Task Order()
{
    var orderedTeams = await db.Teams
    .Where(t => t.Id > 0)
    .OrderByDescending(t => t.Id)
    .ThenBy(t => t.Name)
    .ToListAsync();

    foreach (var team in orderedTeams)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}, CreatedDate: {team.CreatedDate}");
    }

    var maxByDescendingOrderedTeams = await db.Teams
        .OrderByDescending(t => t.Id)
        .FirstOrDefaultAsync();

    //or

    //var maxBy = db.Teams.MaxBy(t => t.Id);

    var maxByCreatedDate = await db.Teams
        .Where(t => t.Id > 0)
        .OrderByDescending(t => t.CreatedDate)
        .Select(t => new { t.Id, t.Name, t.CreatedDate })
        .FirstOrDefaultAsync();
}
void GroupedAndAggregate()
{
    var groupedTeamsOnCretaedDate =  db.Teams
    //.Where(t => t.Id > 0) //Transalates to a Where clause in SQL
    .GroupBy(t => t.CreatedDate);
    //.Where() //Transalates to a Having clause in SQL

    foreach (var group in groupedTeamsOnCretaedDate)
    {
        Console.WriteLine($"Group Created Date: {group.Key}");
        Console.WriteLine(group.Count() + " teams in this group:");
        Console.WriteLine(group.Max(t => t.Id) + " is the maximum Id in this group.");
        Console.WriteLine(group.Min(t => t.Id) + " is the minimum Id in this group.");
        Console.WriteLine(group.Average(t => t.Id) + " is the average TeamId in this group.");
        Console.WriteLine(group.Sum(t => t.Id) + " is the sum of TeamId in this group.");
        Console.WriteLine("Teams in this group:");
        foreach (var team in group)
        {
            Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}, CreatedDate: {team.CreatedDate}");
        }
    }

    var groupedTeams = db.Teams.GroupBy(t => t.Name)
        .Select(g => new
        {
            TeamName = g.Key,
            Count = g.Count(),
            MaxTeamId = g.Max(t => t.Id),
            MinTeamId = g.Min(t => t.Id),
            AverageTeamId = g.Average(t => t.Id),
            SumTeamId = g.Sum(t => t.Id)
        });
}
async Task AggregateFunctions()
{
    var numberOfTeams = await db.Teams.CountAsync();
    Console.WriteLine($"Number of teams: {numberOfTeams}");

    var numberOfTeamsWithName = await db.Teams.CountAsync(t => t.Name == "Tivoli Gardens F.C.");
    Console.WriteLine($"Number of teams with condition above: {numberOfTeamsWithName}");

    //Get the maximum TeamId
    var maxTeamId = await db.Teams.MaxAsync(t => t.Id);
    Console.WriteLine($"Maximum TeamId: {maxTeamId}");

    //Get the minimum TeamId
    var minTeamId = await db.Teams.MinAsync(t => t.Id);
    Console.WriteLine($"Minimum TeamId: {minTeamId}");

    //Get the average TeamId
    var averageTeamId = await db.Teams.AverageAsync(t => t.Id);
    Console.WriteLine($"Average TeamId: {averageTeamId}");

    //Get the sum of TeamId
    var sumTeamId = await db.Teams.SumAsync(t => t.Id);
    Console.WriteLine($"Sum of TeamId: {sumTeamId}");
}
async Task GetAllTeamsQuerySyntax()
{
    var teams = await (from t in db.Teams
                       orderby t.Id descending
                       where t.Id > 0 & EF.Functions.Like(t.Name, "%F%")
                       select t).ToListAsync();
                       //select new{ t.Name, t.TeamId }).ToListAsync();
    foreach (var team in teams)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }
}
async Task GetFilteredTeams()
{
    var teamsWithName = await db.Teams.Where(t => t.Name == "Tivoli Gardens F.C.").ToListAsync();
    Console.WriteLine("Teams with Name 'Tivoli Gardens F.C.':");
    foreach (var team in teamsWithName)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }


    Console.WriteLine("Enter the name of the team to search for:");
    var name = Console.ReadLine() ?? string.Empty;
    var GetTeamsWithNameAsync = await db.Teams.Where(t => t.Name == name).ToListAsync();
    Console.WriteLine($"Teams with Name '{name}':");
    foreach (var team in GetTeamsWithNameAsync)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }

    //Select * from Teams hwere Name Like '%F%'
    Console.WriteLine("Enter the name of the team to search for (using Contains):");
    var nameContains = Console.ReadLine() ?? string.Empty;
    var partialMatch = await db.Teams.Where(t => EF.Functions.Like(t.Name, $"%{nameContains}%")).ToListAsync();
    Console.WriteLine($"Teams with Name containing '{nameContains}':");
    foreach (var team in partialMatch)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }


    var teamsIdGreaterThanOne = await db.Teams.Where(t => t.Id > 1).ToListAsync();
    Console.WriteLine("Teams with TeamId greater than 1:");
    foreach (var team in teamsIdGreaterThanOne)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }

    var teamNameContainsF = await db.Teams.Where(t => t.Name.Contains("F")).ToListAsync();
    Console.WriteLine("Teams with Name containing 'F':");
    foreach (var team in teamNameContainsF)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }

    var teamsWithNameStartingWithT = await db.Teams.Where(t => t.Name.StartsWith("T")).ToListAsync();
    Console.WriteLine("Teams with Name starting with 'T':");
    foreach (var team in teamsWithNameStartingWithT)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }

    var teamsWithNameEndingWithC = await db.Teams.Where(t => t.Name.EndsWith("C")).ToListAsync();
    Console.WriteLine("Teams with Name ending with 'C':");
    foreach (var team in teamsWithNameEndingWithC)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }

    var teamsWithNameContainingSpace = await db.Teams.Where(t => t.Name.Contains(" ")).ToListAsync();
    Console.WriteLine("Teams with Name containing space:");
    foreach (var team in teamsWithNameContainingSpace)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }

}
async Task GetOneTeam()
{
    // Searching a single record - First one in the List
    Console.WriteLine("Searching a single record - First one in the List");
    var teamFirst = await db.Teams.FirstAsync();
    if (teamFirst == null)
    {
        Console.WriteLine("No team found.");
    }
    else
    {
        Console.WriteLine($"Team is : {teamFirst.Name}");
    }

    // Searching a single record - First one in the List with FirstOrDefault
    var teamFirstOrDefault = await db.Teams.FirstOrDefaultAsync();
    if (teamFirstOrDefault == null)
    {
        Console.WriteLine("No team found.");
    }
    else
    {
        Console.WriteLine($"Team is : {teamFirstOrDefault.Name}");
    }



    // Selecting a single record - First one in the list that meets the condition
    Console.WriteLine("Selecting a single record - First one in the list that meets the condition");
    var teamFirstAsync = await db.Teams.FirstAsync(t => t.Id == 1);
    if (teamFirstAsync == null) { Console.WriteLine("No team found."); } else { Console.WriteLine($"Team is : {teamFirstAsync.Name}"); }

    var teamFirstOrDeafaultAsync = await db.Teams.FirstOrDefaultAsync(t => t.Id == 2);
    if (teamFirstOrDeafaultAsync == null)
    {
        Console.WriteLine("No team found.");
    }
    else
    {
        Console.WriteLine($"Team is : {teamFirstOrDeafaultAsync.Name}");
    }

    // Selecting a single record - Only one record should be returned
    Console.WriteLine("Selecting a single record - Only one record should be returned");
    var teamSingleAsync = await db.Teams.SingleAsync(t => t.Id == 1);
    if (teamSingleAsync == null)
    {
        Console.WriteLine("No team found.");
    }
    else
    {
        Console.WriteLine($"Team is : {teamSingleAsync.Name}");
    }
    var teamSingleOrDeafultAsync = await db.Teams.SingleOrDefaultAsync(t => t.Id == 2);
    if (teamSingleOrDeafultAsync == null)
    {
        Console.WriteLine("No team found.");
    }
    else
    {
        Console.WriteLine($"Team is : {teamSingleOrDeafultAsync.Name}");
    }

    // Selection based on ID
    var teamBasedOnId = await db.Teams.FindAsync(1);
    if (teamBasedOnId != null)
    {
        Console.WriteLine($"Team found with given ID is : {teamBasedOnId.Name}");
    }
    else
    {
        Console.WriteLine("No team found with given ID.");

    }

}
void GetAllTeams()
{
    var teams = db.Teams.ToList();
    foreach (var team in teams)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }
}
async Task GetAllTeamsAsync()
{
    var teams = await db.Teams.ToListAsync();
    foreach (var team in teams)
    {
        Console.WriteLine($"TeamId: {team.Id}, Name: {team.Name}");
    }
}
public class TeamInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public override string ToString()
    {
        return $"TeamId: {Id}, Name: {Name}, CreatedDate: {CreatedDate}";
    }
}
#endregion

// Uncomment the line below if you want to keep the console window open after execution.
//Console.ReadKey();
