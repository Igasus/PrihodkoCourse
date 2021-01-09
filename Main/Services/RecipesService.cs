using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class RecipesService
    {
        private readonly ApplicationDbContext _context;

        public RecipesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Recipe> CreateAsync(Recipe createModel)
        {
            var recipeEntry = await _context.Recipes.AddAsync(createModel);
            await _context.SaveChangesAsync();

            return recipeEntry.Entity;
        }

        public async Task<Recipe> ReadByIdAsync(int recipeId)
        {
            return await _context.Recipes
                .Include(recipe => recipe.Client)
                .Include(recipe => recipe.Disease)
                .FirstOrDefaultAsync(recipe => recipe.Id == recipeId);
        }

        public async Task<IEnumerable<Recipe>> ReadListAsync(string searchText)
        {
            searchText = searchText.ToLower();
            return await _context.Recipes
                .Include(recipe => recipe.Client)
                .Include(recipe => recipe.Disease)
                .Where(recipe =>
                    recipe.Client.FullName.ToLower().Contains(searchText) ||
                    recipe.Disease.Name.ToLower().Contains(searchText))
                .ToListAsync();
        }

        public async Task<Recipe> UpdateAsync(Recipe updateModel)
        {
            var recipeEntry = _context.Recipes.Update(updateModel);
            await _context.SaveChangesAsync();

            return recipeEntry.Entity;
        }

        public async Task DeleteByIdAsync(int recipeId)
        {
            var recipe = await ReadByIdAsync(recipeId);

            if (recipe == null)
                return;

            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
        }
    }
}