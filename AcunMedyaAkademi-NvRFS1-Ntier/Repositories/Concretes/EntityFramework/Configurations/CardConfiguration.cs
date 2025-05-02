using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Modelid).HasColumnName("Modelid").IsRequired();

            builder.Property(b => b.ModelYear).HasColumnName("ModelYear").IsRequired();
            builder.Property(b => b.Plate).HasColumnName("Plate").IsRequired().HasMaxLength(15);
            builder.Property(b => b.Plate).HasColumnName("Plate").IsRequired().HasMaxLength(15);
            builder.Property(b => b.DailyPrice).HasColumnName("DailyPrice").IsRequired();

            builder.HasOne(b => b.Model);
        }
    }
}
