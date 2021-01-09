using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.EntitiesTypesConfigurations
{
    public class SubstituteConfiguration : IEntityTypeConfiguration<Substitute>
    {
        public void Configure(EntityTypeBuilder<Substitute> builder)
        {
            builder.HasKey(s => new {s.OriginalMedicamentId, s.SubstituteMedicamentId});
            builder.HasOne(s => s.OriginalMedicament)
                .WithMany(m => m.MedicamentSubstitutes)
                .HasForeignKey(s => s.OriginalMedicamentId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.SubstituteMedicament)
                .WithMany(m => m.SubstituteOfMedicaments)
                .HasForeignKey(s => s.SubstituteMedicamentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}