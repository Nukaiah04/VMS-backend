using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using VMS.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "VMS API",
        Version = "v1"
    });
});
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// ✅ Swagger enabled for all environments
app.UseSwagger();
app.UseSwaggerUI();

// ✅ HTTPS redirect removed for Kubernetes
// app.UseHttpsRedirection();

app.MapControllers();

// ✅ Home route
app.MapGet("/", () => "VMS Backend Running Successfully");

app.Run();
