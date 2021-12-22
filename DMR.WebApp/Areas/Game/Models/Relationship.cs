using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DMR.WebApp.Areas.Game.Models;


// Limit SaveState based on whether characters have met, how often, their disposition with one another, past experiences
// https://www.carls-sims-3-guide.com/relationships/

public class Relationship : GameAsset
{
    public Character CharacterOne { get; set; }
    public FamilyRelationship CharacterOneToCharacterTwo { get; set; }
    public Character CharacterTwo { get; set; }
    public FamilyRelationship CharacterTwoToCharacterOne { get; set; }

    public Tag MaxFriendship { get; set; }
    public Tag MaxDislike { get; set; }
    public Tag MaxRomance { get; set; }

    public Disposition Disposition { get; set; }
    public int Interest { get; set; }
}


#region FluentAPI
class RelationshipConfiguration : IEntityTypeConfiguration<Relationship>
{
    public void Configure(EntityTypeBuilder<Relationship> builder)
    {
        builder.ToTable("Relationship");

        //builder.HasData(RelationshipData.Seed());
    }
}
#endregion

#region Enumerators
public enum FamilyRelationship
{
    Self,
    Child,
    GrandChild,
    GreatGrandChild,

    Sibling,
    Niece,
    Nephew,
    GreatNiece,
    GreatNephew,

    Parent,
    Aunt,
    Uncle,
    FirstCousin,
    FirstCousinOnceRemoved,
    FirstCousinTwiceRemoved,

    GrandParent,
    GreatAunt,
    GreatUncle,
    SecondCousin,
    SecondCousinOnceRemoved,
    SecondCousinTwiceRemoved
}

public enum Disposition
{
    Unfriendly,
    Neutral,
    Friendly,
    Honored,
    Revered,
    Exalted
}
#endregion
