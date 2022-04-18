using AutoMapper;
using BlazorApp.Data;
using Business.Characters;
using Business.Episodes;
using Business.Interfaces.Characters;
using Business.Interfaces.Episodes;
using Business.Interfaces.Locations;
using Business.Locations;
using DataAccess.Characters;
using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
using DataAccess.Episodes;
using DataAccess.Interfaces.Characters;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Episodes;
using DataAccess.Interfaces.Locations;
using DataAccess.Locations;
using DataAccess.Services.RestServices;
using Entities.Characters;
using Entities.CrossCutting;
using IoC;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

RegisterDependencies(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

static void RegisterDependencies(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IApiResponseMapper, ApiResponseMapper>();
    builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
    builder.Services.AddScoped<ICharacterService, CharacterService>();
    builder.Services.AddScoped<IEpisodeRepository, EpisodeRepository>();
    builder.Services.AddScoped<IEpisodeService, EpisodeService>();
    builder.Services.AddScoped<ILocationRepository, LocationRepository>();
    builder.Services.AddScoped<ILocationService, LocationService>();
    builder.Services.AddScoped(typeof(IRestService<>), typeof(RestService<>));

    var mapper = AutomapperConfiguration.GetMapper();

    builder.Services.AddSingleton(mapper);
}
