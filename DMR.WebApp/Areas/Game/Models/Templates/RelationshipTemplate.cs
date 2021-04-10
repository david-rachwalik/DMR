using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class RelationshipTemplate : Relationship
    {
    }

    #region FluentAPI
    class RelationshipTemplateConfiguration : IEntityTypeConfiguration<RelationshipTemplate>
    {
        public void Configure(EntityTypeBuilder<RelationshipTemplate> builder)
        {
            builder.ToTable("RelationshipTemplate");

            //builder.HasData(RelationshipTemplateData.Seed());
        }
    }
    #endregion
}
