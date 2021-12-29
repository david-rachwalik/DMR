using DMR.WebApp.Areas.Game.Models.CharacterBodyParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMR.WebApp.Areas.Game.Models;

public class Character : GameAsset
{
    //https://en.wikipedia.org/wiki/Personal_name
    //https://en.wikipedia.org/wiki/Given_name
    //public string GivenName { get; set; }
    //https://en.wikipedia.org/wiki/Surname
    //public string FamilyName { get; set; }

    // Audit Stuff
    //public IEnumerable<UserProfile> Creators { get; set; }
    //public IEnumerable<UserProfile> Contributors { get; set; }
    // Information
    public int ParentMomId { get; set; }
    public int ParentDadId { get; set; }
    public int SoulOwnerId { get; set; }  // Soul selling/stealing
    public string? Nickname { get; set; }
    public string? Job { get; set; } // Occupation
    [Display(Name = "Smutosaur Wiki")]
    public string? UriSmutosaurWiki { get; set; }
    [Display(Name = "CoC Revamp Wikia")]
    public string? UriRevampWikia { get; set; }


    // History
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Birthdate { get; set; }

    // Current Status
    public Gender Gender { get; set; }      // Set during new game event
    public Tag? Species { get; set; }        // https://wiki.smutosaur.us/CoC/Sentient_Species
    public Location? Location { get; set; }
    public GrappleTemperment Temperment { get; set; }
    // Role | Disposition
    public bool CampRecruit { get; set; }
    public bool Follower { get; set; }
    public bool Lover { get; set; }
    public bool Slave { get; set; }

    public IEnumerable<Attribute> Stats { get; set; }

    // Core Statistics
    [NotMapped]
    public int Agility { get; set; }        // AGI: Dexterity and speed
    [NotMapped]
    public int Strength { get; set; }       // STR: Ability to weild grander weapons and strike with greater efficiency
    [NotMapped]
    public int Speed { get; set; }          // SPE: Hastens the pace of combat flow
    [NotMapped]
    public int Vitality { get; set; }       // VIT: Toughness and resilience
    [NotMapped]
    public int Intelligence { get; set; }   // INT: Boosts attack of spells and ability to cast more effectively (conjuration, alchemy, alteration, illusion)
    [NotMapped]
    public int Willpower { get; set; }      // WIL: Increases mana capacity and regen (restoration, mysticism)
    [NotMapped]
    public int Esteem { get; set; }         // EST: Enhances charisma, confidence, mood (personality, tease)
    [NotMapped]
    public int Luck { get; set; }           // LUK: Effects everything nominally

    // Offensive Statistics

    // Defensive Statistics
    [NotMapped]
    public int HealthCurrent { get; set; }
    [NotMapped]
    public int HealthMaximum { get; set; }

    // Utility Statistics
    [NotMapped]
    public int Mana { get; set; }

    // Mind
    public IEnumerable<Effect> Talents { get; set; }
    public IEnumerable<Effect> Traits { get; set; }

    // Body
    // Character class is the 'core' of body & soul
    // https://en.wikipedia.org/wiki/Core_(anatomy)
    public IEnumerable<Head> Heads { get; set; }
    public Torso? Torso { get; set; }
    public IEnumerable<Wing> Wings { get; set; }
    public IEnumerable<Arm> Arms { get; set; }
    public IEnumerable<Hand> Hands { get; set; }
    public IEnumerable<Breast> Breasts { get; set; }
    public IEnumerable<Penis> Penises { get; set; }
    public IEnumerable<Vagina> Vaginas { get; set; }
    public IEnumerable<Tail> Tails { get; set; }
    public IEnumerable<Butt> Butts { get; set; }
    public IEnumerable<Leg> Legs { get; set; }
    public IEnumerable<Foot> Feet { get; set; }

    // Reputation
    [Display(Name = "Heroic Deeds")]
    public int HeroicDeeds { get; set; }

    // Appearance
    public SkinStyle Skin { get; set; }
    public int Masculinity { get; set; }    // More str/power
    public int Femininity { get; set; }     // More int/virtue
    public int Fitness { get; set; }        // Musculature
    public int Fatness { get; set; }        // Thickness

    // Gear
    public IEnumerable<Item> Equipment { get; set; }
    public IEnumerable<Item> Inventory { get; set; }

    public IEnumerable<Tag> Tags { get; set; }

    //#region Virtual Properties
    //public int SaveState_Player_FK { get; set; }
    //public SaveState SaveState_Player { get; set; }
    //public int SaveState_NPCs_FK { get; set; }
    //public SaveState SaveState_NPCs { get; set; }
    //public int SaveState_Followers_FK { get; set; }
    //public SaveState SaveState_Followers { get; set; }
    //public int SaveState_Mounts_FK { get; set; }
    //public SaveState SaveState_Mounts { get; set; }
    //#endregion
}


#region FluentAPI
class CharacterConfiguration : IEntityTypeConfiguration<Character>
{
    public void Configure(EntityTypeBuilder<Character> builder)
    {
        //builder
        //    .HasOne(p => p.SaveState_Player)
        //    .WithOne(b => b.Player)
        //    .HasForeignKey(s => s.SaveState_Player_FK);
        //builder
        //    .HasOne(p => p.SaveState_NPCs)
        //    .WithMany(b => b.NPCs)
        //    .HasForeignKey(s => s.SaveState_NPCs_FK);
        //builder
        //    .HasOne(p => p.SaveState_Followers)
        //    .WithMany(b => b.Followers)
        //    .HasForeignKey(s => s.SaveState_Followers_FK);
        //builder
        //    .HasOne(p => p.SaveState_Mounts)
        //    .WithMany(b => b.Mounts)
        //    .HasForeignKey(s => s.SaveState_Mounts_FK);

        builder.ToTable("Character");

        //builder.HasData(CharacterData.Seed());
    }
}
#endregion

#region Enumerators
public enum Gender
{
    None = 1,
    Male,
    Female,
    Herm
}

// Temperment: used for determining grapple behaviors
public enum GrappleTemperment
{
    Random = 1,
    Avoid,      // 0 - avoid grapples/break grapple
    Eager,      // 3 - love grapples
    Lusty       // 1 - lust determines > 50 grapple
}

public enum SkinStyle
{
    Undefined = 1,
    Plain,
    Fur,
    Goo,
    Scales
}
#endregion

public interface ICharacterAsset
{
    int Skin { get; set; }
    Tag Species { get; set; }
}
