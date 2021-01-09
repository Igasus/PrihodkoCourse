using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class RecipeCreator
    {
        private readonly DiseasesMedicamentsService _diseasesMedicamentsService;
        private readonly DosagesService _dosagesService;
        private readonly SubstitutesService _substitutesService;
        private readonly MedicamentsService _medicamentsService;

        public RecipeCreator(DiseasesMedicamentsService diseasesMedicamentsService,
            DosagesService dosagesService,
            SubstitutesService substitutesService,
            MedicamentsService medicamentsService)
        {
            _diseasesMedicamentsService = diseasesMedicamentsService;
            _dosagesService = dosagesService;
            _substitutesService = substitutesService;
            _medicamentsService = medicamentsService;
        }
        
        public async Task<IEnumerable<RecipeMedicament>> GetExistingMedicamentsListByDiseaseAndClientAsync(
            Disease disease,
            int clientAge)
        {
            var resultList = new List<RecipeMedicament>();

            foreach (var diseaseMedicament in disease.DiseaseMedicaments)
            {
                var dosage = await _dosagesService.FindForSpecifiedAge(diseaseMedicament.Id, clientAge);
                var medicament = dosage.DiseaseMedicament.Medicament;
                var dose = dosage.Dose;

                var queue = new List<KeyValuePair<int, double>> {new KeyValuePair<int, double>(medicament.Id, 1)};
                var i = 0;
                const int cycledTimesBorder = 50;

                while (queue.Any())
                {
                    if (i > cycledTimesBorder)
                        return null;
                    
                    var currentItem = queue[i];
                    medicament = await _medicamentsService.ReadByIdAsync(currentItem.Key);

                    if (medicament.StockQuantity >= dose * currentItem.Value)
                    {
                        dose *= currentItem.Value;
                        break;
                    }

                    var substitutes = await _substitutesService
                        .ReadSubstitutesListByOriginalMedicamentIdAsync(medicament.Id, "");

                    foreach (var substitute in substitutes)
                    {
                        var nextMedicamentId = substitute.SubstituteMedicamentId;
                        var nextMultiplier = currentItem.Value * substitute.DosageMultiplier;
                        queue.Add(new KeyValuePair<int, double>(nextMedicamentId, nextMultiplier));
                    }

                    i++;
                }
                
                resultList.Add(new RecipeMedicament
                {
                    Dose = dose,
                    MedicamentId = medicament.Id,
                    Medicament = medicament
                });
            }

            return resultList;
        }
    }
}