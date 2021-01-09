using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.EntitiesTypesConfigurations
{
    public class DiseaseMedicamentConfiguration : IEntityTypeConfiguration<DiseaseMedicament>
    {
        public void Configure(EntityTypeBuilder<DiseaseMedicament> builder)
        {
            builder.HasOne(dm => dm.Disease)
                .WithMany(d => d.DiseaseMedicaments)
                .HasForeignKey(dm => dm.DiseaseId);
            builder.HasOne(dm => dm.Medicament)
                .WithMany(m => m.MedicamentDiseases)
                .HasForeignKey(dm => dm.MedicamentId);
        }
    }
}