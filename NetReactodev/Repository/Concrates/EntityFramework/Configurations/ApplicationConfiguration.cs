using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repository.Concrates.EntityFramework.Configurations;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ApplicantId).IsRequired();
        builder.Property(x => x.BootcampId).IsRequired();
        builder.Property(x => x.ApplicationState).HasConversion<string>();
    }
}
