using Pomelo.EntityFrameworkCore.MySql;
using FiberStack.Api.Data;
using Microsoft.EntityFrameworkCore;
using FiberStack.Api.Data.Models;
using FiberStack.Api.Interfaces;
using FiberStack.Api.Repository;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<FiberStackDbContext>(opts => opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddScoped<IRepository<Olt>, OltRepository>();
builder.Services.AddScoped<IRepository<Acesso>, AcessoRepository>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();


