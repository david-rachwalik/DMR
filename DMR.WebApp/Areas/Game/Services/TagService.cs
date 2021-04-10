using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Data;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Services
{
    public interface ITagService
    {
        Task<Tag> ReadAsync(int? id);
        Task<IEnumerable<Tag>> ReadListAsync();
        Task<IEnumerable<Tag>> ReadListAsync(string group);
        Task<int> CreateAsync(Tag tag);
        Task<int> UpdateAsync(Tag tag);
        Task<int> DeleteAsync(int? id);
    }


    public class TagService : ITagService
    {
        private readonly ApplicationContext _context;

        public TagService(ApplicationContext context)
        {
            _context = context;
        }


        // Private Methods
        private bool Exists(int id)
        {
            return _context.Tags.Any(e => e.Id == id);
        }


        // Public Methods
        public async Task<Tag> ReadAsync(int? id)
        {
            if (id == null) { return null; }
            Tag tag = await _context.Tags.FirstOrDefaultAsync(m => m.Id == id);
            return await Task.FromResult(tag);
        }

        public async Task<IEnumerable<Tag>> ReadListAsync()
        {
            IEnumerable<Tag> tags = new List<Tag>();

            tags = await _context.Tags
                .OrderBy(m => m.Title).ToListAsync();

            return await Task.FromResult(tags);
        }
        public async Task<IEnumerable<Tag>> ReadListAsync(string group)
        {
            IEnumerable<Tag> tags = await ReadListAsync();
            tags = tags.Where(m => m.Group == group).ToList();
            return await Task.FromResult(tags);
        }

        public async Task<int> CreateAsync(Tag tag)
        {
            _context.Tags.Add(tag);
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> UpdateAsync(Tag tag)
        {
            _context.Attach(tag).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();
            
            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            Tag tag = await ReadAsync(id);

            if (tag != null)
            {
                _context.Tags.Remove(tag);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }

        // --------------------------------------------------------

        //public async Task<int> OnPostSleepAsync(int? id)
        //{
        //    int changeCount = 0;
        //    Tag tag = await OnGetAsync(id);

        //    if (tag != null)
        //    {
        //        tag.Slept = ++tag.Slept;
        //        changeCount = await _context.SaveChangesAsync();
        //    }

        //    return await Task.FromResult(changeCount);
        //}
    }
}
