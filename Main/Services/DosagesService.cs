using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class DosagesService
    {
        private readonly ApplicationDbContext _context;

        public DosagesService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Dosage> CreateAsync(Dosage createModel)
        {
            var dosage = (await _context.Dosages.AddAsync(createModel)).Entity;
            await _context.SaveChangesAsync();

            return dosage;
        }

        public async Task<Dosage> ReadByIdAsync(int dosageId)
        {
            return await _context.Dosages.FirstOrDefaultAsync(d => d.Id == dosageId);
        }

        public async Task<IEnumerable<Dosage>> ReadListAsync()
        {
            return await _context.Dosages
                .Include(dosage => dosage.DiseaseMedicament)
                    .ThenInclude(dm => dm.Disease)
                .Include(dosage => dosage.DiseaseMedicament)
                    .ThenInclude(dm => dm.Medicament)
                .ToListAsync();
        }

        public async Task<Dosage> UpdateAsync(Dosage updateModel)
        {
            var dosage = _context.Dosages.Update(updateModel).Entity;
            await _context.SaveChangesAsync();

            return dosage;
        }

        public async Task DeleteByIdAsync(int dosageId)
        {
            var dosage = await ReadByIdAsync(dosageId);
            _context.Dosages.Remove(dosage);
            await _context.SaveChangesAsync();
        }

        public async Task<Dosage> FindForSpecifiedAge(int diseaseMedicamentId, int age)
        {
            var dosagesList = await _context.Dosages
                .Include(dosage => dosage.DiseaseMedicament)
                    .ThenInclude(diseaseMedicament => diseaseMedicament.Disease)
                .Include(dosage => dosage.DiseaseMedicament)
                    .ThenInclude(diseaseMedicament => diseaseMedicament.Medicament)
                .Where(d => d.DiseaseMedicamentId == diseaseMedicamentId)
                .ToListAsync();

            var resultDosageMinAge = 0;

            foreach (var dosage in dosagesList)
            {
                if (dosage.MinAge <= age && dosage.MinAge > resultDosageMinAge)
                    resultDosageMinAge = dosage.MinAge;
            }

            return dosagesList.FirstOrDefault(d => d.MinAge == resultDosageMinAge);
        }
    }
}