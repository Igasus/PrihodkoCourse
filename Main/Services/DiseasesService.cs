using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class DiseasesService
    {
        private readonly ApplicationDbContext _context;

        public DiseasesService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Disease> CreateAsync(Disease createModel)
        {
            var disease = (await _context.Diseases.AddAsync(createModel)).Entity;
            await _context.SaveChangesAsync();

            return disease;
        }

        public async Task<Disease> ReadByIdAsync(int diseaseId)
        {
            return await _context.Diseases.FirstOrDefaultAsync(d => d.Id == diseaseId);
        }

        public async Task<IEnumerable<Disease>> ReadListAsync(string searchName)
        {
            return await _context.Diseases
                .Include(disease => disease.DiseaseSymptoms)
                .Include(disease => disease.DiseaseMedicaments)
                .Where(d => d.Name.Contains(searchName))
                .ToListAsync();
        }

        public async Task<Disease> UpdateAsync(Disease updateModel)
        {
            var disease = _context.Diseases.Update(updateModel).Entity;
            await _context.SaveChangesAsync();

            return disease;
        }

        public async Task DeleteByIdAsync(int diseaseId)
        {
            var disease = await ReadByIdAsync(diseaseId);
            _context.Diseases.Remove(disease);
            await _context.SaveChangesAsync();
        }
    }
}