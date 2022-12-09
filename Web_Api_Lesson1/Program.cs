using BusinessLogic;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
string connectionStr = builder.Configuration.GetConnectionString("AzureDb");
builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionStr));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ShopDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IMonitorService, MonitorService>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(
    builder => builder
    .WithOrigins("http://localhost:4200", "https://white-river-0e32dd810.2.azurestaticapps.net")
    .SetIsOriginAllowedToAllowWildcardSubdomains()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );

app.UseAuthorization();

app.MapControllers();

app.Run();
