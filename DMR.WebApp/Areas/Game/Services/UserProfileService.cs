using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Data;

namespace DMR.WebApp.Areas.Game.Services
{
    public interface IUserProfileService
    {
        Task<UserProfile> ReadAsync(int? id);
        Task<IEnumerable<UserProfile>> ReadListAsync();
        Task<int> CreateAsync(UserProfile userProfile);
        Task<int> UpdateAsync(UserProfile userProfile);
        Task<int> DeleteAsync(int? id);
        // --------------------------------------------------------
        Task<int> ReadListCountAsync();
        Task<int> OnPostNewGameAsync();
    }


    public class UserProfileService : IUserProfileService
    {
        private readonly ApplicationContext _context;

        public UserProfileService(ApplicationContext context)
        {
            _context = context;
        }

        
        public async Task<UserProfile> ReadAsync(int? id)
        {
            UserProfile profile = null;
            if (id != null)
            {
                profile = await _context.UserProfiles
                    .Include(m => m.Saves)
                        .ThenInclude(m => m.Player)
                    .FirstAsync();
            }

            return await Task.FromResult(profile);
        }

        public async Task<IEnumerable<UserProfile>> ReadListAsync()
        {
            IEnumerable<UserProfile> profiles = new List<UserProfile>();

            profiles = await _context.UserProfiles.ToListAsync();
            return await Task.FromResult(profiles);
        }

        public async Task<int> CreateAsync(UserProfile userProfile)
        {
            _context.UserProfiles.Add(userProfile);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(UserProfile userProfile)
        {
            _context.Attach(userProfile).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            UserProfile profile = await ReadAsync(id);

            if (profile != null)
            {
                _context.UserProfiles.Remove(profile);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }

        // --------------------------------------------------------
        
        public async Task<int> ReadListCountAsync()
        {
            IEnumerable<UserProfile> userProfiles = await ReadListAsync();
            return await Task.FromResult(userProfiles.Count());
        }
        
        public async Task<int> OnPostNewGameAsync()
        {
            int changeCount = 0;
            int testId = 1;
            UserProfile userProfile = await ReadAsync(testId);

            if (userProfile == null)
            {
                userProfile = new UserProfile()
                {

                };
                changeCount += await CreateAsync(userProfile);

                //userProfile.Slept = ++userProfile.Slept;
                //changeCount += await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }
    }
}
