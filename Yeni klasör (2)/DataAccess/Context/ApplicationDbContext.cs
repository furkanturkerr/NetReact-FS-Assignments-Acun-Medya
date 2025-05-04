using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Application> Applications { get; set; }
    public DbSet<Bootcamp> Bootcamps { get; set; }
    public DbSet<Blacklist> Blacklists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        { 
            entity.Property(a => a.CreatedDate)
                  .HasDefaultValueSql("GETDATE()");  
            
            entity.Property(a => a.ApplicationState)
                  .IsRequired();  
        });

        modelBuilder.Entity<Blacklist>(entity =>
        {
            
            entity.Property(b => b.Date)
                  .HasDefaultValueSql("GETDATE()");  

          
            entity.Property(b => b.Reason)
                  .IsRequired() 
                  .HasMaxLength(500);  

           
            entity.HasOne(b => b.Application)
                  .WithMany()  
                  .HasForeignKey(b => b.ApplicantId);  

        });

        modelBuilder.Entity<Bootcamp>(entity =>
        {
           
            entity.Property(b => b.StartDate)
                  .HasDefaultValueSql("GETDATE()");  

            entity.Property(b => b.EndDate)
                  .HasDefaultValueSql("GETDATE()"); 

            
            entity.Property(b => b.BootcampState)
                  .IsRequired();  
        });


        base.OnModelCreating(modelBuilder);
    }
}
