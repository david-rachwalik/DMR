using DMR.WebApp.Areas.Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DMR.WebApp.Areas.Game.Models;


public class Tag : GameAsset
{
    // Description: use to store non-int values based on format
    [StringLength(4)]
    [Display(Name = "Abbr")]
    public string? Abbreviation { get; set; }

    public bool IsActive { get; set; }

    public string? Group { get; set; } // Entity model name

    [Display(Name = "Default Value")]
    public int Value { get; set; }
}


#region FluentAPI
class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable("Tag");
        builder.HasIndex(t => t.Title).IsUnique();

        builder.HasData(TagData.Seed());
    }
}
#endregion
