// This middleware restricts Swagger UI access to authenticated users in production.
// Place this file in your API project and register the middleware in Program.cs if you want to secure Swagger UI.
using Microsoft.AspNetCore.Http;
using System.Text;

namespace EntityFrameworkCore.API.Middleware;

public class SwaggerBasicAuthMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string _username;
    private readonly string _password;

    public SwaggerBasicAuthMiddleware(RequestDelegate next, string username, string password)
    {
        _next = next;
        _username = username;
        _password = password;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Path.StartsWithSegments("/swagger"))
        {
            var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
            if (authHeader != null && authHeader.StartsWith("Basic "))
            {
                var encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                var decodedUsernamePassword = Encoding.UTF8.GetString(Convert.FromBase64String(encodedUsernamePassword));
                var parts = decodedUsernamePassword.Split(':', 2);
                if (parts.Length == 2)
                {
                    var username = parts[0];
                    var password = parts[1];
                    if (username == _username && password == _password)
                    {
                        await _next(context);
                        return;
                    }
                }
            }
            context.Response.Headers["WWW-Authenticate"] = "Basic";
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Unauthorized");
            return;
        }
        await _next(context);
    }
}

// To use this middleware, add the following in Program.cs:
// app.UseMiddleware<SwaggerBasicAuthMiddleware>("admin", "yourStrongPassword");
// Place it before app.UseSwaggerUI();
