using Business.Implementations;
using Business.Services.Interfaces;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Repositories.Implementations;
using Repositories.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// ✅ 1. Veritabanı Bağlantısı (ApplicationDbContext)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BaseDb"));
});

// ✅ 2. Repositories (Veritabanı erişimi için)
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IBootcampRepository, BootcampRepository>();
builder.Services.AddScoped<IBlacklistRepository, BlacklistRepository>();

// ✅ 3. Services (İş mantığı için Manager sınıfları)
builder.Services.AddScoped<IApplicationService, ApplicationManager>();
builder.Services.AddScoped<IBootcampService, BootcampManager>();
builder.Services.AddScoped<IBlacklistService, BlacklistManager>();

// ✅ 4. API Controller ve Swagger Ayarları
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ 5. CORS Ayarları (Geliştirme ortamı için izinli yap)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// ✅ 6. Swagger ve CORS Konfigürasyonu (Sadece geliştirme ortamında)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowAll");
}

// ✅ 7. Middleware'ler
app.UseHttpsRedirection();
app.UseAuthorization();

// ✅ 8. API Controller'ların yola çıkması
app.MapControllers();

app.Run();
