using EntityFrameworkCore.API.Middleware;
using EntityFrameworkCore.Data;
using EntityFrameworkCore.Data.WebAPIContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    // Configure JSON options as needed
});
builder.Services.AddOpenApi();

var sqLiteDatabaseName = builder.Configuration.GetConnectionString("SqliteDatabaseConnectionString");
var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var dbPath = Path.Combine(path, sqLiteDatabaseName);
var connectionString = $"Data Source={dbPath}";

builder.Services.AddDbContext<FootballLeagueWebAPIContext>(options =>
{
    options.UseSqlite(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.LogTo(Console.WriteLine, LogLevel.Information);
    if (!builder.Environment.IsProduction())
    {
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Secure Swagger UI with basic auth in production only
if (app.Environment.IsProduction())
{
    app.UseMiddleware<SwaggerBasicAuthMiddleware>("admin", "yourStrongPassword");
}

// Enable Swagger/OpenAPI in Development and Staging
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
