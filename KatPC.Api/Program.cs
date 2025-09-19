using KatPC.Api.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<KatPCDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("testCon")));
    
builder.Services.AddCors();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "allowCors",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
            .AllowCredentials()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();
