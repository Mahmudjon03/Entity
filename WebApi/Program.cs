using Infrastructure;
using Infrastructure.Servises.AddressServise;
using Infrastructure.Servises.CompanyServises;
using Infrastructure.Servises.EmployeeServises;
using Infrastructure.Servises.SkillEmployeeServise;
using Infrastructure.Servises.SkillServises;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var con = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(c => c.UseNpgsql(con));
builder.Services.AddScoped<ICompanyServise, CompanyServise>();
builder.Services.AddScoped<IEmployeeServise, EmployeeServise>();
builder.Services.AddScoped<IAddressServise,AddressEmplyeeServise>();    
builder.Services.AddScoped<ISkillServise, SkillServise>();
builder.Services.AddScoped<ISkillEmployeeServise,EmployeeSkilServise>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
