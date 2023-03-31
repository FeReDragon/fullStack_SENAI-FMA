using Microsoft.EntityFrameworkCore;
using BerçarioAPI.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Adição do DbContext para LojaContexto e configuração da conexão com o banco de dados
builder.Services.AddDbContext<BerçarioContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("ServerConnection"),
    new MySqlServerVersion(new Version(8, 0, 26)))); // Ajuste a versão do MySQL de acordo com a versão que você está usando

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
