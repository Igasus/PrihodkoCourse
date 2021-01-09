using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrihodkoCourse.Models;

namespace PrihodkoCourse
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dosage> Dosages { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Substitute> Substitutes { get; set; }
        public DbSet<DiseaseSymptom> DiseasesSymptoms { get; set; }
        public DbSet<RecipeMedicament> RecipesMedicaments { get; set; }
        public DbSet<DiseaseMedicament> DiseasesMedicaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = ServiceProviderFactory.ServiceProvider.GetService<IConfiguration>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MsSQL"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}