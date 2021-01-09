using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Services
{
    public class ClientsService
    {
        private readonly ApplicationDbContext _context;

        public ClientsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Client> CreateAsync(Client createModel)
        {
            var clientEntry = await _context.Clients.AddAsync(createModel);
            await _context.SaveChangesAsync();

            return clientEntry.Entity;
        }

        public async Task<Client> ReadByIdAsync(int clientId)
        {
            return await _context.Clients.FirstOrDefaultAsync(client => client.Id == clientId);
        }

        public async Task<IEnumerable<Client>> ReadListAsync(string searchFullName)
        {
            return await _context.Clients
                .Where(client => client.FullName.ToLower().Contains(searchFullName.ToLower()))
                .ToListAsync();
        }

        public async Task<Client> UpdateAsync(Client updateModel)
        {
            var clientEntry = _context.Clients.Update(updateModel);
            await _context.SaveChangesAsync();

            return clientEntry.Entity;
        }

        public async Task DeleteByIdAsync(int clientId)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(client => client.Id == clientId);

            if (client == null)
                return;

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}