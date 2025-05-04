using DataAccess;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Repositories.Implementations;
using Repositories.Interfaces;
using Business.Services.Implementations;
using Business.Services.Interfaces;

builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddAutoMapper(typeof(Program));

var builder = WebApplication.CreateBuilder(args);

// DbContext'i ekle
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BaseDb")));

// Repository'leri ekle
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();