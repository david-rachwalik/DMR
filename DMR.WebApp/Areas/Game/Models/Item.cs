using DMR.WebApp.Areas.Game.Models.Templates;
using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMR.WebApp.Areas.Game.Models;


// https://ffxiv.consolegameswiki.com/wiki/Medicines_and_Meals
// https://ffxiv.consolegameswiki.com/wiki/Medicines
public class Item : GameAsset
{
    public ItemOrigin Origin { get; set; }
    public ItemGroup Group { get; set; }
    public int Cost { get; set; }
    public int Sale { get; set; }

    public IEnumerable<Attribute> Stats { get; set; }
    public IEnumerable<Effect> Procs { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
}


#region FluentAPI
class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Item");

        //builder.HasData(ItemData.Seed());
    }
}
#endregion

#region Enumerators
public enum ItemOrigin
{
    Unobtainable = 1,
    Gift,
    Encounter,
    Vendor,
    Mob,
    Quest,
    Treasure,
    Gathering,
    Crafting,
    Achievement
}

public enum ItemGroup
{
    Food = 1,
    Consumable,
    Apparel,        // Panties, thank you please
    Accessory,
    Weapon,
    Armor,
    Trinket,
    Key
}
#endregion
