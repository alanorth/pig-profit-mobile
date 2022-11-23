using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using PigTool.API.Middleware;
using Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddAuthentication(o =>
{
    o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.AccessDeniedPath = Constants.ROUTE_API_DENIED;
    options.LoginPath = "/mobileauth/Google";
    //options.AccessDeniedPath = "/Denied/";

}).AddGoogle(googleOptions =>
{
    //googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
    //googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
    googleOptions.ClientId = builder.Configuration.GetValue<string>("GoogleClient");
    googleOptions.ClientSecret = builder.Configuration.GetValue<string>("GoogleSecret");
    googleOptions.SaveTokens = true;
    googleOptions.AccessDeniedPath = Constants.ROUTE_API_DENIED;
    //googleOptions.AuthorizationEndpoint = "/mobileauth/Google";
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

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//app.UseMiddleware<ApiKeyMiddleware>();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
