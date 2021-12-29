using DMR.WebApp.Areas.Game.Models.CharacterBodyParts;

namespace DMR.WebApp.Areas.Game.Data.Seeds.CharacterBodyParts;

public static class WingSeed
{
    public static Wing[] Data()
    {
        Wing[] characters = new Wing[]
        {
            new Wing
            {
                //Id = (int)WingStyle.NONE,
                Title = "non-existant",
                Description = "non-existant"
            },
            new Wing
            {
                Title = "Bee", // Bee Wings (small)
                Description = "small, bee-like",
                Size = WingSize.Small
            },
            new Wing
            {
                //Id = (int)WingStyle.BEE_LIKE_LARGE,
                Title = "large bee-like",
                Description = "large bee-like"
            },
            new Wing
            {
                //Id = (int)WingStyle.HARPY,
                Title = "harpy",
                Description = "large feathery"
            },
            new Wing
            {
                //Id = (int)WingStyle.IMP,
                Title = "imp",
                Description = "small"
            },
            new Wing
            {
                //Id = (int)WingStyle.BAT_LIKE_TINY,
                Title = "tiny bat-like",
                Description = "tiny, bat-like"
            },
            new Wing
            {
                //Id = (int)WingStyle.BAT_LIKE_LARGE,
                Title = "large bat-like",
                Description = "large, bat-like"
            },
            new Wing
            {
                //Id = (int)WingStyle.SHARK_FIN,
                Title = "shark fin",
                Description = ""
            },
            new Wing
            {
                //Id = (int)WingStyle.FEATHERED_LARGE,
                Title = "large feathered",
                Description = "large, feathered"
            },
            new Wing
            {
                //Id = (int)WingStyle.DRACONIC_SMALL,
                Title = "small draconic",
                Description = "small, draconic"
            },
            new Wing
            {
                //Id = (int)WingStyle.DRACONIC_LARGE,
                Title = "large draconic",
                Description = "large, draconic"
            },
            new Wing
            {
                //Id = (int)WingStyle.GIANT_DRAGONFLY,
                Title = "giant dragonfly",
                Description = "giant dragonfly"
            }
        };

        return characters;
    }
}