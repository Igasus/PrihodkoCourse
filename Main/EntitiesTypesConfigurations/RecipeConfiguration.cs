using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.EntitiesTypesConfigurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasOne(recipe => recipe.Client)
                .WithMany(client => client.Recipes)
                .HasForeignKey(recipe => recipe.ClientId);
            builder.HasOne(recipe => recipe.Disease)
                .WithMany(disease => disease.Recipes)
                .HasForeignKey(recipe => recipe.DiseaseId);
        }
    }
}