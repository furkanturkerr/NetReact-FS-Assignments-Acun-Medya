using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.ToTable("Model");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.Id).HasColumnName("BrandId").IsRequired();

            builder.Property(a => a.Id).HasColumnName("Name").IsRequired().HasMaxLength(20);

            builder.HasOne(a => a.Brand);

            builder.HasMany(b => b.Cars);
        }
    }
}
