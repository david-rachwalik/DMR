using DMR.WebApp.Areas.Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class LocationTemplate : Location
    {
    }

    #region FluentAPI
    class LocationTemplateConfiguration : IEntityTypeConfiguration<LocationTemplate>
    {
        public void Configure(EntityTypeBuilder<LocationTemplate> builder)
        {
            builder.ToTable("LocationTemplate");

            builder.HasData(LocationTemplateData.Seed());
        }
    }
    #endregion
}
