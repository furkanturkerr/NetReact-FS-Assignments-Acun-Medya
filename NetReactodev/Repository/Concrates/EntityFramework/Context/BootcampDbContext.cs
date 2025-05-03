using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrates.EntityFramework.Context;

public class BootcampDbContext : DbContext
{
    public BootcampDbContext(DbContextOptions<BootcampDbContext> options) : base(options) { }

    public DbSet<Application> Applications { get; set; }
    public DbSet<Bootcamp> Bootcamps { get; set; }
    public DbSet<Blacklist> Blacklists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BootcampDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
