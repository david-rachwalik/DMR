using DMR.WebApp.Areas.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Data
{
    // New profiles will have limited species unlocked; earn more through achievements (e.g. unlock species by mating)
    public static class UserProfileData
    {
        public static UserProfile[] Seed()
        {
            UserProfile[] profiles = new UserProfile[]
            {
                new UserProfile
                {
                    Id = 1,
                    Title = "007",
                    Description = "Primary profile for DMR development",
                    Who = Guid.Empty,
                    When = DateTime.UtcNow,
                    Email = "rhodair@gmail.com"
                }
            };

            return profiles;
        }
    }
}
