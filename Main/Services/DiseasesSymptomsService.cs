using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class DiseasesSymptomsService
    {
        private readonly ApplicationDbContext _context;

        public DiseasesSymptomsService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<DiseaseSymptom> CreateRelationAsync(int diseaseId, int symptomId)
        {
            var createModel = new DiseaseSymptom
            {
                DiseaseId = diseaseId,
                SymptomId = symptomId
            };

            var relationEntry = await _context.DiseasesSymptoms.AddAsync(createModel);
            await _context.SaveChangesAsync();

            return relationEntry.Entity;
        }

        public async Task<List<DiseaseSymptom>> ReadListAsync(int? selectedDiseaseId,
            int? selectedSymptomId,
            string diseaseSearchName,
            string symptomSearchName)
        {
            var list = await _context.DiseasesSymptoms
                .Include(model => model.Disease)
                .Include(model => model.Symptom)
                .ToListAsync();

            if (selectedDiseaseId != null)
                list = list
                    .Where(model => 
                        model.DiseaseId == selectedDiseaseId && model.Disease.Name.Contains(diseaseSearchName))
                    .ToList();

            if (selectedSymptomId != null)
                list = list
                    .Where(model =>
                        model.SymptomId == selectedSymptomId && model.Disease.Name.Contains(symptomSearchName))
                    .ToList();

            return list;
        }

        public async Task DeleteRelationByIdAsync(int diseaseId, int symptomId)
        {
            var relationModel = await _context.DiseasesSymptoms.FirstOrDefaultAsync(model =>
                model.DiseaseId == diseaseId && model.SymptomId == symptomId);
            _context.DiseasesSymptoms.Remove(relationModel);
            await _context.SaveChangesAsync();
        }
    }
}