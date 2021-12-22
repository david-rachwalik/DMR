using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMR.WebApp.Areas.Game.Models;


public class Moment : GameAsset
{
    public EventGroup Group { get; set; }
    public int Parent { get; set; } // Chain
    public Location Location { get; set; }
    public IEnumerable<Character> Characters { get; set; }
    public IEnumerable<Tag> Tags { get; set; } // Limits/Requirements
    // NOTE: You can tag other Event IDs.  This is different than a parent which denotes an event chain.
    // NOTE: RPG Maker has switches, which are Boolean toggles for controlling game state.
    // - Tags offer the same capability as switches without the need to track IDs.
}


#region FluentAPI
class MomentConfiguration : IEntityTypeConfiguration<Moment>
{
    public void Configure(EntityTypeBuilder<Moment> builder)
    {
        builder.ToTable("Moment");

        //builder.HasData(MomentData.Seed());
    }
}
#endregion

#region Enumerators
public enum EventGroup
{
    Normal = 1,     // Typical NPC interactions
    NewGame,
    Encounter,
    Seasonal,       // Holiday
    Supernatural
}
#endregion
