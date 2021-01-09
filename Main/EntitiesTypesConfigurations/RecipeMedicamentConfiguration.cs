using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.EntitiesTypesConfigurations
{
    public class RecipeMedicamentConfiguration : IEntityTypeConfiguration<RecipeMedicament>
    {
        public void Configure(EntityTypeBuilder<RecipeMedicament> builder)
        {
            builder.HasKey(relation => new {relation.RecipeId, relation.MedicamentId});
            builder.HasOne(relation => relation.Recipe)
                .WithMany(recipe => recipe.RecipeMedicaments)
                .HasForeignKey(relation => relation.RecipeId);
            builder.HasOne(relation => relation.Medicament)
                .WithMany(medicament => medicament.MedicamentRecipes)
                .HasForeignKey(relation => relation.MedicamentId);
        }
    }
}