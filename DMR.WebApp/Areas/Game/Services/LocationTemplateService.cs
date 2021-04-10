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
    public interface ILocationTemplateService
    {
        Task<LocationTemplate> ReadAsync(int? id);
        Task<IEnumerable<LocationTemplate>> ReadListAsync();
        Task<IEnumerable<LocationTemplate>> ReadListAsync(LocationGroup? group);
        Task<int> CreateAsync(LocationTemplate location);
        Task<int> UpdateAsync(LocationTemplate location);
        Task<int> DeleteAsync(int? id);
    }


    public class LocationTemplateService : ILocationTemplateService
    {
        private readonly ApplicationContext _context;

        public LocationTemplateService(ApplicationContext context)
        {
            _context = context;
        }


        // Private Methods
        private bool Exists(int id)
        {
            return _context.LocationTemplates.Any(e => e.Id == id);
        }


        // Public Methods
        public async Task<LocationTemplate> ReadAsync(int? id)
        {
            if (id == null) { return null; }
            LocationTemplate location = await _context.LocationTemplates.FirstOrDefaultAsync(m => m.Id == id);
            return await Task.FromResult(location);
        }

        public async Task<IEnumerable<LocationTemplate>> ReadListAsync()
        {
            IEnumerable<LocationTemplate> locations = new List<LocationTemplate>();
            locations = await _context.LocationTemplates.ToListAsync();

            return await Task.FromResult(locations);
        }
        public async Task<IEnumerable<LocationTemplate>> ReadListAsync(LocationGroup? group)
        {
            IEnumerable<LocationTemplate> locations = await ReadListAsync();
            locations = locations.Where(m => m.Group == group).ToList();
            return await Task.FromResult(locations);
        }

        public async Task<int> CreateAsync(LocationTemplate location)
        {
            _context.LocationTemplates.Add(location);
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> UpdateAsync(LocationTemplate location)
        {
            _context.Attach(location).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();
            
            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            LocationTemplate location = await ReadAsync(id);

            if (location != null)
            {
                _context.LocationTemplates.Remove(location);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }

        // --------------------------------------------------------

        //public async Task<int> OnPostSleepAsync(int? id)
        //{
        //    int changeCount = 0;
        //    LocationTemplate location = await OnGetAsync(id);

        //    if (location != null)
        //    {
        //        location.Slept = ++location.Slept;
        //        changeCount = await _context.SaveChangesAsync();
        //    }

        //    return await Task.FromResult(changeCount);
        //}
    }
}
