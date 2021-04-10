using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Data;
using DMR.WebApp.Areas.Game.Models.Templates;

namespace DMR.WebApp.Areas.Game.Services
{
    public interface IItemTemplateService
    {
        Task<ItemTemplate> ReadAsync(int? id);
        Task<IEnumerable<ItemTemplate>> ReadListAsync();
        Task<int> CreateAsync(ItemTemplate item);
        Task<int> UpdateAsync(ItemTemplate item);
        Task<int> DeleteAsync(int? id);
        // --------------------------------------------------------
        Task<IEnumerable<string>> OnGetItemGroupListAsync();
    }


    public class ItemTemplateService : IItemTemplateService
    {
        private readonly ApplicationContext _context;

        public ItemTemplateService(ApplicationContext context)
        {
            _context = context;
        }


        // Private Methods
        private bool Exists(int id)
        {
            return _context.ItemTemplates.Any(e => e.Id == id);
        }


        // Public Methods
        public async Task<ItemTemplate> ReadAsync(int? id)
        {
            if (id == null) { return null; }
            ItemTemplate item = await _context.ItemTemplates.FirstOrDefaultAsync(m => m.Id == id);
            return await Task.FromResult(item);
        }

        public async Task<IEnumerable<ItemTemplate>> ReadListAsync()
        {
            IEnumerable<ItemTemplate> items = new List<ItemTemplate>();
            items = await _context.ItemTemplates.ToListAsync();
            return await Task.FromResult(items);
        }

        public async Task<int> CreateAsync(ItemTemplate item)
        {
            _context.ItemTemplates.Add(item);
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> UpdateAsync(ItemTemplate item)
        {
            _context.Attach(item).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();
            
            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            ItemTemplate item = await ReadAsync(id);

            if (item != null)
            {
                _context.ItemTemplates.Remove(item);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }

        // --------------------------------------------------------
        
        public async Task<IEnumerable<string>> OnGetItemGroupListAsync()
        {
            IEnumerable<string> itemGroups = Enum.GetValues(typeof(ItemGroup)).Cast<string>().ToList();

            return await Task.FromResult(itemGroups);
        }
    }
}
