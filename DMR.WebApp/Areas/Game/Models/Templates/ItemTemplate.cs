using DMR.WebApp.Areas.Game.Data.Seeds.Templates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMR.WebApp.Areas.Game.Models.Templates;

public class ItemTemplate : Item
{
}


#region FluentAPI
class ItemTemplateConfiguration : IEntityTypeConfiguration<ItemTemplate>
{
    public void Configure(EntityTypeBuilder<ItemTemplate> builder)
    {
        builder.ToTable("ItemTemplate");

        builder.HasData(ItemTemplateSeed.Data());
    }
}
#endregion