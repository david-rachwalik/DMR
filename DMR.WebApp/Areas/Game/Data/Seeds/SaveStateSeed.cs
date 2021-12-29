using DMR.WebApp.Areas.Game.Models;

namespace DMR.WebApp.Areas.Game.Data.Seeds;

public static class SaveStateSeed
{
    public static SaveState[] Data()
    {
        SaveState[] saveState = new SaveState[]
        {
            new SaveState
            {
                Id = 1,
                Title = "The Player"
            }
        };

        return saveState;
    }
}