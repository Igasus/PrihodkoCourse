using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class RecipesMedicamentsService
    {
        private readonly ApplicationDbContext _context;

        public RecipesMedicamentsService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<RecipeMedicament> CreateRelationAsync(RecipeMedicament createModel)
        {
            var relationEntry = await _context.RecipesMedicaments.AddAsync(createModel);
            await _context.SaveChangesAsync();

            return relationEntry.Entity;
        }

        public async Task<RecipeMedicament> ReadByIdAsync(int recipeId, int medicamentId)
        {
            return await _context.RecipesMedicaments
                .Include(relationModel => relationModel.Recipe)
                    .ThenInclude(recipe => recipe.Client)
                .Include(relationModel => relationModel.Recipe)
                    .ThenInclude(recipe => recipe.Disease)
                .Include(relationModel => relationModel.Medicament)
                .FirstOrDefaultAsync(relationModel =>
                    relationModel.RecipeId == recipeId && relationModel.MedicamentId == medicamentId);
        }

        public async Task<List<RecipeMedicament>> ReadListByRecipeIdAsync(int selectedRecipeId)
        {
            return await _context.RecipesMedicaments
                .Include(relationModel => relationModel.Recipe)
                    .ThenInclude(recipe => recipe.Client)
                .Include(relationModel => relationModel.Recipe)
                    .ThenInclude(recipe => recipe.Disease)
                .Include(relationModel => relationModel.Medicament)
                .Where(relationModel => relationModel.RecipeId == selectedRecipeId)
                .ToListAsync();
        }

        public async Task<RecipeMedicament> UpdateAsync(RecipeMedicament updateModel)
        {
            var relationEntry = _context.RecipesMedicaments.Update(updateModel);
            await _context.SaveChangesAsync();

            return relationEntry.Entity;
        }

        public async Task DeleteRelationByIdAsync(int recipeId, int medicamentId)
        {
            var removeModel = await _context.RecipesMedicaments.FirstOrDefaultAsync(relationModel =>
                relationModel.RecipeId == recipeId && relationModel.MedicamentId == medicamentId);
            
            _context.RecipesMedicaments.Remove(removeModel);
            await _context.SaveChangesAsync();
        }
    }
}