using DMR.WebApp.Areas.Game.Data;
using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMR.WebApp.Areas.Game.Models;


// http://finalfantasy.wikia.com/wiki/Status_effect
// https://ffxiv.consolegameswiki.com/wiki/Category:Status_Effects
// Ailments afflicted in battle.  These can be cured with skills and items, and all ailments are removed when combat ends.
public class Effect : GameAsset
{
    public Element Element { get; set; }
    public int AmountMinimum { get; set; }
    public int AmountMaximum { get; set; }
    public DateTimeOffset CastTime { get; set; }
    public int Duration { get; set; }
    public int Cooldown { get; set; }
    public int Area { get; set; }               // 0: single-target
    public int Range { get; set; }              // 0: melee attack
    public bool IsHarmful { get; set; }         // false: helpful (heal, buff); true: curse
    public bool IsDispellable { get; set; }     // false: can be cured
    public bool IsTargetted { get; set; }       // false: self cast; true: capable of casting on anyone
    public bool IsSpell { get; set; }           // false: cannot be silenced
    public IEnumerable<Tag> Tags { get; set; }
}


#region FluentAPI
class EffectConfiguration : IEntityTypeConfiguration<Effect>
{
    public void Configure(EntityTypeBuilder<Effect> builder)
    {
        builder.ToTable("Effect");

        builder.HasData(EffectData.Seed());
    }
}
#endregion

#region Enumerators
// Nature=Physical; Life=Light; Light=Energy; Shadow=Void
public enum Element
{
    Physical = 1,
    Ethereal,
    Water,
    Earth,      // https://fairytail.fandom.com/wiki/Earth_Magic
    Fire,
    Air,
    //Nature,
    //Arcane,
    Energy,
    Void
}
#endregion
