using DMR.WebApp.Areas.Game.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DMR.WebApp.Areas.Game.Models;

public class Attribute : GameAsset
{
    // Description: use to store non-int values based on format
    [StringLength(4)]
    [Display(Name = "Abbr")]
    public string Abbreviation { get; set; }
    public AttributeFormat Format { get; set; }
    public AttributeStyle Style { get; set; }
    [Display(Name = "Default Value")]
    public int Value { get; set; }

    public IEnumerable<Tag> Tags { get; set; }
}


#region FluentAPI
class AttributeConfiguration : IEntityTypeConfiguration<Attribute>
{
    public void Configure(EntityTypeBuilder<Attribute> builder)
    {
        builder.ToTable("Attribute");
        //builder.HasIndex(t => t.Abbreviation).IsUnique();

        builder.HasData(AttributeSeed.Data());
    }
}
#endregion

#region Enumerators
public enum AttributeFormat
{
    Integer,
    Double,
    Boolean,
    String,
    DateTime
}

public enum AttributeStyle
{
    Core,
    Offense,
    Defense,
    Utility,
    Sexual
}
#endregion
