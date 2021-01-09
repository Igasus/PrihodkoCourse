using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class SubstitutesService
    {
        private readonly ApplicationDbContext _context;

        public SubstitutesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Substitute> CreateAsync(int originalMedicamentId, int substituteMedicamentId,
            float dosageMultiplier)
        {
            var createModel = new Substitute
            {
                OriginalMedicamentId = originalMedicamentId,
                SubstituteMedicamentId = substituteMedicamentId,
                DosageMultiplier = dosageMultiplier
            };

            var substituteEntry = await _context.Substitutes.AddAsync(createModel);
            await _context.SaveChangesAsync();

            return substituteEntry.Entity;
        }

        public async Task<Substitute> ReadByIdAsync(int originalMedicamentId, int substituteMedicamentId)
        {
            return await _context.Substitutes.FirstOrDefaultAsync(s =>
                s.OriginalMedicamentId == originalMedicamentId && s.SubstituteMedicamentId == substituteMedicamentId);
        }

        public async Task<IEnumerable<Substitute>> ReadSubstitutesListByOriginalMedicamentIdAsync(
            int originalMedicamentId,
            string searchName)
        {
            return await _context.Substitutes
                .Include(s => s.SubstituteMedicament)
                .Where(s => s.OriginalMedicamentId == originalMedicamentId)
                .Where(s => s.SubstituteMedicament.Name.Contains(searchName))
                .ToListAsync();
        }

        public async Task<IEnumerable<Substitute>> ReadMedicamentsListBySubstituteMedicamentIdAsync(
            int substituteMedicamentId,
            string searchName)
        {
            return await _context.Substitutes
                .Include(s => s.OriginalMedicament)
                .Where(s => s.SubstituteMedicamentId == substituteMedicamentId)
                .Where(s => s.OriginalMedicament.Name.Contains(searchName))
                .ToListAsync();
        }

        public async Task<Substitute> UpdateByIdAsync(Substitute updateModel)
        {
            var substitute = _context.Substitutes.Update(updateModel).Entity;
            await _context.SaveChangesAsync();

            return substitute;
        }

        public async Task DeleteByIdAsync(int originalMedicamentId, int substituteMedicamentId)
        {
            var substitute = await ReadByIdAsync(originalMedicamentId, substituteMedicamentId);
            _context.Substitutes.Remove(substitute);
            await _context.SaveChangesAsync();
        }
    }
}