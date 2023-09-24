using Microsoft.EntityFrameworkCore;
using EFPractice.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
