using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.EntitiesTypesConfigurations
{
    public class DiseaseSymptomConfiguration : IEntityTypeConfiguration<DiseaseSymptom>
    {
        public void Configure(EntityTypeBuilder<DiseaseSymptom> builder)
        {
            builder.HasKey(ds => new {ds.DiseaseId, ds.SymptomId});
            builder.HasOne(ds => ds.Disease)
                .WithMany(d => d.DiseaseSymptoms)
                .HasForeignKey(ds => ds.DiseaseId);
            builder.HasOne(ds => ds.Symptom)
                .WithMany(s => s.SymptomDiseases)
                .HasForeignKey(ds => ds.SymptomId);
        }
    }
}