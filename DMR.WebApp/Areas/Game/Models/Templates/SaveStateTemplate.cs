using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class SaveStateTemplate : SaveState
    {
    }

    #region FluentAPI
    class SaveStateTemplateConfiguration : IEntityTypeConfiguration<SaveStateTemplate>
    {
        public void Configure(EntityTypeBuilder<SaveStateTemplate> builder)
        {
            builder.ToTable("SaveStateTemplate");

            //builder.HasData(SaveStateTemplateData.Seed());
        }
    }
    #endregion
}
