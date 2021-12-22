using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DMR.WebApp.Areas.Game.Models;


public class SaveState : GameAsset
{
    public Character Player { get; set; }
    public IEnumerable<Effect> Appearances { get; set; }
    public IEnumerable<Item> Inventory { get; set; }

    public IEnumerable<Character> NPCs { get; set; }
    public IEnumerable<Character> Followers { get; set; }
    public IEnumerable<Character> Mounts { get; set; }

    public IEnumerable<Tag> Tags { get; set; }

    // Historical Statistics
    public int Level { get; set; }
    public int EncounterCurrentId { get; set; }
    public int EncounterPreviousId { get; set; }
    [Display(Name = "Encounters Completed")]
    public IEnumerable<Moment> EncountersDone { get; set; }
    [Display(Name = "Comsumables Forced")]
    public int ComsumablesForced { get; set; }
    [Display(Name = "Comsumables Taken")]
    public int ComsumablesTaken { get; set; }
    public int Explored { get; set; }
    public int Eaten { get; set; }
    public int Exercised { get; set; }
    public int Slept { get; set; }
    public int Meditated { get; set; }

    // NOTE: virtual can be protected but not private
    //public virtual UserProfile UserProfile { get; set; }
}


#region FluentAPI
class SaveStateConfiguration : IEntityTypeConfiguration<SaveState>
{
    public void Configure(EntityTypeBuilder<SaveState> builder)
    {
        builder.ToTable("SaveState");

        //builder
        //    .HasOne(p => p.UserProfile)
        //    .WithMany(b => b.Saves);

        //builder
        //    .HasMany(s => s.Appearances).WithOne();
        //builder
        //    .HasMany(s => s.NPCs).WithOne();
        //builder
        //    .HasMany(s => s.Followers).WithOne();
        //builder
        //    .HasMany(s => s.Mounts).WithOne();

        //builder.HasData(SaveStateData.Seed());
    }
}
#endregion
