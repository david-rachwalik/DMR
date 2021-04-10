using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class MomentTemplate : Moment
    {
    }

    #region FluentAPI
    class MomentTemplateConfiguration : IEntityTypeConfiguration<MomentTemplate>
    {
        public void Configure(EntityTypeBuilder<MomentTemplate> builder)
        {
            builder.ToTable("MomentTemplate");

            //builder.HasData(MomentTemplateData.Seed());
        }
    }
    #endregion
}
