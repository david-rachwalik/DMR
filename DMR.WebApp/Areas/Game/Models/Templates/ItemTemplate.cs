using DMR.WebApp.Areas.Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class ItemTemplate : Item
    {
    }

    #region FluentAPI
    class ItemTemplateConfiguration : IEntityTypeConfiguration<ItemTemplate>
    {
        public void Configure(EntityTypeBuilder<ItemTemplate> builder)
        {
            builder.ToTable("ItemTemplate");

            builder.HasData(ItemTemplateData.Seed());
        }
    }
    #endregion
}
