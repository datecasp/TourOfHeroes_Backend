using Microsoft.EntityFrameworkCore;
using TourOfHeroes_Backend.Configuration;
using TourOfHeroes_Backend.DataContext;
using TourOfHeroes_Backend.Models;
using TourOfHeroes_Backend.Repositories;
using TourOfHeroes_Backend.Services;

var builder = WebApplication.CreateBuilder(args);

const string CONNSTRING = "connString";
var connectionString = builder.Configuration.GetConnectionString(CONNSTRING);

// Add services to the container.

builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IHeroService, HeroService>();
builder.Services.AddScoped<IHeroRepository, HeroRepository>();

builder.Services.AddControllers();

//builder.Services.ResolveDependencies();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cors Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
