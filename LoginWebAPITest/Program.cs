using ElCamino.AspNetCore.Identity.AzureTable;
using IdentityUser = ElCamino.AspNetCore.Identity.AzureTable.Model.IdentityUser;
using ElCamino.AspNetCore.Identity.AzureTable.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LoginWebAPITest.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//ElCamino configuration
.AddAzureTableStores<ApplicationDbContext>(new Func<IdentityConfiguration>(() =>
{
    IdentityConfiguration idconfig = new IdentityConfiguration();
    idconfig.TablePrefix = builder.Configuration.GetSection("IdentityAzureTable:IdentityConfiguration:TablePrefix").Value;
    idconfig.StorageConnectionString = builder.Configuration.GetSection("IdentityAzureTable:IdentityConfiguration:StorageConnectionString").Value;
    idconfig.IndexTableName = builder.Configuration.GetSection("IdentityAzureTable:IdentityConfiguration:IndexTableName").Value; // default: AspNetIndex
    idconfig.RoleTableName = builder.Configuration.GetSection("IdentityAzureTable:IdentityConfiguration:RoleTableName").Value;   // default: AspNetRoles
    idconfig.UserTableName = builder.Configuration.GetSection("IdentityAzureTable:IdentityConfiguration:UserTableName").Value;   // default: AspNetUsers
    return idconfig;
}))
//Can remove .CreateAzureTablesIfNotExists() after first run 
.CreateAzureTablesIfNotExists<ApplicationDbContext>();
builder.Services.AddControllersWithViews();


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
