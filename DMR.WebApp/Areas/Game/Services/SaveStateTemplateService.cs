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
    public interface ISaveStateTemplateService
    {
        Task<SaveStateTemplate> ReadAsync(int? id);
        Task<IEnumerable<SaveStateTemplate>> ReadListAsync();
        Task<int> CreateAsync(SaveStateTemplate saveState);
        Task<int> UpdateAsync(SaveStateTemplate saveState);
        Task<int> DeleteAsync(int? id);
        // ----------------------------------------
        Task<int> SleepAsync(int? id);
    }


    public class SaveStateTemplateService : ISaveStateTemplateService
    {
        private readonly ApplicationContext _context;

        public SaveStateTemplateService(ApplicationContext context)
        {
            _context = context;
        }


        // Private Methods
        private bool Exists(int id)
        {
            return _context.SaveStateTemplates.Any(e => e.Id == id);
        }


        // Public Methods
        public async Task<SaveStateTemplate> ReadAsync(int? id)
        {
            if (id == null) { return null; }
            SaveStateTemplate saveState = await _context.SaveStateTemplates.FirstOrDefaultAsync(m => m.Id == id);
            return await Task.FromResult(saveState);
        }

        public async Task<IEnumerable<SaveStateTemplate>> ReadListAsync()
        {
            IEnumerable<SaveStateTemplate> saveStates = await _context.SaveStateTemplates.ToListAsync();
            return await Task.FromResult(saveStates);
        }

        public async Task<int> CreateAsync(SaveStateTemplate saveState)
        {
            _context.SaveStateTemplates.Add(saveState);
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> UpdateAsync(SaveStateTemplate saveState)
        {
            _context.Attach(saveState).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            SaveStateTemplate saveState = await ReadAsync(id);

            if (saveState != null)
            {
                _context.SaveStateTemplates.Remove(saveState);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }

        // --------------------------------------------------------

        public async Task<int> SleepAsync(int? id)
        {
            int changeCount = 0;
            SaveStateTemplate saveState = await ReadAsync(id);

            if (saveState != null)
            {
                saveState.Slept += saveState.Slept;
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }
    }
}
