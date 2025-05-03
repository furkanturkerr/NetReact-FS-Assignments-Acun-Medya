using Business.Concretes;
using Business.Abstracts;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstracts;
using Repositories.Concretes;
using Repositories.Concretes.EntityFramework.Contexts;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<BaseDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("BaseDb")));

builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();

builder.Services.AddControllers();   //Controller servislerini tanýmlar.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//uygulamayý yapýlandýrýr
var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();


app.Run();


