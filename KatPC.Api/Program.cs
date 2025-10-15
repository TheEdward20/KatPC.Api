using KatPC.Api.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<KatPCDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("testCon")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("allowCors", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Angular
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// Habilitar CORS (con el nombre de la política)
app.UseCors("allowCors");

app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c=> c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ejemplo de API"));

app.Run();
