using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using PigTool.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddAuthentication().AddGoogle(googleOptions =>
{
    //googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
    // googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
    googleOptions.ClientId = builder.Configuration.GetValue<string>("GoogleClient");
    googleOptions.ClientSecret = builder.Configuration.GetValue<string>("GoogleSecret");
});

var app = builder.Build();

IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.UseMiddleware<ApiKeyMiddleware>();

app.Run();
