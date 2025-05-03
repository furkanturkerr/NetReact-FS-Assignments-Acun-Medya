using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Repository.Concrates.EntityFramework.Configurations;

public partial class BootcampConfiguration
{
    public class BlacklistConfiguration : IEntityTypeConfiguration<Blacklist>
    {
        public void Configure(EntityTypeBuilder<Blacklist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Reason).HasMaxLength(250);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.ApplicantId).IsRequired();
        }
    }

}
