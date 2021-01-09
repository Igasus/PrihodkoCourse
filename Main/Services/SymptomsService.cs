using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class SymptomsService
    {
        private readonly ApplicationDbContext _context;

        public SymptomsService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Symptom> CreateAsync(Symptom createModel)
        {
            var symptom = (await _context.Symptoms.AddAsync(createModel)).Entity;
            await _context.SaveChangesAsync();

            return symptom;
        }

        public async Task<Symptom> ReadByIdAsync(int symptomId)
        {
            return await _context.Symptoms.FirstOrDefaultAsync(s => s.Id == symptomId);
        }

        public async Task<IEnumerable<Symptom>> ReadListAsync(string searchName)
        {
            return await _context.Symptoms
                .Include(symptom => symptom.SymptomDiseases)
                .Where(s => s.Name.Contains(searchName))
                .ToListAsync();
        }

        public async Task<Symptom> UpdateAsync(Symptom updateModel)
        {
            var symptom = _context.Symptoms.Update(updateModel).Entity;
            await _context.SaveChangesAsync();

            return symptom;
        }

        public async Task DeleteByIdAsync(int symptomId)
        {
            var symptom = await ReadByIdAsync(symptomId);
            _context.Symptoms.Remove(symptom);
            await _context.SaveChangesAsync();
        }
    }
}