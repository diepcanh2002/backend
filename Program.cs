using Microsoft.EntityFrameworkCore;
using PitchManagerAPI.Data;
using PitchManagerAPI.Interfaces;
using PitchManagerAPI.Models;
using PitchManagerAPI.Reponsitory;
using PitchManagerAPI.Controllers;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("test"));
});
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IPlayerRepository,PlayerRepository>();
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
