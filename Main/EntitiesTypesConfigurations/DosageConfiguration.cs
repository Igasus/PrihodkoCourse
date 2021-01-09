using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.EntitiesTypesConfigurations
{
    public class DosageConfiguration : IEntityTypeConfiguration<Dosage>
    {
        public void Configure(EntityTypeBuilder<Dosage> builder)
        {
            builder.HasOne(d => d.DiseaseMedicament)
                .WithMany(dm => dm.Dosages)
                .HasForeignKey(d => d.DiseaseMedicamentId);
        }
    }
}