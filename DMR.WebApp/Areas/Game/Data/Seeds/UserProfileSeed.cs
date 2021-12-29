using DMR.WebApp.Areas.Game.Models;

namespace DMR.WebApp.Areas.Game.Data.Seeds;

// New profiles will have limited species unlocked; earn more through achievements (e.g. unlock species by mating)
public static class UserProfileSeed
{
    public static UserProfile[] Data()
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