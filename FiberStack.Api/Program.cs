using Pomelo.EntityFrameworkCore.MySql;
using FiberStack.Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using FiberStack.Api.Domain.Entities;
using FiberStack.Api.Domain.Interfaces;
using FiberStack.Api.Infrastructure.Repository;

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


