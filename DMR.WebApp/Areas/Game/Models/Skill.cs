using DMR.WebApp.Areas.Game.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMR.WebApp.Areas.Game.Models;

// https://wiki.smutosaur.us/CoC/Special_Attacks
public class Skill : GameAsset
{
    public SkillStyle Style { get; set; }
    public SkillSubgroup Subgroup { get; set; }
    public int RankMax { get; set; }
    public int RankCurrent { get; set; }
    public string? Prerequisites { get; set; }
    public string? Effect { get; set; }
    public string? Note { get; set; }
    public int LevelRequired { get; set; }
    public int SkillId { get; set; } // Parent Skill
    public int Cost { get; set; }
    public Effect? EffectImmediate { get; set; }
    public Effect? EffectOverTime { get; set; }
    public DateTimeOffset CastTime { get; set; }
    /*
        * Typically, melee abilities and spells are instant
        * - instant skills: laser, teleport, exit, bind, etc.
        * - travel time skills: arrow/bullet, fireball, flee, net, etc.
        */
    public DateTimeOffset TravelTime { get; set; }
    public int ProcsPerMinute { get; set; }
    public CooldownDisplay CooldownDisplay { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
}


#region FluentAPI
class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.ToTable("Skill");
        //builder.HasIndex(t => t.Abbreviation).IsUnique();

        builder.HasData(SkillSeed.Data());
    }
}
#endregion

#region Enumerators
public enum SkillStyle
{
    Aura = 1,
    Buff,
    Debuff,
    Perk,
    Trait,
    Spellcast,
    Mastery,
    TrinketProc
}

public enum SkillSubgroup
{
    CoC_StarterPerk = 1,
    CoC_HistoryPerk,
    CoC_Tier0Perk,
    CoC_Tier1Perk,
    CoC_Tier2Perk,
    CoC_TFPerk,
    CoC_OtherPerk,
    CoC_EventPerk,
    CoC_ItemPerk,
    CoC_UnimplementedPerk,
    Combat,
    Social
}

public enum CooldownDisplay
{
    AlwaysShown = 1,
    AlwaysHidden,
    AdvancedTooltip
}
#endregion
