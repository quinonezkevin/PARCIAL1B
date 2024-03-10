using Microsoft.EntityFrameworkCore;
using PARCIAL1B.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Inyecci�n por dependencia del string de conexion al contexto

builder.Services.AddDbContext<Parcial1BDBContext>(options =>
        options.UseSqlServer(
                builder.Configuration.GetConnectionString("equiposDbConnection")
            )
        );


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
