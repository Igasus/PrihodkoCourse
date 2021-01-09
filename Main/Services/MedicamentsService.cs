using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class MedicamentsService
    {
        private readonly ApplicationDbContext _context;

        public MedicamentsService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Medicament> CreateAsync(Medicament createModel)
        {
            var medicament = (await _context.Medicaments.AddAsync(createModel)).Entity;
            await _context.SaveChangesAsync();

            return medicament;
        }

        public async Task<Medicament> ReadByIdAsync(int medicamentId)
        {
            return await _context.Medicaments.FirstOrDefaultAsync(m => m.Id == medicamentId);
        }

        public async Task<IEnumerable<Medicament>> ReadListAsync(string searchName)
        {
            return await _context.Medicaments
                .Include(m => m.MedicamentDiseases)
                .Include(m => m.MedicamentSubstitutes)
                .Include(m => m.SubstituteOfMedicaments)
                .Where(m => m.Name.Contains(searchName))
                .ToListAsync();
        }

        public async Task<Medicament> UpdateAsync(Medicament updateModel)
        {
            var medicament = _context.Medicaments.Update(updateModel).Entity;
            await _context.SaveChangesAsync();

            return medicament;
        }

        public async Task DeleteByIdAsync(int medicamentId)
        {
            var medicament = await ReadByIdAsync(medicamentId);
            _context.Medicaments.Remove(medicament);
            await _context.SaveChangesAsync();
        }
    }
}