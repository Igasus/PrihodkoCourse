using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class DiseasesMedicamentsService
    {
        private readonly ApplicationDbContext _context;

        public DiseasesMedicamentsService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<DiseaseMedicament> CreateRelationAsync(int diseaseId, int medicamentId)
        {
            var createModel = new DiseaseMedicament
            {
                DiseaseId = diseaseId,
                MedicamentId = medicamentId
            };

            var relationEntry = await _context.DiseasesMedicaments.AddAsync(createModel);
            await _context.SaveChangesAsync();

            return relationEntry.Entity;
        }

        public async Task<DiseaseMedicament> ReadByIdAsync(int relationModelId)
        {
            return await _context.DiseasesMedicaments
                .FirstOrDefaultAsync(model => model.Id == relationModelId);
        }

        public async Task<List<DiseaseMedicament>> ReadListAsync(int? selectedDiseaseId,
            int? selectedMedicamentId,
            string diseaseSearchName,
            string medicamentSearchName)
        {
            var list = await _context.DiseasesMedicaments
                .Include(model => model.Disease)
                .Include(model => model.Medicament)
                .ToListAsync();

            if (selectedDiseaseId != null)
                list = list
                    .Where(model => 
                        model.DiseaseId == selectedDiseaseId && model.Disease.Name.Contains(diseaseSearchName))
                    .ToList();

            if (selectedMedicamentId != null)
                list = list
                    .Where(model =>
                        model.MedicamentId == selectedMedicamentId && model.Disease.Name.Contains(medicamentSearchName))
                    .ToList();

            return list;
        }

        public async Task DeleteRelationByIdAsync(int modelId)
        {
            var relationModel = await _context.DiseasesMedicaments.FirstOrDefaultAsync(model => model.Id == modelId);
            _context.DiseasesMedicaments.Remove(relationModel);
            await _context.SaveChangesAsync();
        }
    }
}