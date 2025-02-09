using kilit_data.Context;
using kilit_data.Data.Mapper;
using kilit_services.Services.Interfaces;
using kilit_services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using kilit_data.UnitOfWork.Interface;
using kilit_data.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();



var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<KilitContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork<KilitContext>, UnitOfWork<KilitContext>>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();