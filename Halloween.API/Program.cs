using Halloween.Repo.Repositories;
using Halloween.API.DTO;
using Halloween.Repo.Interfaces;
using Halloween.Repo.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISuperHeroRepo, SuperHeroRepo>();
builder.Services.AddScoped<ITeamRepo, TeamRepo>();

//Database
builder.Services.AddDbContext<Halloween.Repo.Repositories.Dbcontext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("connection")));
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
