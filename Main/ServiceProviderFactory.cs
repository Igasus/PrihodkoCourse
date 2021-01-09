using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrihodkoCourse.Forms;
using PrihodkoCourse.Services;

namespace PrihodkoCourse
{
    public static class ServiceProviderFactory
    {
        private const string ConfigurationFile = "appsettings.json";
        public static readonly IServiceProvider ServiceProvider;

        static ServiceProviderFactory()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile(ConfigurationFile).Build();
            var serviceCollection = new ServiceCollection();
            
            serviceCollection.AddSingleton<IConfiguration>(provider => configuration);
            serviceCollection.AddDbContext<ApplicationDbContext>();

            serviceCollection
                .AddTransient<ClientsService>()
                .AddTransient<DosagesService>()
                .AddTransient<RecipesService>()
                .AddTransient<DiseasesService>()
                .AddTransient<SymptomsService>()
                .AddTransient<MedicamentsService>()
                .AddTransient<SubstitutesService>()
                .AddTransient<DiseasesSymptomsService>()
                .AddTransient<RecipesMedicamentsService>()
                .AddTransient<DiseasesMedicamentsService>();

            serviceCollection.AddTransient<RecipeCreator>();

            serviceCollection
                .AddTransient<StartupForm>()
                .AddTransient<ClientsForm>()
                .AddTransient<RecipesForm>()
                .AddTransient<DiseasesForm>()
                .AddTransient<SymptomsForm>()
                .AddTransient<MedicamentsForm>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
