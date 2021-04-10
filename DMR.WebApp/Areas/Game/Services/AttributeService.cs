using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Data;
using Attribute = DMR.WebApp.Areas.Game.Models.Attribute;

namespace DMR.WebApp.Areas.Game.Services
{
    public interface IAttributeService
    {
        Task<Attribute> ReadAsync(int? id);
        Task<IEnumerable<Attribute>> ReadListAsync();
        Task<int> CreateAsync(Attribute character);
        Task<int> UpdateAsync(Attribute character);
        Task<int> DeleteAsync(int? id);
    }


    public class AttributeService : IAttributeService
    {
        private readonly ApplicationContext _context;

        public AttributeService(ApplicationContext context)
        {
            _context = context;
        }


        // Private Methods
        private bool Exists(int id)
        {
            return _context.Attributes.Any(e => e.Id == id);
        }


        // Public Methods
        public async Task<Attribute> ReadAsync(int? id)
        {
            if (id == null) { return null; }
            Attribute attribute = await _context.Attributes.FirstOrDefaultAsync(m => m.Id == id);
            return await Task.FromResult(attribute);
        }

        public async Task<IEnumerable<Attribute>> ReadListAsync()
        {
            IEnumerable<Attribute> attributes = new List<Attribute>();

            // Hardcode DMR game for dev
            // TODO: either copy this to CoC area or add Version dropdown for Admin
            //attributes = attributes.Where(m => m.Version.Equals(WebApp.Models.Version.Core)).ToList();
            attributes = await _context.Attributes.ToListAsync();

            return await Task.FromResult(attributes);
        }

        public async Task<int> CreateAsync(Attribute attribute)
        {
            _context.Attributes.Add(attribute);
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> UpdateAsync(Attribute attribute)
        {
            _context.Attach(attribute).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();
            
            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            Attribute attribute = await ReadAsync(id);

            if (attribute != null)
            {
                _context.Attributes.Remove(attribute);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }
    }
}
