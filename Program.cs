using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Diagnostics;
using VMS.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "VMS API",
        Version = "v1"
    });
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Automatically open Swagger in browser during development
if (app.Environment.IsDevelopment())
{
    Task.Run(async () =>
    {
        await Task.Delay(2000);
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://localhost:7244/swagger",
                UseShellExecute = true
            });
        }
        catch
        {
            // Ignore browser launch errors
        }
    });
}

// ✅ Use CORS — must be before MapControllers
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

// Home route
app.MapGet("/", () => "VMS Backend Running Successfully");

app.Run();