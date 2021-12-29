using DMR.WebApp.Areas.Game.Data.Seeds.Templates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMR.WebApp.Areas.Game.Models.Templates;

public class LocationTemplate : Location
{
}


#region FluentAPI
class LocationTemplateConfiguration : IEntityTypeConfiguration<LocationTemplate>
{
    public void Configure(EntityTypeBuilder<LocationTemplate> builder)
    {
        builder.ToTable("LocationTemplate");

        builder.HasData(LocationTemplateSeed.Data());
    }
}
#endregion