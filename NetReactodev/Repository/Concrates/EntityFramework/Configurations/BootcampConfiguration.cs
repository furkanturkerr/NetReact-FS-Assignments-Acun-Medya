using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrates.EntityFramework.Configurations;

public partial class BootcampConfiguration : IEntityTypeConfiguration<Bootcamp>
{
    public void Configure(EntityTypeBuilder<Bootcamp> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.InstructorId).IsRequired();
        builder.Property(x => x.StartDate).IsRequired();
        builder.Property(x => x.EndDate).IsRequired();
        builder.Property(x => x.BootcampState).HasConversion<string>().IsRequired();
    }
}
