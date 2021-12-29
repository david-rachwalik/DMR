using DMR.WebApp.Areas.Game.Models.CharacterBodyParts;

namespace DMR.WebApp.Areas.Game.Data.Seeds.CharacterBodyParts;

public static class VaginaSeed
{
    public static Vagina[] Data()
    {
        Vagina[] vaginas = new Vagina[]
        {
            new Vagina
            {
                Id = 1,
                Title = "Human",
                Description = "human"
            },
            new Vagina
            {
                Id = 2,
                Title = "Black Sand Trap",
                Description = "black sandtrap"
            }
        };

        return vaginas;
    }
}