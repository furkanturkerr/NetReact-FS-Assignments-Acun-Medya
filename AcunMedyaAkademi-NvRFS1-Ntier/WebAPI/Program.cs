using Microsoft.EntityFrameworkCore;
using Repositories.Concretes.EntityFramework.Contexts;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<BaseDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("BaseDb")));

var app = builder.Build();


app.Run();


