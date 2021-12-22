using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DMR.WebApp.Areas.Game.Models;


public class Location : GameAsset
{
    public int ParentId { get; set; }
    public string? Nickname { get; set; }
    public LocationGroup Group { get; set; }
    [Display(Name = "Smutosaur Wiki")]
    public string? UriSmutosaurWiki { get; set; }
    [Display(Name = "CoC Revamp Wikia")]
    public string? UriRevampWikia { get; set; }
    // Coordinates
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    [Range(0, 60)]
    public int LevelMinimum { get; set; }
    [Range(0, 60)]
    public int LevelMaximum { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
}


#region FluentAPI
class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("Location");

        //builder.HasData(LocationData.Seed());
    }
}
#endregion

#region Enumerators
public enum LocationGroup
{
    World = 1,      // Planet
    Zone,           // Explorable Area: https://wiki.smutosaur.us/CoC/Areas
    Place,          // Specific location|city|town|hideout
    Destination,    // Points of interest in a place: homes, services, shops, parks
    Dungeon
}
#endregion
