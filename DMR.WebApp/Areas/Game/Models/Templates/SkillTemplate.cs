using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class SkillTemplate : Skill
    {
    }

    #region FluentAPI
    class SkillTemplateConfiguration : IEntityTypeConfiguration<SkillTemplate>
    {
        public void Configure(EntityTypeBuilder<SkillTemplate> builder)
        {
            builder.ToTable("SkillTemplate");

            //builder.HasData(SkillTemplateData.Seed());
        }
    }
    #endregion
}
